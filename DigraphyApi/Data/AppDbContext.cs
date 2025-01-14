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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO
    }
}