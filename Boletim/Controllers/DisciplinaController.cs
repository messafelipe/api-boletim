using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Boletim.API.Controllers
{
    [Route("api/disciplinas")]
    public class DisciplinaController : ControllerBase
    {
        public readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var disciplinas = _disciplinaService.GetAll();

            return Ok(disciplinas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var disciplina = _disciplinaService.GetById(id);

            return Ok(disciplina);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] DisciplinaInputModel inputModel)
        {
            var id = _disciplinaService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateDisciplinaInputModel inputModel)
        {
            _disciplinaService.Update(id, inputModel);
            return NoContent();
        }
    }
}
