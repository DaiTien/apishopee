using Volo.Abp.Modularity;

namespace ApiShopee;

[DependsOn(
    typeof(ApiShopeeApplicationModule),
    typeof(ApiShopeeDomainTestModule)
    )]
public class ApiShopeeApplicationTestModule : AbpModule
{

}
