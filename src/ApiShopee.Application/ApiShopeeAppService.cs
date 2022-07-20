using System;
using System.Collections.Generic;
using System.Text;
using ApiShopee.Localization;
using Volo.Abp.Application.Services;

namespace ApiShopee;

/* Inherit your application services from this class.
 */
public abstract class ApiShopeeAppService : ApplicationService
{
    protected ApiShopeeAppService()
    {
        LocalizationResource = typeof(ApiShopeeResource);
    }
}
