using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ApiShopee.App
{
    public interface IProductAppService : IApplicationService
    {
        string OnTestApi();
    }
}
