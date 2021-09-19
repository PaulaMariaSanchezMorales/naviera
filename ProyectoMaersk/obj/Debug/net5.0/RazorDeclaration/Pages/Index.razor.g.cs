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
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\Index.razor"
 
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
        NavManager.NavigateTo("/", true); //dirige de nuevo a la página principal (reservas)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginState { get; set; }
    }
}
#pragma warning restore 1591
