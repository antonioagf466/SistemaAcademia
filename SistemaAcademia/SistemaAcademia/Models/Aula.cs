using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SistemaAcademia.Models
{
    public class Aula
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nome deve ter apenas letras e espaços")]
        public string Nome { get; set; }
        public string Horario { get; set; }
        public int Vagas {get; set;}
        public EnumTipoAula Tipo { get; set; }
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public bool TemVagas()
        {
            return Vagas > 0;
        }
        public enum EnumTipoAula : int
        {
            Luta = 0,
            Aerobico = 1,
            Musculação = 2,
            Ginastica = 3,
            Natação = 4
        }

    }

    
}
