using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ApiShopee.Data;

/* This is used if database provider does't define
 * IApiShopeeDbSchemaMigrator implementation.
 */
public class NullApiShopeeDbSchemaMigrator : IApiShopeeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
