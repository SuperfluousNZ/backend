using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Exceptions;
using DigraphyApi.Interfaces;
using DigraphyApi.Models;
using DigraphyApi.Utils;

namespace DigraphyApi.Services;

public class CollectionService(ICollectionRepository collectionRepository, IMapper mapper) : ICollectionService
{
    public async Task<Result<ICollection<CollectionDto>>> GetCollectionsAsync()
    {
        var collection = await collectionRepository.GetCollectionsAsync();

        return mapper.Map<List<CollectionDto>>(collection);
    }
}