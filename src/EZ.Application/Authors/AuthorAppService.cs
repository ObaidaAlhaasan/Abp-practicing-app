using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EZ.Books;
using EZ.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace EZ.Authors;

[Authorize(EZPermissions.Authors.Default)]
public class AuthorAppService: EZAppService, IAuthorAppService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly AuthorManager _authorManager;
    
    public AuthorAppService(
        IAuthorRepository authorRepository,
        AuthorManager authorManager)
    {
        _authorRepository = authorRepository;
        _authorManager = authorManager;
    }

    public async Task<AuthorDto> GetAsync(Guid id)
    {
        var author = await _authorRepository.GetAsync(id);
        return ObjectMapper.Map<Author, AuthorDto>(author);
    }

    public async Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Author.Name);
        }

        var authors = await _authorRepository.GetListAsync(
            input.SkipCount,
            input.MaxResultCount,
            input.Sorting,
            input.Filter
        );

        var totalCount = input.Filter == null
            ? await _authorRepository.CountAsync()
            : await _authorRepository.CountAsync(
                author => author.Name.Contains(input.Filter));

        return new PagedResultDto<AuthorDto>(
            totalCount,
            ObjectMapper.Map<List<Author>, List<AuthorDto>>(authors)
        );
    }

    [Authorize(EZPermissions.Authors.Create)]
    public async Task<AuthorDto> CreateAsync(CreateAuthorDto input)
    {
        var author = await _authorManager.CreateAsync(
            input.Name,
            input.BirthDate,
            input.ShortBio
        );

        author.TenantId = CurrentTenant.Id;

        await _authorRepository.InsertAsync(author);

        return ObjectMapper.Map<Author, AuthorDto>(author);
    }

    [Authorize(EZPermissions.Authors.Edit)]
    public async Task<AuthorDto> UpdateAsync(Guid id, UpdateAuthorDto input)
    {
        var author = await _authorRepository.GetAsync(id);

        if (author.Name != input.Name)
        {
            await _authorManager.ChangeNameAsync(author, input.Name);
        }

        author.ChangeBirthDate(input.BirthDate);
        author.ChangeShortBio(input.ShortBio);

        await _authorRepository.UpdateAsync(author);
        return ObjectMapper.Map<Author, AuthorDto>(author);
    }

    [Authorize(EZPermissions.Authors.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _authorRepository.DeleteAsync(id);
    }
}