using EcoVision.API.Models;

namespace EcoVision.API.Repositories
{
    public interface IPontoAlagamentoRepository
    {
        Task<IEnumerable<PontoAlagamento>> ObterTodosAsync();
        Task<PontoAlagamento?> ObterPorIdAsync(int id);
        Task<IEnumerable<PontoAlagamento>> ObterPontosEmRiscoAsync();
        Task AdicionarAsync(PontoAlagamento ponto);
        Task AtualizarAsync(PontoAlagamento ponto);
        Task DeletarAsync(int id);
    }
}