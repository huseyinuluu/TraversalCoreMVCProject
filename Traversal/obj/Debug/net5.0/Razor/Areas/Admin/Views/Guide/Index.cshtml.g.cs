#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1f7e05ef836fde9c8bab38485c1b04e3f59365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using HuzurELiProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using HuzurELiProjesi.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
using EntityKatman.concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1f7e05ef836fde9c8bab38485c1b04e3f59365", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992f7fa56699449470f492cdf2ea2a251022c99a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td img{
        border-radius:50%;
    }
</style>

<h1 class=""text-center"">Yetkililer</h1>

<table class=""table text-center"">

    <tr>
        <th>#</th>
        <th>Görsel</th>
        <th>Adı Soyadı</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 27 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 30 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
              sayac = @sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 31 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 626, "\"", 643, 1);
#nullable restore
#line 32 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 632, item.Image, 632, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
              
                if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 881, "\"", 928, 2);
            WriteAttributeValue("", 888, "/Admin/Guide/ChangetoFalse/", 888, 27, true);
#nullable restore
#line 40 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 915, item.GuideID, 915, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">\r\n                            Pasif Yap\r\n                        </a>\r\n                    </td>\r\n");
#nullable restore
#line 44 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1217, 2);
            WriteAttributeValue("", 1178, "/Admin/Guide/ChangetoTrue/", 1178, 26, true);
#nullable restore
#line 48 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1204, item.GuideID, 1204, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">\r\n                            Aktif Yap\r\n                        </a>\r\n                    </td>\r\n");
#nullable restore
#line 52 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td><a href=\"/Admin/Guide/EditGuide\" class=\"btn btn-outline-success col-9 mx-auto\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide\" class=\"btn btn-outline-primary col-9 mx-auto\">Yetkili Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
