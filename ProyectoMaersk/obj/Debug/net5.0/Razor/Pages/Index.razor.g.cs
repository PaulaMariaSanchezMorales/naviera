#pragma checksum "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d535604bc755b269f1a6b36ed9ab203d04b92c91"
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
#line 1 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1>Reservas</h1>\r\n\r\n        ");
                __builder2.AddMarkupContent(3, "<p>Listado de reservas</p>\r\n\r\n        ");
                __builder2.AddMarkupContent(4, @"<div class=""row""><div class=""col-8 mb-3""><a class=""btn btn-secondary text-dark"" href=""ReservasEditar"" role=""button"">Agregar</a></div>
            <div class=""col-4 mb-3""><form class=""form-inline""><div class=""form-group""><button class=""btn btn-secondary"" href=""#"" role=""button""><i class=""oi oi-magnifying-glass text-dark""></i></button>
                        <input type=""text"" class=""form-control"" id=""textobuscar"" placeholder=""Buscar""></div></form></div></div>
        ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-sm");
                __builder2.AddMarkupContent(7, @"<thead><tr class=""bg-primary""><th>ID</th>
                    <th>Codigo</th>
                    <th>Empresa</th>
                    <th>Número Tributario</th>
                    <th>Direccion</th>
                    <th>Puerto Origen</th>
                    <th>Pais Origen</th>
                    <th>Puerto Destino</th>
                    <th>Pais Destino</th>
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
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 57 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                 foreach (var reserva in reservas)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.AddContent(11, 
#nullable restore
#line 60 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n                        ");
                __builder2.OpenElement(13, "td");
                __builder2.AddContent(14, 
#nullable restore
#line 61 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Codigo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 62 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Empresa

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 63 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Nit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 64 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 65 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Puerto_Origen

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 66 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Pais_Origen

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 67 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Puerto_Destino

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 68 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Pais_Destino

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 69 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Receptor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.OpenElement(40, "td");
                __builder2.AddContent(41, 
#nullable restore
#line 70 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Contraseña_Recepcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "td");
                __builder2.AddContent(44, 
#nullable restore
#line 71 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Tipo_Carga

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.AddContent(47, 
#nullable restore
#line 72 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "td");
                __builder2.AddContent(50, 
#nullable restore
#line 73 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Peso

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "td");
                __builder2.AddContent(53, 
#nullable restore
#line 74 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Valor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.OpenElement(55, "td");
                __builder2.AddContent(56, 
#nullable restore
#line 75 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Tipo_Contenedor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.AddMarkupContent(58, "<td><button class=\"btn btn-secondary text-dark\" href=\"#\" role=\"button\"><i class=\"oi oi-document text-dark\"></i></button></td>\r\n                        ");
                __builder2.AddMarkupContent(59, "<td><button class=\"btn btn-secondary text-dark\" href=\"#\" role=\"button\"><i class=\"oi oi-data-transfer-download text-dark\"></i></button></td>\r\n                        ");
                __builder2.OpenElement(60, "td");
                __builder2.OpenElement(61, "a");
                __builder2.AddAttribute(62, "class", "btn btn-secondary text-dark");
                __builder2.AddAttribute(63, "href", "ReservasEditar?Id=" + (
#nullable restore
#line 87 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                                            reserva.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "role", "button");
                __builder2.AddMarkupContent(65, "<i class=\"oi oi-pencil text-dark\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "td");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "class", "btn btn-secondary");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                        () => borrar(reserva.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "role", "button");
                __builder2.AddMarkupContent(72, "<i class=\"oi oi-trash text-dark\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 97 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, @"<div class=""row""><div class=""col-12 text-center""><button class=""btn btn-secondary text-dark"" href=""#"" role=""button""><i class=""oi oi-grid-four-up text-dark""></i>
                    Descargar a Excel
                </button>
                <button class=""btn btn-secondary text-dark"" href=""#"" role=""button""><i class=""oi oi-data-transfer-download text-dark""></i>
                    PDF
                </button></div></div>");
            }
            ));
            __builder.AddAttribute(75, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(76, "<div class=\"row\"><div class=\"col-12 text-center\"><div style=\"font-size: 64px;\">NAVIERA MAERKS LINE</div></div></div>\r\n        ");
                __builder2.AddMarkupContent(77, "<div class=\"row\"><div class=\"col-12 m-0 p-0 text-center\"><img src=\"/barco.jpg\" style=\"width:100%;\"></div></div>\r\n        }\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
 
    private List<Reserva> reservas = new List<Reserva>();

    protected override async Task OnInitializedAsync()
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM reserva_contenedor;", connection);
            using var reader = command.ExecuteReader();
            while (await reader.ReadAsync())
            {
                var reserva = new Reserva();
                reserva.Id = (int) reader["id"];
                reserva.Codigo = reader["Codigo_contenedor"].ToString();
                reserva.Empresa = reader["Empresa"].ToString();
                reserva.Nit = reader["Nit"].ToString();
                reserva.Direccion = reader["Direccion"].ToString();
                reserva.Puerto_Origen = reader["Puerto_Origen"].ToString();
                reserva.Pais_Origen = reader["Pais_Origen"].ToString();
                reserva.Puerto_Destino = reader["Puerto_Destino"].ToString();
                reserva.Pais_Destino = reader["Pais_Destino"].ToString();
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

    private void borrar(int id)
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        {
            using var connection = new MySqlConnection(connString);
            {
                connection.Open();
                String q = "Delete from reserva_contenedor where id = '" + id + "'";

                using var command = new MySqlCommand(q, connection);
                var resultado = command.ExecuteNonQuery();
            }
        }
        NavManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591