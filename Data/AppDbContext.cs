using Microsoft.EntityFrameworkCore;

namespace MyApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Temple> Temples { get; set; }
}

