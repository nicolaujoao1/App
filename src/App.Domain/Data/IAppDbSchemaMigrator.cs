using System.Threading.Tasks;

namespace App.Data;

public interface IAppDbSchemaMigrator
{
    Task MigrateAsync();
}
