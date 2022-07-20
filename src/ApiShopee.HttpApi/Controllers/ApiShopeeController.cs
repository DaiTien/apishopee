using ApiShopee.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ApiShopee.Controllers
{
    /* Inherit your controllers from this class.
 */
    public abstract class ApiShopeeController : AbpControllerBase
    {
        protected ApiShopeeController()
        {
            LocalizationResource = typeof(ApiShopeeResource);
        }
    }
}

