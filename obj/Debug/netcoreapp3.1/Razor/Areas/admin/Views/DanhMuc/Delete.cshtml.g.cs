#pragma checksum "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6c8c56caecd3943b73bae121afb960edae15ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_DanhMuc_Delete), @"mvc.1.0.view", @"/Areas/admin/Views/DanhMuc/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6c8c56caecd3943b73bae121afb960edae15ff", @"/Areas/admin/Views/DanhMuc/Delete.cshtml")]
    public class Areas_admin_Views_DanhMuc_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ShopV1.Models.DanhMuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 13 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt>\r\n                ");
#nullable restore
#line 16 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
           Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </dt>\r\n");
#nullable restore
#line 18 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n");
#nullable restore
#line 21 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 26 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\phamt\Desktop\ShopV1\ShopV1\Areas\admin\Views\DanhMuc\Delete.cshtml"
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
