using App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace App;

[DependsOn(
    typeof(AppEntityFrameworkCoreTestModule)
    )]
public class AppDomainTestModule : AbpModule
{

}
