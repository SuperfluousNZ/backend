using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Todo
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
