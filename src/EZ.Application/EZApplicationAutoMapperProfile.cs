using AutoMapper;
using EZ.Authors;
using EZ.Books;

namespace EZ;

public class EZApplicationAutoMapperProfile : Profile
{
    public EZApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
