using Boletim.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Boletim.API.Controllers
{
    [Route("api/resultados")]
    public class ResultadoController : ControllerBase
    {
        public readonly IResultadoService _resultadoService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultadoService"></param>
        public ResultadoController(IResultadoService resultadoService)
        {
            _resultadoService = resultadoService;
        }

        /// <summary>
        /// Determina se o aluno foi aprovado ou reprovado 
        /// com base nos critérios fornecidos.
        /// </summary>
        /// <param name="idAluno"></param>
        /// <returns></returns>
        [HttpGet("{idAluno}")]
        public IActionResult Get(int idAluno)
        {
            try
            {
                var resultado = _resultadoService.GetResultado(idAluno);
                return Ok(resultado);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }
    }
}
