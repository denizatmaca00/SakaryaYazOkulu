#pragma checksum "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b56e9239a486ee7d6791d6a83979514a7e7396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateAnimal), @"mvc.1.0.view", @"/Views/Admin/CreateAnimal.cshtml")]
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
#line 1 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\_ViewImports.cshtml"
using SakaryaYazOkulu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\_ViewImports.cshtml"
using SakaryaYazOkulu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b56e9239a486ee7d6791d6a83979514a7e7396", @"/Views/Admin/CreateAnimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8fd94f3f6a216b4d235cbd43d7178724724039", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CreateAnimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Animal>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
      
    ViewBag.Title = "CreateAnimal";
    Layout = "~/Views/Shared/_Layout.cshtml";
    // Burada sadece listeliyor addını yanlış yazdım ekleme işlemleri RealCreate classımda

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\" \">\r\n    <br />\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Adı</th>\r\n        <th>Yaşı</th>\r\n        <th>Türü</th>\r\n        <th>Cinsiyeti</th>\r\n        <th>Sahipli Mi?</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
     foreach( var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n        <th>");
#nullable restore
#line 21 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.AnimalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 22 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 23 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.Old);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 24 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 25 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.IsBoy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 26 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
       Write(x.IsOwned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\deniz.atmaca\source\repos\SakaryaYazOkulu\SakaryaYazOkulu\Views\Admin\CreateAnimal.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Admin/RealCreate/\" class=\"btn btn-primary\"> Hayvan Eklemek İçin Tıklayınız.</a>\r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Animal>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
