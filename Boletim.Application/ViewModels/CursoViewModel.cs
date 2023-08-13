namespace Boletim.Application.ViewModels
{
    public  class CursoViewModel 
    {
        public CursoViewModel(int id, string nomeCurso)
        {
            Id = id;
            NomeCurso = nomeCurso;
        }

        public int Id { get; private set; }

        public string NomeCurso { get; private set; }
    }
}
