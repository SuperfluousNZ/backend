using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Collection
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsVerified { get; set; }
    public List<Title> Titles { get; set; } = [];
}