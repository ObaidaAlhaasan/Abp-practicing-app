using Volo.Abp.Modularity;

namespace EZ;

[DependsOn(
    typeof(EZApplicationModule),
    typeof(EZDomainTestModule)
    )]
public class EZApplicationTestModule : AbpModule
{

}
