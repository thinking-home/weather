using System.Text.Json;
using ThinkingHome.Weather.Api.Model;

namespace ThinkingHome.Weather.Api;

public class YandexWeatherClient : IDisposable
{
    private readonly HttpClient yandexWeatherHttp = new()
    {
        BaseAddress = new Uri("https://api.weather.yandex.ru/v2/")
    };

    public YandexWeatherClient(string apiKey)
    {
        yandexWeatherHttp.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", apiKey);
    }

    public void Dispose()
    {
        yandexWeatherHttp.Dispose();
    }

    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        var slat = JsonSerializer.Serialize(lat);
        var slon = JsonSerializer.Serialize(lon);
        var json = await yandexWeatherHttp.GetStringAsync($"forecast?lat={slat}&lon={slon}");
        Console.WriteLine(json);
        var response = JsonSerializer.Deserialize<ForecastResponse>(json);
        return response;
    }
}
