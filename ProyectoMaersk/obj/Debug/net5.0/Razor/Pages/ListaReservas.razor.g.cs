#pragma checksum "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9491330ff1a968efb144eb6af3616123aaac295a"
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
#line 1 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
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
            __builder.AddMarkupContent(2, "<h4 class=\"text-center\">Reporte General de Reservas</h4>\r\n\r\n        ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-sm");
            __builder.AddMarkupContent(5, @"<thead><tr class=""bg-primary""><th>Codigo</th>
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
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 40 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                 foreach (var reserva in reservas)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 44 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                        ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 45 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 46 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Nit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 47 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 48 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Puerto_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 49 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Pais_Origen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 50 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Hora_Salida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Puerto_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Pais_Destino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 53 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Hora_Llegada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 54 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Receptor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 55 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Contraseña_Recepcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, " \r\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 56 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Tipo_Carga

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 57 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 58 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Peso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 59 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 60 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
                             reserva.Tipo_Contenedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
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
#line 68 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ListaReservas.razor"
 
        private List<Reserva> reservas = new List<Reserva>();

        public void lee_reservas()
        {
            reservas.Clear();
            String connString = config.GetConnectionString("MySqlNaviera");
            using var connection = new MySqlConnection(connString);
            {
                connection.Open();

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