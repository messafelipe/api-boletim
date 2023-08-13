namespace Boletim.Core.Entities
{
    public class Curso : BaseEntity
    {
        public Curso(int id, string nomeCurso) : base(id)
        {
            NomeCurso = nomeCurso;
            Alunos =  new List<Aluno>();
        }

        public string NomeCurso { get; private set; }

        public List<Aluno> Alunos { get; private set; }

        public void Update(string nomeCurso)
        {
            NomeCurso = nomeCurso;
        }
    }
}
