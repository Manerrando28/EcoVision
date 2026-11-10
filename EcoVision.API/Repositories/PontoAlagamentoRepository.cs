using EcoVision.API.Data;
using EcoVision.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoVision.API.Repositories
{
    public class PontoAlagamentoRepository : IPontoAlagamentoRepository
    {
        private readonly AppDbContext _context;

        public PontoAlagamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PontoAlagamento>> ObterTodosAsync()
        {
            return await _context.PontosAlagamento.ToListAsync();
        }

        public async Task<PontoAlagamento?> ObterPorIdAsync(int id)
        {
            return await _context.PontosAlagamento.FindAsync(id);
        }

        public async Task<IEnumerable<PontoAlagamento>> ObterPontosEmRiscoAsync()
        {
            return await _context.PontosAlagamento
                .Where(p => p.RiscoTransbordo || p.NivelAguaCm > 50)
                .ToListAsync();
        }

        public async Task AdicionarAsync(PontoAlagamento ponto)
        {
            await _context.PontosAlagamento.AddAsync(ponto);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(PontoAlagamento ponto)
        {
            _context.PontosAlagamento.Update(ponto);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarAsync(int id)
        {
            var ponto = await ObterPorIdAsync(id);
            if (ponto != null)
            {
                _context.PontosAlagamento.Remove(ponto);
                await _context.SaveChangesAsync();
            }
        }
    }
}