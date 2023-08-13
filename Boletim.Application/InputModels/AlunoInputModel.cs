namespace Boletim.Application.InputModels
{
    public class AlunoInputModel
    {
        public required int Id { get; set; }

        public required string Nome { get; set; }

        public required int IdCurso { get; set; }

        public required double NotaCurso { get; set; }
    }
}
