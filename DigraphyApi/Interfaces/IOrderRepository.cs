using DigraphyApi.Models;

namespace DigraphyApi.Interfaces;

public interface IOrderRepository
{
    Task<ICollection<Order>> GetOrdersAsync(bool verified);
    Task<ICollection<Order>> GetOrdersByCollectionIdAsync(int collectionId, bool verified);
}