using ApiShopee.MongoDB;
using Volo.Abp.Modularity;

namespace ApiShopee;

[DependsOn(
    typeof(ApiShopeeMongoDbTestModule)
    )]
public class ApiShopeeDomainTestModule : AbpModule
{

}
