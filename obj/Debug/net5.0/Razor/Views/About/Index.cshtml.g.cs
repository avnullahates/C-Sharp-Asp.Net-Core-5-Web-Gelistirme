#pragma checksum "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "caa44df2d510492085229bebadd35195aa0c2faea5c7af40c6e24a96171f679a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"caa44df2d510492085229bebadd35195aa0c2faea5c7af40c6e24a96171f679a", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb9f156f2823993cf3577b29e1c610bfc477722fd8bac717071bd496dc97251f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.About>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
 using (Html.BeginForm("Index", "About", FormMethod.Post))
{


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
Write(Html.HiddenFor(x => x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n\r\n                \r\n                <h4 class=\"card-title\">Hakkımda Duzenle Sayfası</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caa44df2d510492085229bebadd35195aa0c2faea5c7af40c6e24a96171f679a5025", async() => {
                WriteLiteral("\r\n                    <br />\r\n                    <label>Baslık</label>\r\n                    ");
#nullable restore
#line 21 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <br />\r\n                    <label>Yas</label>\r\n                    ");
#nullable restore
#line 25 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n\r\n                    <label>Mail</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n\r\n                    <label>Telefon</label>\r\n                    ");
#nullable restore
#line 33 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n\r\n                    <label>Adres</label>\r\n                    ");
#nullable restore
#line 37 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n\r\n                    <label>Gorsel Yolu</label>\r\n                    ");
#nullable restore
#line 41 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n\r\n                    <label>Aciklama</label>\r\n                    ");
#nullable restore
#line 45 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"
               Write(Html.TextAreaFor(x => x.Description, 10, 2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-success\">Kaydet</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\pana_\Desktop\Udemy\CoreProjeMVC\CoreProjeMVC\Views\About\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591