#pragma checksum "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cea4d3ca132d6e10d02f7ba13a21db2843712e7e604e04c2f200e8e1dbeecab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Participantes), @"mvc.1.0.view", @"/Views/Home/Participantes.cshtml")]
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
#line 1 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cea4d3ca132d6e10d02f7ba13a21db2843712e7e604e04c2f200e8e1dbeecab7", @"/Views/Home/Participantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b743f8997fdbd7d778e5831cb109868d9a65173eb28b3959a8b58fdf2c6eb2e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Participantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Participantes>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br />
<br />

<div class=""container-fluid bg-light w-100 p-3"" style=""border:solid"">
    <br />
    <br />
    <h3>Lista de eventos</h3>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>ID do Convite</th>
                <th>ID do Usuario</th>
                <th>ID da Festa</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml"
                   Write(item.ConviteID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml"
                   Write(item.UsuarioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml"
                   Write(item.FestaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\ryana\OneDrive\Documentos\PROJETO01\PROJETO01\Views\Home\Participantes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Participantes>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
