#pragma checksum "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c2fdcf6505663a155c18634cdef1e0c2627348"
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
#nullable restore
#line 11 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
 if (loginState.EsAdministrador)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Personal</h1>");
            __builder.AddMarkupContent(1, "<p>Modificar personal</p>");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                         usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                 grabar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, " \r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"tipoempleado\">Tipo de empleado</label>\r\n                ");
                __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_0(__builder2, 13, 14, "form-control", 15, "tipoempleado", 16, 
#nullable restore
#line 22 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                          usuario.Tipo

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Tipo = __value, usuario.Tipo)), 18, () => usuario.Tipo, 19, (__builder3) => {
                    __builder3.AddMarkupContent(20, "<option value>Elegir...</option>");
#nullable restore
#line 24 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                     foreach (var tipo_empleado in Tipo_empleados)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(21, "option");
                    __builder3.AddAttribute(22, "value", 
#nullable restore
#line 26 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                        tipo_empleado.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(23, 
#nullable restore
#line 26 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                               tipo_empleado.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 27 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label for=\"nombre\">Nombre</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "id", "nombre");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                        usuario.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Nombre = __value, usuario.Nombre))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label for=\"contraseña\">Contraseña</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "id", "contraseña");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                        usuario.Contraseña

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Contraseña = __value, usuario.Contraseña))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Contraseña));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label for=\"codigo\">Código de empleado</label>");
#nullable restore
#line 41 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                 if (usuario.Id > 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "readonly", true);
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "id", "codigo");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            usuario.Codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Codigo = __value, usuario.Codigo))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Codigo));
                __builder2.CloseComponent();
#nullable restore
#line 44 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "readonly", true);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "id", "codigo");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            usuario.Codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Codigo = __value, usuario.Codigo))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Codigo));
                __builder2.CloseComponent();
#nullable restore
#line 48 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "<label for=\"pais\">Pais</label>\r\n                ");
                __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_1(__builder2, 66, 67, "form-control", 68, "pais", 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                                                                 Llena_Puertos_Evento

#line default
#line hidden
#nullable disable
                ), 70, 
#nullable restore
#line 52 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                          usuario.Pais

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Pais = __value, usuario.Pais)), 72, () => usuario.Pais, 73, (__builder3) => {
                    __builder3.AddMarkupContent(74, "<option value>Elegir...</option>");
#nullable restore
#line 54 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                     foreach (var pais in Paises)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(75, "option");
                    __builder3.AddAttribute(76, "value", 
#nullable restore
#line 56 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                        pais.Codigo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(77, 
#nullable restore
#line 56 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                      pais.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 57 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "<label for=\"puerto\">Puerto</label>\r\n                ");
                __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_2(__builder2, 82, 83, "form-control", 84, "puerto", 85, 
#nullable restore
#line 62 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                          usuario.Puerto

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Puerto = __value, usuario.Puerto)), 87, () => usuario.Puerto, 88, (__builder3) => {
                    __builder3.AddMarkupContent(89, "<option value>Elegir...</option>");
#nullable restore
#line 64 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                     foreach (var puerto in Puertos)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(90, "option");
                    __builder3.AddAttribute(91, "value", 
#nullable restore
#line 66 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                        puerto.Codigo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(92, 
#nullable restore
#line 66 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                        puerto.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 67 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            <input type=\"submit\" class=\"btn btn-primary text-dark\" value=\"Enviar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\pmari\Google Drive\2021\C5\2. proyecto de prácticas\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
 
    int Id = 0;
    Usuarios usuario = new Usuarios();

    List<Tipo_empleado> Tipo_empleados = new List<Tipo_empleado>();
    List<Pais> Paises = new List<Pais>();
    List<Puerto> Puertos = new List<Puerto>();

    //para que el puerto que elija dependa del país que ya se eligió
    void LlenaPuertos(String Pais)
    {
        //puertos
        Puertos.Clear();
        String connString = config.GetConnectionString("MySqlNaviera"); //variable de conexión a la base
        using var connectionPuertos = new MySqlConnection(connString);
        {
            //tipo de empleado
            connectionPuertos.Open(); //apertura de la base

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

    //verificación de todos los datos ingresados por el usuario que serán grabados en la base de datos
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
namespace __Blazor.ProyectoMaersk.Pages.PersonalEditar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
