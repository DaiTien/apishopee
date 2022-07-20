using ApiShopee.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ApiShopee.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ApiShopeePageModel : AbpPageModel
{
    protected ApiShopeePageModel()
    {
        LocalizationResourceType = typeof(ApiShopeeResource);
    }
}
