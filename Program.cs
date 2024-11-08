var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "https://auth.snowse.duckdns.org/realms/advanced-frontend",
                ValidAudience = "dorian-demo2",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key"))
            };
        });

var app = builder.Build();

app.UseCors(
  p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
);

app.MapGet("/authOnly", () => 
{
  Console.WriteLine("Hello World!");
  return "Hello world auth"
});

app.MapGet("/public", () =>
{
Console.WriteLine("public endpoing");
return "Hello world public";
} ).AllowAnonymous();


app.Run();


//make sql file

//post to pg container

//scaffold from sql file to generate 