using AutoMapper;
using BookStoreApi.API.Data;
using BookStoreApi.API.Models.Author;

namespace BookStoreApi.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
        }
           

    }
}
