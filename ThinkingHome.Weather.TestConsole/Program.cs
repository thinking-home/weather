using Microsoft.Extensions.Logging;
using ThinkingHome.Weather.Api;


namespace ThinkingHome.Weather.TestConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        var apiKey = "49a881a1-3e9a-45f0-b4e7-da8374231cab";
        var lat = 44.706288f;
        var lon = 34.352471f;
        var ttt = Response(lat, lon, apiKey);
        ttt.Wait();
    }
    
    private static async Task Response(float lat, float lon, string apiKey)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        using (var weatherClient = new YandexWeatherClient(apiKey, logger))
        {
            var response = await weatherClient.GetForecast(lat, lon);

            Console.WriteLine($"сейчас на улице {response.Fact.Temperature}°C");
            Console.WriteLine($"ощущается как {response.Fact.FeelsLike}°C");
        }
    }
}
