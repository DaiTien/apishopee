using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace ApiShopee.MongoDB;

[DependsOn(
    typeof(ApiShopeeTestBaseModule),
    typeof(ApiShopeeMongoDbModule)
    )]
public class ApiShopeeMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = ApiShopeeMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
