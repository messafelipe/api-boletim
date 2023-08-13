using Boletim.Application.Services.Interfaces;
using Boletim.Core.Enums;
using Boletim.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Boletim.Application.Services.Implementations
{
    public class ResultadoService : IResultadoService
    {
        public readonly BoletimDbContext _dbContext;

        public ResultadoService(BoletimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string GetResultado(int idAluno)
        {
            var aluno = _dbContext.Alunos
                .Include(a => a.Curso)
                .SingleOrDefault(a => a.Id == idAluno);

            var curso = _dbContext.Cursos.SingleOrDefault(c => c.Id == aluno.Curso.Id);

            var resultado = (aluno?.NotaCurso >= 7) ? SituacaoEnum.Aprovado: SituacaoEnum.Reprovado;

            return $"{aluno.Nome} foi {resultado} no curso de {curso.NomeCurso} com nota {aluno.NotaCurso}";
        }
    }
}
