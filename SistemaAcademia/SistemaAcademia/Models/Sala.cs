namespace SistemaAcademia.Models
{
    public class Sala
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string Tipo { get; set;}
        public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    }
}
