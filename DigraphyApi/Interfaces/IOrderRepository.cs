using DigraphyApi.Models;
using DigraphyApi.Utils;

namespace DigraphyApi.Interfaces;

public interface IOrderRepository
{
    Task<ICollection<Order>> GetOrdersAsync(OrderFilters filters);
}