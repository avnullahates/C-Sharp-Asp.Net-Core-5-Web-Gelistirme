#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Admin\NavigationPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87e59192cf2da98d22b7a970feecfd1bf974774752a03b35322ea76c51896493"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NavigationPartial), @"mvc.1.0.view", @"/Views/Admin/NavigationPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\_ViewImports.cshtml"
using CoreProjeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\_ViewImports.cshtml"
using CoreProjeMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"87e59192cf2da98d22b7a970feecfd1bf974774752a03b35322ea76c51896493", @"/Views/Admin/NavigationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb9f156f2823993cf3577b29e1c610bfc477722fd8bac717071bd496dc97251f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_NavigationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">");
#nullable restore
#line 6 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Admin\NavigationPartial.cshtml"
                                                             Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 10 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Admin\NavigationPartial.cshtml"
                                                               Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 11 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Admin\NavigationPartial.cshtml"
                                                                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ol>\r\n                    </nav>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591