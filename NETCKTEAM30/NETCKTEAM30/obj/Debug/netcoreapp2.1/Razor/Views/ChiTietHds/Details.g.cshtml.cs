#pragma checksum "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a4f95f764f9d110999e8e41899cffa83227369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChiTietHds_Details), @"mvc.1.0.view", @"/Views/ChiTietHds/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChiTietHds/Details.cshtml", typeof(AspNetCore.Views_ChiTietHds_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a4f95f764f9d110999e8e41899cffa83227369", @"/Views/ChiTietHds/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_ChiTietHds_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NETCKTEAM30.Models.ChiTietHd>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ChiTietHd</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 42, false);
#line 14 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoaDon));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 47, false);
#line 17 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoaDon.HoaDonID));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(383, 43, false);
#line 20 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HangHoa));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(470, 49, false);
#line 23 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayFor(model => model.HangHoa.HanghoaID));

#line default
#line hidden
            EndContext();
            BeginContext(519, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(563, 42, false);
#line 26 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 38, false);
#line 29 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(687, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(731, 43, false);
#line 32 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(774, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(818, 39, false);
#line 35 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(901, 43, false);
#line 38 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 39, false);
#line 41 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1074, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b29ec6cb0eae437f95ba2ebc1831c72d", async() => {
                BeginContext(1129, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\ChiTietHds\Details.cshtml"
                           WriteLiteral(Model.ChiTietHdID);

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
            BeginContext(1137, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1145, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e278b2ead61e4ea784aacd4941ea3494", async() => {
                BeginContext(1167, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1183, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NETCKTEAM30.Models.ChiTietHd> Html { get; private set; }
    }
}
#pragma warning restore 1591
