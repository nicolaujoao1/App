using System;
using System.Collections.Generic;
using System.Text;
using App.Localization;
using Volo.Abp.Application.Services;

namespace App;

/* Inherit your application services from this class.
 */
public abstract class AppAppService : ApplicationService
{
    protected AppAppService()
    {
        LocalizationResource = typeof(AppResource);
    }
}
