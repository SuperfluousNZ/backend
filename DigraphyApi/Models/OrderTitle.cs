namespace DigraphyApi.Models;

public class OrderTitle
{
    public int TitleId { get; set; }
    public int OrderId { get; set; }
    public int Index { get; set; }

    public Title Title { get; set; } = null!;
    public Order Order { get; set; } = null!;
}
