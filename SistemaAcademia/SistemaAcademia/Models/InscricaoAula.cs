using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class InscricaoAula
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; private set; }

        public int AlunoId { get; set; }

        public InscricaoAula() { DataInscricao = DateTime.Now; }

    }
}
