using Boletim.Application.Services.Implementations;
using Boletim.Application.Services.Interfaces;
using Boletim.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<BoletimDbContext>(options => options.UseInMemoryDatabase("db_Boletim"));

builder.Services.AddDbContext<BoletimDbContext>();

builder.Services.AddScoped<ICursoService, CursoService>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IResultadoService, ResultadoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
