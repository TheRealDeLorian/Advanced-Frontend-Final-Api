using Microsoft.EntityFrameworkCore;
using Final_Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = "Server=localhost;Database=db;User Id=user;Password=password;";
builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseNpgsql(connectionString));

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

app.UseHttpsRedirection();

app.MapGet("/health", () => Results.Ok("Healthy!"));

app.MapGet("/temples", async (AppDbContext dbContext) =>
{
  var temples = await dbContext.Temples.ToListAsync();
  return Results.Ok(temples);
});



app.Run();
