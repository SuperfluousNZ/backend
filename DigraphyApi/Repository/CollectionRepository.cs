using DigraphyApi.Data;
using DigraphyApi.Models;
using DigraphyApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Repository;

public class CollectionRepository(AppDbContext context) : ICollectionRepository
{
    public async Task<ICollection<Collection>> GetCollectionsAsync()
    {
        return await context.Collections.OrderBy(c => c.Id).ToListAsync();
    }
}