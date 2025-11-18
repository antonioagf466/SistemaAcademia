namespace SistemaAcademia.Models
{
    public class Professor
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string Cref { get; set;}
        public string Email { get; set; }
        public string Especialidade{ get; set; }
        public bool Ativo  { get; set; }

        public List<Aula> Aulas { get; set; }

    }
}
