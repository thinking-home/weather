using System.Collections.Specialized;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace ThinkingHome.Weather.Api;

public class YandexWeatherClient
{
    private HttpClient yandexWeather = new HttpClient()
    {
        BaseAddress = new Uri("https://api.weather.yandex.ru/v2/"),
    };

    public YandexWeatherClient(string yandexApi)
    {
        yandexWeather.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", yandexApi);
    }
    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        lat.ToString();
        lon.ToString();
        string json = await yandexWeather.GetStringAsync($"forecast?{lat}&{lon}");
        var response = JsonSerializer.Deserialize<ForecastResponse>(json);
        return response;
    }
}
