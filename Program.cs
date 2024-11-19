using Microsoft.EntityFrameworkCore;
using Final_Api.Data;
using Final_Api.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddSingleton<TempleController>();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(c =>
c.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.MapControllers();

app.UseHttpsRedirection();

app.MapGet("/api/health", () => Results.Ok("Healthy!"));

// app.MapGet("/api/temples", async (AppDbContext dbContext) =>
// {
//   var temples = await dbContext.Temples.ToListAsync();
//   return Results.Ok(temples);
// });

app.Run();
