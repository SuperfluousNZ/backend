using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Filters;
using DigraphyApi.Interfaces;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
{
    public async Task<Result<ICollection<OrderDto>>> GetOrdersAsync(int? collectionId, bool? isVerified)
    {
        var orders = await orderRepository.GetOrdersAsync(new OrderFilters(collectionId, isVerified));
        return mapper.Map<List<OrderDto>>(orders);
    }
}