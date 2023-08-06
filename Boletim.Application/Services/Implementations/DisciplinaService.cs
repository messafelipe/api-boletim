using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Boletim.Application.ViewModels;
using Boletim.Core.Entities;
using Boletim.Infrastructure.Persistence;

namespace Boletim.Application.Services.Implementations
{
    public class DisciplinaService : IDisciplinaService
    {
        public readonly BoletimDbContext _dbContext;

        public DisciplinaService(BoletimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(DisciplinaInputModel inputModel)
        {
            var disciplina = new Disciplina(inputModel.Id, inputModel.Nome_Disciplina,
                inputModel.Nota, inputModel.Id_Aluno);

            _dbContext.Disciplinas.Add(disciplina);

            return disciplina.Id;
        }

        public IEnumerable<DisciplinaViewModel> GetAll()
        {
            var disciplinas = _dbContext.Disciplinas
                .Select(d => new DisciplinaViewModel(d.Id, d.Nome_Disciplina, d.Nota, d.Id_Aluno));

            return disciplinas;
        }

        public DisciplinaViewModel? GetById(int id)
        {
            var disciplina = _dbContext.Disciplinas.SingleOrDefault(d => d.Id == id);

            if (disciplina == null) return null;

            var disciplinaViewModel = 
                new DisciplinaViewModel(
                    disciplina.Id,
                    disciplina.Nome_Disciplina,
                    disciplina.Nota,
                    disciplina.Id_Aluno
                );

            return disciplinaViewModel;
        }
    }
}
