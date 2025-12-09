using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Collection> Collections { get; set; }
    public DbSet<Factoid> Factoids { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Todo> Todos { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<OrderTitle> OrderTitles { get; set; }
    public DbSet<FactoidsImportance> FactoidsImportances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Title>()
            .HasMany(t => t.ContainedFactoids)
            .WithMany(f => f.AffilitatedTitles);
        
        modelBuilder.Entity<Title>()
            .HasMany(t => t.RequiredFactoids)
            .WithMany(f => f.DependentTitles)
            .UsingEntity<FactoidsImportance>();

        modelBuilder.Entity<Title>()
            .HasMany(t => t.Collections)
            .WithMany(c => c.Titles);

        modelBuilder.Entity<Title>()
            .HasMany(t => t.Orders)
            .WithMany(o => o.Titles)
            .UsingEntity<OrderTitle>();

        modelBuilder.Entity<Factoid>()
            .HasMany(f => f.Topics)
            .WithMany(t => t.Factoids);
    }
}
