#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b817582e81fcda6f7b661b957fc715924b9199ac"
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
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using MySqlConnector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using ProyectoMaersk.Clases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PersonalEditar")]
    public partial class PersonalEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1>Personal</h1>\r\n\r\n        ");
                __builder2.AddMarkupContent(3, "<p>Modificar personal</p>\r\n\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
                __builder2.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                             usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                     grabar

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, " \r\n                ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "form-group");
                    __builder3.AddMarkupContent(14, "<label for=\"tipoempleado\">Tipo de empleado</label>\r\n                    ");
                    __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_0(__builder3, 15, 16, "form-control", 17, "tipoempleado", 18, 
#nullable restore
#line 25 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                              usuario.Tipo_Empleado

#line default
#line hidden
#nullable disable
                    , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Tipo_Empleado = __value, usuario.Tipo_Empleado)), 20, () => usuario.Tipo_Empleado, 21, (__builder4) => {
                        __builder4.AddMarkupContent(22, "<option value>Elegir...</option>");
#nullable restore
#line 27 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                         foreach (var tipo_empleado in Tipo_empleados)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(23, "option");
                        __builder4.AddAttribute(24, "value", 
#nullable restore
#line 29 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            tipo_empleado.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(25, 
#nullable restore
#line 29 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                                   tipo_empleado.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 30 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n                ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "form-group");
                    __builder3.AddMarkupContent(29, "<label for=\"nombre\">Nombre</label>\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                    __builder3.AddAttribute(31, "class", "form-control");
                    __builder3.AddAttribute(32, "id", "nombre");
                    __builder3.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            usuario.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Nombre = __value, usuario.Nombre))));
                    __builder3.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Nombre));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n                ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "form-group");
                    __builder3.AddMarkupContent(39, "<label for=\"contraseña\">Contraseña</label>\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                    __builder3.AddAttribute(41, "class", "form-control");
                    __builder3.AddAttribute(42, "id", "contraseña");
                    __builder3.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            usuario.Contraseña

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Contraseña = __value, usuario.Contraseña))));
                    __builder3.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Contraseña));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n                ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "form-group");
                    __builder3.AddMarkupContent(49, "<label for=\"codigo\">Código de empleado</label>");
#nullable restore
#line 44 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                     if (usuario.Id != "")
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                    __builder3.AddAttribute(51, "readonly", true);
                    __builder3.AddAttribute(52, "class", "form-control");
                    __builder3.AddAttribute(53, "id", "codigo");
                    __builder3.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                usuario.Codigo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Codigo = __value, usuario.Codigo))));
                    __builder3.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Codigo));
                    __builder3.CloseComponent();
#nullable restore
#line 47 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                    __builder3.AddAttribute(58, "readonly", true);
                    __builder3.AddAttribute(59, "class", "form-control");
                    __builder3.AddAttribute(60, "id", "codigo");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                usuario.Codigo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Codigo = __value, usuario.Codigo))));
                    __builder3.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Codigo));
                    __builder3.CloseComponent();
#nullable restore
#line 51 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "form-group");
                    __builder3.AddMarkupContent(67, "<label for=\"pais\">Pais</label>\r\n                    ");
                    __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_1(__builder3, 68, 69, "form-control", 70, "pais", 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                                                                     Llena_Puertos_Evento

#line default
#line hidden
#nullable disable
                    ), 72, 
#nullable restore
#line 55 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                              usuario.Pais

#line default
#line hidden
#nullable disable
                    , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Pais = __value, usuario.Pais)), 74, () => usuario.Pais, 75, (__builder4) => {
                        __builder4.AddMarkupContent(76, "<option value>Elegir...</option>");
#nullable restore
#line 57 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                         foreach (var pais in Paises)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(77, "option");
                        __builder4.AddAttribute(78, "value", 
#nullable restore
#line 59 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            pais.Codigo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(79, 
#nullable restore
#line 59 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                          pais.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 60 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n                ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "form-group");
                    __builder3.AddMarkupContent(83, "<label for=\"puerto\">Puerto</label>\r\n                    ");
                    __Blazor.ProyectoMaersk.Pages.PersonalEditar.TypeInference.CreateInputSelect_2(__builder3, 84, 85, "form-control", 86, "puerto", 87, 
#nullable restore
#line 65 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                              usuario.Puerto

#line default
#line hidden
#nullable disable
                    , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Puerto = __value, usuario.Puerto)), 89, () => usuario.Puerto, 90, (__builder4) => {
                        __builder4.AddMarkupContent(91, "<option value>Elegir...</option>");
#nullable restore
#line 67 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                         foreach (var puerto in Puertos)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(92, "option");
                        __builder4.AddAttribute(93, "value", 
#nullable restore
#line 69 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                            puerto.Codigo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(94, 
#nullable restore
#line 69 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                                                            puerto.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 70 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
                        }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n                <input type=\"submit\" class=\"btn btn-primary text-dark\" value=\"Enviar\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\PersonalEditar.razor"
 
    string Id = "";
    UsuarioEditar usuario = new UsuarioEditar();

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

    public async Task grabar()
    {
        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            String q = "";

            connection.Open();
            if (usuario.Id != null)
            {
                q = q + "UPDATE AspNetUsers SET ";
                q = q + "nombre = '" + usuario.Nombre + "',";
                q = q + "tipo_empleado = '" + usuario.Tipo_Empleado + "',";
                q = q + " puerto = '" + usuario.Puerto + "',";
                q = q + " pais = '" + usuario.Pais + "'";
                q = q + " where id = '" + usuario.Id + "'";
            }
            else
            {
                usuario.Id = Guid.NewGuid().ToString();
                usuario.Codigo = Guid.NewGuid().ToString("N").Substring(0, 6); //generar numeros random, es una funcion ya por los sistemas para generar un id unico
                string nombreandemail = usuario.Codigo + "@naviera.com";
                q = q + "INSERT INTO AspNetUsers(Id, UserName, Email, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockOutEnabled, AccessFailedCount, tipo_empleado, codigo, nombre, puerto, pais)" +
                    "values ('" + usuario.Id + "','" + nombreandemail + "','" + nombreandemail + "','1','1','0','0','0','" + usuario.Tipo_Empleado + "','" + usuario.Codigo + "','" + usuario.Nombre + "','" + usuario.Puerto + "','" + usuario.Pais + "')";
            }
            using var command = new MySqlCommand(q, connection);
            var resultado = command.ExecuteNonQuery();

            // Resetea la contraseña
            if (!string.IsNullOrEmpty(usuario.Contraseña))
            {
                var user = await UserManager.FindByIdAsync(usuario.Id);
                user.SecurityStamp = "xx";
                var token = await UserManager.GeneratePasswordResetTokenAsync(user);
                var result = await UserManager.ResetPasswordAsync(user, token, usuario.Contraseña);
            }

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
                Id = parametro;
            }
        }

        Llena_Combos();

        String connString = config.GetConnectionString("MySqlNaviera");
        using var connection = new MySqlConnection(connString);
        {
            connection.Open();
            String q = "SELECT * FROM AspNetUsers where id = '" + Id + "';";
            using var command = new MySqlCommand(q, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                usuario.Id = reader["id"].ToString();
                usuario.Tipo_Empleado = reader["tipo_empleado"].ToString();
                usuario.Codigo = reader["codigo"].ToString();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<UsuarioIdentity> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<UsuarioIdentity> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
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
