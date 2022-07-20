using ApiShopee.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ApiShopee.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ApiShopeeMongoDbModule),
    typeof(ApiShopeeApplicationContractsModule)
    )]
public class ApiShopeeDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
