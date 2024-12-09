namespace ThinkingHome.Weather.Api;

public class NoValidAPIKeysException : Exception
{
    public NoValidAPIKeysException()
        : base("Тo valid keys to make request to Yandex Weather") { }
}
