using Digraphy.Data;
using Digraphy.Models;

namespace Digraphy.Scripts;

public class Seed(AppDbContext context)
{
    public void SeedDataContext()
    {
        // TODO
        context.SaveChanges();
    }
}