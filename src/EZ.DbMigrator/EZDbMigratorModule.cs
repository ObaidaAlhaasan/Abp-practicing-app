using EZ.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EZ.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EZEntityFrameworkCoreModule),
    typeof(EZApplicationContractsModule)
    )]
public class EZDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
