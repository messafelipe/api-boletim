namespace Boletim.Core.Entities
{
    public class Disciplina : BaseEntity
    {
        public Disciplina(int id, string nome_Disciplina, double nota, int id_Aluno) : base(id)
        {
            Nome_Disciplina = nome_Disciplina;
            Nota = nota;
            Id_Aluno = id_Aluno;
        }

        public string Nome_Disciplina { get; private set; }

        public double Nota { get; private set; }

        public int Id_Aluno { get; private set; }
    }
}
