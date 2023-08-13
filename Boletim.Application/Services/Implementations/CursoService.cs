using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Boletim.Application.ViewModels;
using Boletim.Core.Entities;
using Boletim.Infrastructure.Persistence;

namespace Boletim.Application.Services.Implementations
{
    public class CursoService : ICursoService
    {
        public readonly BoletimDbContext _dbContext;

        public CursoService(BoletimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CursoInputModel inputModel)
        {
            var Curso = new Curso(inputModel.Id, inputModel.NomeCurso);

            _dbContext.Cursos.Add(Curso);

            _dbContext.SaveChanges();

            return Curso.Id;
        }

        public IEnumerable<CursoViewModel> GetAll()
        {
            var Cursos = _dbContext.Cursos
                .Select(d => new CursoViewModel(d.Id, d.NomeCurso));

            return Cursos;
        }

        public CursoViewModel? GetById(int id)
        {
            var Curso = _dbContext.Cursos.SingleOrDefault(d => d.Id == id);

            if (Curso == null) return null;

            var CursoViewModel = 
                new CursoViewModel(
                    Curso.Id,
                    Curso.NomeCurso
                );

            return CursoViewModel;
        }

        public void Update(int id, UpdateCursoInputModel updateInputModel)
        {
            var disciplina = _dbContext.Cursos.SingleOrDefault(d => d.Id == id);

            disciplina?.Update(updateInputModel.NomeCurso);

            _dbContext.SaveChanges();
        }
    }
}
