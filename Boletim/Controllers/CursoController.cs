using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Boletim.API.Controllers
{
    [Route("api/cursos")]
    public class CursoController : ControllerBase
    {
        public readonly ICursoService _cursoService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursoService"></param>
        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        /// <summary>
        /// Retorna uma lista de todos os cursos disponíveis
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var cursos = _cursoService.GetAll();
                if (cursos == null) { return NotFound(); }
                return Ok(cursos);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Recupera um curso específico com base no ID fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var curso = _cursoService.GetById(id);
                if (curso == null) { return NotFound(); }
                return Ok(curso);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Realiza o cadastro do curso
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] CursoInputModel inputModel)
        {
            try
            {
                var id = _cursoService.Create(inputModel);
                return CreatedAtAction(nameof(GetById), new { id }, inputModel);
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }

        /// <summary>
        /// Permite a atualização das informações de um curso específico
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateInputModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCursoInputModel updateInputModel)
        {
            try
            {
                _cursoService.Update(id, updateInputModel);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(e.HResult, e.Message);
            }
        }
    }
}
