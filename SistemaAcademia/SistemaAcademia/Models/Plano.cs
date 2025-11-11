namespace SistemaAcademia.Models
{
    public class Plano
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Periodicidade { get; set; }
        public int AulasSemana { get; set; }
        public bool Ativo { get; set; }
    }
}
