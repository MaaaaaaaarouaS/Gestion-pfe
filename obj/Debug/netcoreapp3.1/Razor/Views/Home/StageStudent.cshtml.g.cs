#pragma checksum "D:\Downloads\asp.netcoreauth-master\asp.netcoreauth-master\Views\Home\StageStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30a5fcb27b429262348b6c5677bba1ebedef17c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StageStudent), @"mvc.1.0.view", @"/Views/Home/StageStudent.cshtml")]
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
#line 1 "D:\Downloads\asp.netcoreauth-master\asp.netcoreauth-master\Views\_ViewImports.cshtml"
using authdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\asp.netcoreauth-master\asp.netcoreauth-master\Views\_ViewImports.cshtml"
using authdemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Downloads\asp.netcoreauth-master\asp.netcoreauth-master\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30a5fcb27b429262348b6c5677bba1ebedef17c", @"/Views/Home/StageStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a202a9644898895c92cca9a08f972f8b994c63", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StageStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<authdemo.Models.Stage>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Downloads\asp.netcoreauth-master\asp.netcoreauth-master\Views\Home\StageStudent.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30a5fcb27b429262348b6c5677bba1ebedef17c3718", async() => {
                WriteLiteral(@"    
        <div class=""mb-3"">
            <label for=""sujet"" class=""form-label"">Sujet de stage</label>
            <input type=""text"" class=""form-control"" id=""SujetStage"">
        </div>
        <div class=""mb-3"">
            <label for=""dateDebut"" class=""form-label"">Date de debut</label>
            <input type=""text"" class=""form-control"" id=""DateDebut"">
        </div>
        <div class=""mb-3"">
            <label for=""dateFin"" class=""form-label"">Date de fin</label>
            <input type=""text"" class=""form-control"" id=""DateFin"">
        </div>
        <div class=""mb-3"">
            <label for=""entreprise"" class=""form-label"">Entreprise de stage</label>
            <input type=""text"" class=""form-control"" id=""EntrepriseStage"">
        </div>  
    <button type=""submit"" class=""btn btn-primary"">Enregistrer</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<authdemo.Models.Stage> Html { get; private set; }
    }
}
#pragma warning restore 1591