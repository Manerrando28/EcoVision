using EcoVision.API.Data;
using EcoVision.API.Models;
using EcoVision.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EcoVision.Tests
{
    public class PontoAlagamentoRepositoryTests
    {
        private AppDbContext ObterDbContextInMemory()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new AppDbContext(options);
        }

        [Fact]
        public async Task AdicionarAsync_DeveSalvarPontoNoBanco()
        {
            // Arrange
            var context = ObterDbContextInMemory();
            var repository = new PontoAlagamentoRepository(context);
            var novoPonto = new PontoAlagamento
            {
                Localizacao = "Rua Vergueiro, 1000",
                Bairro = "Paraíso",
                NivelAguaCm = 30,
                RiscoTransbordo = false
            };

            // Act
            await repository.AdicionarAsync(novoPonto);
            var resultado = await repository.ObterPorIdAsync(novoPonto.Id);

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal("Rua Vergueiro, 1000", resultado.Localizacao);
        }

        [Fact]
        public async Task ObterPontosEmRiscoAsync_DeveRetornarApenasPontosEmRisco()
        {
            // Arrange
            var context = ObterDbContextInMemory();
            var repository = new PontoAlagamentoRepository(context);

            await repository.AdicionarAsync(new PontoAlagamento { Localizacao = "Local Seguro", NivelAguaCm = 10, RiscoTransbordo = false });
            await repository.AdicionarAsync(new PontoAlagamento { Localizacao = "Local em Risco", NivelAguaCm = 70, RiscoTransbordo = true });

            // Act
            var pontosEmRisco = await repository.ObterPontosEmRiscoAsync();

            // Assert
            Assert.Single(pontosEmRisco);
            Assert.Contains(pontosEmRisco, p => p.Localizacao == "Local em Risco");
        }
    }
}