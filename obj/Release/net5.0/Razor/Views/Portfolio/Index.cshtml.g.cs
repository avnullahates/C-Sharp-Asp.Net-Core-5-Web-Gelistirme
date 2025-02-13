#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d69c46ac4ce26931d206b702a69cfa947c8f3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d69c46ac4ce26931d206b702a69cfa947c8f3fb", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18ab17a7bb67292d9e1e7e85f22a6afdcb3b697", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
                <h3 class=""text-white mb-0"">Projelerim</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">Proje</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Ucret</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Durum</th>
                            
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Tamamlanma Orani</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"">Duzenle</th>
                        </tr>
                    </thead>
                   ");
            WriteLiteral(" <tbody class=\"list\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <th scope=""row"">
                                    <div class=""media align-items-center"">
                                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                                            <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 1600, "\"", 1620, 1);
#nullable restore
#line 35 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1606, item.Platform, 1606, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                        <div class=\"media-body\">\r\n                                            <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 38 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </th>\r\n                                <td class=\"budget\">\r\n                                    ");
#nullable restore
#line 43 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                                <td>
                                    <span class=""badge badge-dot mr-4"">
                                        <i class=""bg-success""></i>
                                        <span class=""status"">Tamamlandı</span>
                                    </span>
                                </td>
                           
                                <td>
                                    <div class=""d-flex align-items-center"">
                                        <span class=""completion mr-2"">");
#nullable restore
#line 54 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
                                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        <div>\r\n                                            <div class=\"progress\">\r\n                                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2899, "\"", 2926, 1);
#nullable restore
#line 57 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2915, item.Value, 2915, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 2965, "\"", 2993, 3);
            WriteAttributeValue("", 2973, "width:", 2973, 6, true);
#nullable restore
#line 57 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
WriteAttributeValue(" ", 2979, item.Value, 2980, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2991, "%;", 2991, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>   \r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3227, "\"", 3278, 2);
            WriteAttributeValue("", 3234, "/Portfolio/DeletePortfolio/", 3234, 27, true);
#nullable restore
#line 62 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3261, item.PortfolioID, 3261, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3364, "\"", 3413, 2);
            WriteAttributeValue("", 3371, "/Portfolio/EditPortfolio/", 3371, 25, true);
#nullable restore
#line 63 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3396, item.PortfolioID, 3396, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn btn-outline-success\">Guncelle</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Portfolio\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<a href=\"/Portfolio/AddPortfolio\" class=\"btn btn-primary\">Yeni Proje Girisi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
