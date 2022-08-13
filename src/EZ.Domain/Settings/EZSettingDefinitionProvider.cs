using Volo.Abp.Settings;

namespace EZ.Settings;

public class EZSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EZSettings.MySetting1));
    }
}
