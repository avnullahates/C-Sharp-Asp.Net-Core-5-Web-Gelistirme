#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Test\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ba84656bc03604cd6309ab9963137c1df38ceda993363907e5fa3097cf7fa652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ba84656bc03604cd6309ab9963137c1df38ceda993363907e5fa3097cf7fa652", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb9f156f2823993cf3577b29e1c610bfc477722fd8bac717071bd496dc97251f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Bordered table</h4>
            <p class=""card-description"">
                Add class <code>.table-bordered</code>
            </p>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th> # </th>
                            <th> First name </th>
                            <th> Progress </th>
                            <th> Amount </th>
                            <th> Deadline </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td> 1 </td>
                            <td> Herman Beck </td>
                            <td>
                                <div class=""progress"">
                                    <div cla");
            WriteLiteral(@"ss=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $ 77.99 </td>
                            <td> May 15, 2015 </td>
                        </tr>
                        <tr>
                            <td> 2 </td>
                            <td> Messsy Adam </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $245.30 </td>
                            <td> July 1, 2015 </td>
                        </tr>
                        <tr>
                            <td> 3 </td>
                 ");
            WriteLiteral(@"           <td> John Richards </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $138.00 </td>
                            <td> Apr 12, 2015 </td>
                        </tr>
                        <tr>
                            <td> 4 </td>
                            <td> Peter Meggik </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $ 77.99 </td>
");
            WriteLiteral(@"                            <td> May 15, 2015 </td>
                        </tr>
                        <tr>
                            <td> 5 </td>
                            <td> Edward </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 35%"" aria-valuenow=""35"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $ 160.25 </td>
                            <td> May 03, 2015 </td>
                        </tr>
                        <tr>
                            <td> 6 </td>
                            <td> John Doe </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 65%"" aria-valuenow=""65"" aria-value");
            WriteLiteral(@"min=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $ 123.21 </td>
                            <td> April 05, 2015 </td>
                        </tr>
                        <tr>
                            <td> 7 </td>
                            <td> Henry Tom </td>
                            <td>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </td>
                            <td> $ 150.00 </td>
                            <td> June 16, 2015 </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

");
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