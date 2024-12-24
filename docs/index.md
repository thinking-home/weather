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
