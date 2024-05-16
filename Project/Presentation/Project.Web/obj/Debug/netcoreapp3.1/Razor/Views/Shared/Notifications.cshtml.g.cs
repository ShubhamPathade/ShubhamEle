#pragma checksum "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e092cc7412ef98fe2b0ae755d40297b56a87162c69715091b59e21b1262bea76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Notifications), @"mvc.1.0.view", @"/Views/Shared/Notifications.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Web.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Web.Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Core.Domain.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Core.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Web.Models.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\_ViewImports.cshtml"
using Project.Web.Models.Electricians;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e092cc7412ef98fe2b0ae755d40297b56a87162c69715091b59e21b1262bea76", @"/Views/Shared/Notifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2323473da21a8d9cd337ee06e17864f7005d7a18ba92c48ff408cf1c412722e7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Notifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
  
    //success messages
    var successMessages = new List<string>();
    if (TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Success)] != null)
    {
        successMessages.AddRange(TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Success)] as IList<string>);
    }
    if (ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Success)] != null)
    {
        successMessages.AddRange(ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Success)] as IList<string>);
    }


    //error messages
    var errorMessages = new List<string>();
    if (TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Error)] != null)
    {
        errorMessages.AddRange(TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Error)] as IList<string>);
    }
    if (ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Error)] != null)
    {
        errorMessages.AddRange(ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Error)] as IList<string>);
    }


    //warning messages
    var warningMessages = new List<string>();
    if (TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Warning)] != null)
    {
        warningMessages.AddRange(TempData[string.Format("truckBhejo.notifications.{0}", NotifyType.Warning)] as IList<string>);
    }
    if (ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Warning)] != null)
    {
        warningMessages.AddRange(ViewData[string.Format("truckBhejo.notifications.{0}", NotifyType.Warning)] as IList<string>);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
 foreach (var message in successMessages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\'");
#nullable restore
#line 41 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
          Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    </script>\r\n");
#nullable restore
#line 43 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
 foreach (var message in errorMessages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\'");
#nullable restore
#line 48 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
          Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    </script>\r\n");
#nullable restore
#line 50 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
 foreach (var message in warningMessages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\'");
#nullable restore
#line 55 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
          Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    </script>\r\n");
#nullable restore
#line 57 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\Notifications.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
