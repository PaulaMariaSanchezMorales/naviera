#pragma checksum "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a5a31131dccee1f25b6d6a461647f96356b629"
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
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((autorizado) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1>Reservas</h1>\r\n\r\n        ");
                __builder2.AddMarkupContent(3, "<h4>Listado de reservas</h4>\r\n\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "<div class=\"col-sm-10 mb-3\"><a class=\"btn btn-secondary text-dark\" href=\"ReservasEditar\" role=\"button\">Agregar</a></div>\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-sm-2 mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
                __builder2.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                  busqueda

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "class", "form-inline");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "form-group");
                    __builder3.OpenElement(15, "button");
                    __builder3.AddAttribute(16, "class", "btn btn-secondary");
                    __builder3.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                    () => buscar(busqueda.Texto)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "role", "button");
                    __builder3.AddMarkupContent(19, "<i class=\"oi oi-magnifying-glass text-dark\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                    __builder3.AddAttribute(22, "id", "textobuscar");
                    __builder3.AddAttribute(23, "class", "form-control");
                    __builder3.AddAttribute(24, "placeholder", "Buscar");
                    __builder3.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                 busqueda.Texto

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => busqueda.Texto = __value, busqueda.Texto))));
                    __builder3.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => busqueda.Texto));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "table");
                __builder2.AddAttribute(30, "class", "table table-sm");
                __builder2.AddMarkupContent(31, @"<thead><tr class=""bg-primary""><th>Codigo</th>
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
                __builder2.OpenElement(32, "tbody");
#nullable restore
#line 59 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                 foreach (var reserva in reservas)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "tr");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 63 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Codigo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 64 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Empresa

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.OpenElement(40, "td");
                __builder2.AddContent(41, 
#nullable restore
#line 65 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Nit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "td");
                __builder2.AddContent(44, 
#nullable restore
#line 66 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.AddContent(47, 
#nullable restore
#line 67 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Puerto_Origen

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "td");
                __builder2.AddContent(50, 
#nullable restore
#line 68 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Pais_Origen

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "td");
                __builder2.AddContent(53, 
#nullable restore
#line 69 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Hora_Salida

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.OpenElement(55, "td");
                __builder2.AddContent(56, 
#nullable restore
#line 70 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Puerto_Destino

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.OpenElement(58, "td");
                __builder2.AddContent(59, 
#nullable restore
#line 71 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Pais_Destino

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenElement(61, "td");
                __builder2.AddContent(62, 
#nullable restore
#line 72 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Hora_Llegada

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "td");
                __builder2.AddContent(65, 
#nullable restore
#line 73 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Receptor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "td");
                __builder2.AddContent(68, 
#nullable restore
#line 74 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Contraseña_Recepcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, " \r\n                        ");
                __builder2.OpenElement(70, "td");
                __builder2.AddContent(71, 
#nullable restore
#line 75 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Tipo_Carga

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.OpenElement(73, "td");
                __builder2.AddContent(74, 
#nullable restore
#line 76 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenElement(76, "td");
                __builder2.AddContent(77, 
#nullable restore
#line 77 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Peso

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.OpenElement(79, "td");
                __builder2.AddContent(80, 
#nullable restore
#line 78 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Valor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.OpenElement(82, "td");
                __builder2.AddContent(83, 
#nullable restore
#line 79 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                             reserva.Tipo_Contenedor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.AddMarkupContent(85, "<td><button class=\"btn btn-secondary text-dark\" href=\"#\" role=\"button\"><i class=\"oi oi-document text-dark\"></i></button></td>\r\n                        ");
                __builder2.AddMarkupContent(86, "<td><button class=\"btn btn-secondary text-dark\" href=\"#\" role=\"button\"><i class=\"oi oi-data-transfer-download text-dark\"></i></button></td>\r\n                        ");
                __builder2.OpenElement(87, "td");
                __builder2.OpenElement(88, "a");
                __builder2.AddAttribute(89, "class", "btn btn-secondary text-dark");
                __builder2.AddAttribute(90, "href", "ReservasEditar?Id=" + (
#nullable restore
#line 91 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                                            reserva.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "role", "button");
                __builder2.AddMarkupContent(92, "<i class=\"oi oi-pencil text-dark\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                        ");
                __builder2.OpenElement(94, "td");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "class", "btn btn-secondary");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                                                                        () => borrar(reserva.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "role", "button");
                __builder2.AddMarkupContent(99, "<i class=\"oi oi-trash text-dark\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 101 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.AddMarkupContent(101, @"<div class=""row""><div class=""col-12 text-center""><a href=""ListaReservas"" target=""_parent"" class=""btn btn-secondary btn-lg text-dark"" role=""button""><i class=""oi oi-data-transfer-download text-dark""></i>
                    PDF
                </a>
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""ListaReservas"">
                    Launch demo modal
                </button></div></div>");
            }
            ));
            __builder.AddAttribute(102, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(103, "<div class=\"row\"><div class=\"col-12 text-center\"><div style=\"font-size: 64px;\">NAVIERA MAERKS LINE</div></div></div>\r\n        ");
                __builder2.AddMarkupContent(104, "<div class=\"row\"><div class=\"col-12 m-0 p-0 text-center\"><img src=\"/barco.jpg\" style=\"width:100%;\"></div></div>\r\n        }\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
 
    private List<Reserva> reservas = new List<Reserva>();
    Busqueda busqueda = new Busqueda();

    public void lee_reservas(string Texto)
    {
        reservas.Clear();
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            connection.Open();

            string q = "SELECT * FROM reserva_contenedor"; //selección de lo que q vaya a devolver
            if (Texto != "")
            {
                q = q + " where codigo_contenedor ='" + Texto + "' ";
                q = q + "or empresa ='" + Texto + "' ";
                q = q + "or nit ='" + Texto + "' ";
                q = q + "or direccion ='" + Texto + "' ";
                q = q + "or puerto_origen ='" + Texto + "' ";
                q = q + "or pais_origen ='" + Texto + "' ";
                q = q + "or puerto_destino ='" + Texto + "' ";
                q = q + "or pais_destino ='" + Texto + "' ";
                q = q + "or receptor ='" + Texto + "' ";
                q = q + "or contraseña_recepcion ='" + Texto + "' ";
                q = q + "or tipo_carga ='" + Texto + "' ";
                q = q + "or descripcion_carga ='" + Texto + "' ";
                q = q + "or peso_carga ='" + Texto + "' ";
                q = q + "or valor_carga ='" + Texto + "' ";
                q = q + "or tipo_contenedor ='" + Texto + "'";
            }

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
        lee_reservas("");
    }
    //funciones
    private void borrar(int id)
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        {
            using var connection = new MySqlConnection(connString);
            {
                connection.Open(); //abriendo la conección a la base de datos, si xampp no está abierto no funciona
                String q = "Delete from reserva_contenedor where id = '" + id + "'";

                using var command = new MySqlCommand(q, connection);
                var resultado = command.ExecuteNonQuery(); //resultado de las filas afectadas por update, insert y delete
            }
        }
        NavManager.NavigateTo("/"); //dirige de nuevo a la página principal (reservas)
    }

    private void buscar(string Texto)
    {
        lee_reservas(Texto);
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
