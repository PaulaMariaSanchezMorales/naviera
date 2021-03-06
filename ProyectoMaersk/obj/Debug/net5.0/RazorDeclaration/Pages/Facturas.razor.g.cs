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
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Facturas.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Facturas.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Facturas.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Facturas.razor"
using Clases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlankLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Facturas")]
    public partial class Facturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 170 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Facturas.razor"
 
    //generaci??n de las listas que se van a leer
    int Id = 0;
    Reserva reserva = new Reserva();

    List<Pais> Paises_Origen = new List<Pais>(); //listado de los pa??ses existentes
    List<Pais> Paises_Destino = new List<Pais>();

    List<Puerto> Puertos_Origen = new List<Puerto>();
    List<Puerto> Puertos_Destino = new List<Puerto>();

    List<Tipo_carga> Tipo_Carga = new List<Tipo_carga>();

    List<Valor> Valores = new List<Valor>();

    List<Tipo_contenedor> Tipo_Contenedores = new List<Tipo_contenedor>();

    //se inicializa la base de datos
    protected override void OnInitialized() //inicializando la lectura de los datos
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
        using var connection = new MySqlConnection(connString);
        {
            //abrir conexi??n a la base de datos
            connection.Open();
            String q = "SELECT * FROM reserva_contenedor where id = '" + Id + "';"; //se busca por ID, el cual es ??nico

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
                //convertir el valor de la reserva a double para poderlo sumar con otro valor
                double valordelareserva = 0;
                double.TryParse(reserva.Valor.Substring(2,7), out valordelareserva); //utilizar datos desde la posici??n 2 hasta la 7, y que salga como valordelareserva
                double totalfactura = valordelareserva + 950.00;
                reserva.Total_Factura = totalfactura.ToString();
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
