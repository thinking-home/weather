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
    
    
    private readonly ILogger logger;

    private string MaskApiKey(string apiKey)
    {
        return apiKey.Substring(apiKey.Length - 6);
    }

    public YandexWeatherClient(string apiKey, ILogger logger)
    {
        yandexWeatherHttp.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", apiKey);
        this.logger = logger;
        logger.LogInformation($"Yandex Weather API Key: ***{MaskApiKey(apiKey)}");
    }

    public void Dispose()
    {
        logger.LogInformation("Dispose weather client");
        yandexWeatherHttp.Dispose();
    }

    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        var slat = JsonSerializer.Serialize(lat);
        var slon = JsonSerializer.Serialize(lon);
        logger.LogInformation($"Getting forecast for {slat}, {slon}");
        
        DateTime start = DateTime.Now;
        var responseMessage = await yandexWeatherHttp.GetAsync($"forecast?lat={slat}&lon={slon}");
        var time = DateTime.Now - start;
        var reqId = responseMessage.Headers.GetValues("X-Req-Id").FirstOrDefault() ?? "<unknown>";
        
        logger.LogInformation($"Response received: {responseMessage.ReasonPhrase}, time: {time.TotalMilliseconds:0.000} ms, reqID: {reqId}");
        responseMessage.EnsureSuccessStatusCode();
        
        var json = await responseMessage.Content.ReadAsStringAsync();
        var response = JsonSerializer.Deserialize<ForecastResponse>(json);
        return response;
    }
}
