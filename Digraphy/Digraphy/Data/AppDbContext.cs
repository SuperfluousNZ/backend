using Microsoft.EntityFrameworkCore;

namespace Digraphy.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    // TODO
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO
    }
}