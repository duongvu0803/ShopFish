#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d2e98e93c655659c5c13eb4972b77c09872249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d2e98e93c655659c5c13eb4972b77c09872249", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VGSShop.Models.ProductViewModel>>
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
#line 3 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-lg-12"">
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade show active"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"">
");
#nullable restore
#line 17 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                 foreach (var item in Model)
                                {
                                    string url = $"/{item.MetaTitle}-{item.ID}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-lg-3 col-sm-6 pt-6"">
                                        <div class=""product-item"">
                                            <div class=""product-img img-zoom-effect"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1069, 1);
#nullable restore
#line 23 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 1065, url, 1065, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12d2e98e93c655659c5c13eb4972b77c098722495154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1152, "~/images/product/", 1152, 17, true);
#nullable restore
#line 24 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1169, item.Images, 1169, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1188, item.MetaTitle, 1188, 15, false);

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
            WriteLiteral("\r\n                                                </a>\r\n");
            WriteLiteral("                                            </div>\r\n                                            <div class=\"product-content\">\r\n                                                <a class=\"product-name\"");
            BeginWriteAttribute("href", " href=\"", 2092, "\"", 2103, 1);
#nullable restore
#line 37 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 2099, url, 2099, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                <div class=\"price-box pb-1\">\r\n                                                    <span class=\"new-price\">");
#nullable restore
#line 39 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                                                        Write(item.Price.HasValue ? item.Price.Value.ToString("#,##0 VNĐ") : "Liên hệ cửa hàng");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                     if (ViewBag.TotalPage > 1)
                    {
                        var pageDisplay = (int)ViewBag.MaxPage;
                        int totalPage = (int)ViewBag.TotalPage;
                        int currentPage = ((int)ViewBag.Page);

                        // Create numeric links
                        var startPageIndex = Math.Max(1, currentPage - pageDisplay / 2);
                        var endPageIndex = Math.Min(totalPage, currentPage + pageDisplay / 2);

                        var link = "/tim-kiem?keyword/" + ViewBag.Keyword;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"pagination-area pt-10\">\r\n                            <nav aria-label=\"Page navigation example\">\r\n                                <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 63 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                     if (currentPage > ViewBag.First)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3735, "\"", 3767, 3);
#nullable restore
#line 67 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 3742, link, 3742, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3747, "&page=", 3747, 6, true);
#nullable restore
#line 67 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 3753, ViewBag.First, 3753, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                                <span class=\"fa fa-chevron-left\"></span>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 71 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                    }
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                     for (int i = startPageIndex; i <= endPageIndex; i++)
                                    {
                                        if (currentPage == i)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item active\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4770, "\"", 4790, 3);
#nullable restore
#line 82 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 4777, link, 4777, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4782, "&page=", 4782, 6, true);
#nullable restore
#line 82 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 4788, i, 4788, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4791, "\"", 4807, 2);
            WriteAttributeValue("", 4799, "Trang", 4799, 5, true);
#nullable restore
#line 82 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 4804, i, 4805, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 84 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5136, "\"", 5156, 3);
#nullable restore
#line 88 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 5143, link, 5143, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5148, "&page=", 5148, 6, true);
#nullable restore
#line 88 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 5154, i, 5154, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5157, "\"", 5173, 2);
            WriteAttributeValue("", 5165, "Trang", 5165, 5, true);
#nullable restore
#line 88 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 5170, i, 5171, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 90 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                     if (currentPage < totalPage)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5550, "\"", 5581, 3);
#nullable restore
#line 95 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 5557, link, 5557, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5562, "&page=", 5562, 6, true);
#nullable restore
#line 95 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
WriteAttributeValue("", 5568, ViewBag.Next, 5568, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                                <span class=\"fa fa-chevron-right\"></span>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 99 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </nav>\r\n                        </div>\r\n");
#nullable restore
#line 103 "C:\Users\DUONG\VGSShop\VGSShop\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VGSShop.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
