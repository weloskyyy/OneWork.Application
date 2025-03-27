using Microsoft.EntityFrameworkCore;
using OneWork.Application.Service;
using OneWork.Domain.Data;
using OneWork.infraestructura.Repositorio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OneWorkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<TareaRepositorio>();
builder.Services.AddScoped<TareaService>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
