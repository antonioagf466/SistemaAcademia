using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }

        public Plano Plano { get; set; }
        public DateTime DataInicio { get; private set;}
        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set;}

        public Matricula() { DataInicio = DateTime.Now; }

    }

    
}
