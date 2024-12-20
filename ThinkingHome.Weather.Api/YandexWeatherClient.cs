using System.Linq.Expressions;
using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using ThinkingHome.Weather.Api.Model;

namespace ThinkingHome.Weather.Api;

/// <summary>
/// Этот класс предоставляет API для получения данных о погоде из API
/// сервиса <see href="https://yandex.ru/dev/weather/doc/ru/concepts/weather-data-api">Яндекс Погода</see>.
/// Для работы вам понадобится ключ доступа,
/// который можно получить в <see href="https://yandex.ru/pogoda/b2b/console/smarthome">личном кабинете</see>.
/// </summary>
public class YandexWeatherClient : IDisposable
{
    private int index = 0;

    private readonly HttpClient yandexWeatherHttp = new()
    {
        BaseAddress = new Uri("https://api.weather.yandex.ru/v2/")
    };


    private readonly ILogger<YandexWeatherClient>? logger;
    private readonly string[] apiKeys;

    private string MaskApiKey(string apiKey)
    {
        return apiKey.Substring(apiKey.Length - 6);
    }

    /// <summary>
    /// Создает экземпляр класса <c>YandexWeatherClient</c>
    /// </summary>
    /// <param name="apiKeys">Массив ключей доступа к API Яндекс Погоды</param>
    /// <param name="logger">Интерфейс для записи информации в журнал событий (опциональный параметр)</param>
    public YandexWeatherClient(string[] apiKeys, ILogger<YandexWeatherClient>? logger = null)
    {
        this.apiKeys = apiKeys.Distinct().ToArray();
        this.logger = logger;
        logger?.LogInformation($"Created Yandex Weather Client. Keys count: {apiKeys.Length}");
    }

    /// <summary>
    /// Создает экземпляр класса <c>YandexWeatherClient</c> 
    /// </summary>
    /// <param name="apiKey">Ключ доступа к API Яндекс Погоды</param>
    /// <param name="logger">Интерфейс для записи информации в журнал событий (опциональный параметр)</param>
    public YandexWeatherClient(string apiKey, ILogger<YandexWeatherClient>? logger = null)
        : this([apiKey], logger)
    {
    }

    /// <summary>
    /// Выполняет определенные приложением задачи, связанные с освобождением, разгружением
    /// или сбросом неуправляемых ресурсов.
    /// </summary>
    public void Dispose()
    {
        logger?.LogInformation("Dispose weather client");
        yandexWeatherHttp.Dispose();
    }

    /// <summary>
    /// Получает данные о погоде в заданном месте Земли
    /// </summary>
    /// <param name="lat">Широта</param>
    /// <param name="lon">Долгота</param>
    /// <exception cref="NoValidAPIKeysException">
    /// Исключение произойдет, если нет действительных ключей доступа к API (например, на всех переданных ключах
    /// превышен лимит запросов)
    /// </exception>
    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        var slat = JsonSerializer.Serialize(lat);
        var slon = JsonSerializer.Serialize(lon);
        logger?.LogInformation($"Getting forecast for {slat}, {slon}");

        try
        {
            var responseMessage = await MakeRequest(slat, slon);

            responseMessage.EnsureSuccessStatusCode();

            var json = await responseMessage.Content.ReadAsStringAsync();
            logger?.LogDebug(json);
            var response = JsonSerializer.Deserialize<ForecastResponse>(json);
            return response;
        }
        catch (Exception ex)
        {
            logger?.LogError(ex, "Getting forecast failed");
            throw;
        }
    }

    private async Task<HttpResponseMessage> MakeRequest(string slat, string slon)
    {
        while (index < apiKeys.Length)
        {
            var apiKey = apiKeys[index];
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"forecast?lat={slat}&lon={slon}", UriKind.Relative),
                Headers =
                {
                    { "X-Yandex-Weather-Key", apiKey }
                },
            };

            logger?.LogInformation($"Using API Key: ***{MaskApiKey(apiKey)}");

            DateTime start = DateTime.Now;
            var responseMessage = await yandexWeatherHttp.SendAsync(request);
            var time = DateTime.Now - start;

            var reqId = "<unknown>";
            if (responseMessage.Headers.TryGetValues("X-Req-Id", out var res))
            {
                reqId = res.FirstOrDefault();
            }

            logger?.LogInformation(
                $"Response received: {responseMessage.ReasonPhrase}, time: {time.TotalMilliseconds:0.000} ms, reqID: {reqId}");

            if (responseMessage.StatusCode == HttpStatusCode.Forbidden)
            {
                index++;
                logger?.LogError($"***{MaskApiKey(apiKey)} API Key was revoked");
            }
            else
            {
                return responseMessage;
            }
        }

        throw new NoValidApiKeysException();
    }
}
