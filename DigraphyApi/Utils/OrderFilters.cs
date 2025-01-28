namespace DigraphyApi.Utils;

public class OrderFilters(int? collectionId, bool? verified)
{
    public int? CollectionId = collectionId;
    public bool? Verified = verified;
}