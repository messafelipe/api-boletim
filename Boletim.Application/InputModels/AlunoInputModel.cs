using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim.Application.InputModels
{
    public class AlunoInputModel
    {
        public required int Id { get; set; }

        public required string Nome { get; set; }

        public required string Turma { get; set; }
    }
}
