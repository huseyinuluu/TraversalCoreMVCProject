#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aaaa603f7d3884c3709e4db59db02c921abcd21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
using EntityKatman.concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aaaa603f7d3884c3709e4db59db02c921abcd21", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992f7fa56699449470f492cdf2ea2a251022c99a", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Aktif Rotalar</h4>
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
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aaaa603f7d3884c3709e4db59db02c921abcd215690", async() => {
                WriteLiteral("\r\n                        <p class=\"card-text\">\r\n\r\n                            <div>\r\n                                <p>\r\n                                    Aranacak Kelime: <input type=\"text\" name=\"searcString\"");
                BeginWriteAttribute("value", " value=\"", 1336, "\"", 1370, 1);
#nullable restore
#line 32 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1344, ViewData["CurrentFilter"], 1344, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"submit\" name=\"name\" value=\"Ara\" class=\"btn btn-outline-info\" />\r\n                                </p>\r\n                            </div>\r\n                        </p>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <p><span class=""text-bold-600"">Example 1:</span> Table with outer spacing</p>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr class=""text-center"">
                                    <th>#</th>
                                    <th>Şehir</th>
                                    <th>İlçe</th>
                                    <th>Kapasite</th>
                                    <th>Detay</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 52 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"text-center\">\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.DayTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2756, "\"", 2814, 2);
            WriteAttributeValue("", 2763, "/Destination/DestinationDetails/", 2763, 32, true);
#nullable restore
#line 59 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
WriteAttributeValue("", 2795, item.DestinationID, 2795, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Areas\Member\Views\Destination\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
