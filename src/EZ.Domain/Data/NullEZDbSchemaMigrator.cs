using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EZ.Data;

/* This is used if database provider does't define
 * IEZDbSchemaMigrator implementation.
 */
public class NullEZDbSchemaMigrator : IEZDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
