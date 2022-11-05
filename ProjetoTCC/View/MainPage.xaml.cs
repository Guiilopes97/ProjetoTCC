using ProjetoTCC.ViewModel;

namespace ProjetoTCC;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }	
}

