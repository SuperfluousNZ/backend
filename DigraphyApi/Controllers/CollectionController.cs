using DigraphyApi.Dto;
using DigraphyApi.Models;
using DigraphyApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigraphyApi.Controllers;

[Route("api/")]
[ApiController]
public class CollectionController(ICollectionService collectionService) : Controller
{
    [Route("collections")]
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Collection>))]
    public async Task<ActionResult<List<CollectionDto>>> GetCollections()
    {
        var collectionsResult = await collectionService.GetCollectionsAsync();
        var collectionsDto = collectionsResult.Data;
        return Ok(collectionsDto);
    }
}