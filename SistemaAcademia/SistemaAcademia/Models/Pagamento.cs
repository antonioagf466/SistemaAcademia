namespace SistemaAcademia.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string NumeroRecibo { get; set;}
        public double Valor { get; set; }
        public string Forma { get; set;}
        public DateTime Data { get; private set; }

        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public Pagamento() { Data = DateTime.Now; }
    }
}
