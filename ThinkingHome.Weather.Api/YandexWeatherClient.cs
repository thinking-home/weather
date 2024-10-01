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

    public YandexWeatherClient(string apiKey)
    {
        yandexWeather.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", apiKey);
    }
    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        string slat = JsonSerializer.Serialize(lat);
        string slon = JsonSerializer.Serialize(lon);
        var url = $"forecast?lat={slat}&lon={slon}";
        string json = await yandexWeather.GetStringAsync(url);
        var response = JsonSerializer.Deserialize<ForecastResponse>(json);
        return response;
    }
}
