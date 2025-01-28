namespace DigraphyApi.Dto;

public class CollectionDto : CreateCollectionDto
{
    public int Id { get; set; }
}

public class CreateCollectionDto
{
    public string Name { get; set; }
    public bool IsVerified { get; set; }
}