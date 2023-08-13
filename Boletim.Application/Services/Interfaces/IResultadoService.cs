using Boletim.Application.ViewModels;
using Boletim.Core.Entities;

namespace Boletim.Application.Services.Interfaces
{
    public interface IResultadoService
    {
        string GetResultado(int idAluno);
    }
}
