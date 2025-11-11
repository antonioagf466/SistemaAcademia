using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string NumeroPatrimonio { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set;}
        [DataType(DataType.Date)]
        public DateTime DataAquisicao { get; set; }
        public string Status { get; set; }
    }
}
