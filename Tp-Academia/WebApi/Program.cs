using Data;
using Entidades;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<AcademiaContext>();
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

#region Comisiones

app.MapGet("/comisiones", () => 
{
    return ComisionService.GetComisiones();
});

app.MapGet("/comisiones/{id}", (int id) =>
{
    return ComisionService.GetComisionById(id);
});


app.MapPost("/comisiones",  (Comision com) =>
{
    ComisionService.InsertComision(com);
});

app.MapPut("/comisiones/{id}", (Comision com) =>
{
    ComisionService.ModificarComision(com);
 
});

app.MapDelete("/comisiones/{id}",(int id) =>
{
    ComisionService.EliminarComision(ComisionService.GetComisionById(id));
});
#endregion


app.Run();
