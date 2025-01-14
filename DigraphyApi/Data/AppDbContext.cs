using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Factoid> Factoids { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Title>()
            .HasMany(t => t.Factoids)
            .WithMany(f => f.Titles);

        modelBuilder.Entity<Title>()
            .HasMany(t => t.Collections)
            .WithMany(c => c.Titles);
    }
}