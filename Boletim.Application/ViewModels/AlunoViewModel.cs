namespace Boletim.Application.ViewModels
{
    public class AlunoViewModel
    {
        public AlunoViewModel(int id, string nome, string nomeCurso, double notaCurso)
        {
            Id = id;
            Nome = nome;
            NomeCurso = nomeCurso;
            NotaCurso = notaCurso;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string NomeCurso { get; private set; }

        public double NotaCurso { get; private set; }
    }
}
