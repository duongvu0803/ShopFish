#pragma checksum "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b4c0d70b661881f2371aa0b2a20f9088937d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b4c0d70b661881f2371aa0b2a20f9088937d6c", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197ab5da9f648aa1ce7d17df5729eb6986389d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 104, "\"", 123, 2);
            WriteAttributeValue("", 111, "/", 111, 1, true);
#nullable restore
#line 7 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 112, item.Alias, 112, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
                              Write(item.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 8 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DUONG\VGSShop\VGSShop\Views\Shared\Components\Category\Default.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
