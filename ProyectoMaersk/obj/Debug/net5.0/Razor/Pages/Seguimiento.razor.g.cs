#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969843476d75b813a92732a2129cf5e99910994b"
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
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Seguimiento")]
    public partial class Seguimiento : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Seguimiento</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Visualice la ruta de su contenedor</h4>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-sm-1\"></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-10 mb-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                          busqueda

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "form-inline");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "<div class=\"form-group col-sm-4\"><label for=\"textobuscar\">C??digo de contenedor / Contrase??a de recepci??n</label></div>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group col-sm-8");
                __builder2.OpenElement(14, "button");
                __builder2.AddAttribute(15, "class", "btn btn-secondary");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                            () => buscar(busqueda.Texto)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "role", "button");
                __builder2.AddMarkupContent(18, "<i class=\"oi oi-magnifying-glass text-dark\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "textobuscar");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "Buscar");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                         busqueda.Texto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => busqueda.Texto = __value, busqueda.Texto))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => busqueda.Texto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <div class=\"col-sm-1\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.AddMarkupContent(31, "<div class=\"col-1\"></div>\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-8");
#nullable restore
#line 32 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
         if (reserva.Puerto_Origen != "" && reserva.Puerto_Destino != "")
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "iframe");
            __builder.AddAttribute(35, "class", "custom-shadow");
            __builder.AddAttribute(36, "id", "map-canvas");
            __builder.AddAttribute(37, "frameborder", "0");
            __builder.AddAttribute(38, "scrolling", "no");
            __builder.AddAttribute(39, "marginheight", "0");
            __builder.AddAttribute(40, "marginwidth", "0");
            __builder.AddAttribute(41, "style", "width:100%; height:800px;");
            __builder.AddAttribute(42, "src", "Prueba.html?loc1=" + (
#nullable restore
#line 35 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                           localizacion_origen

#line default
#line hidden
#nullable disable
            ) + "&loc2=" + (
#nullable restore
#line 35 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                                     localizacion_destino

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<iframe class=\"custom-shadow\" id=\"map-canvas\" frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\" style=\"width:100%; height:800px;\" src=\"Prueba.html\"></iframe>");
#nullable restore
#line 46 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-3");
            __builder.AddMarkupContent(47, "<h4>Nombre de la empresa:</h4>\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "shadow p-4 mb-5 bg-white rounded");
            __builder.AddContent(50, 
#nullable restore
#line 50 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                       reserva.Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.AddMarkupContent(52, "<h4>Fecha y hora de salida:</h4>\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "shadow p-4 mb-5 bg-white rounded");
            __builder.AddContent(55, 
#nullable restore
#line 52 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                       reserva.Hora_Salida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, "<h4>Fecha y hora de llegada:</h4>\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "shadow p-4 mb-5 bg-white rounded");
            __builder.AddContent(60, 
#nullable restore
#line 54 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                       reserva.Hora_Llegada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.AddMarkupContent(62, "<h4>Descripci??n de la carga:</h4>\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "shadow p-4 mb-5 bg-white rounded");
            __builder.AddContent(65, 
#nullable restore
#line 56 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
                                                       reserva.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Seguimiento.razor"
 
    Reserva reserva = new Reserva();
    Busqueda busqueda = new Busqueda();

    String localizacion_origen = "";
    String localizacion_destino = "";

    public void lee_reservas(string Texto)
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            string q = "";

            reserva.Puerto_Origen = "";
            reserva.Puerto_Destino = "";
            reserva.Hora_Salida = "";
            reserva.Hora_Llegada = "";
            reserva.Empresa = "";
            reserva.Descripcion = "";

            localizacion_origen = "";
            localizacion_destino = "";

            q = "SELECT * FROM reserva_contenedor";
            q = q + " where codigo_contenedor ='" + Texto + "' ";
            q = q + "or contrase??a_recepcion ='" + Texto + "'";

            connection.Open();
            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader(); //ejecuta la b??squeda, va a la base de datos
            while (reader.Read()) //variables que leer?? para poder mostrar a la hora de bucar el contenedor
            {
                reserva.Puerto_Origen = reader["Puerto_Origen"].ToString();
                reserva.Hora_Salida = ((DateTime)reader["Hora_Salida"]).ToString("dd/MM/yyyy hh:mm tt"); //convierte lo que la base de datos trae a tipo DateTime de C# y le aplica el formato
                reserva.Puerto_Destino = reader["Puerto_Destino"].ToString();
                reserva.Hora_Llegada = ((DateTime)reader["Hora_Llegada"]).ToString("dd/MM/yyyy hh:mm tt");
                reserva.Empresa = reader["Empresa"].ToString();
                reserva.Descripcion = reader["Descripcion_Carga"].ToString();
            }
            connection.Close();

            connection.Open();
            String q1 = "SELECT localizacion from puertos where codigo = '" + reserva.Puerto_Origen + "'";
            using var command1 = new MySqlCommand(q1, connection);
            using var reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                localizacion_origen = reader1["localizacion"].ToString();
            }
            connection.Close();

            connection.Open();
            String q2 = "SELECT localizacion from puertos where codigo = '" + reserva.Puerto_Destino + "'";
            using var command2 = new MySqlCommand(q2, connection);
            using var reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                localizacion_destino = reader2["localizacion"].ToString();
            }
            connection.Close();
        }
    }

    protected override void OnInitialized()
    {
        lee_reservas("");
    }
    private void buscar(string Texto)
    {
        lee_reservas(Texto);
        NavManager.NavigateTo("/Seguimiento");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
