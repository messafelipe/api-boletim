using Boletim.Application.InputModels;
using Boletim.Application.ViewModels;

namespace Boletim.Application.Services.Interfaces
{
    public interface ICursoService
    {
        public IEnumerable<CursoViewModel> GetAll();

        public CursoViewModel? GetById(int id);

        int Create(CursoInputModel inputModel);

        void Update(int id, UpdateCursoInputModel updateInputModel);
    }
}
