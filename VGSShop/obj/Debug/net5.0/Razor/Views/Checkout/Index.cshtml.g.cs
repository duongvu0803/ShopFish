#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cecdf88745464f1f9fc27d4f6ae90f764f721e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecdf88745464f1f9fc27d4f6ae90f764f721e74", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VGSShop.ModelsView.MuahangVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Họ và tên"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Số điện thoại"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Địa chỉ nhận hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<VGSShop.ModelsView.CartItem> Carts = ViewBag.Giohang;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        .nice-select .list {
            border-radius: 0px;
            overflow-y: auto;
            overflow: hidden;
            max-height: 200px;
            overflow-y: scroll;
        }

        .nice-select .option:hover, .nice-select .option:focus, .nice-select .option-selected-focus {
            color: red;
            background: none;
        }
    </style>
");
            }
            );
            WriteLiteral("<!-- Begin Main Content Area -->\r\n<main class=\"main-content\">\r\n\r\n    <div class=\"checkout-area section-space-y-axis-100\">\r\n        <div class=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecdf88745464f1f9fc27d4f6ae90f764f721e746622", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cecdf88745464f1f9fc27d4f6ae90f764f721e746896", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 30 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-6 col-12"">
                        <div class=""checkbox-form"">
                            <h3>THÔNG TIN ĐƠN HÀNG</h3>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Họ và tên*</label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cecdf88745464f1f9fc27d4f6ae90f764f721e749173", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 39 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Số điện thoại*</label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cecdf88745464f1f9fc27d4f6ae90f764f721e7411268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Địa chỉ nhận hàng*</label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cecdf88745464f1f9fc27d4f6ae90f764f721e7413365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 51 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                \r\n");
                WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-12"">
                        <div class=""your-order"">
                            <h3>THÔNG TIN ĐƠN HÀNG</h3>
                            <div class=""your-order-table table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""cart-product-name"">Sản phẩm</th>
                                            <th class=""cart-product-total"">Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 94 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                         if (Carts.Count > 0)
                                        {
                                            foreach (var item in Carts)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr class=\"cart_item\">\r\n                                                    <td class=\"cart-product-name\">\r\n                                                        ");
#nullable restore
#line 100 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                                   Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<strong class=\"product-quantity\">\r\n                                                            × ");
#nullable restore
#line 101 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                                         Write(item.amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        </strong>\r\n                                                    </td>\r\n                                                    <td class=\"cart-product-total\"><span class=\"amount\">");
#nullable restore
#line 104 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                                                                                   Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 106 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                    <tfoot>
                                        <tr class=""cart-subtotal"">
                                            <th>TỔNG HÓA ĐƠN</th>
                                            <td><span class=""amount"">");
#nullable restore
#line 112 "C:\Users\DUONG\VGSShop\VGSShop\Views\Checkout\Index.cshtml"
                                                                Write(Carts.Sum(x =>x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion"">
                                    <div id=""accordion"">
                                        <div class=""card"">
                                            <div class=""card-header"" id=""#payment-1"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)""");
                BeginWriteAttribute("class", " class=\"", 6362, "\"", 6370, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"">
                                                        Thanh toán khi giao hàng (COD)
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseOne"" class=""collapse show"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p style=""color: red"">
                                                        Qúy khách sẽ thanh toán khi nhận được sản phẩm đã đặt hàng.
                                                        (chỉ có tại Tp. HCM - Đơn ngoại thành phải chuyển khoản trước)
                                                    </p>
                                                </div>
                                            </div>
                     ");
                WriteLiteral(@"                   </div>
                                        <div class=""card"">
                <div class=""card-header"" id=""#payment-2"">
                    <h5 class=""panel-title"">
                        <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"">
                            Chuyển khoản qua ngân hàng
                        </a>
                    </h5>
                </div>
                <div id=""collapseTwo"" class=""collapse"" data-bs-parent=""#accordion"">
                    <div class=""card-body"">
                        <p style=""color:red"">
                            VCB 0261003477110 Vũ Hữu Trùng Dương
                        </p>
                    </div>
                </div>
            </div>
                                        <div class=""card"">
                <div class=""card-header"" id=""#payment-3"">
                    <h5 class=""panel-title"">
                        <a href=""j");
                WriteLiteral(@"avascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"">
                            Thanh toán qua MOMO
                        </a>
                    </h5>
                </div>
                <div id=""collapseThree"" class=""collapse"" data-bs-parent=""#accordion"">
                    <div class=""card-body"">
                        <p>
                            THÔNG TIN MOMO:
                        </p>
                        <p>
                            SỐ ĐIỆN THOẠI: 000000xxx
                        </p>
                    </div>
                </div>
            </div>
                                    </div>
                                    <div class=""order-button-payment"">
                                        <input value=""XÁC NHẬN ĐẶT HÀNG"" type=""submit"">
                                    </div>
                                    
                                </div>
                           ");
                WriteLiteral(" </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>\r\n<!-- Main Content Area End Here -->\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('select').niceSelect();
            $(function () {
                $(""#TinhThanh"").change(function () {
                    var locationid = $('#TinhThanh').val();
                    $.ajax({
                        url: '/Location/QuanHuyenList',
                        type: ""GET"",
                        dataType: ""JSON"",
                        data: {
                            LocationId: locationid,
                        },
                        success: function (QuanHuyens) {
                            $(""#QuanHuyen"").empty();
                            $(""#PhuongXa"").empty();
                            var strPhuongXa = '<option value="""" disabled selected>Phường / Xã<option>';
                            $(""#PhuongXa"").append(strPhuongXa);
                            var strQuanHuyen = '<option value="""" disabled selected>Quân / Huyện<option>';
                            $(""#PhuongXa"").append(strQuanHuy");
                WriteLiteral(@"en);
                            $.each(QuanHuyens, function (i, item) {
                                var option = '<option value=""' + item.locationid + '"">' + item.nameWithType + '< option >';
                                $(""#QuanHuyen"").append(option);
                            });
                            $('select').niceSelect('update');
                        }
                    });
                });
                $(""#QuanHuyen"").change(function () {
                    var locationid = $('#QuanHuyen').val();
                    $.ajax({
                        url: '/Location/PhuongXaList',
                        type: ""GET"",
                        dataType: ""JSON"",
                        data: {
                            LocationId: locationid,
                        },
                        success: function (QuanHuyens) {
                            $(""#PhuongXa"").empty();
                            var readonly = '<option value="""" disabled selected>Phườ");
                WriteLiteral(@"ng / Xã<option>';
                            $(""#PhuongXa"").append(readonly);
                            $.each(PhuongXaList, function (i, item) {
                                var option = '<option value=""' + item.locationid + '"">' + item.nameWithType + '< option >';
                                $(""#PhuongXa"").append(option);
                            });
                            $('select').niceSelect('update');
                        }
                    });
                });
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VGSShop.ModelsView.MuahangVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
