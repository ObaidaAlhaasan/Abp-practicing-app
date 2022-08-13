using System.Threading.Tasks;

namespace EZ.Data;

public interface IEZDbSchemaMigrator
{
    Task MigrateAsync();
}
