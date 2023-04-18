#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "344167a5adf98d64d6630a1f99989bd870a7fe6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminHome_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminHome/Index.cshtml")]
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
#line 1 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\_ViewImports.cshtml"
using VGSShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\_ViewImports.cshtml"
using VGSShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344167a5adf98d64d6630a1f99989bd870a7fe6e", @"/Areas/Admin/Views/AdminHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminAssets/js/ChartJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
  
    ViewData["Title"] = "Admin Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    var currentMonth = DateTime.Now.Month;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media align-items-center"">
                    <div class=""avatar avatar-icon avatar-lg avatar-blue"">
                        <i class=""anticon anticon-dollar""></i>
                    </div>
                    <div class=""m-l-15"">
                        <h2 class=""m-b-0"">");
#nullable restore
#line 17 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                     Write(ViewBag.ThongKeTongDoanhThu.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</h2>
                        <p class=""m-b-0 text-muted"">Doanh thu</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media align-items-center "">
                    <div class=""avatar avatar-icon avatar-lg avatar-gold"">
                        <i class=""anticon anticon-profile""></i>
                    </div>
                    <div class=""m-l-15"">
                        <h2 class=""m-b-0"">");
#nullable restore
#line 32 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                     Write(ViewBag.ThongKeDonDatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <p class=""m-b-0 text-muted"">Đơn hàng đã giao thành công </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-body"">
            <div class=""media align-items-center "">
                <div class=""fas fa-cart-plus"">
                </div>
                <div class=""m-l-15"">
                    <h2 class=""m-b-0"">");
#nullable restore
#line 45 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                 Write(ViewBag.ThongKeDonDatHangMoi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p class=""m-b-0 text-muted"">Đơn hàng mới</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media align-items-center"">
                    <div class=""avatar avatar-icon avatar-lg avatar-purple"">
                        <i class=""anticon anticon-user""></i>
                    </div>
                    <div class=""m-l-15"">
                        <h2 class=""m-b-0"">");
#nullable restore
#line 59 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                     Write(ViewBag.ThongKeKhachHang);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <p class=""m-b-0 text-muted"">Khách hàng</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div style=""text-align:center; color:#688d0d; font-size: 30px"">
    Truy thu doanh số
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344167a5adf98d64d6630a1f99989bd870a7fe6e7963", async() => {
                WriteLiteral(@"
    <div class=""row"">

        <div class=""col"">
            <input type=""date"" id=""txtstart"" class=""form-control"" placeholder=""Ngày bắt đầu"">
        </div>
        <div class=""col"">
            <input type=""date"" id=""txtstop"" class=""form-control"" placeholder=""Ngày kết thúc"">
        </div>
    </div>
    <button type=""submit"" id=""btnSubmit"" class=""btn btn-primary"">Thống kê</button>
    <h1 id=""result"">0 VNĐ</h1>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div style=\"text-align:center; color:#688d0d; font-size: 30px\">\r\n    Thống kê sản phẩm bán ra\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <select id=\"ddlMonth\" class=\"form-control\" style=\"width: 150px;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344167a5adf98d64d6630a1f99989bd870a7fe6e9914", async() => {
                WriteLiteral("Chọn tháng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
             for (var i = 1; i < 13; i++)
            {
                if (i == currentMonth)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344167a5adf98d64d6630a1f99989bd870a7fe6e11398", async() => {
                WriteLiteral("Tháng ");
#nullable restore
#line 94 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344167a5adf98d64d6630a1f99989bd870a7fe6e13781", async() => {
                WriteLiteral("Tháng ");
#nullable restore
#line 98 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                                        Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\DUONG\VGSShop\VGSShop\Areas\Admin\Views\AdminHome\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <canvas id=\"chartProduct\"></canvas>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344167a5adf98d64d6630a1f99989bd870a7fe6e15989", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#btnSubmit"").click(function (e) {
                e.preventDefault();

                var ngaybatdau = $(""#txtstart"").val();
                var ngayketthuc = $(""#txtstop"").val();
                $.ajax({
                    url: '/Admin/AdminHome/ThongKe/',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { datestart: ngaybatdau, datestop: ngayketthuc },
                    success: function (results) {

                        $(""#result"").html("""");
                        $(""#result"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
            $('#ddlMonth').trigger('change');
        });

        $('#ddlMonth').on('change', function () {
            var month = $(this).val();

            $.get('/Admin/AdminHome/GetReportByMonth?m");
                WriteLiteral(@"onth=' + month, function (resp) {
                console.log(resp);
                var labels = resp.map(x => x.productName);
                var datasets = [];
                datasets.push({
                    label: ""Sản phẩm"",
                    backgroundColor: '#0b9663',
                    borderWidth: 1,
                    data: resp.map(x => x.total)
                });
                RegisterChartProduct(labels, datasets);
            });
        });

        // RegisterChartProduct();
        var myBarChart;

        function RegisterChartProduct(labels, datasets) {
            var ctx = document.getElementById('chartProduct');

            if (myBarChart) {
                myBarChart.destroy();
            }

            var barChartData = {
                labels: labels, // ['2011', '2012', '2013', '2014', '2015', '2016', '2017', '2018'],
                datasets: datasets
                //datasets: [{
                //    label: 'Series A',
                /");
                WriteLiteral(@"/    backgroundColor: '#0b9663',
                //    borderWidth: 1,
                //    data: [56, 55, 40, 37, 54, 76, 63, 62]
                //},
                //    //{
                //    //    label: 'Series B',
                //    //    borderWidth: 1,
                //    //    data: [86, 27, 90, 43, 65, 76, 87, 85]
                //    //}]
                //]
            };

             myBarChart = new Chart(ctx, {
                type: 'bar',
                data: barChartData,
                //options: options

            });
        }

        
    </script>
    
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
