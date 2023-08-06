using Boletim.Core.Entities;
using Boletim.Core.Enums;

namespace Boletim.Infrastructure.Persistence
{
    public  class BoletimDbContext
    {
        public BoletimDbContext()
        {
            Alunos = new List<Aluno>
            {
                new Aluno(1, "Felipe", "3A"),
                new Aluno(2, "Beatriz", "1A"),
                new Aluno(3, "Gustavo", "3C"),
                new Aluno(4, "Igor", "2B")
            };

            Disciplinas = new List<Disciplina>
            {
                new Disciplina(1, "Matemática", 10.0, 1),
                new Disciplina(2, "Português", 8.0, 1),

            };

            Resultados = new List<Resultado>
            {
                new Resultado(9, ResultadoFinalEnum.Aprovado, 1)
            };
        }

        public List<Aluno> Alunos { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

        public List<Resultado> Resultados { get; set; }
    }
}
