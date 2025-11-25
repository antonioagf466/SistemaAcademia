using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models

{
    public class Manutencao
    {
        public int Id { get; set; }
        public EnumTipoManutencao Tipo { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Display(Name = "Técnico")]
        public string Tecnico { get; set; }
        [Display(Name = "Observação")]
        public string? Observacao { get; set; }
        public double Custo { get; set; }
        [Display(Name = "Equipamento")]
        public int EquipamentoId { get; set; }
        public Equipamento Equipamento { get; set; }
    }

    public enum EnumTipoManutencao : int
    {
        Rotineira = 0,
        Emergencial = 1
    }
}
