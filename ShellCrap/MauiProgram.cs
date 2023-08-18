using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ShellCrap.ViewModels;

namespace ShellCrap;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var version = typeof(MauiApp).Assembly.GetName().Version;
		System.Diagnostics.Debug.WriteLine($"Version = {version.ToString()}");
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialIcons");
            });

        builder.Services.AddTransient<PageOne>();
        builder.Services.AddTransient<PageTwo>();
        builder.Services.AddTransient<PageThree>();

        builder.Services.AddSingleton<PageOneVM>();
        builder.Services.AddSingleton<PageTwoVM>();
        builder.Services.AddSingleton<PageThreeVM>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

