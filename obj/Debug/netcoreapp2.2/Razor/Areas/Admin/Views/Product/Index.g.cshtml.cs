#pragma checksum "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7ce0f9ea68a65a5d21b2caf5283013ba91503f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineBazar;

#line default
#line hidden
#line 2 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineBazar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7ce0f9ea68a65a5d21b2caf5283013ba91503f", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04b056db7889f151fa13d560c1ef11b1543723c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonForProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 166, true);
            WriteLiteral("\r\n<br /><br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Products List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(238, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd7ce0f9ea68a65a5d21b2caf5283013ba91503f4703", async() => {
                BeginContext(282, 48, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp;Add New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(334, 160, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-bordered table-striped\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 39, false);
#line 20 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(534, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(590, 33, false);
#line 23 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 40, false);
#line 26 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(719, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(775, 38, false);
#line 29 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.IsAvailabe));

#line default
#line hidden
            EndContext();
            BeginContext(813, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(869, 55, false);
#line 32 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductType.ProductTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(924, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(980, 53, false);
#line 35 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.SpecialTag.SpecialTagName));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n");
            EndContext();
#line 40 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1164, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1195, 16, false);
#line 43 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1235, 10, false);
#line 44 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1269, 17, false);
#line 45 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1310, 15, false);
#line 46 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.IsAvailabe);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1349, 32, false);
#line 47 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.ProductType.ProductTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1405, 30, false);
#line 48 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
           Write(item.SpecialTag.SpecialTagName);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1458, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd7ce0f9ea68a65a5d21b2caf5283013ba91503f11299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 49 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

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
            BeginContext(1518, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "F:\DotNet\OnlineBazar\OnlineBazar\Areas\Admin\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1551, 26, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
