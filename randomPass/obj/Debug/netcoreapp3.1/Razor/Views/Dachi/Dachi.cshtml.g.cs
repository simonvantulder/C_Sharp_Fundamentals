#pragma checksum "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de68c23fcd71a1e4986436c10a7384780731cbe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dachi_Dachi), @"mvc.1.0.view", @"/Views/Dachi/Dachi.cshtml")]
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
#line 1 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\_ViewImports.cshtml"
using randomPass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\_ViewImports.cshtml"
using randomPass.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de68c23fcd71a1e4986436c10a7384780731cbe0", @"/Views/Dachi/Dachi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353a11ba7afa836b72102f9f7fe9c675401d63f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Dachi_Dachi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dachi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml"
  
    ViewData["Title"] = "Dachi Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n<h2>Happiness: ");
#nullable restore
#line 7 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml"
          Write(Model.Happiness);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h2>Fullness: ");
#nullable restore
#line 8 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml"
         Write(Model.Fullness);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h2>Energy:");
#nullable restore
#line 9 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml"
      Write(ViewBag.Energy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h2>Meals: ");
#nullable restore
#line 10 "C:\Users\kaitl\Desktop\CodingDojo\C#\randomPass\Views\Dachi\Dachi.cshtml"
      Write(Context.Session.GetInt32("Meals"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

</div>

    <button onclick=""location.href='/feed'"" role=""link"" data-href=""/"">Feed</button>
    <button onclick=""location.href='/play'"" role=""link"" data-href=""/"">Play</button>
    <button onclick=""location.href='/sleep'"" role=""link"" data-href=""/"">Sleep</button>
    <button onclick=""location.href='/work'"" role=""link"" data-href=""/"">Work</button>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dachi> Html { get; private set; }
    }
}
#pragma warning restore 1591