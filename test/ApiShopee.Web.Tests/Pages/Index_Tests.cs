using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ApiShopee.Pages;

[Collection(ApiShopeeTestConsts.CollectionDefinitionName)]
public class Index_Tests : ApiShopeeWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
