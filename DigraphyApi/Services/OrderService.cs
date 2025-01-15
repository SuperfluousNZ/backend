using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Interfaces;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
{
    public async Task<Result<ICollection<OrderDto>>> GetOrdersAsync()
    {
        var orders = await orderRepository.GetOrdersAsync();

        return mapper.Map<List<OrderDto>>(orders);
    }
}