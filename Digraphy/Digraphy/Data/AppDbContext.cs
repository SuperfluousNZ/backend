using Digraphy.Models;
using Microsoft.EntityFrameworkCore;

namespace Digraphy.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Todo> Todos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO
    }
}