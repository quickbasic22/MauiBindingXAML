using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MauiAudio;
using Plugin.Maui.Audio;

namespace MauiBindingXAML;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		 builder.UseMauiAudio().UseMauiCommunityToolkit();
		builder.Services.AddSingleton<AudioManager>();
		builder.Services.AddTransient<MainPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
