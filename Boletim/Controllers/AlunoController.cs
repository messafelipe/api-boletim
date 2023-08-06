using Boletim.Application.InputModels;
using Boletim.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Boletim.API.Controllers
{
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService )
        {
            _alunoService = alunoService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string query)
        {
            var aluno = _alunoService.GetAll(query);

            return Ok(aluno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult? GetById(int id)
        {
            var aluno = _alunoService.GetById(id);

            if (aluno == null) { return NotFound(); }

            return Ok(aluno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] AlunoInputModel inputModel)
        {
            var id = _alunoService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new {id}, inputModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateAlunoInputModel updateInputModel)
        {
            _alunoService.Update(id, updateInputModel);
            return NoContent();
        }
    }
}
