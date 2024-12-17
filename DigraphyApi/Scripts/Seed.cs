using DigraphyApi.Data;
using DigraphyApi.Models;

namespace Digraphy.Scripts;

public class Seed(AppDbContext context)
{
    public void SeedDataContext()
    {
        // TODO
        context.SaveChanges();
    }
}