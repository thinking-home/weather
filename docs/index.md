---
_layout: landing
---

# Thinking-Home.Weather.API

`Thinking-Home.Weather.API` — библиотека, которая предоставляет API для получения
данных о погоде из сервиса
[Яндекс Погода](https://yandex.ru/dev/weather/doc/ru/concepts/weather-data-api).
Для работы вам понадобится ключ доступа, который можно получить в
[личном кабинете](https://yandex.ru/pogoda/b2b/console/smarthome).

## Как установить

``` shell
dotnet add package Thinking-Home.Weather.API
```

## Как использовать

```csharp
// создаем экземпляр класса YandexWeatherClient
using var weatherClient = new YandexWeatherClient(
    "ae672ade-c0ed-43c7-b6e1-36d821aa2c27" // ключ доступа к API
);

// делаем запрос к API Яндекс Погоды
var response = await weatherClient.GetForecast(
    52.37125, // широта
    4.89388  // долгота
);

Console.WriteLine($"сейчас на улице {response.Fact.Temperature}°C");
Console.WriteLine($"ощущается как {response.Fact.FeelsLike}°C");
```

### Логирование

Вы можете передать в конструктор класса `YandexWeatherClient` параметр `logger` (объект, 
[реализующий интерфейс](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line)
`ILogger<YandexWeatherClient>`), в который будет записана информация о
всех возникающих событиях.
```csharp
// создаем фабрику логгеров
using ILoggerFactory factory = LoggerFactory.Create(builder =>
{
    builder.AddConsole(); // подключаем логгирование в консоль
    builder.SetMinimumLevel(LogLevel.Information); // уровень логирования
});

// создаем экземпляр логгера и передаем логгер в конструктор
var logger = factory.CreateLogger<YandexWeatherClient>();
using var weatherClient = new YandexWeatherClient(apiKeys, logger);
```

### Использование с несколькими ключами доступа

В сервисе Яндекс Погода у ключей доступа может быть лимит на количество запросов в месяц
(в зависимости от тарифа). Если вашей программой пользуется несколько человек, у каждого из которых
есть собственный ключ доступа, то вы можете настроить, чтобы при достижении лимита на одном ключе
приложение автоматически начинало использовать следующий. Для этого передайте массив ключей в
конструктор `YandexWeatherClient`. 

Если у всех ключей были достигнуты лимиты запросов, то будет сгенерировано исключение
`NoValidApiKeysException`.

```csharp

string[] apiKeys = [
    "ae672ade-c0ed-43c7-b6e1-36d821aa2c27",
    "e12929c4-74f7-4228-84f0-476632b2782d"
] // ключи доступа к API

// создаем экземпляр класса YandexWeatherClient
using var weatherClient = new YandexWeatherClient(apiKeys);

try
{
    // делаем запрос к API Яндекс Погоды
    var response = await weatherClient.GetForecast(lat, lon);
    // ...
}
catch (NoValidApiKeysException e)
{
    // обрабатываем ситуацию, когда были достигнуты лимиты запросов у всех ключей
    Console.WriteLine("Закончились рабочие ключи");
}
```


