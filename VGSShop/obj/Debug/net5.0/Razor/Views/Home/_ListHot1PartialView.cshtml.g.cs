#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba41f30d0d2af56b774acfc0250b2e9325bb03e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListHot1PartialView), @"mvc.1.0.view", @"/Views/Home/_ListHot1PartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba41f30d0d2af56b774acfc0250b2e9325bb03e", @"/Views/Home/_ListHot1PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListHot1PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-item-wrap row\">\r\n");
#nullable restore
#line 6 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
         foreach (var item in Model)
        {
            string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xl-3 col-lg-4 col-sm-6\">\r\n                <div class=\"product-item\">\r\n                    <div class=\"product-img img-zoom-effect\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 421, 1);
#nullable restore
#line 12 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
WriteAttributeValue("", 417, url, 417, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aba41f30d0d2af56b774acfc0250b2e9325bb03e4578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 480, "~/images/product/", 480, 17, true);
#nullable restore
#line 13 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
AddHtmlAttributeValue("", 497, item.Thumb, 497, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
AddHtmlAttributeValue("", 515, item.Title, 515, 11, false);

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
                        <div class=""product-add-action"">
                            <ul>
                                <li>
                                    <a href=""javascript:void(0)"" class=""add-to-cart1"" data-ProductId=""");
#nullable restore
#line 18 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                                                                                                 Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                        <i class=""pe-7s-cart""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""product-content"">
                        <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 1153, "\"", 1164, 1);
#nullable restore
#line 26 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
WriteAttributeValue("", 1160, url, 1160, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <div class=\"price-box pb-1\">\r\n                            <span class=\"new-price\">");
#nullable restore
#line 28 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                                               Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n");
#nullable restore
#line 30 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                         if (item.Discount.HasValue)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <del>");
#nullable restore
#line 32 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                            Write(item.Discount.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 33 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 41 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\_ListHot1PartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591