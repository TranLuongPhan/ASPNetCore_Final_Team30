#pragma checksum "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f4c07f8680f1761c40b31621a2d8fc979a2942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoas_Search), @"mvc.1.0.view", @"/Views/HangHoas/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoas/Search.cshtml", typeof(AspNetCore.Views_HangHoas_Search))]
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
#line 1 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30;

#line default
#line hidden
#line 2 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f4c07f8680f1761c40b31621a2d8fc979a2942", @"/Views/HangHoas/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoas_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NETCKTEAM30.Models.HangHoaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "chitiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("_hanghoa1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(99, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
 foreach (var hh in Model)
{
    string[] arrListStr = hh.Hinh.Split(';');
    hh.Hinh = arrListStr[0];

#line default
#line hidden
            BeginContext(211, 36, true);
            WriteLiteral("    <div class=\"col-sm-4\">\r\n        ");
            EndContext();
            BeginContext(247, 347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d5b885fe124cf8ac35b918dd712a22", async() => {
                BeginContext(351, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(365, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "698acdc69df345a8bc8fd6f4a21e032b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 375, "~/images/", 375, 9, true);
#line 14 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
AddHtmlAttributeValue("", 384, hh.Hinh, 384, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(396, 85, true);
                WriteLiteral("\r\n            <span class=\"thongtinsanpham\">\r\n                <h4 class=\"tensanpham\">");
                EndContext();
                BeginContext(482, 8, false);
#line 16 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
                                  Write(hh.TenHH);

#line default
#line hidden
                EndContext();
                BeginContext(490, 51, true);
                WriteLiteral("</h4>\r\n                <div class=\"danhmucsanpham\">");
                EndContext();
                BeginContext(542, 9, false);
#line 17 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
                                       Write(hh.GiaBan);

#line default
#line hidden
                EndContext();
                BeginContext(551, 39, true);
                WriteLiteral(" $</div>\r\n            </span>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
             WriteLiteral(hh.MaHH);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(594, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HangHoas\Search.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NETCKTEAM30.Models.HangHoaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
