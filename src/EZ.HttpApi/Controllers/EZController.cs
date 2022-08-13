using EZ.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EZ.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EZController : AbpControllerBase
{
    protected EZController()
    {
        LocalizationResource = typeof(EZResource);
    }
}
