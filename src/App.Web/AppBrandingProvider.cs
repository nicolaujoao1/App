using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace App.Web;

[Dependency(ReplaceServices = true)]
public class AppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "App";
}
