using Microsoft.Extensions.Logging;

namespace CadastroEventos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    // Open Sans
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    // Lexend
                    fonts.AddFont("Lexend-Regular.ttf", "LexendRegular");
                    fonts.AddFont("Lexend-SemiBold.ttf", "LexendSemiBold");
                    fonts.AddFont("Lexend-Bold.ttf", "LexendBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
