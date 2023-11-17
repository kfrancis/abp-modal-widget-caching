using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.JQuery;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Web.Pages.Components.MySimpleWidget
{
    [ViewComponent(Name = "MySimpleWidget")]
    [Widget(
        StyleTypes = new[] { typeof(MySimpleWidgetStyleBundleContributor) },
        ScriptTypes = new[] { typeof(MySimpleWidgetScriptBundleContributor) },
        AutoInitialize = true,
        RequiresAuthentication = true
    )]
    public class MySimpleWidgetViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

    public class MySimpleWidgetStyleBundleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files
              .AddIfNotContains("/Pages/Components/MySimpleWidget/MySimpleWidget.css");
        }
    }

    [DependsOn(typeof(JQueryScriptContributor))]
    public class MySimpleWidgetScriptBundleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files
              .AddIfNotContains("/Pages/Components/MySimpleWidget/MySimpleWidget.js");
        }
    }
}
