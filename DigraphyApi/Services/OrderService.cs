using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Interfaces;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
{
    public async Task<Result<ICollection<OrderDto>>> GetOrdersAsync(int? collectionId, bool isVerified)
    {
        var orders = collectionId == null
            ? await orderRepository.GetOrdersAsync(isVerified)
            : await orderRepository.GetOrdersByCollectionIdAsync(collectionId.Value, isVerified);
        return mapper.Map<List<OrderDto>>(orders);
    }
}