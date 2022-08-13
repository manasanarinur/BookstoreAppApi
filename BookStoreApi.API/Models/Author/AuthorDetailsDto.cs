using BookStoreApi.API.Models.Book;

namespace BookStoreApi.API.Models.Author
{
    public class AuthorDetailsDto:AuthorReadOnlyDto
    {
        public List<BookReadOnlyDto> Books { get; set; }
    }
}
