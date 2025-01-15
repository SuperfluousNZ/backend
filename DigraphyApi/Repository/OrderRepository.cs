using DigraphyApi.Data;
using DigraphyApi.Interfaces;
using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Repository;

public class OrderRepository(AppDbContext context) : IOrderRepository
{
    public async Task<ICollection<Order>> GetOrdersAsync()
    {
        return await context.Orders.OrderBy(o => o.Id).ToListAsync();
    }
}