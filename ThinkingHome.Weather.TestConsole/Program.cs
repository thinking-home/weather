using System.Net.Http;
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
            HttpClient yandexWeather = new HttpClient()
            {
                BaseAddress = new Uri("https://api.weather.yandex.ru/v2/"),
            };
            yandexWeather.DefaultRequestHeaders.Add("X-Yandex-Weather-Key", "c6e1cdc8-3f10-4583-a744-25e7eb042594");
            string response = await yandexWeather.GetStringAsync("forecast?lat=52.37125&lon=4.89388");
            Console.WriteLine(response);
        }
    }
}