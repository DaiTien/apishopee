﻿using ApiShopee.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ApiShopee.Permissions;

public class ApiShopeePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ApiShopeePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ApiShopeePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ApiShopeeResource>(name);
    }
}
