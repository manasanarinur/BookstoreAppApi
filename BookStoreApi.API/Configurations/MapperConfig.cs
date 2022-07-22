using AutoMapper;
using BookStoreApi.API.Data;
using BookStoreApi.API.Models.Author;
using BookStoreApi.API.Models.Book;
using BookStoreApi.API.Models.User;

namespace BookStoreApi.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<BookCreateDto, Author>().ReverseMap();
            CreateMap<BookUpdateDto, Author>().ReverseMap();
            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"));
            CreateMap<Book, BookDetailsDto>()
               .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName}{map.Author.LastName}")).ReverseMap();
            CreateMap<ApiUser, UserDto>().ReverseMap();

        }
           

    }
}
