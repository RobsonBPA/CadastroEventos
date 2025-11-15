using CadastroEventos.Models;

namespace CadastroEventos.Views;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now; // Impede que o usuário selecione uma data passada
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day); // Limita a data inicial a 6 meses no futuro

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1); // A data mínima de término é 1 dia após a data inicial
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(3); // A data máxima de término é 3 meses após a data inicial
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            var evento = new Evento
            {
                Nome = nomeEvento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                Participantes = int.Parse(qtdParticipantes.Text),
                Local = localEvento.Text,
                CustoParticipante = double.Parse(custoParticipante.Text)
            };

            Navigation.PushAsync(new ResumoCadastro(evento)); // Direciona o usuário para ResumoCadastro.xaml
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}