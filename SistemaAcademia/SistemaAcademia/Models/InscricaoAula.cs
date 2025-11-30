using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class InscricaoAula
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da inscrição")]
        public DateTime DataInscricao { get; private set; }
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }
        [Display(Name = "Aula")]
        public int AulaId { get; set; }
        public Aula Aula { get; set; }

        public InscricaoAula() { DataInscricao = DateTime.Now; }

    }
}
