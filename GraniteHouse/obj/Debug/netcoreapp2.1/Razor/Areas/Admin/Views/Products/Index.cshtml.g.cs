#pragma checksum "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724d7e8e272ca571046f3ce227d6a3412496157f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
#line 1 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724d7e8e272ca571046f3ce227d6a3412496157f", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraniteHouse.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 161, true);
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(252, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafb86cb64de4592bdc896681b547f15", async() => {
                BeginContext(296, 45, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Product");
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
            BeginContext(345, 154, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(500, 32, false);
#line 22 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(532, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(588, 33, false);
#line 25 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(677, 37, false);
#line 28 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Available));

#line default
#line hidden
            EndContext();
            BeginContext(714, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(770, 40, false);
#line 31 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.ProductTypes));

#line default
#line hidden
            EndContext();
            BeginContext(810, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(866, 39, false);
#line 34 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.SpecialTags));

#line default
#line hidden
            EndContext();
            BeginContext(905, 84, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1038, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1075, 31, false);
#line 44 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1150, 32, false);
#line 47 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
       Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1226, 36, false);
#line 50 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
       Write(Html.DisplayFor(m => item.Available));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1306, 44, false);
#line 53 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
       Write(Html.DisplayFor(m => item.ProductTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1394, 43, false);
#line 56 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
       Write(Html.DisplayFor(m => item.SpecialTags.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1480, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b335570a3f44862b8ad65ba693708f6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 59 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(1534, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 62 "C:\Users\solom\source\repos\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1573, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraniteHouse.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
