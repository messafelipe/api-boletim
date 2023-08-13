using Boletim.Core.Enums;

namespace Boletim.Application.ViewModels
{
    public class ResultadoViewModel
    {
        public ResultadoViewModel(int id, SituacaoEnum situacao, int idAluno)
        {
            Id = id;
            Situacao = situacao;
            IdAluno = idAluno;
        }

        public int Id { get; private set; }

        public SituacaoEnum Situacao { get; private set; }

        public int IdAluno { get; private set; }
    }
}
