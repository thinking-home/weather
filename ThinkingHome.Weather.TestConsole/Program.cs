using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using ThinkingHome.Weather.Api;

namespace ThinkingHome.Weather.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YandexWeatherClient client = new YandexWeatherClient();
            var ttt = Response();
            ttt.Wait();
        }
        static async Task Response() {
            string yandexApi = "49a881a1-3e9a-45f0-b4e7-da8374231cab";
            var lat = "44.706288";
            var lon = "34.352471";
            HttpClient yandexWeather = new HttpClient()
            {
                BaseAddress = new Uri("https://api.weather.yandex.ru/v2/"),
            };
            yandexWeather.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", yandexApi);
            string response = await yandexWeather.GetStringAsync("forecast?"+lat+"&"+lon);

            Console.WriteLine(response);
        }
    }
}