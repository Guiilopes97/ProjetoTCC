using Newtonsoft.Json;
using ProjetoTCC.ViewModel;
using ProjetoTCC.Classes;

namespace ProjetoTCC;

public partial class CovidPage : ContentPage
{
    DashboardService service;
    public CovidPage(CovidViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

        service = new DashboardService();
        GetData();
    }

    async void GetData()
    {
        CovidData data = await service.GetCovidData("https://covid19-brazil-api.now.sh/api/report/v1/brazil");
        BindingContext = data;
    }

}