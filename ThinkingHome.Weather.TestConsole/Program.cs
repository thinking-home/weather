using Microsoft.Extensions.Logging;
using ThinkingHome.Weather.Api;


namespace ThinkingHome.Weather.TestConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] apiKeys = ["49a881a1-3e9a-45f0-b4e7-da8374231cab","74c80fd8-5d3e-4691-90cc-684987134c79"];
        var lat = 44.706288f;
        var lon = 34.352471f;
        var ttt = Response(lat, lon, apiKeys);
        ttt.Wait();
    }
    
    private static async Task Response(float lat, float lon, string[] apiKeys)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Information);       // уровень логирования
        });
        ILogger logger = factory.CreateLogger("Program");
        using var weatherClient = new YandexWeatherClient(apiKeys, logger);
        try
        {
            var response = await weatherClient.GetForecast(lat, lon);
            Console.WriteLine($"сейчас на улице {response.Fact.Temperature}°C");
            Console.WriteLine($"ощущается как {response.Fact.FeelsLike}°C");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
