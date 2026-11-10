using EcoVision.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoVision.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PontoAlagamento> PontosAlagamento { get; set; }
        public DbSet<AlertaEmergencia> AlertasEmergencia { get; set; }
    }
}