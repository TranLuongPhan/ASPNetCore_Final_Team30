#pragma checksum "C:\Users\Mcuong.FIT\Desktop\NetCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ce330d0d471c0ae3d82884bb587edddefb2992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Mcuong.FIT\Desktop\NetCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30;

#line default
#line hidden
#line 2 "C:\Users\Mcuong.FIT\Desktop\NetCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\_ViewImports.cshtml"
using NETCKTEAM30.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ce330d0d471c0ae3d82884bb587edddefb2992", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0613840a446b3e0d199dc06641aec1324a2f2111", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Mcuong.FIT\Desktop\NetCK\ASPNetCore_Final_Team30\NETCKTEAM30\NETCKTEAM30\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 13855, true);
            WriteLiteral(@"<div class=""w3l_banner_nav_right"">
    <section class=""slider"">
        <div class=""flexslider"">
            <ul class=""slides"">
                <li>
                    <div class=""w3l_banner_nav_right_banner"" style=""background-image:url(../images/carousel2.jpg);min-height:460px;"">
                        <h3 style=""color:red;"">Make your <span>food</span> with Spicy.</h3>
                        <div class=""more"">
                            <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""w3l_banner_nav_right_banner1"" style=""background-image:url(../images/carousel3.jpg);min-height:460px;"">
                        <h3>Make your <span>food</span> with Spicy.</h3>
                        <div class=""more"">
                            <a href=""products.html"" class=""button--saqui button--round-l butto");
            WriteLiteral(@"n--text-thick"" data-text=""Shop now"">Shop now</a>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""w3l_banner_nav_right_banner2"" style=""background-image:url(../images/1.jpg);min-height:460px;"">
                        <h3>upto <i>50%</i> off.</h3>
                        <div class=""more"">
                            <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </section>
    <!-- flexSlider -->
    <link rel=""stylesheet"" href=""css/flexslider.css"" type=""text/css"" media=""screen"" property="""" />
    <script defer src=""js/jquery.flexslider.js""></script>
    <script type=""text/javascript"">
                $(window).load(function () {
                    $('.flexslider').flexslider({
                        animation: ""slide"",
 ");
            WriteLiteral(@"                       start: function (slider) {
                            $('body').removeClass('loading');
                        }
                    });
                });
    </script>
    <!-- //flexSlider -->
</div>
<div class=""clearfix""></div>
    </div>
<!-- banner -->
<div class=""banner_bottom"" style=""padding:1em 0 !important;"">
    <div class=""wthree_banner_bottom_left_grid_sub"">
    </div>
    <div class=""wthree_banner_bottom_left_grid_sub1"" style=""width: 77%;"">
        <div class=""col-md-4 wthree_banner_bottom_left"">
            <div class=""wthree_banner_bottom_left_grid"">
                <img src=""images/4.jpg"" alt="" "" class=""img-responsive"" />
                <div class=""wthree_banner_bottom_left_grid_pos"">
                    <h4>Discount Offer <span>25%</span></h4>
                </div>
            </div>
        </div>
        <div class=""col-md-4 wthree_banner_bottom_left"">
            <div class=""wthree_banner_bottom_left_grid"">
                <img src=""ima");
            WriteLiteral(@"ges/5.jpg"" alt="" "" class=""img-responsive"" />
                <div class=""wthree_banner_btm_pos"">
                    <h3>introducing <span>best store</span> for <i>groceries</i></h3>
                </div>
            </div>
        </div>
        <div class=""col-md-4 wthree_banner_bottom_left"">
            <div class=""wthree_banner_bottom_left_grid"">
                <img src=""images/6.jpg"" alt="" "" class=""img-responsive"" />
                <div class=""wthree_banner_btm_pos1"">
                    <h3>Save <span>Upto</span> $10</h3>
                </div>
            </div>
        </div>
        <div class=""clearfix""> </div>
    </div>
    <div class=""clearfix""> </div>
</div>
<!-- top-brands -->
<div class=""top-brands"">
    <div class=""container"">
        <h3>Ưu đãi hàng đầu</h3>
        <div class=""agile_top_brands_grids"">
            <div class=""col-md-3 top_brand_left"">
                <div class=""hover14 column"">
                    <div class=""agile_top_brand_left_grid"">
        ");
            WriteLiteral(@"                <div class=""tag""><img src=""images/tag.png"" alt="" "" class=""img-responsive"" /></div>
                        <div class=""agile_top_brand_left_grid1"">
                            <figure>
                                <div class=""snipcart-item block"">
                                    <div class=""snipcart-thumb"">
                                        <a href=""single.html""><img title="" "" alt="" "" src=""images/1.png"" /></a>
                                        <p>fortune sunflower oil</p>
                                        <h4>$7.99 <span>$10.00</span></h4>
                                    </div>
                                    
                                </div>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 top_brand_left"">
                <div class=""hover14 column"">
                    <div class=""agile_top_brand_left_grid"">
      ");
            WriteLiteral(@"                  <div class=""agile_top_brand_left_grid1"">
                            <figure>
                                <div class=""snipcart-item block"">
                                    <div class=""snipcart-thumb"">
                                        <a href=""single.html""><img title="" "" alt="" "" src=""images/3.png"" /></a>
                                        <p>basmati rise (5 Kg)</p>
                                        <h4>$11.99 <span>$15.00</span></h4>
                                    </div>
                                   
                                </div>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 top_brand_left"">
                <div class=""hover14 column"">
                    <div class=""agile_top_brand_left_grid"">
                        <div class=""agile_top_brand_left_grid_pos"">
                            <img src=""images/");
            WriteLiteral(@"offer.png"" alt="" "" class=""img-responsive"" />
                        </div>
                        <div class=""agile_top_brand_left_grid1"">
                            <figure>
                                <div class=""snipcart-item block"">
                                    <div class=""snipcart-thumb"">
                                        <a href=""single.html""><img src=""images/2.png"" alt="" "" class=""img-responsive"" /></a>
                                        <p>Pepsi soft drink (2 Ltr)</p>
                                        <h4>$8.00 <span>$10.00</span></h4>
                                    </div>
                                    
                                </div>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 top_brand_left"">
                <div class=""hover14 column"">
                    <div class=""agile_top_brand_left_grid"">
            ");
            WriteLiteral(@"            <div class=""agile_top_brand_left_grid_pos"">
                            <img src=""images/offer.png"" alt="" "" class=""img-responsive"" />
                        </div>
                        <div class=""agile_top_brand_left_grid1"">
                            <figure>
                                <div class=""snipcart-item block"">
                                    <div class=""snipcart-thumb"">
                                        <a href=""single.html""><img src=""images/4.png"" alt="" "" class=""img-responsive"" /></a>
                                        <p>dogs food (4 Kg)</p>
                                        <h4>$9.00 <span>$11.00</span></h4>
                                    </div>
                                    
                                </div>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div");
            WriteLiteral(@">
<!-- //top-brands -->
<!-- fresh-vegetables -->
<div class=""fresh-vegetables"">
    <div class=""container"">
        <h3>Sản phẩm bán chạy</h3>
        <div class=""w3l_fresh_vegetables_grids"">
            <div class=""col-md-3 w3l_fresh_vegetables_grid w3l_fresh_vegetables_grid_left"">
        <div class=""w3l_fresh_vegetables_grid2"">
            <ul>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""products.html"">Strong bell</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""vegetables.html"">Cá hồi</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""vegetables.html"">Thịt thăn bò</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""drinks.html"">Nước ép cam</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""pet.html"">Bánh quy bơ</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""bread.html"">Cánh gà 500g</a></li>
");
            WriteLiteral(@"                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""household.html"">Sữa Nutifood</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""products.html"">Bánh hộp Chocopie</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""products.html"">Cam sành</a></li>
                <li><i class=""fa fa-check"" aria-hidden=""true""></i><a href=""products.html"">Bưởi da xanh</a></li>
            </ul>
        </div>
    </div>
            <div class=""col-md-9 w3l_fresh_vegetables_grid_right"">

                <div class=""col-md-4 w3l_fresh_vegetables_grid"">
                    <div class=""w3l_fresh_vegetables_grid1"">
                        <img src=""images/strongbow.jpg"" alt="" "" class=""img-responsive"" style=""height: 350px;"" />
                        <div class=""w3l_fresh_vegetables_grid1_rel_pos"">
                            <div class=""more m1"">
                                <a href=""products.html"" class=""button--saqui button--r");
            WriteLiteral(@"ound-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 w3l_fresh_vegetables_grid"">
                    <div class=""w3l_fresh_vegetables_grid1"">
                        <div class=""w3l_fresh_vegetables_grid1_rel"">
                            <img src=""images/52.png"" alt="" "" class=""img-responsive"" />
                            <div class=""w3l_fresh_vegetables_grid1_rel_pos"">
                                <div class=""more m1"">
                                    <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""w3l_fresh_vegetables_grid1_bottom"">
                        <img src=""images/68.png"" alt="" "" class=""im");
            WriteLiteral(@"g-responsive"" />
                        <div class=""w3l_fresh_vegetables_grid1_rel_pos"">
                            <div class=""more m1"">
                                <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                            </div>
                        </div>
                        <div class=""w3l_fresh_vegetables_grid1_bottom_pos"">
                            <h5>Special Offers</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 w3l_fresh_vegetables_grid"">
                    <div class=""w3l_fresh_vegetables_grid1"">
                        <img src=""images/46.png"" alt="" "" class=""img-responsive"" />
                        <div class=""w3l_fresh_vegetables_grid1_rel_pos"">
                            <div class=""more m1"">
                                <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" d");
            WriteLiteral(@"ata-text=""Shop now"">Shop now</a>
                            </div>
                        </div>
                    </div>
                    <div class=""w3l_fresh_vegetables_grid1_bottom"">
                        <img src=""images/11.jpg"" alt="" "" class=""img-responsive"" />
                        <div class=""w3l_fresh_vegetables_grid1_rel_pos"">
                            <div class=""more m1"">
                                <a href=""products.html"" class=""button--saqui button--round-l button--text-thick"" data-text=""Shop now"">Shop now</a>
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class=""clearfix""> </div>
                <div class=""agileinfo_move_text"">
                    <div class=""agileinfo_marquee"">
                        <h4>get <span class=""blink_me"">25% off</span> on first order and also get gift voucher</h4>
                    </div>
                    <div class=""ag");
            WriteLiteral(@"ileinfo_breaking_news"">
                        <span> </span>
                    </div>
                    <div class=""clearfix""></div>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<!-- //fresh-vegetables -->
<!-- newsletter -->
<div class=""newsletter"">
    <div class=""container"">
        <div class=""w3agile_newsletter_left"">
            <h3>sign up for our newsletter</h3>
        </div>
        <div class=""w3agile_newsletter_right"">
            ");
            EndContext();
            BeginContext(13900, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84e4e630d8447f1862db2bf49411019", async() => {
                BeginContext(13931, 234, true);
                WriteLiteral("\r\n                <input type=\"email\" name=\"Email\" value=\"Email\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Email\';}\" required=\"\">\r\n                <input type=\"submit\" value=\"subscribe now\">\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14172, 75, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
