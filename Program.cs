using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Sessions_app.Model;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Empresa de Brinquedos API",
        Version = "v1",
        Description = "API para gerenciamento de brinquedos"
    });
});

var app = builder.Build();

// Middleware do Swagger SEM restri��o de ambiente
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brinquedos API v1");
    c.RoutePrefix = "swagger"; // Define a rota como /swagger
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

try
{
    Console.WriteLine("Iniciando aplica��o...");
    app.Run();
    Console.WriteLine("Aplica��o encerrada normalmente");
}
catch (Exception ex)
{
    Console.WriteLine($"Falha catastr�fica: {ex.Message}");
}