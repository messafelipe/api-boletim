using Boletim.Application.InputModels;
using Boletim.Application.ViewModels;

namespace Boletim.Application.Services.Interfaces
{
    public interface IAlunoService
    {
        public List<AlunoViewModel>GetAll(string query);

        public AlunoViewModel? GetById(int id);

        int Create(AlunoInputModel inputModel);

        void Update(int id, UpdateAlunoInputModel updateInputModel);
    }
}
