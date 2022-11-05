using ProjetoTCC.ViewModel;

namespace ProjetoTCC;

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

        builder.Services.AddSingleton<IConnectivity>((e) => Connectivity.Current);

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<DetailViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailPage>();

		var app = builder.Build();

		return app;
	}
}
