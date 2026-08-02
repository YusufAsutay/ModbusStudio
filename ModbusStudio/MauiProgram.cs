using Microsoft.Extensions.Logging;
using ModbusStudio.Core.Interfaces;
using ModbusStudio.Services.Logging;

namespace ModbusStudio;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Dependency Injection
        builder.Services.AddSingleton<ILoggerService, LoggerService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}