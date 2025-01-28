namespace DigraphyApi.Dto;

public class OrderDto : CreateOrderDto
{
    public int Id { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime EditedAtUtc { get; set; }
}

public class CreateOrderDto
{
    public string Name { get; set; }
    public bool IsVerified { get; set; }
}