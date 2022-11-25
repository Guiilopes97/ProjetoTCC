using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProjetoTCC.ViewModel;

public partial class MainViewModel : ObservableObject
{
    //Monkey monkey;
    IConnectivity connectivity;
    //IToast toast;
    public MainViewModel(IConnectivity connectivity)//, IToast toast)
    {
        //monkey = new Monkey { Name = "Mooch" };
        this.connectivity = connectivity;
        //this.toast = toast;
    }

    [ObservableProperty]
    int count;
    

    [RelayCommand]
    void IncrementCount()
    {
        if (count == 0)
        {

        }
        Count += 10;
    }

    [RelayCommand]
    async Task Navigate()
    {
        NetworkAccess accessType = connectivity.NetworkAccess;

        if (accessType == NetworkAccess.Internet)
        {
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }
        else
        {
            await Shell.Current.DisplayAlert("Conexão", "Sem Conexão a Internet", "ok");
        }
    }

    [RelayCommand]
    async Task NavigateCovid()
    {
        NetworkAccess accessType = connectivity.NetworkAccess;

        if (accessType == NetworkAccess.Internet)
        {
            await Shell.Current.GoToAsync(nameof(CovidPage));
        }
        else
        {
            await Shell.Current.DisplayAlert("Conexão", "Sem Conexão a Internet", "ok");
        }
    }

    [RelayCommand]
    async Task CheckInternet()
    {
        NetworkAccess accessType = connectivity.NetworkAccess;

        if (accessType == NetworkAccess.Internet)
        {
            //toast.MakeToast("You Have Internet!");
            await Shell.Current.DisplayAlert("Conexão", "Conectado a internet", "ok");
        }
        else
        {
            await Shell.Current.DisplayAlert("Conexão", "Sem Conexão a Internet", "ok");
        }
    }

}
