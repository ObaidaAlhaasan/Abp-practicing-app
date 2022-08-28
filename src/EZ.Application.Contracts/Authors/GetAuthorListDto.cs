using Volo.Abp.Application.Dtos;

namespace EZ.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}