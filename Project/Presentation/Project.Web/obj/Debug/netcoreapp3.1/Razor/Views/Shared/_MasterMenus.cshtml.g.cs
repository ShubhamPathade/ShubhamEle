#pragma checksum "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Shared\_MasterMenus.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c5476604002d74211635d3119e8b1e93523bd1f65767aa50c0971112ce48a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MasterMenus), @"mvc.1.0.view", @"/Views/Shared/_MasterMenus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7c5476604002d74211635d3119e8b1e93523bd1f65767aa50c0971112ce48a39", @"/Views/Shared/_MasterMenus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2323473da21a8d9cd337ee06e17864f7005d7a18ba92c48ff408cf1c412722e7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MasterMenus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Role/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"quicklink-sidebar-menu ctm-border-radius shadow-sm bg-white card\">\r\n    <div class=\"card-body\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item text-center active button-5\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5476604002d74211635d3119e8b1e93523bd1f65767aa50c0971112ce48a395389", async() => {
                WriteLiteral("Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""list-group-item text-center button-6""><a class=""text-dark"" href=""employees-team.html"">Teams</a></li>
            <li class=""list-group-item text-center button-6""><a class=""text-dark"" href=""employees-offices.html"">Offices</a></li>
        </ul>
    </div>
</div>");
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
