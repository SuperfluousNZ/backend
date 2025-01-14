using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Collection
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsVerified { get; set; }

    /// <summary>
    /// Titles that are contained in this collection.
    /// </summary>
    public List<Title> Titles { get; set; } = [];

    /// <summary>
    /// Orders that belong to this collection.
    /// </summary>
    public List<Order> Orders { get; set; } = [];
}