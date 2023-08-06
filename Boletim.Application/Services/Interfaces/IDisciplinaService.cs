using Boletim.Application.InputModels;
using Boletim.Application.ViewModels;

namespace Boletim.Application.Services.Interfaces
{
    public interface IDisciplinaService
    {
        public IEnumerable<DisciplinaViewModel> GetAll();

        public DisciplinaViewModel? GetById(int id);

        int Create(DisciplinaInputModel inputModel);

        void Update(int id, UpdateDisciplinaInputModel inputModel);
    }
}
