#pragma checksum "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c82d80703ee3f2a25347a595c70bacc3bf2dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NguoiDungs_Delete), @"mvc.1.0.view", @"/Views/NguoiDungs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NguoiDungs/Delete.cshtml", typeof(AspNetCore.Views_NguoiDungs_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c82d80703ee3f2a25347a595c70bacc3bf2dcd", @"/Views/NguoiDungs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_NguoiDungs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NETCKTEAM30.Models.NguoiDung>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-bar-item w3-padding w3-pale-blue w3-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#line 6 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
  
    Layout = "_Admin";

#line default
#line hidden
            BeginContext(112, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d481d1dbf8434b679302371d98d0a7b5", async() => {
                BeginContext(118, 382, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <style>
        .mainmenu {
            margin-left: 30%;
        }

        table, tr, td {
            border: 1px solid black;
            border-collapse: collapse;
            background-color: white;
        }

        tr, td {
            padding: 10px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(507, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(509, 1918, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf6746ee34c40d68a8928e8bf995acf", async() => {
                BeginContext(515, 308, true);
                WriteLiteral(@"
    <h3 class=""w3-bar-item w3-padding w3-white"" style=""width:100%; text-align: center"">USERS</h3>
    <br />
    <br />
    <div class=""mainmenu"">
        <h4>Bán Muốn Xóa Người Dùng Này ?</h4>
        <hr />
        <table>
            <tr>
                <td>Họ Tên: </td>
                <td> ");
                EndContext();
                BeginContext(824, 37, false);
#line 37 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
                EndContext();
                BeginContext(861, 103, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Giới tính: </td>\r\n                <td> ");
                EndContext();
                BeginContext(965, 46, false);
#line 41 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.GioiTinh.TenGT));

#line default
#line hidden
                EndContext();
                BeginContext(1011, 103, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Ngày Sinh: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1115, 40, false);
#line 45 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
                EndContext();
                BeginContext(1155, 101, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Địa Chỉ: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1257, 38, false);
#line 49 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
                EndContext();
                BeginContext(1295, 97, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>SĐT: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1393, 35, false);
#line 53 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.SDT));

#line default
#line hidden
                EndContext();
                BeginContext(1428, 99, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Email: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1528, 37, false);
#line 57 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1565, 105, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Ảnh đại diện: </td>\r\n                <td>");
                EndContext();
                BeginContext(1671, 36, false);
#line 61 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
                EndContext();
                BeginContext(1707, 109, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Loại Người Dùng: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1817, 50, false);
#line 65 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.LoaiNgDung.TenLoai));

#line default
#line hidden
                EndContext();
                BeginContext(1867, 107, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Tên Đăng Nhập: </td>\r\n                <td> ");
                EndContext();
                BeginContext(1975, 43, false);
#line 69 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
                Write(Html.DisplayFor(model => model.TenDangNhap));

#line default
#line hidden
                EndContext();
                BeginContext(2018, 84, true);
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <br />\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(2102, 304, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b962d0d1a53a4f46b7c21c5ee6763ed0", async() => {
                    BeginContext(2128, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(2142, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea1e04e6ac474135b7b2cd42ee3315b6", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 75 "C:\Users\Mcuong.FIT\Desktop\team30\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\NguoiDungs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NguoiDungID);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2187, 116, true);
                    WriteLiteral("\r\n            <input type=\"submit\" value=\"Xóa\" class=\"w3-bar-item w3-padding w3-pale-red w3-button\" />\r\n            ");
                    EndContext();
                    BeginContext(2303, 86, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca2ecc683bbc4b3395c0595c72997105", async() => {
                        BeginContext(2379, 6, true);
                        WriteLiteral("Trở Về");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2389, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2406, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NETCKTEAM30.Models.NguoiDung> Html { get; private set; }
    }
}
#pragma warning restore 1591
