using System.Diagnostics.SymbolStore;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ThinkingHome.Weather.Api;

namespace ThinkingHome.Weather.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yandexApi = "49a881a1-3e9a-45f0-b4e7-da8374231cab";
            float lat = 44.706288f;
            float lon = 34.352471f;
            var ttt = Response(lat, lon, yandexApi);
            ttt.Wait();
        }
        static async Task Response(float lat, float lon, string yandexApi) {

            //string response = await yandexWeather.GetStringAsync("forecast?"+lat+"&"+lon);

            //Console.WriteLine(response);
            var weatherClient = new YandexWeatherClient(yandexApi);
            var json = await weatherClient.GetForecast(lat, lon);

            var response = JsonSerializer.Deserialize<ForecastResponse>(json);

            Console.WriteLine($"сейчас на улице {response.Fact.Temperature}°C");
            Console.WriteLine($"ощущается как {response.Fact.FeelsLike}°C");
        }
    }
}