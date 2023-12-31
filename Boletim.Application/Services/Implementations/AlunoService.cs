﻿using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Boletim.Application.ViewModels;
using Boletim.Core.Entities;
using Boletim.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Boletim.Application.Services.Implementations
{
    public class AlunoService : IAlunoService
    {
        private readonly BoletimDbContext _dbContext;

        public AlunoService(BoletimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<AlunoViewModel> GetAll(string query)
        {
            var alunos = _dbContext.Alunos;

            var alunosViewModel = alunos.Select(a => new AlunoViewModel(a.Id, a.Nome, a.Curso.NomeCurso, a.NotaCurso)).ToList();

            return alunosViewModel;
        }

        public AlunoViewModel? GetById(int id)
        {
            var aluno = _dbContext.Alunos
                .Include(a => a.Curso)
                .SingleOrDefault(a => a.Id == id);

            if (aluno == null) return null;

            var alunoViewModel = 
                new AlunoViewModel
                (
                    aluno.Id,
                    aluno.Nome,
                    aluno.Curso.NomeCurso,
                    aluno.NotaCurso
                );

            return alunoViewModel;
        }

        public int Create(AlunoInputModel inputModel)
        {
            var aluno = new Aluno(inputModel.Id, inputModel.Nome, inputModel.IdCurso, inputModel.NotaCurso);

            _dbContext.Alunos.Add(aluno);

            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public void Update(int id, UpdateAlunoInputModel updateInputModel)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(a => a.Id == id);

            aluno?.Update(id, updateInputModel.NotaCurso);

            _dbContext.SaveChanges();
        }
    }
}
