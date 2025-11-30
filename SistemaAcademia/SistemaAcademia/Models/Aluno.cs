using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SistemaAcademia.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter entre 5 a 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nome deve conter apenas letras e espaços")]
        public string Nome { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite apenas números")]
        public string Cpf { get; set; }
        [EmailAddress(ErrorMessage = "Formato de E-mail inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefone deve ter 11 dígitos")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite apenas números")]
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNasc { get; set; }
        public string Matricula { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de criação")]
        public DateTime DataCriacao { get; private set; }
        [Display(Name = "Plano")]
        public int PlanoId { get; set; }

        public Plano Plano { get; set; }
        public Aluno()
        {
            DataCriacao = DateTime.Now;
            Matricula = GerarCodigoMatricula( DataCriacao);

        }
        public List<Aula> Aulas { get; set; } = new List<Aula>();

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

    

