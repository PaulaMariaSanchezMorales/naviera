#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98d95ed9dcda27c088304ed0c69b92b333f73607"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoMaersk.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlankLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaReservasIndividual")]
    public partial class ListaReservasIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddAttribute(1, "onload", "window.print()");
            __builder.AddMarkupContent(2, @"<div class=""row""><div class=""col-sm-4 mb-3""><img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Maersk_Group_Logo.svg/1280px-Maersk_Group_Logo.svg.png"" class=""img-fluid"" width=""500"" height=""400"">
            <br>
            <br></div>
        <div class=""col-sm-8 mb-3""><br>
            <br>
            <div class=""d-flex p-3 bd-highlight bg-tertiary""></div></div></div>

    ");
            __builder.AddMarkupContent(3, "<h1><div class=\"d-flex p-2 bd-highlight bg-secondary\">Reporte individual de Reservas</div>\r\n        <br></h1>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"codigo\" class=\"font-weight-bold\">Codigo: </label>\r\n            ");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "id", "codigo");
            __builder.AddContent(11, 
#nullable restore
#line 34 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                reserva.Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label for=\"empresa\" class=\"font-weight-bold\">Empresa: </label>\r\n            ");
            __builder.OpenElement(16, "label");
            __builder.AddAttribute(17, "id", "empresa");
            __builder.AddContent(18, 
#nullable restore
#line 38 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                 reserva.Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "<label for=\"nit\" class=\"font-weight-bold\">Numero Id. Tributaria: </label>\r\n            ");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "id", "nit");
            __builder.AddContent(25, 
#nullable restore
#line 42 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                             reserva.Nit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "<label for=\"direccion\" class=\"font-weight-bold\">Direccion: </label>\r\n            ");
            __builder.OpenElement(30, "label");
            __builder.AddAttribute(31, "id", "direccion");
            __builder.AddContent(32, 
#nullable restore
#line 46 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                   reserva.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "<label for=\"paisorigen\" class=\"font-weight-bold\">Pais Origen: </label>\r\n            ");
            __builder.OpenElement(37, "label");
            __builder.AddContent(38, 
#nullable restore
#line 50 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                    reserva.Pais_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "<label for=\"puertoorigen\" class=\"font-weight-bold\">Puerto Origen: </label>\r\n            ");
            __builder.OpenElement(43, "label");
            __builder.AddContent(44, 
#nullable restore
#line 54 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                    reserva.Puerto_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.AddMarkupContent(48, "<label for=\"horasalida\" class=\"font-weight-bold\">Fecha y hora de salida: </label>\r\n            ");
            __builder.OpenElement(49, "label");
            __builder.AddContent(50, 
#nullable restore
#line 58 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                    reserva.Hora_Salida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "<label for=\"paisdestino\" class=\"font-weight-bold\">Pais Destino: </label>\r\n            ");
            __builder.OpenElement(55, "label");
            __builder.AddContent(56, 
#nullable restore
#line 62 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                    reserva.Pais_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group");
            __builder.AddMarkupContent(60, "<label for=\"puertodestino\" class=\"font-weight-bold\">Puerto Destino: </label>\r\n            ");
            __builder.OpenElement(61, "label");
            __builder.AddContent(62, 
#nullable restore
#line 66 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                    reserva.Puerto_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "<label for=\"horallegada\" class=\"font-weight-bold\">Fecha y hora de llegada: </label>\r\n            ");
            __builder.OpenElement(67, "label");
            __builder.AddAttribute(68, "id", "horallegada");
            __builder.AddContent(69, 
#nullable restore
#line 70 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                     reserva.Hora_Llegada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "<label for=\"receptor\" class=\"font-weight-bold\">Receptor de la Carga: </label>\r\n            ");
            __builder.OpenElement(74, "label");
            __builder.AddAttribute(75, "id", "receptor");
            __builder.AddContent(76, 
#nullable restore
#line 74 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                  reserva.Receptor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group");
            __builder.AddMarkupContent(80, "<label for=\"contrasenia\" class=\"font-weight-bold\">Contrase??a de Recepcion: </label>\r\n            ");
            __builder.OpenElement(81, "label");
            __builder.AddAttribute(82, "id", "contrasenia");
            __builder.AddContent(83, 
#nullable restore
#line 78 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                     reserva.Contrase??a_Recepcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-group");
            __builder.AddMarkupContent(87, "<label for=\"tipocarga\" class=\"font-weight-bold\">Tipo de Carga: </label>\r\n            ");
            __builder.OpenElement(88, "label");
            __builder.AddAttribute(89, "id", "tipocarga");
            __builder.AddContent(90, 
#nullable restore
#line 82 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                   reserva.Tipo_Carga

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "form-group");
            __builder.AddMarkupContent(94, "<label for=\"descripcion\" class=\"font-weight-bold\">Descripcion de la carga: </label>\r\n            ");
            __builder.OpenElement(95, "label");
            __builder.AddAttribute(96, "id", "descripcion");
            __builder.AddContent(97, 
#nullable restore
#line 86 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                     reserva.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group");
            __builder.AddMarkupContent(101, "<label for=\"peso\" class=\"font-weight-bold\">Peso en Kg: </label>\r\n            ");
            __builder.OpenElement(102, "label");
            __builder.AddAttribute(103, "id", "peso");
            __builder.AddContent(104, 
#nullable restore
#line 90 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                              reserva.Peso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-group");
            __builder.AddMarkupContent(108, "<label for=\"valor\" class=\"font-weight-bold\">Valor de la carga: </label>\r\n            ");
            __builder.OpenElement(109, "label");
            __builder.AddAttribute(110, "id", "valor");
            __builder.AddContent(111, 
#nullable restore
#line 94 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                               reserva.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form-group");
            __builder.AddMarkupContent(115, "<label for=\"tipocontenedor\" class=\"font-weight-bold\">Tipo de Contenedor: </label>\r\n            ");
            __builder.OpenElement(116, "label");
            __builder.AddAttribute(117, "id", "tipocontenedor");
            __builder.AddContent(118, 
#nullable restore
#line 98 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
                                        reserva.Tipo_Contenedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservasIndividual.razor"
 
    int Id = 0;
    Reserva reserva = new Reserva();

    List<Pais> Paises_Origen = new List<Pais>(); //listado de los pa??ses existentes
    List<Pais> Paises_Destino = new List<Pais>();

    List<Puerto> Puertos_Origen = new List<Puerto>();
    List<Puerto> Puertos_Destino = new List<Puerto>();

    List<Tipo_carga> Tipo_Carga = new List<Tipo_carga>();

    List<Valor> Valores = new List<Valor>();

    List<Tipo_contenedor> Tipo_Contenedores = new List<Tipo_contenedor>();

    //inicializando conexi??n a la base de datos validando el ID, para realizar el registro dependiendo de ??l
    protected override void OnInitialized()
    {
        var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Id", out var param))
        {
            String parametro = param.First();
            if (parametro != null)
            {
                Int32.TryParse(parametro, out Id);
            }
        }

        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString); //variable de conexi??n a la base
        {
            connection.Open(); //abriendo la conexi??n a la base de datos, si xampp no est?? abierto no funciona
            String q = "SELECT * FROM reserva_contenedor where id = '" + Id + "';";

            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                reserva.Id = (int)reader["id"];
                reserva.Codigo = reader["Codigo_contenedor"].ToString();
                reserva.Empresa = reader["Empresa"].ToString();
                reserva.Nit = reader["Nit"].ToString();
                reserva.Direccion = reader["Direccion"].ToString();
                reserva.Puerto_Origen = reader["Puerto_Origen"].ToString();
                reserva.Pais_Origen = reader["Pais_Origen"].ToString();
                reserva.Hora_Salida = reader["Hora_Salida"].ToString();
                reserva.Puerto_Destino = reader["Puerto_Destino"].ToString();
                reserva.Pais_Destino = reader["Pais_Destino"].ToString();
                reserva.Hora_Llegada = reader["Hora_Llegada"].ToString();
                reserva.Receptor = reader["Receptor"].ToString();
                reserva.Contrase??a_Recepcion = reader["Contrase??a_Recepcion"].ToString();
                reserva.Tipo_Carga = reader["Tipo_Carga"].ToString();
                reserva.Descripcion = reader["Descripcion_carga"].ToString();
                reserva.Peso = reader["Peso_carga"].ToString();
                reserva.Valor = reader["Valor_carga"].ToString();
                reserva.Tipo_Contenedor = reader["Tipo_Contenedor"].ToString();
            }
        }

        //para que aparezca el nombre del puerto y no el c??digo
        using var connectionPO = new MySqlConnection(connString);
        {
            connectionPO.Open();

            string qPO = "SELECT * FROM puertos where codigo = '" + reserva.Puerto_Origen + "'";
            using var commandPO = new MySqlCommand(qPO, connectionPO);
            using var readerPO = commandPO.ExecuteReader(); //devuelve un objeto para poder hacer consultas, en este caso q
            if (readerPO.Read())
            {
                reserva.Nombre_Puerto_Origen = readerPO["nombre"].ToString();
            }
        }

        using var connectionPD = new MySqlConnection(connString);
        {
            connectionPD.Open();

            string qPD = "SELECT * FROM puertos where codigo = '" + reserva.Puerto_Destino + "'";
            using var commandPD = new MySqlCommand(qPD, connectionPD);
            using var readerPD = commandPD.ExecuteReader(); //devuelve un objeto para poder hacer consultas, en este caso q
            if (readerPD.Read())
            {
                reserva.Nombre_Puerto_Destino = readerPD["nombre"].ToString();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
