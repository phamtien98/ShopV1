#pragma checksum "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0c617667821020e5fb61357c38b3af7b64519c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Test_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0c617667821020e5fb61357c38b3af7b64519c", @"/Areas/admin/Views/Test/Index.cshtml")]
    public class Areas_admin_Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ShopV1.Models.DanhMuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 10 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml"
    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 11 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml"
    Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\Test\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ShopV1.Models.DanhMuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
