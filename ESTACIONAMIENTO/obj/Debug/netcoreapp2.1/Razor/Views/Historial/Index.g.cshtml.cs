#pragma checksum "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3114df6bfe623bd22fb162dedfed7ab91ccc218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Historial_Index), @"mvc.1.0.view", @"/Views/Historial/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Historial/Index.cshtml", typeof(AspNetCore.Views_Historial_Index))]
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
#line 1 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot;

#line default
#line hidden
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3114df6bfe623bd22fb162dedfed7ab91ccc218", @"/Views/Historial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_Historial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 480, true);
            WriteLiteral(@"<div>

    <!-- Nav tabs -->
    <ul class=""nav nav-tabs"" role=""tablist"">
        <li role=""presentation"" class=""active""><a href=""#reservastab"" aria-controls=""home"" role=""tab"" data-toggle=""tab"">Reservas</a></li>
        <li role=""presentation""><a href=""#pagostab"" aria-controls=""profile"" role=""tab"" data-toggle=""tab"">Pagos</a></li>

    </ul>

    <!-- Tab panes -->
    <div class=""tab-content"">
        <div role=""tabpanel"" class=""tab-pane active"" id=""reservastab"">
");
            EndContext();
#line 17 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
             foreach (var reserva in ViewBag.Reservas)
            {

#line default
#line hidden
            BeginContext(580, 98, true);
            WriteLiteral("                <div>\r\n                    <div>\r\n                        <label>Estacionamiento: ");
            EndContext();
            BeginContext(679, 25, false);
#line 21 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                           Write(reserva.IdEstacionamiento);

#line default
#line hidden
            EndContext();
            BeginContext(704, 114, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Horas reservadas: ");
            EndContext();
            BeginContext(819, 13, false);
#line 24 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                            Write(reserva.NHora);

#line default
#line hidden
            EndContext();
            BeginContext(832, 103, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Fecha: ");
            EndContext();
            BeginContext(936, 36, false);
#line 27 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                 Write(reserva.Fecha.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(972, 86, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
            EndContext();
#line 31 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1073, 78, true);
            WriteLiteral("        </div>\r\n        <div role=\"tabpanel\" class=\"tab-pane\" id=\"pagostab\">\r\n");
            EndContext();
#line 34 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
             foreach (var pago in ViewBag.Pagos)
            {

#line default
#line hidden
            BeginContext(1216, 98, true);
            WriteLiteral("                <div>\r\n                    <div>\r\n                        <label>Estacionamiento: ");
            EndContext();
            BeginContext(1315, 22, false);
#line 38 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                           Write(pago.IdEstacionamiento);

#line default
#line hidden
            EndContext();
            BeginContext(1337, 103, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Fecha: ");
            EndContext();
            BeginContext(1441, 33, false);
#line 41 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                 Write(pago.Fecha.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 103, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Horas: ");
            EndContext();
            BeginContext(1578, 11, false);
#line 44 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                 Write(pago.NHoras);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 105, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Tarjeta: ");
            EndContext();
            BeginContext(1695, 14, false);
#line 47 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
                                   Write(pago.IdTarjeta);

#line default
#line hidden
            EndContext();
            BeginContext(1709, 86, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
            EndContext();
#line 51 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\Historial\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1810, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
