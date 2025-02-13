#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad3ccdfa7c1a3432d36745c97763cc8dd73b66e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad3ccdfa7c1a3432d36745c97763cc8dd73b66e", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18ab17a7bb67292d9e1e7e85f22a6afdcb3b697", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"" >
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Ana Görsel </th>
                                <th> Proje Adı </th>
                                <th> URL </th>
                                <th> Fiyat </th>       
                                <th> Tamamlanma </th>
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 24 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 27 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> <img");
            BeginWriteAttribute("src", " src=\"", 1103, "\"", 1123, 1);
#nullable restore
#line 28 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1109, item.ImageURL, 1109, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </td>\r\n                                    <td> ");
#nullable restore
#line 29 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 30 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.ProjectURL);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 31 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> %");
#nullable restore
#line 32 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1463, "\"", 1513, 3);
            WriteAttributeValue("", 1470, "/Portfolio/EditPortfolio/", 1470, 25, true);
#nullable restore
#line 34 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1495, item.PortfolioID, 1495, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1512, "/", 1512, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"badge badge-outline-success\">Detayları Gör</div>\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
