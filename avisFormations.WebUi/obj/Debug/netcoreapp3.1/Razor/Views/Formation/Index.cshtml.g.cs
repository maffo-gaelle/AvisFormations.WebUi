#pragma checksum "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\Formation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fddd4244c044f5721b6a23dbd290c51ef204b2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formation_Index), @"mvc.1.0.view", @"/Views/Formation/Index.cshtml")]
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
#line 1 "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\_ViewImports.cshtml"
using avisFormations.WebUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\_ViewImports.cshtml"
using avisFormations.WebUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fddd4244c044f5721b6a23dbd290c51ef204b2c1", @"/Views/Formation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f8f4ef2d22e29e7fec84e4f3d92d0586a2ea17", @"/Views/_ViewImports.cshtml")]
    public class Views_Formation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToutesLesFormationsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\Formation\Index.cshtml"
        
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n<p>");
#nullable restore
#line 9 "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\Formation\Index.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>CCeci est la valeur passée : ");
#nullable restore
#line 10 "C:\Users\gaell\source\repos\avisFormations.WebUi\avisFormations.WebUi\Views\Formation\Index.cshtml"
                           Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToutesLesFormationsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591