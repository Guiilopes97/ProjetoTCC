using ProjetoTCC.ViewModel;

namespace ProjetoTCC;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    //protected override void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //}
}