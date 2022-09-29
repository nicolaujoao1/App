using App.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace App.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AppPageModel : AbpPageModel
{
    protected AppPageModel()
    {
        LocalizationResourceType = typeof(AppResource);
    }
}
