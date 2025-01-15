using DigraphyApi.Dto;
using DigraphyApi.Models;
using DigraphyApi.Utils;

namespace DigraphyApi.Interfaces;

public interface ICollectionService
{
    Task<Result<ICollection<CollectionDto>>> GetCollectionsAsync();
}