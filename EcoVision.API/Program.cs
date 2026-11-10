using EcoVision.API.Data;
using EcoVision.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar Banco de Dados em Memória (EF Core)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("EcoVisionDb"));

// 2. Registrar Repositórios (Injeção de Dependência)
builder.Services.AddScoped<IPontoAlagamentoRepository, PontoAlagamentoRepository>();

// 3. Adicionar Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4. Configurar Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();