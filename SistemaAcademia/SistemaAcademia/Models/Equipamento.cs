using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        [Display(Name = "Número do patrimônio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Numero deve ter entre 1 a 50 dígitos")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite apenas números")]
        public string NumeroPatrimonio { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nome deve ter no mínimo 1 caracteres e no máximo 50")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Marca deve ter no mínimo 1 caracteres e no máximo 50")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Marca deve ter apenas letras e espaços")]
        public string Marca { get; set;}
        [DataType(DataType.Date)]
        [Display(Name = "Data de aquisição")]
        public DateTime DataAquisicao { get; set; }
        public EnumStatus Status { get; set; }
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public Sala? Sala { get; set; }
        public List<Manutencao> Manutencoes { get; set; } = new List<Manutencao>();
    }
    
    public enum EnumStatus : int
    {
        Novo = 0,
        Manutenção = 1,
        Usado = 2
    }
}
