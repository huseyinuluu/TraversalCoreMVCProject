#pragma checksum "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d87a3e410f4ffc417744fdae4fb12706932549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d87a3e410f4ffc417744fdae4fb12706932549", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c9a2ccb68035b0139fa78a003e15ba2980ac919", @"/Views/_ViewImports.cshtml")]
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityKatman.concrete.Destination>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d87a3e410f4ffc417744fdae4fb127069325493831", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Rotalar | Rotalar</title>
    <!-- google fonts -->
    <link href=""//fonts.googleapis.com/css2?family=Montserrat:wght@300;400;600;700&display=swap"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css2?family=Lato:ital,wght@0,300;0,400;0,700;1,400&display=swap""
          rel=""stylesheet"">
    <!-- google fonts -->
    <!-- Template CSS -->
    <link rel=""stylesheet"" href=""/HuzurELi2/assets/css/style-huzureli.css"">
    <!-- Template CSS -->
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d87a3e410f4ffc417744fdae4fb127069325495444", async() => {
                WriteLiteral(@"

    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Rota Detayları</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index/"">Anasayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rota Detayları </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--/blog-->
    <div class=""py-5 w3l-homeblock1 text-center"">
        <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Your Blog Posts are Boring? Here are 9 Tips for
                Making your Writing more Interesting
            </h3>
            <div class=""blog-post-align"">
                <div class=""blog-post-img"">
                    <a href=""#""><img");
                BeginWriteAttribute("src", " src=\"", 1845, "\"", 1869, 1);
#nullable restore
#line 48 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 1851, Model.Guide.Image, 1851, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1870, "\"", 1876, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\" /></a>\r\n                </div>\r\n                <div class=\"blog-post-info\">\r\n                    <div class=\"author align-items-center mb-1\">\r\n                        <a href=\"#\">");
#nullable restore
#line 52 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> in <a href=\"#url\">Traversal</a>\r\n                    </div>\r\n                    <ul class=\"blog-meta\">\r\n                        <li class=\"meta-item blog-lesson\">\r\n                            <span class=\"meta-value\"> ");
#nullable restore
#line 56 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
                                                  Write(((DateTime)Model.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                        </li>
                        <li class=""meta-item blog-students"">
                            <span class=""meta-value""> 6min read</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <section class=""blog-post-main w3l-homeblock1"">
        <!--/blog-post-->
        <div class=""blog-content-inf pb-5"">
            <div class=""container pb-lg-4"">
                <div class=""single-post-image"">
                    <div class=""post-content"">
                        <img src=""/HuzurELi2/assets/images/huzuruneli2.jpg"" class=""radius-image img-fluid mb-5""");
                BeginWriteAttribute("alt", " alt=\"", 3064, "\"", 3070, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"single-post-content\">\r\n                    <p class=\"alphabet mb-4\">\r\n                        <span class=\"big-letter\">A</span>");
#nullable restore
#line 77 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
                                                    Write(Model.Descriptions);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>
                    <blockquote class=""blockquote my-5"">
                        <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                        İstanbul Huzur evi Kolay ve imkanı Bol
                        <footer class=""blockquote-footer mt-3"">
                            Smith lara
                        </footer>
                    </blockquote>
                    <div class=""sing-post-thumb mb-5 row pt-3"">
                        <div class=""col-sm-6"">
                            <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 3900, "\"", 3918, 1);
#nullable restore
#line 88 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3906, Model.Image, 3906, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:330px; height:330px\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3984, "\"", 3990, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                        <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                            <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 4138, "\"", 4157, 1);
#nullable restore
#line 91 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 4144, Model.Image2, 4144, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:330px; height:330px\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 4223, "\"", 4229, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n                    <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\">Rota Yorumları</h3>\r\n                    <p class=\"mb-4\">\r\n");
                WriteLiteral(@"                    </p>

                  

                    <div class=""author-card mt-5"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-3 col-6"">
                                <div>
                                    <img");
                BeginWriteAttribute("src", " src=\"", 4765, "\"", 4789, 1);
#nullable restore
#line 105 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 4771, Model.Guide.Image, 4771, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4790, "\"", 4796, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n                                <h3 class=\"mb-3 title\">");
#nullable restore
#line 109 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
                                                  Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 110 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
                              Write(Model.Guide.Description2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                <ul class=""author-icons mt-4"">
                                    <li>
                                        <a class=""facebook"" href=""#url"">
                                            <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""twitter"" href=""#url"">
                                            <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""google"" href=""#url"">
                                            <span class=""fa fa-google-plus""
                                                  a");
                WriteLiteral(@"ria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""linkedin"" href=""#url"">
                                            <span class=""fa fa-linkedin""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""github"" href=""#url"">
                                            <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""dribbble"" href=""#url"">
                                            <span class=""fa fa-dribbble""
        ");
                WriteLiteral(@"                                          aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>


                    <!--//author-card-->


                    ");
#nullable restore
#line 157 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("_CommentList", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 159 "C:\Users\Giresun\Desktop\yayın\Traversal\Traversal\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml", new { id = ViewBag.destID }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                </div>
            </div>
        </div> <!--//blog-post-->
    </section>

    <!--/w3l-footer-29-main-->
    <!-- Template JavaScript -->
    <script src=""/HuzurELi2/assets/js/jquery-3.3.1.min.js""></script>
    <script src=""/HuzurELi2/assets/js/theme-change.js""></script>
    <!--/MENU-JS-->
    <script>
        $(window).on(""scroll"", function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 80) {
                $(""#site-header"").addClass(""nav-fixed"");
            } else {
                $(""#site-header"").removeClass(""nav-fixed"");
            }
        });

        //Main navigation Active Class Add Remove
        $("".navbar-toggler"").on(""click"", function () {
            $(""header"").toggleClass(""active"");
        });
        $(document).on(""ready"", function () {
            if ($(window).width() > 991) {
                $(""header"").removeClass(""active"");
            }
            $(window).on(""resize"", function () {
     ");
                WriteLiteral(@"           if ($(window).width() > 991) {
                    $(""header"").removeClass(""active"");
                }
            });
        });
    </script>
    <!--//MENU-JS-->

    <script src=""/HuzurELi2/assets/js/bootstrap.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityKatman.concrete.Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591