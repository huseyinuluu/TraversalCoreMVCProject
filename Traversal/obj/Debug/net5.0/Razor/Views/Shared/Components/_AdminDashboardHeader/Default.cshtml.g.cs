#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Shared\Components\_AdminDashboardHeader\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84f27c1da3c519e32519938414ee6d7e67368d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AdminDashboardHeader_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AdminDashboardHeader/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84f27c1da3c519e32519938414ee6d7e67368d64", @"/Views/Shared/Components/_AdminDashboardHeader/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c9a2ccb68035b0139fa78a003e15ba2980ac919", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__AdminDashboardHeader_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84f27c1da3c519e32519938414ee6d7e67368d643395", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\"\r\n          content=\"width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0\" />\r\n\r\n    <title>Traversal | Admin PaneLi</title>\r\n\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 260, "\"", 270, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

    <!-- Favicon -->
    <link rel=""icon"" type=""image/x-icon"" href=""/admin-Panel/assets/img/favicon/favicon.ico"" />

    <!-- Fonts -->
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=Public+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&display=swap""
          rel=""stylesheet"" />

    <!-- Icons. Uncomment required icon fonts -->
    <link rel=""stylesheet"" href=""/admin-Panel/assets/vendor/fonts/boxicons.css"" />

    <link rel=""stylesheet"" href=""/admin-Panel/assets/vendor/css/core.css"" class=""template-customizer-core-css"" />
    <link rel=""stylesheet"" href=""/admin-Panel/assets/vendor/css/theme-default.css"" class=""template-customizer-theme-css"" />
    <link rel=""stylesheet"" href=""/admin-Panel/assets/css/demo.css"" />
    <link rel=""stylesheet"" href=""/admin-Panel/assets/vendor/libs/perfect-scrollbar/perfect-scrollba");
                WriteLiteral("r.css\" />\r\n\r\n    <link rel=\"stylesheet\" href=\"/admin-Panel/assets/vendor/libs/apex-charts/apex-charts.css\" />\r\n    <script src=\"/admin-Panel/assets/vendor/js/helpers.js\"></script>\r\n    <script src=\"/admin-Panel/assets/js/config.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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