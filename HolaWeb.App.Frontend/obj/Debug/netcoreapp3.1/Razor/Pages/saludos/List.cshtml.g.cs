#pragma checksum "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "396f14ebc831a8df262bc24d40ca17b017865c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolaWeb.App.Frontend.Pages.saludos.Pages_saludos_List), @"mvc.1.0.razor-page", @"/Pages/saludos/List.cshtml")]
namespace HolaWeb.App.Frontend.Pages.saludos
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
#line 1 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\_ViewImports.cshtml"
using HolaWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396f14ebc831a8df262bc24d40ca17b017865c24", @"/Pages/saludos/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da21e6eb861da2e3f9fd1f81e5c9e01edd2af728", @"/Pages/_ViewImports.cshtml")]
    public class Pages_saludos_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Saludos en Varios Idiomas</h1>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 7 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml"
     foreach (var saludo in Model.Saludos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml"
           Write(saludo.EnEspanol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml"
           Write(saludo.EnIngles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml"
           Write(saludo.EnItaliano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n");
            WriteLiteral("           \r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\HolaWeb\HolaWeb.App\holaweb.app.frontend\Pages\saludos\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HolaWeb.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public HolaWeb.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
