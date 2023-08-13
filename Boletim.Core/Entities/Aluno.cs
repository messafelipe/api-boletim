namespace Boletim.Core.Entities
{
    public class Aluno : BaseEntity
    {
        public Aluno(int id, string nome, int idCurso, double notaCurso) : base(id)
        {
            Nome = nome;
            IdCurso = idCurso;
            NotaCurso = notaCurso;
        }

        public string Nome { get; private set; }

        public int IdCurso { get; private set; }

        public Curso Curso { get; private set; }

        public double NotaCurso { get; private set; }

        public void Update(int id, double notaCurso)
        {
            Id = id;
            NotaCurso = notaCurso;
        }
    }
}
