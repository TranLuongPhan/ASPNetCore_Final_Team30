#pragma checksum "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b545bb45fad2d357f1f9ea2b60899ffbe1b50f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDons_Index), @"mvc.1.0.view", @"/Views/HoaDons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDons/Index.cshtml", typeof(AspNetCore.Views_HoaDons_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b545bb45fad2d357f1f9ea2b60899ffbe1b50f", @"/Views/HoaDons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NETCKTEAM30.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(119, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9663610a67a14acab9e40bdcab773a98", async() => {
                BeginContext(142, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 45, false);
#line 16 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NguoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 43, false);
#line 19 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 44, false);
#line 22 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayNhan));

#line default
#line hidden
            EndContext();
            BeginContext(493, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(549, 41, false);
#line 25 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(590, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(646, 42, false);
#line 28 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(744, 45, false);
#line 31 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(789, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(845, 45, false);
#line 34 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(890, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(946, 48, false);
#line 37 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(994, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1050, 45, false);
#line 40 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1151, 42, false);
#line 43 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1311, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1360, 56, false);
#line 52 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NguoiDung.NguoiDungID));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1472, 42, false);
#line 55 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1570, 43, false);
#line 58 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayNhan));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1669, 40, false);
#line 61 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1765, 41, false);
#line 64 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1862, 56, false);
#line 67 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThanhToan.ThanhToanID));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1974, 56, false);
#line 70 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VanChuyen.VanChuyenID));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2086, 47, false);
#line 73 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2189, 56, false);
#line 76 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrangThai.TrangThaiID));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2301, 41, false);
#line 79 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2397, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "945995b8de934e6586308c5a5a391806", async() => {
                BeginContext(2448, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
                                       WriteLiteral(item.HoaDonID);

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
            BeginContext(2456, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2476, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bdf9941887b44548cc8762c772c51e1", async() => {
                BeginContext(2530, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
                                          WriteLiteral(item.HoaDonID);

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
            BeginContext(2541, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2561, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c71e6a653548f28dd34122f34a734e", async() => {
                BeginContext(2614, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
                                         WriteLiteral(item.HoaDonID);

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
            BeginContext(2624, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\HoaDons\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2663, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NETCKTEAM30.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
