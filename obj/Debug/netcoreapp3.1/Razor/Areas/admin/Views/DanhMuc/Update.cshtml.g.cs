#pragma checksum "C:\Users\phamt\Desktop\github\ShopV1\Areas\admin\Views\DanhMuc\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c32023feb3fef4caef007a798d2bc1a3386161d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_DanhMuc_Update), @"mvc.1.0.view", @"/Areas/admin/Views/DanhMuc/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c32023feb3fef4caef007a798d2bc1a3386161d0", @"/Areas/admin/Views/DanhMuc/Update.cshtml")]
    public class Areas_admin_Views_DanhMuc_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopV1.Models.DanhMuc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\phamt\Desktop\github\ShopV1\Areas\admin\Views\DanhMuc\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\phamt\Desktop\github\ShopV1\Areas\admin\Views\DanhMuc\Update.cshtml"
 using (Html.BeginForm("Update", "DanhMuc"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Name ");
#nullable restore
#line 10 "C:\Users\phamt\Desktop\github\ShopV1\Areas\admin\Views\DanhMuc\Update.cshtml"
         Write(Html.TextBoxFor(m => m.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div><input type=\"submit\" value=\"Update\" /></div>\r\n");
#nullable restore
#line 12 "C:\Users\phamt\Desktop\github\ShopV1\Areas\admin\Views\DanhMuc\Update.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopV1.Models.DanhMuc> Html { get; private set; }
    }
}
#pragma warning restore 1591
