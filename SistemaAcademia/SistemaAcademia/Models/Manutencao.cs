using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models

{
    public class Manutencao
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public string Tecnico { get; set; }
        public string? Observacao { get; set; }
        public double Custo { get; set; }
        [Display(Name = "Equipamento")]
        public int EquipamentoId { get; set; }
        public Equipamento Equipamento { get; set; }
    }
}
