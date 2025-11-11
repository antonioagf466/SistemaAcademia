using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class InscricaoAula
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; set; }
        
    }
}
