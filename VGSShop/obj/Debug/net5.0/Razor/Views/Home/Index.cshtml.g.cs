#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7badab9f117fe8379bf5cda6940e3e9e46c747cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\DUONG\VGSShop\VGSShop\Views\_ViewImports.cshtml"
using VGSShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Views\_ViewImports.cshtml"
using VGSShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7badab9f117fe8379bf5cda6940e3e9e46c747cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VGSShop.ModelsView.HomeViewVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/benner/zyro-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Inner Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/benner/zyro-image (1).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/benner/zyro-image (2).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "shoppBettaHouse";
    List<Product> allProduct = ViewBag.AllProduct;
    List<Product> allProductHot = ViewBag.AllProductHot;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<!-- Begin Slider Area -->
");
#nullable restore
#line 9 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
 if (Model.Banners != null && Model.Banners.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"slider-area\">\r\n        <!-- Main Slider -->\r\n        <!--<div class=\"swiper-container main-slider-2 swiper-arrow with-bg_white\">\r\n            <div class=\"swiper-wrapper\">-->\r\n");
            WriteLiteral(@"        <!--<div class=""swiper-slide animation-style-02"">
                <div class=""slide-inner bg-height"" data-bg-image=""https://cdn-img.thethao247.vn/upload/synguyen/2018/01/17/w2_01.jpg"">
                </div>
            </div>
        </div>-->
");
            WriteLiteral(@"
        <!-- Add Pagination -->
        <!--<div class=""swiper-pagination with-bg d-md-none""></div>-->
        <!-- Add Arrows -->
        <!--<div class=""swiper-button-next""></div>
            <div class=""swiper-button-prev""></div>
        </div>-->
    </div>
");
#nullable restore
#line 42 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Slider Area End Here -->
<!-- Main Slider -->
<div class=""swiper-container main-slider swiper-arrow with-bg_white"">
    <div class=""swiper-wrapper"">
        <div class=""swiper-slide animation-style-01""> 
            <div class=""slide-inner bg-height"" data-bg-image=""https://hoaphatmiennam.vn/wp-content/uploads/2019/04/cay-trong-trong-ho-ca-cay-thuy-sinh-1024x388.jpg"">
                <div class=""parallax-img-wrap"">
");
            WriteLiteral(@"                </div>
                <div class=""container"">
                    <div class=""parallax-with-content"">
                        <div class=""slide-content"" >
                            <span class=""sub-title mb-3"" style=""color:azure"">Form & màu</span>
                            <h2 class=""title mb-9""  style=""color:azure"">Đẹp chuẩn chỉ - nét căng số 1 để  <br> làm giống.</h2>
                            <div class=""button-wrap"">
                                <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""shop.html"">Shop Now</a>
                            </div>
                        </div>
                        <div class=""parallax-img-wrap"">
                            <div class=""tomatoes"">
                                <div class=""scene fill"">
                                    <div class=""expand-width"" data-depth=""0.5"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7badab9f117fe8379bf5cda6940e3e9e46c747cb8473", async() => {
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
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""swiper-slide animation-style-01"">
            <div class=""slide-inner bg-height"" data-bg-image=""https://shopheo.com/wp-content/uploads/2022/03/ho-thuy-sinh-ruong-bac-thang.jpg"">
                <div class=""parallax-img-wrap"">
                    <div class=""chilly"">
");
            WriteLiteral("                    </div>\r\n                    <div class=\"avocado\">\r\n                        <div class=\"scene fill\" >\r\n                            <div class=\"expand-width\" data-depth=\"0.5\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7badab9f117fe8379bf5cda6940e3e9e46c747cb10401", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""container"">
                    <div class=""parallax-with-content"">
                        <div class=""slide-content"" >
                            <span class=""sub-title mb-3""style=""color: azure"" > CÁ BETTA HALFMOON </span>
                            <h2 class=""title mb-9"" style=""color: azure""> VẺ ĐẸP  <br> HOANG DÃ.</h2>
                            <div class=""button-wrap"">
                                <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""BETTA-HAFLMOON"">Mua ngay</a>
                            </div>
                        </div>
                        <div class=""parallax-img-wrap"">
                            <div class=""tomatoes"">
                                <div class=""scene fill"">
                                    <div class=""expand-width"" data-depth=""0.5"">
                          ");
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7badab9f117fe8379bf5cda6940e3e9e46c747cb12612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Add Pagination -->
    <div class=""swiper-pagination with-bg d-md-none""></div>

    <!-- Add Arrows -->
    <div class=""swiper-button-next""></div>
    <div class=""swiper-button-prev""></div>
</div>
<!-- Begin Shipping Area -->
<div class=""shipping-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <i class=""fa-solid fa-car-side"" style=""font-size:50px""></i>
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Giao hàng</h5>
                        <p class=""short-desc mb-0"">Miễn phí");
            WriteLiteral(@" vận chuyển</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-md-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <i class=""fa-solid fa-phone-volume"" style=""font-size:50px""></i>
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Hỗ trợ</h5>
                        <p class=""short-desc mb-0"">Hỗ trợ tận tình</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-lg-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <i class=""fa-solid fa-tent-arrow-left-right"" style=""font-size:50px""></i>
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Thanh toán</h5>
                        <p c");
            WriteLiteral(@"lass=""short-desc mb-0"">Thanh toán khi nhận hàng</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shipping Area End Here -->
<!-- Begin Product Area -->
<div class=""product-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title text-center pb-55"">

                    <h2 class=""title mb-0""> BỘ SƯU TẬP CÁ BETTA   </h2>
                </div>
                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""all-items"" role=""tabpanel"" aria-labelledby=""all-items-tab"">
                        ");
#nullable restore
#line 190 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_ListPartialViews", allProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 192 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 9409, "\"", 9434, 1);
#nullable restore
#line 194 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 9414, item.category.Alias, 9414, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"fresh-fruits-tab\">\r\n                            ");
#nullable restore
#line 195 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("_ListPartialViews", item.lsProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 197 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""product-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title text-center pb-55"">

                    <h2 class=""title mb-0""> MẪU CÁ BETTA BÁN CHẠY </h2>
                </div>
                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""all-items"" role=""tabpanel"" aria-labelledby=""all-items-tab"">
                        ");
#nullable restore
#line 213 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_ListHot1PartialView", allProductHot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 215 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 10454, "\"", 10479, 1);
#nullable restore
#line 217 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 10459, item.category.Alias, 10459, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"fresh-fruits-tab\">\r\n                            ");
#nullable restore
#line 218 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("_ListHot1PartialView", item.lsProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 220 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Product Area End Here -->\r\n<!-- Begin Blog Area -->\r\n");
#nullable restore
#line 228 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
 if (Model.News != null && Model.News.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""section-title text-center pb-55"">

                <h2 class=""title mb-0"" style=""color : red"">TIN TỨC MỚI NHẤT</h2>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""swiper-container blog-slider"">
                        <div class=""swiper-wrapper"">
");
#nullable restore
#line 240 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                             foreach (var item in Model.News)
                            {
                                string url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    <div class=\"blog-item\">\r\n                                        <div class=\"blog-img img-zoom-effect\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 11746, "\"", 11757, 1);
#nullable restore
#line 246 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 11753, url, 11753, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7badab9f117fe8379bf5cda6940e3e9e46c747cb22140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11836, "~/images/news/", 11836, 14, true);
#nullable restore
#line 247 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 11850, item.Thumb, 11850, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 247 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 11868, item.Title, 11868, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""blog-content"">
                                            <div class=""blog-meta text-dim-gray pb-3"">
                                                <ul>
                                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 253 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                                                                                                     Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <h5 class=\"title mb-4\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 12547, "\"", 12558, 1);
#nullable restore
#line 257 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 12554, url, 12554, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 257 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h5>\r\n                                            <p class=\"short-desc mb-5\">");
#nullable restore
#line 259 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                                                                  Write(item.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <div class=\"button-wrap\">\r\n                                                <a class=\"btn btn-custom-size btn-dark btn-lg rounded-0\"");
            BeginWriteAttribute("href", " href=\"", 12895, "\"", 12906, 1);
#nullable restore
#line 261 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 12902, url, 12902, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 261 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 266 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- Add Arrows -->
                        <div class=""swiper-button-next""></div>
                        <div class=""swiper-button-prev""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 276 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7badab9f117fe8379bf5cda6940e3e9e46c747cb27865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VGSShop.ModelsView.HomeViewVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
