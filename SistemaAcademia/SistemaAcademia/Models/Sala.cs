using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Sala
    {
        public int Id { get; set;}
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nome deve ter apenas letras e espaços")]
        public string Nome { get; set;}
        public EnumTipoSala Tipo { get; set;}
        public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    }
    public enum EnumTipoSala : int
    {
        Luta = 0,
        Aerobico = 1,
        Musculação = 2,
        Ginastica = 3,
        Natação = 4
    }

}
