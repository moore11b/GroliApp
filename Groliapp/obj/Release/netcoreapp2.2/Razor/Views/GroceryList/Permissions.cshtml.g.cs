#pragma checksum "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f753bb73282f5bebf6398a73c5fc8453c535b6ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroceryList_Permissions), @"mvc.1.0.view", @"/Views/GroceryList/Permissions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroceryList/Permissions.cshtml", typeof(AspNetCore.Views_GroceryList_Permissions))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\_ViewImports.cshtml"
using Groliapp.Models.Entities;

#line default
#line hidden
#line 13 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
using Groliapp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f753bb73282f5bebf6398a73c5fc8453c535b6ec", @"/Views/GroceryList/Permissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e53b7bade994785efa0d77a361adbacb78f02c", @"/Views/_ViewImports.cshtml")]
    public class Views_GroceryList_Permissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Groliapp.Models.ViewModels.UserListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_grantPermission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_revokePermission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/privUser.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(572, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(655, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
  
    ViewData["Title"] = "Permissions";

#line default
#line hidden
            BeginContext(704, 293, true);
            WriteLiteral(@"
<div id=""alertArea"" class=""alert alert-warning"" role=""alert""
     style=""display:none"">
    <span id=""messageArea""></span>
    <button id=""alertCloseBtn"" type=""button"" class=""close"" aria-label=""Close"">
        <span aria-hidden=""true""></span>
    </button>
</div>
<h2>Permissions for ");
            EndContext();
            BeginContext(998, 40, false);
#line 26 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
               Write(Html.DisplayFor(model => model.ListName));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 214, true);
            WriteLiteral("</h2>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Permitted Users:\r\n                <hr />\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n\r\n");
            EndContext();
#line 40 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
                 foreach (var user in Model.UserList)
                {
                    

#line default
#line hidden
#line 42 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
                     if (Model.PriviledgedUsers.Contains(user.Email) &&
       user.Id != Model.OwnerId)
                    {

#line default
#line hidden
            BeginContext(1456, 26, true);
            WriteLiteral("                        <p");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1482, "\"", 1498, 1);
#line 45 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
WriteAttributeValue("", 1490, user.Id, 1490, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1499, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1501, 13, false);
#line 45 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
                                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 46 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
                    }

#line default
#line hidden
#line 46 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1563, 58, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
#line 52 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
 if (Model.UserId == Model.OwnerId)
{

#line default
#line hidden
            BeginContext(1661, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1665, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f753bb73282f5bebf6398a73c5fc8453c535b6ec9441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1714, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1720, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f753bb73282f5bebf6398a73c5fc8453c535b6ec11118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 55 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1770, 434, true);
            WriteLiteral(@"
    <table class=""table"">
        <tbody>
            <tr>

                <td>
                    <input type=""button"" id=""grantPermission"" class=""btn btn-success"" value=""Grant Permission"" />
                </td>
                <td>
                    <input type=""button"" id=""revokePermission"" class=""btn btn-danger"" value=""Revoke Access"" />
                </td>
            </tr>
        </tbody>
    </table>
");
            EndContext();
#line 69 "C:\LAST SEMESTER\SE2\Project\GroliApp\Groliapp\Views\GroceryList\Permissions.cshtml"
}

#line default
#line hidden
            BeginContext(2207, 113, true);
            WriteLiteral("<table class=\"table\">\r\n    <tbody>\r\n        <tr>\r\n\r\n            <td>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(2320, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f753bb73282f5bebf6398a73c5fc8453c535b6ec13602", async() => {
                BeginContext(2402, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2418, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2521, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2527, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f753bb73282f5bebf6398a73c5fc8453c535b6ec15630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2567, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Groliapp.Models.ViewModels.UserListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
