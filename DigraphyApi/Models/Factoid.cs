using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Factoid
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public List<Title> Titles { get; set; } = [];
}