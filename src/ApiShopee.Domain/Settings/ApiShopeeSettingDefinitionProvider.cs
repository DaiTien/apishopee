using Volo.Abp.Settings;

namespace ApiShopee.Settings;

public class ApiShopeeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ApiShopeeSettings.MySetting1));
    }
}
