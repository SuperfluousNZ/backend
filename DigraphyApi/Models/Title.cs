using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Title
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string SmallPosterUrl { get; set; } = null!;
    public string LargePosterUrl { get; set; } = null!;
    public DateTime ReleasedAtUrc { get; set; }
    public string Description { get; set; } = null!;
    public int? TmdbId { get; set; }
    public List<Factoid> Factoids { get; set; } = [];
    public List<Collection> Collections { get; set; } = [];
}