using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Professor
    {
        public int Id { get; set;}
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nome deve ter apenas letras e espaços")]
        public string Nome { get; set;}
        [StringLength(8, MinimumLength = 8, ErrorMessage = "CREF deve ter 8 dígitos")]
        public string Cref { get; set;}
        [EmailAddress(ErrorMessage = "Formato de E-mail inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public EnumEspecialidade Especialidade{ get; set; }
        public List<Aula> Aulas { get; set; }

    }
    public enum EnumEspecialidade : int
    {
        Luta = 0,
        Aerobico = 1,
        Musculação = 2,
        Ginastica = 3,
        Natação = 4
    }
}
