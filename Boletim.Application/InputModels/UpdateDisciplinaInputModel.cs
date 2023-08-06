namespace Boletim.Application.InputModels
{
    public class UpdateDisciplinaInputModel
    {
        public required int Id { get; set; }      
        
        public required string Nome_Disciplina { get; set; }

        public required double Nota { get; set; }

        public required int Id_Aluno { get; set; }
    }
}
