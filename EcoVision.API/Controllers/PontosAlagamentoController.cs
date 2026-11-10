using EcoVision.API.Models;
using EcoVision.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EcoVision.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PontosAlagamentoController : ControllerBase
    {
        private readonly IPontoAlagamentoRepository _repository;

        public PontosAlagamentoController(IPontoAlagamentoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pontos = await _repository.ObterTodosAsync();
            return Ok(pontos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var ponto = await _repository.ObterPorIdAsync(id);
            if (ponto == null) return NotFound("Ponto de alagamento não encontrado.");
            return Ok(ponto);
        }

        [HttpGet("em-risco")]
        public async Task<IActionResult> GetEmRisco()
        {
            var pontosEmRisco = await _repository.ObterPontosEmRiscoAsync();
            return Ok(pontosEmRisco);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PontoAlagamento ponto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _repository.AdicionarAsync(ponto);
            return CreatedAtAction(nameof(GetPorId), new { id = ponto.Id }, ponto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PontoAlagamento ponto)
        {
            if (id != ponto.Id) return BadRequest("ID divergente.");

            var existente = await _repository.ObterPorIdAsync(id);
            if (existente == null) return NotFound("Ponto não localizado para atualização.");

            await _repository.AtualizarAsync(ponto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existente = await _repository.ObterPorIdAsync(id);
            if (existente == null) return NotFound("Ponto não localizado.");

            await _repository.DeletarAsync(id);
            return NoContent();
        }
    }
}
