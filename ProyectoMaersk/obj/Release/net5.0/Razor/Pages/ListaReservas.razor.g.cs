#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbbd599ba4cc108b2ef0ecdcb9d79dbb44c789b"
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
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlankLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaReservas")]
    public partial class ListaReservas : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(3, "<h1><div class=\"d-flex p-2 bd-highlight bg-secondary\">Reporte general de Reservas</div>\r\n        <br></h1>\r\n\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-sm");
            __builder.AddMarkupContent(6, @"<thead><tr class=""bg-primary""><th>Codigo</th>
                <th>Empresa</th>
                <th>Número Tributario</th>
                <th>Direccion</th>
                <th>Puerto Origen</th>
                <th>Pais Origen</th>
                <th>Hora de salida</th>
                <th>Puerto Destino</th>
                <th>Pais Destino</th>
                <th>Hora de llegada</th>
                <th>Receptor de la carga</th>
                <th>Contraseña de Recepcion</th>
                <th>Tipo de Carga</th>
                <th>Descripcion de la Carga</th>
                <th>Peso</th>
                <th>Valor</th>
                <th>Tipo Contenedor</th>
                <th></th>
                <th></th>
                <th></th>
                <th></th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 60 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
             foreach (var reserva in reservas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 64 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 65 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 66 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Nit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 67 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 68 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Nombre_Puerto_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 69 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Pais_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 70 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Hora_Salida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 71 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Nombre_Puerto_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 72 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Pais_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 73 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Hora_Llegada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 74 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Receptor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 75 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Contraseña_Recepcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, " \r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 76 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Tipo_Carga

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 77 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 78 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Peso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 79 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 80 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                         reserva.Tipo_Contenedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
 
    //nueva lista con los datos de la clase Reservas
    private List<Reserva> reservas = new List<Reserva>();

    public void lee_reservas()
    {
        reservas.Clear(); //limpiando el campo de reservas para que los valores no se vayan acumulando
        String connString = config.GetConnectionString("MySqlNaviera"); //variable de conexión a la base
        using var connection = new MySqlConnection(connString);
        {
            connection.Open(); //abriendo la conección a la base de datos, si xampp no está abierto no funciona 

            string q = "SELECT * FROM reserva_contenedor"; //selección de lo que q vaya a devolver

            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader(); //devuelve un objeto para poder hacer consultas, en este caso q
            while (reader.Read())
            {
                var reserva = new Reserva();
                reserva.Id = (int)reader["id"];
                reserva.Codigo = reader["Codigo_contenedor"].ToString();
                reserva.Empresa = reader["Empresa"].ToString();
                reserva.Nit = reader["Nit"].ToString();
                reserva.Direccion = reader["Direccion"].ToString();
                reserva.Puerto_Origen = reader["Puerto_Origen"].ToString();
                reserva.Pais_Origen = reader["Pais_Origen"].ToString();
                reserva.Hora_Salida = ((DateTime)reader["Hora_Salida"]).ToString("dd/MM/yyyy hh:mm tt"); //convierte lo que la base de datos trae a tipo DateTime de C# y le aplica el formato
                reserva.Puerto_Destino = reader["Puerto_Destino"].ToString();
                reserva.Pais_Destino = reader["Pais_Destino"].ToString();
                reserva.Hora_Llegada = ((DateTime)reader["Hora_Llegada"]).ToString("dd/MM/yyyy hh:mm tt");
                reserva.Receptor = reader["Receptor"].ToString();
                reserva.Contraseña_Recepcion = reader["Contraseña_Recepcion"].ToString();
                reserva.Tipo_Carga = reader["Tipo_Carga"].ToString();
                reserva.Descripcion = reader["Descripcion_carga"].ToString();
                reserva.Peso = reader["Peso_carga"].ToString();
                reserva.Valor = reader["Valor_carga"].ToString();
                reserva.Tipo_Contenedor = reader["Tipo_Contenedor"].ToString();
                reservas.Add(reserva);

                //para que aparezca el nombre del puerto y no el código
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
        }
    }

    protected override void OnInitialized() //inicializando la lectura de los datos
    {
        lee_reservas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
