namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } 
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Participantes { get; set; }
        public string Local { get; set; }
        public double CustoParticipante { get; set; }

        public double CustoTotal => Participantes * CustoParticipante;
        public TimeSpan Duracao => DataTermino - DataInicio;
        public string DuracaoFormatada
        {
            get
            {
                var d = Duracao;
                return $"{d.Days} dias";
            }
        }
    }
}
