# Логирование

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