#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Shared\Components\_DestinationStatistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca7cf28efbfb6f277ced11644c584f811d4720cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DestinationStatistic2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DestinationStatistic2/Default.cshtml")]
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
#line 1 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\_ViewImports.cshtml"
using EntityKatman.concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca7cf28efbfb6f277ced11644c584f811d4720cd", @"/Views/Shared/Components/_DestinationStatistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c9a2ccb68035b0139fa78a003e15ba2980ac919", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__DestinationStatistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-6 col-lg-4 order-1 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header"">
            <ul class=""nav nav-pills"" role=""tablist"">
                <li class=""nav-item"">
                    <button type=""button""
                            class=""nav-link active""
                            role=""tab""
                            data-bs-toggle=""tab""
                            data-bs-target=""#navs-tabs-line-card-income""
                            aria-controls=""navs-tabs-line-card-income""
                            aria-selected=""true"">
                        Income
                    </button>
                </li>
                <li class=""nav-item"">
                    <button type=""button"" class=""nav-link"" role=""tab"">Expenses</button>
                </li>
                <li class=""nav-item"">
                    <button type=""button"" class=""nav-link"" role=""tab"">Profit</button>
                </li>
            </ul>
        </div>
        <div cl");
            WriteLiteral(@"ass=""card-body px-0"">
            <div class=""tab-content p-0"">
                <div class=""tab-pane fade show active"" id=""navs-tabs-line-card-income"" role=""tabpanel"">
                    <div class=""d-flex p-4 pt-3"">
                        <div class=""avatar flex-shrink-0 me-3"">
                            <img src=""/admin-Panel/assets/img/icons/unicons/wallet.png"" alt=""User"" />
                        </div>
                        <div>
                            <small class=""text-muted d-block"">Total Balance</small>
                            <div class=""d-flex align-items-center"">
                                <h6 class=""mb-0 me-1"">$459.10</h6>
                                <small class=""text-success fw-semibold"">
                                    <i class=""bx bx-chevron-up""></i>
                                    42.9%
                                </small>
                            </div>
                        </div>
                    </div>
                    <div");
            WriteLiteral(@" id=""incomeChart""></div>
                    <div class=""d-flex justify-content-center pt-4 gap-2"">
                        <div class=""flex-shrink-0"">
                            <div id=""expensesOfWeek""></div>
                        </div>
                        <div>
                            <p class=""mb-n1 mt-1"">Expenses This Week</p>
                            <small class=""text-muted"">$39 less than last week</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
