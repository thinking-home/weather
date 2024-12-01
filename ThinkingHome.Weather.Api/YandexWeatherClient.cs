using System.Text.Json;
using Microsoft.Extensions.Logging;
using ThinkingHome.Weather.Api.Model;

namespace ThinkingHome.Weather.Api;

public class YandexWeatherClient : IDisposable
{
    private readonly HttpClient yandexWeatherHttp = new()
    {
        BaseAddress = new Uri("https://api.weather.yandex.ru/v2/")
    };
    
    
    private readonly ILogger? logger;
    private readonly string[] apiKeys;

    private string MaskApiKey(string apiKey)
    {
        return apiKey.Substring(apiKey.Length - 6);
    }

    public YandexWeatherClient(string[] apiKeys, ILogger? logger = null)
    {
        this.apiKeys = apiKeys;
        this.logger = logger;
        logger?.LogInformation($"Created Yandex Weather Client. Keys count: {apiKeys.Length}");
    }

    public void Dispose()
    {
        logger?.LogInformation("Dispose weather client");
        yandexWeatherHttp.Dispose();
    }

    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        var slat = JsonSerializer.Serialize(lat);
        var slon = JsonSerializer.Serialize(lon);
        logger?.LogInformation($"Getting forecast for {slat}, {slon}");

        try
        {
            DateTime start = DateTime.Now;
            var responseMessage = await MakeRequest(slat, slon);
            var time = DateTime.Now - start;
            
            var reqId = "<unknown>";
            if (responseMessage.Headers.TryGetValues("X-Req-Id", out var res))
            {
                reqId = res.FirstOrDefault();
            }

            logger?.LogInformation(
                $"Response received: {responseMessage.ReasonPhrase}, time: {time.TotalMilliseconds:0.000} ms, reqID: {reqId}");
            responseMessage.EnsureSuccessStatusCode();

            var json = await responseMessage.Content.ReadAsStringAsync();
            logger?.LogDebug(json);
            var response = JsonSerializer.Deserialize<ForecastResponse>(json);
            return response;
        }
        catch(Exception ex)
        {
            logger?.LogError(ex, "Getting forecast failed");
            throw;
        }
    }

    private async Task<HttpResponseMessage> MakeRequest(string slat, string slon)
    {
        var apiKey = apiKeys[0];
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"forecast?lat={slat}&lon={slon}", UriKind.Relative),
            Headers = { 
                { "X-Yandex-Weather-Key", apiKey}
            },
        };
        
        logger?.LogInformation($"Yandex Weather API Key: ***{MaskApiKey(apiKey)}");
        var responseMessage = await yandexWeatherHttp.SendAsync(request);
        return responseMessage;
    }
}
