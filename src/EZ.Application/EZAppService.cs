using System;
using System.Collections.Generic;
using System.Text;
using EZ.Localization;
using Volo.Abp.Application.Services;

namespace EZ;

/* Inherit your application services from this class.
 */
public abstract class EZAppService : ApplicationService
{
    protected EZAppService()
    {
        LocalizationResource = typeof(EZResource);
    }
}
