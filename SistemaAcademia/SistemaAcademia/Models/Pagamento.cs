using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        [Display(Name = "Número do recibo")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Recibo deve ter pelo menos 1 número")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite apenas números")]
        public string NumeroRecibo { get; set;}
        public double Valor { get; set; }
        [Display(Name = "Forma de pagamento")]
        public EnumForma Forma { get; set;}
        public DateTime Data { get; private set; }
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public Pagamento() { Data = DateTime.Now; }
    }

    public enum EnumForma : int
    {
        Debito = 0,
        Credito = 1,
        Pix = 2,
        Dinheiro = 3
    }
}
