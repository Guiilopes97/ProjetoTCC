using ProjetoTCC.ViewModel;

namespace ProjetoTCC;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }	



	public async void girar()
	{
        image.Rotation = 0;
        await image.RotateTo(360, 6000);
        
    }

    public async void animarImg()
    {
        await image.TranslateTo(-100, 0, 1000);    // Move image left
        await image.TranslateTo(-100, -100, 1000); // Move image diagonally up and left
        await image.TranslateTo(100, 100, 2000);   // Move image diagonally down and right
        await image.TranslateTo(0, 100, 1000);     // Move image left
        await image.TranslateTo(0, 0, 1000);       // Move image up
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var evento = await DisplayActionSheet("Eventos", null, "Fechar", "Girar Imagem", "Animar Imagem");

        if(evento == "Girar Imagem"){
            girar();
        }
        else if (evento == "Animar Imagem")
        {
            animarImg();
        }
    }

    private void BtnAlunos_Clicked(object sender, EventArgs e)
    {
        var alunos =
            "188648 | Guilherme Lopes de Oliveira\n\n" +
            "185378 | Thiago Ikenaga Suzuki\n\n" +
            "190718 | Pedro Henrrique de Jesus Barbosa\n\n" +
            "150184 | Ramon Fisher de Paula Conceição";

        DisplayAlert("Alunos", alunos, "Fechar");
    }
}

