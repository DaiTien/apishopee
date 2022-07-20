using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ApiShopee.Web;

[Dependency(ReplaceServices = true)]
public class ApiShopeeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ApiShopee";
}
