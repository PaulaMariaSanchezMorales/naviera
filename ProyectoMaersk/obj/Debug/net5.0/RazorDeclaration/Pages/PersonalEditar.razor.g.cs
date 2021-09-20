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
#line 1 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PersonalEditar")]
    public partial class PersonalEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
 
    int Id = 0;
    Usuarios usuario = new Usuarios();

    List<Tipo_empleado> Tipo_empleados = new List<Tipo_empleado>();
    List<Pais> Paises = new List<Pais>();
    List<Puerto> Puertos = new List<Puerto>();

    void LlenaPuertos(String Pais)
    {
        //puertos
        Puertos.Clear();
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connectionPuertos = new MySqlConnection(connString);
        {
            //tipo de empleado
            connectionPuertos.Open();

            using var commandPuertos = new MySqlCommand("SELECT * FROM puertos where pais = '" + Pais + "'", connectionPuertos);
            {
                using var readerPuertos = commandPuertos.ExecuteReader();
                {
                    while (readerPuertos.Read())
                    {
                        var puerto = new Puerto();
                        puerto.Codigo = readerPuertos["codigo"].ToString();
                        puerto.Nombre = readerPuertos["nombre"].ToString();
                        Puertos.Add(puerto);
                    }
                }
            }
        }
    }
    void Llena_Puertos_Evento(ChangeEventArgs e)
    {
        // Recibe como parametro el dato que cambio en e.value
        String Pais = e.Value.ToString();
        usuario.Puerto = "";
        LlenaPuertos(Pais);
    }

    void Llena_Combos() //no regresa ningún resultado void (lista de todos lo países)
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            //tipo de empleado
            connection.Open();
            using var command1 = new MySqlCommand("SELECT * FROM tipo_empleado;", connection);
            {
                using var reader1 = command1.ExecuteReader();
                {
                    while (reader1.Read())
                    {
                        var empleado = new Tipo_empleado();
                        empleado.Nombre = reader1["nombre"].ToString();
                        Tipo_empleados.Add(empleado);
                    }
                }
            }

            //paises
            using var command2 = new MySqlCommand("SELECT * FROM paises;", connection);
            {
                using var reader2 = command2.ExecuteReader();
                {
                    while (reader2.Read())
                    {
                        var pais = new Pais();
                        pais.Codigo = reader2["codigo"].ToString();
                        pais.Nombre = reader2["nombre"].ToString();
                        Paises.Add(pais);
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
            String q = "";

            connection.Open();
            if (usuario.Id > 0)
            {
                q = q + "UPDATE usuarios SET ";
                q = q + "nombre = '" + usuario.Nombre + "',";
                q = q + "tipo_empleado = '" + usuario.Tipo + "',";
                q = q + " puerto = '" + usuario.Puerto + "',";
                q = q + " pais = '" + usuario.Pais + "'";

                q = q + " where id = '" + usuario.Id + "'";
            }
            else
            {
                usuario.Codigo = Guid.NewGuid().ToString("N").Substring(0, 6); //generar numeros random, es una funcion ya por los sistemas para generar un id unico

                q = q + "INSERT INTO usuarios(tipo_empleado, contraseña, codigo_empleado, nombre, puerto, pais)" +
                    "values ('" + usuario.Tipo + "','" + usuario.Contraseña + "','" + usuario.Codigo + "','" + usuario.Nombre + "','" + usuario.Puerto + "','" + usuario.Pais + "')";
            }
            using var command = new MySqlCommand(q, connection);
            var resultado = command.ExecuteNonQuery();
        }

        NavManager.NavigateTo("/Personal");
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
            String q = "SELECT * FROM usuarios where id = '" + Id + "';";
            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                usuario.Id = (int)reader["id"];
                usuario.Tipo = reader["tipo_empleado"].ToString();
                usuario.Contraseña = reader["contraseña"].ToString();
                usuario.Codigo = reader["codigo_empleado"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Puerto = reader["puerto"].ToString();
                usuario.Pais = reader["pais"].ToString();
                LlenaPuertos(usuario.Pais);
            }
        }
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
