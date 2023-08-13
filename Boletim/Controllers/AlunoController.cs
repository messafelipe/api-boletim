using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Boletim.API.Controllers
{
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alunoService"></param>
        public AlunoController(IAlunoService alunoService )
        {
            _alunoService = alunoService;
        }

        /// <summary>
        /// Retorna uma lista de todos os alunos disponíveis
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string query)
        {
            try
            {
                var alunos = _alunoService.GetAll(query);
                if (alunos == null) { return NotFound(); }
                return Ok(alunos);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Recupera um aluno específico com base no ID fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult? GetById(int id)
        {
            try
            {
                var aluno = _alunoService.GetById(id);
                if (aluno == null) { return NotFound(); }
                return Ok(aluno);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Realiza o cadastro do aluno
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] AlunoInputModel inputModel)
        {
            try
            {
                var id = _alunoService.Create(inputModel);
                return CreatedAtAction(nameof(GetById), new { id }, inputModel);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Permite a atualização das informações de um aluno específico
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateInputModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateAlunoInputModel updateInputModel)
        {
            try
            {
                _alunoService.Update(id, updateInputModel);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }
    }
}
