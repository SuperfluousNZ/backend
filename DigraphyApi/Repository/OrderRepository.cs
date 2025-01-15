using DigraphyApi.Data;
using DigraphyApi.Interfaces;
using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Repository;

public class OrderRepository(AppDbContext context) : IOrderRepository
{
    public async Task<ICollection<Order>> GetOrdersAsync(bool verified)
    {
        return await context.Orders.Where(o => !o.IsVerified && verified == false).OrderBy(o => o.Id).ToListAsync();
    }

    public async Task<ICollection<Order>> GetOrdersByCollectionIdAsync( int collectionId, bool verified)
    {
        return await context.Orders.Where(o => !o.IsVerified && verified == false && o.Collection.Id  == collectionId).OrderBy(o => o.Id).ToListAsync();
    }
}