using CadastroEventos.Models;
namespace CadastroEventos.Views;

public partial class ResumoCadastro : ContentPage
{
    public ResumoCadastro(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento; // Agora a página inteira enxerga o evento
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync(); // Direciona novamente o usuário para Cadastro.xaml
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK"); // Mensagem de erro
        }
    }
}