namespace Boletim.Core.Entities
{
    public class Aluno : BaseEntity
    {
        public Aluno(int id, string nome, string turma) : base(id)
        {
            Nome = nome;
            Turma = turma;
        }

        public string Nome { get; private set; }

        public string Turma { get; private set; }


        public void Update(int id, string nome, string turma)
        {
            Id = id;
            Nome = nome;
            Turma = turma;
        }
    }
}
