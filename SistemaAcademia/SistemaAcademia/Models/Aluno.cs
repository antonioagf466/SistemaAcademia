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
        public string Email { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }
        public string Matricula { get; set; }
        public DateTime DataCriacao { get; private set; }
        public bool Ativo { get; set; }
        public Aluno()
        {
            DataCriacao = DateTime.Now;
            Matricula = GerarCodigoMatricula( DataCriacao);

        }

        // Função para gerar o código de matrícula
        public static string GerarCodigoMatricula( DateTime DataCriacao)
        {
            // Formatar a data no formato YYYYMMDD-hhmmss
            string dataFormatada = DataCriacao.ToString("yyyyMMdd");

            // Formatar a hora no formato HHMMSS
            string horaFormatada = DataCriacao.ToString("HHmmss");

            // Gerar o código de matrícula no formato: YYYYMMDD-HHMMSS
            string codigoMatricula = $"{dataFormatada}{horaFormatada}";

            return codigoMatricula;
        }
    }
}

    
    /*enum ai*/

