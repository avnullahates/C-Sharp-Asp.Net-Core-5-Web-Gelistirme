#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f418dc43fe38127f8d5f9b901b28322eabc0b2fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterLayout), @"mvc.1.0.view", @"/Views/Shared/_WriterLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f418dc43fe38127f8d5f9b901b28322eabc0b2fe", @"/Views/Shared/_WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18ab17a7bb67292d9e1e7e85f22a6afdcb3b697", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f418dc43fe38127f8d5f9b901b28322eabc0b2fe3706", async() => {
                WriteLiteral("\r\n    <div class=\"container-scroller\">\r\n\r\n        <!-- partial:~/skydash/partials/_navbar.html -->\r\n        ");
#nullable restore
#line 15 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_NavBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- partial -->\r\n        <div class=\"container-fluid page-body-wrapper\">\r\n\r\n            <!-- partial:~/skydash/partials/_sidebar.html -->\r\n            ");
#nullable restore
#line 21 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
       Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_SideBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- partial -->\r\n            <div class=\"main-panel\">\r\n                <div class=\"content-wrapper\">\r\n\r\n\r\n                    ");
#nullable restore
#line 27 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n                <!-- content-wrapper ends -->\r\n                <!-- partial:~/skydash/partials/_footer.html -->\r\n                ");
#nullable restore
#line 32 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
           Write(await Html.PartialAsync("/Areas/Writer/Views/Default/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- partial -->\r\n            </div>\r\n            <!-- main-panel ends -->\r\n        </div>\r\n        <!-- page-body-wrapper ends -->\r\n    </div>\r\n    <!-- container-scroller -->\r\n    ");
#nullable restore
#line 40 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
