using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ApiShopee;

public class ApiShopeeWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ApiShopeeWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
