using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class InscricaoAula
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; private set; }

        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }
        public int AulaId { get; set; }
        public Aula Aula { get; set; }

        public InscricaoAula() { DataInscricao = DateTime.Now; }

    }
}
