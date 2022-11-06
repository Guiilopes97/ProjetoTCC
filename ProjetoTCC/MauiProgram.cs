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

        builder.Services.AddSingleton<MainViewModel>();			// Inicializa a Classe MainViewModel - AddSingleton = Mantem a Pagina salva em cache
        builder.Services.AddTransient<DetailViewModel>();		// Inicializa a Classe DetailViewModel - AddTransient = Destroi a pagina ao sair, e cria uma nova ao acessar

        builder.Services.AddSingleton<MainPage>();				// Inicializa a Pagina MainPage
        builder.Services.AddTransient<DetailPage>();			// Inicializa a Pagina DetailPage

		var app = builder.Build();

		return app;
	}
}
