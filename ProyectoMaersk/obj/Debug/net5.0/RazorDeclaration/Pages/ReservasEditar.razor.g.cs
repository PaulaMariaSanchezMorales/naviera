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
#line 1 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ReservasEditar.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ReservasEditar.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ReservasEditar.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ReservasEditar.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReservasEditar")]
    public partial class ReservasEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\ReservasEditar.razor"
 
    int Id = 0;
    Reserva reserva = new Reserva();

    List<Pais> Paises_Origen = new List<Pais>();
    List<Pais> Paises_Destino = new List<Pais>();

    List<Puerto> Puertos_Origen = new List<Puerto>();
    List<Puerto> Puertos_Destino = new List<Puerto>();

    List<Tipo_carga> Tipo_Carga = new List<Tipo_carga>();

    List<Valor> Valores = new List<Valor>();

    List<Tipo_contenedor> Tipo_Contenedores = new List<Tipo_contenedor>();

    void Llena_Combos() //no regresa ningún resultado void (lista de todos lo países)
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            //paises
            connection.Open();
            using var command1 = new MySqlCommand("SELECT * FROM paises;", connection);
            {
                using var reader1 = command1.ExecuteReader();
                {
                    while (reader1.Read())
                    {
                        var pais = new Pais();
                        pais.Codigo = reader1["codigo"].ToString();
                        pais.Nombre = reader1["nombre"].ToString();
                        Paises_Origen.Add(pais);
                        Paises_Destino.Add(pais);
                    }
                }
            }
            //puertos
            using var command2 = new MySqlCommand("SELECT * FROM puertos;", connection);
            {
                using var reader2 = command2.ExecuteReader();
                {
                    while (reader2.Read())
                    {
                        var puerto = new Puerto();
                        puerto.Codigo = reader2["codigo"].ToString();
                        puerto.Nombre = reader2["nombre"].ToString();
                        Puertos_Origen.Add(puerto);
                        Puertos_Destino.Add(puerto);
                    }
                }
            }
            //cargas
            using var command3 = new MySqlCommand("SELECT * FROM tipo_carga;", connection);
            {
                using var reader3 = command3.ExecuteReader();
                {
                    while (reader3.Read())
                    {
                        var carga = new Tipo_carga();
                        carga.Nombre = reader3["nombre"].ToString();
                        Tipo_Carga.Add(carga);
                    }
                }
            }
            //valores
            using var command4 = new MySqlCommand("SELECT * FROM valores;", connection);
            {
                using var reader4 = command4.ExecuteReader();
                {
                    while (reader4.Read())
                    {
                        var valor = new Valor();
                        valor.Cantidad = reader4["cantidades"].ToString();
                        Valores.Add(valor);
                    }
                }
            }
            //contenedores
            using var command5 = new MySqlCommand("SELECT * FROM tipo_contenedores;", connection);
            {
                using var reader5 = command5.ExecuteReader();
                {
                    while (reader5.Read())
                    {
                        var contenedor = new Tipo_contenedor();
                        contenedor.Nombre = reader5["nombre"].ToString();
                        contenedor.Codigo = reader5["codigo"].ToString();
                        Tipo_Contenedores.Add(contenedor);
                    }
                }
            }
        }
    }

    void grabar()
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            connection.Open();
            String q = "UPDATE reserva_contenedor SET ";
            q = q + "empresa = '" + reserva.Empresa + "',";
            q = q + " nit = '" + reserva.Nit + "',";
            q = q + " direccion = '" + reserva.Direccion + "',";
            q = q + " puerto_origen = '" + reserva.Puerto_Origen + "',";
            q = q + " pais_origen = '" + reserva.Pais_Origen + "',";
            q = q + " puerto_destino = '" + reserva.Puerto_Destino + "',";
            q = q + " pais_destino = '" + reserva.Pais_Destino + "',";
            q = q + " receptor = '" + reserva.Receptor + "',";
            q = q + " contraseña_recepcion = '" + reserva.Contraseña_Recepcion + "',";
            q = q + " tipo_carga = '" + reserva.Tipo_Carga + "',";
            q = q + " descripcion_carga = '" + reserva.Descripcion + "',";
            q = q + " peso_carga = '" + reserva.Peso + "',";
            q = q + " valor_carga = '" + reserva.Valor + "',";
            q = q + " tipo_contenedor = '" + reserva.Tipo_Contenedor + "'";

            q = q + " where codigo_contenedor = '" + reserva.Codigo + "'";

            using var command = new MySqlCommand(q, connection);
            var resultado = command.ExecuteNonQuery();
        }

        NavManager.NavigateTo("/");
    }

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

        Llena_Combos();

        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            connection.Open();
            String q = "SELECT * FROM reserva_contenedor where id = '" + Id + "';";
            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
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