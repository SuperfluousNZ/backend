using DigraphyApi.Dto;
using DigraphyApi.Utils;

namespace DigraphyApi.Interfaces;

public interface IOrderService
{
    Task<Result<ICollection<OrderDto>>> GetOrdersAsync();
}