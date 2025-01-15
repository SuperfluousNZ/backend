using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Interfaces;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
{
    public async Task<Result<ICollection<OrderDto>>> GetOrdersAsync(int? collectionId, bool isVerified)
    {
        if (collectionId == null)
        {
            var orders = await orderRepository.GetOrdersAsync(isVerified);
            return mapper.Map<List<OrderDto>>(orders);
        }
        else
        {
            var orders = await orderRepository.GetOrdersByCollectionIdAsync(collectionId.Value, isVerified);
            return mapper.Map<List<OrderDto>>(orders);
        }
    }
}