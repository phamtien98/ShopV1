#pragma checksum "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "854cf21565b73479b4d12d9bb12bbc641f0b23ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_test), @"mvc.1.0.view", @"/Views/Product/test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854cf21565b73479b4d12d9bb12bbc641f0b23ae", @"/Views/Product/test.cshtml")]
    public class Views_Product_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopV1.Models.SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml"
  
    ViewData["Title"] = "test";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>test</h1>\r\n");
#nullable restore
#line 7 "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml"
  Write(item.TenSanpham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml"
  Write(item.GiaSanpham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\phamt\Desktop\github\ShopV1\Views\Product\test.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopV1.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
