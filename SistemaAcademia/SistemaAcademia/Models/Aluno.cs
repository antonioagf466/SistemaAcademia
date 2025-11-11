using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SistemaAcademia.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set;}
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        public DateTime DataCriacao { get; private set; }
        public bool Ativo { get; set; }
        public Aluno() { DataCriacao = DateTime.Now; }

    }
    /*enum ai*/
}
