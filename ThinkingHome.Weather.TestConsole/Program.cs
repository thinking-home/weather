using ThinkingHome.Weather.Api;

namespace ThinkingHome.Weather.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YandexWeatherClient client = new YandexWeatherClient();
            client.SayMoo();
        }
    }
}