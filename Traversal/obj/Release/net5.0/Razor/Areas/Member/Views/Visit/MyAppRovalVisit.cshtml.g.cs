#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fd1ac57610bad668f08e67a110f4569fbceb51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Visit_MyAppRovalVisit), @"mvc.1.0.view", @"/Areas/Member/Views/Visit/MyAppRovalVisit.cshtml")]
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
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\_ViewImports.cshtml"
using HuzurELiProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\_ViewImports.cshtml"
using HuzurELiProjesi.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
using EntityKatman.concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fd1ac57610bad668f08e67a110f4569fbceb51", @"/Areas/Member/Views/Visit/MyAppRovalVisit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992f7fa56699449470f492cdf2ea2a251022c99a", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Visit_MyAppRovalVisit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Visit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
  
    ViewData["Title"] = "MyAppRovalVisit";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Onay Bekleyen Rotalar</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                        <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <p class=""card-text"">Using the most basic table markup, here’s how <code>.table</code>-based tables l");
            WriteLiteral(@"ook in Bootstrap. You can use any example of below table for your table and it can be use with any type of bootstrap tables. </p>
                    <p><span class=""text-bold-600"">Example 1:</span> Table with outer spacing</p>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Şehir</th>
                                    <th>Kişi Sayısı</th>
                                    <th>Ziyaret Tarihi</th>
                                    <th>Durum</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 41 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                 foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 47 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                       Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 48 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                       Write(item.VisitDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 49 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Visit\MyAppRovalVisit.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Visit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
