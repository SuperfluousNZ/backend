using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Interfaces;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class CollectionService(ICollectionRepository collectionRepository, IMapper mapper) : ICollectionService
{
    public async Task<Result<ICollection<CollectionDto>>> GetCollectionsAsync()
    {
        var collections = await collectionRepository.GetCollectionsAsync();

        return mapper.Map<List<CollectionDto>>(collections);
    }
}