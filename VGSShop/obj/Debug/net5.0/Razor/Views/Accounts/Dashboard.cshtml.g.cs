#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "685b797b78cc9745fbd631e8e8c21663d9eda348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685b797b78cc9745fbd631e8e8c21663d9eda348", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VGSShop.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-primary-hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> Danhsachdonhang = ViewBag.Order;
    VGSShop.ModelsView.ChangePasswordViewModel changePassword = new VGSShop.ModelsView.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">THÔNG TIN TÀI KHOẢN</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">DANH SÁCH ĐƠN HÀNG</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-t");
            WriteLiteral(@"ab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">THAY ĐỔI MẬT KHẨU</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""dang-xuat.html"" role=""tab"" aria-selected=""false"">ĐĂNG XUẤT</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào: <b>");
#nullable restore
#line 35 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                            Write(Model.FullName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n                                <p>Email: ");
#nullable restore
#line 37 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Số điện thoại: ");
#nullable restore
#line 38 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Địa chỉ: ");
#nullable restore
#line 39 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH SÁCH ĐƠN HÀNG</h4>
");
#nullable restore
#line 45 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                 if (Danhsachdonhang != null && Danhsachdonhang.Count > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>Mã đơn hàng</th>
                                                    <th>Ngày đặt mua</th>
");
            WriteLiteral(@"                                                    <th>Trạng thái</th>
                                                    <th>Tổng hóa đơn</th>
                                                    <th></th>
                                                </tr>
");
#nullable restore
#line 58 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                 foreach (var item in Danhsachdonhang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 61 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 62 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                        <td>");
#nullable restore
#line 64 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 65 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                                        <td>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "685b797b78cc9745fbd631e8e8c21663d9eda34811240", async() => {
                WriteLiteral("<span>Xem đơn hàng</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                                                                                                                                        WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </div>
");
#nullable restore
#line 81 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>chưa có đơn hàng .</p>\r\n");
#nullable restore
#line 85 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">ĐỊA CHỈ THANH TOÁN</h4>
                                        <address>
                                            ");
#nullable restore
#line 95 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">ĐỊA CHỈ GIAO HÀNG</h4>
                                        <address>
                                            ");
#nullable restore
#line 101 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 108 "C:\Users\DUONG\VGSShop\VGSShop\Views\Accounts\Dashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<!-- Main Content Area End Here -->\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"");
                $.ajax({
                    url: '/DonHang/Details',
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        id: madonhang,
                    },
                    async: true,
                    success: function (results) {
                        $(""#records_table"").html("""");
                        $(""#records_table"").html(results);
                    },
                    error: function (xhr) {
                        alert(""Đã có lỗi xảy ra"");
                    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VGSShop.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
