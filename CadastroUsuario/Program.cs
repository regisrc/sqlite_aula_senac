using CadastroUsuario.Application.Interfaces;
using CadastroUsuario.Application.Services;
using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;
using CadastroUsuario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddDbContext<CadastroUsuarioContext>(options =>
{
    options.UseSqlite("Data Source=C:\\Users\\filipe.regis\\Documents\\CadastroUsuario.db");
});

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
