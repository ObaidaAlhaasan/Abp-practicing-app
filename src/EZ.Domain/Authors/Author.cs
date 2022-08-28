using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EZ.Authors;

public class Author : FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public Guid? TenantId { get; set; }
    public string Name { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string ShortBio { get; private set; }

    private Author()
    {
    }

    public Author(Guid id, [NotNull] string name, DateTime birthDate, [CanBeNull] string shortBio) : base(id)
    {
        SetName(name);
        BirthDate = birthDate;
        ShortBio = shortBio;
    }

    internal Author ChangeName([NotNull] string name)
    {
        SetName(name);
        return this;
    }

    public Author ChangeBirthDate(DateTime birthDate)
    {
        BirthDate = birthDate;
        return this;
    }

    public Author ChangeShortBio([CanBeNull] string bio)
    {
        ShortBio = bio;
        return this;
    }

    private void SetName([NotNull] string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: AuthorConsts.MaxNameLength);
    }
}