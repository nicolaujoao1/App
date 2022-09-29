using Volo.Abp.Modularity;

namespace App;

[DependsOn(
    typeof(AppApplicationModule),
    typeof(AppDomainTestModule)
    )]
public class AppApplicationTestModule : AbpModule
{

}
