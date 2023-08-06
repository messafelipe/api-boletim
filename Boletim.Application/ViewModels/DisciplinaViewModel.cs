using Boletim.Core.Entities;

namespace Boletim.Application.ViewModels
{
    public  class DisciplinaViewModel 
    {
        public DisciplinaViewModel(int id, string nome_Disciplina, double nota, int id_Aluno)
        {
            Id = id;
            Nome_Disciplina = nome_Disciplina;
            Nota = nota;
            Id_Aluno = id_Aluno;
        }

        public int Id { get; private set; }

        public string Nome_Disciplina { get; private set; }

        public double Nota { get; private set; }

        public int Id_Aluno { get; private set; }
    }
}
