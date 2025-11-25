using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaAcademia.Models
{
    public class Plano
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nome deve ter apenas letras e espaços")]
        public string Nome { get; set; }
        public double Valor { get; set; }
        [Display(Name = "Periodicidade mensal")]
        [Range(0, 12, ErrorMessage = "Escolha apenas de 0 a 12")]
        public int Periodicidade { get; set; }
        [Display(Name = "Aulas por semana")]
        [Range(0, 6, ErrorMessage = "Escolha apenas de 0 a 6")]
        public int AulasSemana { get; set; }
    }

}
