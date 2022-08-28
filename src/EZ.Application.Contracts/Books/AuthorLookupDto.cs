using System;
using Volo.Abp.Application.Dtos;

namespace EZ.Books;

public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}