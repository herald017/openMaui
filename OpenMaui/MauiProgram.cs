
using Microsoft.Extensions.Logging;
using OpenMaui.Pages;

namespace OpenMaui;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		Routing.RegisterRoute(nameof(Calculator), typeof(Calculator));
        Routing.RegisterRoute(nameof(TaskList), typeof(TaskList));
        builder.Services.AddTransient<Calculator>();	
		builder.Services.AddTransient<TaskList>();
		return builder.Build();
	}
}
