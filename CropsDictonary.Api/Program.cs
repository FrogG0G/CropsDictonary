using CropsDictonary.Api.Handlers;
using CropsDictonary.Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using CropsDictonary.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=crops.db"));
builder.Services.AddScoped<ICropService, CropService>();
builder.Services.AddScoped<CropsHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapGet("/api/crops", (CropsHandler handler) => { return Results.Ok(handler.GetAll()); });
app.MapPost("/api/crops", (CropsHandler handler, CropDto dto) =>
{
    handler.Add(dto);
    return Results.Ok();
});
app.MapPut("/api/crops/{id:int}", (CropsHandler handler, int id, CropDto dto) =>
{
    return handler.Edit(id, dto)
        ? Results.Ok()
        : Results.NotFound();
});
app.MapDelete("/api/crops/{id:int}", (CropsHandler handler, int id) =>
{
    return handler.Delete(id)
        ? Results.Ok()
        : Results.NotFound();
});
app.Run();
