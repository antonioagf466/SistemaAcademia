using NuGet.Protocol.Plugins;

namespace SistemaAcademia.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Horario { get; set; }
        public int Vagas {get; set;}
        public string Tipo { get; set; }
        public string Sala { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    }
    
}
