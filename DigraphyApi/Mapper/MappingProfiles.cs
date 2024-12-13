using AutoMapper;
using Digraphy.Dto;
using Digraphy.Models;

namespace Digraphy.Mapper;

// can't rememeber if we need this or not
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Todo mapping
        CreateMap<Todo, TodoDto>();
        CreateMap<TodoDto, Todo>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}