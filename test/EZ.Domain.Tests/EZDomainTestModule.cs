using EZ.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EZ;

[DependsOn(
    typeof(EZEntityFrameworkCoreTestModule)
    )]
public class EZDomainTestModule : AbpModule
{

}
