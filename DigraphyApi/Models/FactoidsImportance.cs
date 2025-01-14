namespace DigraphyApi.Models;

public class FactoidsImportance
{
    public int FactoidId { get; set; }
    public int TitleId { get; set; }
    public FactoidImportance Importance { get; set; }
}

public enum FactoidImportance
{
    MUST, SHOULD, COULD
}