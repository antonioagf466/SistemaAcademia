namespace SistemaAcademia.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string NumeroRecibo { get; set;}
        public double Valor { get; set; }
        public string Forma { get; set;}
        public DateTime Data { get; private set; }

        public Pagamento() { Data = DateTime.Now; }
    }
}
