#pragma checksum "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623f177d70bcfaa543f2e3e6d9db5659a10ac505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DanhMucCon_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DanhMucCon/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623f177d70bcfaa543f2e3e6d9db5659a10ac505", @"/Views/Shared/Components/DanhMucCon/Default.cshtml")]
    public class Views_Shared_Components_DanhMucCon_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopV1.Models.DanhMuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml"
     foreach (var todo in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <li><a");
            BeginWriteAttribute("href", " href=\"", 150, "\"", 215, 1);
#nullable restore
#line 10 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml"
WriteAttributeValue("", 157, Url.Action("Producitem", "Product", new { id = todo.Id }), 157, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml"
                                                                           Write(todo.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li> \r\n");
#nullable restore
#line 11 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Views\Shared\Components\DanhMucCon\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopV1.Models.DanhMuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591