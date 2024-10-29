using System.Collections.Specialized;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using ThinkingHome.Weather.Api.Model;

namespace ThinkingHome.Weather.Api;

public class YandexWeatherClient : IDisposable
{
    private HttpClient yandexWeatherHttp = new HttpClient()
    {
        BaseAddress = new Uri("https://api.weather.yandex.ru/v2/"),
    };

    public YandexWeatherClient(string apiKey)
    {
        yandexWeatherHttp.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", apiKey);
    }
    public async Task<ForecastResponse> GetForecast(float lat, float lon)
    {
        string slat = JsonSerializer.Serialize(lat);
        string slon = JsonSerializer.Serialize(lon);
        string json = await yandexWeatherHttp.GetStringAsync($"forecast?lat={slat}&lon={slon}");
        Console.WriteLine(json);
        var response = JsonSerializer.Deserialize<ForecastResponse>(json);
        return response;
    }
    public void Dispose()
    {
        yandexWeatherHttp.Dispose();
    }
}
