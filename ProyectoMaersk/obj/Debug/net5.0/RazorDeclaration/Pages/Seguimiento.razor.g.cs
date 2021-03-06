// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
