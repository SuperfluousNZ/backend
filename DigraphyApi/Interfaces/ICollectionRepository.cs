using DigraphyApi.Models;

namespace DigraphyApi.Interfaces;

public interface ICollectionRepository
{
    Task<ICollection<Collection>> GetCollectionsAsync();
}