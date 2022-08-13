using EZ.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EZ.Permissions;

public class EZPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EZPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EZPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EZResource>(name);
    }
}
