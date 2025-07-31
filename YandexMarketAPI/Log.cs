using Microsoft.Extensions.Logging;

namespace YandexMarketAPI;

public class Log
{
    private static readonly ILoggerFactory Factory = LoggerFactory.Create(builder =>
    {
        builder.AddSimpleConsole(options =>
        {
            options.IncludeScopes = true;
            options.SingleLine = true;
            options.TimestampFormat = "HH:mm:ss ";
        });
    });

    public static ILogger<T> CreateLogger<T>()
    {
        ILogger<T> logger = Factory.CreateLogger<T>();
        logger.BeginScope("YandexMarketAPI");
        return logger;
    }
}