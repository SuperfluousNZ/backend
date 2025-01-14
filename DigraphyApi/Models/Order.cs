using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsVerified { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime EditedAtUtc { get; set; }

    /// <summary>
    /// The collection this order belongs to.
    /// </summary>
    public Collection Collection { get; set; } = null!;
}