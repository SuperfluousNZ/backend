using System.ComponentModel.DataAnnotations;

namespace DigraphyApi.Models;

public class Topic
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int? TmdbId { get; set; }

    /// <summary>
    /// Factoids that are related to this topic.
    /// </summary>
    public List<Factoid> AffiliatedFactoids { get; set; } = [];
}
