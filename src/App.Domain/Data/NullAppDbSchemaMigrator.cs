using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace App.Data;

/* This is used if database provider does't define
 * IAppDbSchemaMigrator implementation.
 */
public class NullAppDbSchemaMigrator : IAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
