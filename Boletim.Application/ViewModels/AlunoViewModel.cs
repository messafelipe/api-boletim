namespace Boletim.Application.ViewModels
{
    public class AlunoViewModel
    {
        public AlunoViewModel(int id, string nome, string turma)
        {
            Id = id;
            Nome = nome;
            Turma = turma;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Turma { get; private set; }
    }
}
