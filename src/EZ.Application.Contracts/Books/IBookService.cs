using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EZ.Books;

public interface IBookAppService: ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>
{
    Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
}