namespace DigraphyApi.Filters;

public class OrderFilters(int? collectionId, bool? verified)
{
    public int? CollectionId { get; } = collectionId;
    public bool? Verified { get; } = verified;
}