#pragma checksum "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Role\Edit.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43bface86bb5781ebd043f98177cbc6e14ca11814150213ee3a9dc0d137e3369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Edit), @"mvc.1.0.view", @"/Views/Role/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"43bface86bb5781ebd043f98177cbc6e14ca11814150213ee3a9dc0d137e3369", @"/Views/Role/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2323473da21a8d9cd337ee06e17864f7005d7a18ba92c48ff408cf1c412722e7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-xl-9 col-lg-8  col-md-12"">
    <div class=""accordion add-employee"" id=""accordion-details"">
        <div class=""card shadow-sm ctm-border-radius"">
            <div class=""card-header"" id=""basic1"">
                <h4 class=""cursor-pointer mb-0"">
                    <a class="" coll-arrow d-block text-dark"" href=""javascript:void(0)"" data-toggle=""collapse"" data-target=""#basic-one"" aria-expanded=""true"">
                        Basic Details
                        <br><span class=""ctm-text-sm""></span>
                    </a>
                </h4>
            </div>
            <div class=""card-body p-0"">
                <div id=""basic-one"" class=""collapse show ctm-padding"" aria-labelledby=""basic1"" data-parent=""#accordion-details"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43bface86bb5781ebd043f98177cbc6e14ca11814150213ee3a9dc0d137e33695959", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 17 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Role\Edit.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 19 "D:\Shubham Ele\Project\ShubhamElectrical\Project\Presentation\Project.Web\Views\Role\Edit.cshtml"
                   Write(await Html.PartialAsync("_CreateOrUpdate", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <button class=\"btn btn-theme text-white ctm-border-radius button-1\" type=\"submit\">Update</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
