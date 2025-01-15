using DigraphyApi.Models;

namespace DigraphyApi.Interfaces;

public interface IOrderRepository
{
    Task<ICollection<Order>> GetOrdersAsync();
}