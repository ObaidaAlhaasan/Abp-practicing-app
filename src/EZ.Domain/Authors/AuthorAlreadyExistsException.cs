using System;
using Volo.Abp;

namespace EZ.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name):base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}