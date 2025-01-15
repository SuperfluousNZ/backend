using DigraphyApi.Dto;
using DigraphyApi.Models;
using DigraphyApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigraphyApi.Controllers;

[Route("api/")]
[ApiController]
public class OrderController(IOrderService orderService) : Controller
{
    [Route("orders")]
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
    public async Task<ActionResult<List<OrderDto>>> GetOrders()
    {
        var ordersResult = await orderService.GetOrdersAsync();
        var ordersDto = ordersResult.Data;
        return Ok(ordersDto);
    }
}