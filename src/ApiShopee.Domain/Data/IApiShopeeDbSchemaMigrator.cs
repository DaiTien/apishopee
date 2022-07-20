using System.Threading.Tasks;

namespace ApiShopee.Data;

public interface IApiShopeeDbSchemaMigrator
{
    Task MigrateAsync();
}
