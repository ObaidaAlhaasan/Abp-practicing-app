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

        var booksPermission = myGroup.AddPermission(EZPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(EZPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(EZPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(EZPermissions.Books.Delete, L("Permission:Books.Delete"));


        var authorsPermission = myGroup.AddPermission(EZPermissions.Authors.Default, L("Permission:Authors"));

        authorsPermission.AddChild(EZPermissions.Authors.Create, L("Permission:Authors.Create"));

        authorsPermission.AddChild(EZPermissions.Authors.Edit, L("Permission:Authors.Edit"));

        authorsPermission.AddChild(EZPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EZResource>(name);
    }
}