#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\FeedBack\FeedBack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c079dd1fead2d37396dc21a7289001d4d23276d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeedBack_FeedBack), @"mvc.1.0.view", @"/Views/FeedBack/FeedBack.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c079dd1fead2d37396dc21a7289001d4d23276d2", @"/Views/FeedBack/FeedBack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_FeedBack_FeedBack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VGSShop.Models.Feedback>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FeedBackController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUONG\VGSShop\VGSShop\Views\FeedBack\FeedBack.cshtml"
      
        ViewData["Title"] = "FeedBack";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <main class=""main-content"">
        <!-- Begin Shipping Area -->
        <div class=""shipping-area section-space-y-axis-100"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""shipping-item"">
                            <div class=""shipping-img"">
                                <i class=""fa-solid fa-car-side"" style=""font-size:25px""></i>
                            </div>
                            <div class=""shipping-content"">
                                <h5 class=""title"">Giao hàng</h5>
                                <p class=""short-desc mb-0"">Miễn phí vận chuyển</p>
                            </div>
         ");
            WriteLiteral(@"               </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""shipping-item"">
                            <div class=""shipping-img"">
                                <i class=""fa-solid fa-phone-volume"" style=""font-size:25px""></i>
                            </div>
                            <div class=""shipping-content"">
                                <h5 class=""title"">Hỗ trợ</h5>
                                <p class=""short-desc mb-0"">Hỗ trợ tận tình</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""shipping-item"">
                            <div class=""shipping-img"">
                                <i class=""fa-solid fa-tent-arrow-left-right""style=""font-size:25px"" ></i>
                            </div>
                            <div class=""shipping-content"">
               ");
            WriteLiteral(@"                 <h5 class=""title"">Thanh toán</h5>
                                <p class=""short-desc mb-0"">Thanh toán khi nhận hàng</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Shipping Area End Here -->

        <div class=""contact-with-map"">
            <div class=""contact-map"">
                <iframe class=""contact-map-size"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5623.203560209008!2d106.66624460976215!3d10.796038021943993!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3175292e79f1e72f%3A0xae118f87eef3dca1!2zVHLGsOG7nW5nIMSQ4bqhaSBo4buNYyBUw6BpIG5ndXnDqm4gdsOgIE3DtGkgdHLGsOG7nW5nIFRQLkhDTQ!5e0!3m2!1svi!2s!4v1670137211020!5m2!1svi!2s""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2995, "\"", 3013, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n            </div>\r\n            <div class=\"contact-form-area section-space-bottom-100\">\r\n                <div class=\"container\">\r\n                    <div class=\"contact-form-wrap\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c079dd1fead2d37396dc21a7289001d4d23276d28097", async() => {
                WriteLiteral(@"
                            <h4 class=""contact-form-title pb-2 mb-7"">Yêu cầu hỗ trợ</h4>
                            <div class=""form-field"">
                                <input type=""text"" id=""txtName"" placeholder=""Họ tên*"" class=""input-field"">
                            </div>
                            <div class=""form-field mt-6"">
                                <input type=""text"" id=""txtMobile"" placeholder=""Điện thoại*"" class=""input-field"">
                            </div>
                            <div class=""form-field mt-6"">
                                <input type=""text"" id=""txtAddress"" placeholder=""Địa chỉ*"" class=""input-field"">
                            </div>
                            <div class=""form-field mt-6"">
                                <input type=""text"" id=""txtEmail"" placeholder=""Email*"" class=""input-field"">
                            </div>
                            <div class=""form-field mt-6"">
                                <textarea type=""text"" id");
                WriteLiteral(@"=""txtContent"" placeholder=""Hỗ trợ"" class=""textarea-field""></textarea>
                            </div>
                            <div class=""button-wrap mt-8"">
                                <button id=""btnSend"" type=""submit"" value=""submit"" class=""btn btn btn-custom-size lg-size btn-primary btn-secondary-hover rounded-0"" name=""submit"">Gửi yêu cầu</button>
                            </div>
                            <p class=""form-messege mt-3 mb-0""></p>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c079dd1fead2d37396dc21a7289001d4d23276d211324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VGSShop.Models.Feedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
