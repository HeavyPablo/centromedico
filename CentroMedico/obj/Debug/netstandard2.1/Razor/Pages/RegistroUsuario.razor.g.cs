#pragma checksum "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca16f4c58f1a6809c85d096c6c7283b58c8fd3a3"
// <auto-generated/>
#pragma warning disable 1591
namespace CentroMedico.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\centromedico\CentroMedico\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\centromedico\CentroMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\centromedico\CentroMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\centromedico\CentroMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\centromedico\CentroMedico\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\centromedico\CentroMedico\_Imports.razor"
using CentroMedico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\centromedico\CentroMedico\_Imports.razor"
using CentroMedico.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\centromedico\CentroMedico\_Imports.razor"
using CentroMedico.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\centromedico\CentroMedico\_Imports.razor"
using CentroMedico.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\centromedico\CentroMedico\_Imports.razor"
using CentroMedico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\centromedico\CentroMedico\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class RegistroUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card shadow");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"card-header font-weight-bold\">\r\n                Registro de usuario\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                  registroForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                               encargadoRegistro

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.AddMarkupContent(22, "<h5 class=\"mb-0 text-dark\">Datos de sesión</h5>\r\n                    <hr class=\"mt-1\">\r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-row");
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col");
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Nombre de usuario");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                           registroForm.nombreUsuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.nombreUsuario = __value, registroForm.nombreUsuario));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group col");
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "type", "password");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "placeholder", "Contraseña");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                               registroForm.contrasena

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.contrasena = __value, registroForm.contrasena));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.AddMarkupContent(49, "<h5 class=\"mb-0 text-dark\">Datos personales</h5>\r\n                    <hr class=\"mt-1\">\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "placeholder", "nombre");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                       registroForm.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.nombre = __value, registroForm.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-row");
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group col");
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "type", "text");
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "placeholder", "Primer apellido");
                __builder2.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                           registroForm.apellidoPaterno

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.apellidoPaterno = __value, registroForm.apellidoPaterno));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group col");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "placeholder", "Segundo apellido");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                           registroForm.apellidoMaterno

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.apellidoMaterno = __value, registroForm.apellidoMaterno));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "type", "text");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "placeholder", "Dirección");
                __builder2.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                       registroForm.direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.direccion = __value, registroForm.direccion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-row");
                __builder2.AddMarkupContent(100, "\r\n                        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group col");
                __builder2.AddMarkupContent(103, "\r\n                            ");
                __builder2.OpenElement(104, "input");
                __builder2.AddAttribute(105, "type", "text");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "placeholder", "Fecha Nacimiento (yyyy/MM/dd)");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                           registroForm.fechaNacimiento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.fechaNacimiento = __value, registroForm.fechaNacimiento));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                        ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group col");
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __builder2.OpenElement(115, "input");
                __builder2.AddAttribute(116, "type", "text");
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "placeholder", "Teléfono");
                __builder2.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                           registroForm.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.telefono = __value, registroForm.telefono));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group");
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __builder2.OpenElement(127, "input");
                __builder2.AddAttribute(128, "type", "email");
                __builder2.AddAttribute(129, "class", "form-control");
                __builder2.AddAttribute(130, "placeholder", "Correo electrónico");
                __builder2.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
                                                                        registroForm.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registroForm.email = __value, registroForm.email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n                    ");
                __builder2.AddMarkupContent(135, @"<div class=""d-flex justify-content-between"">
                        <p class=""text-secondary align-self-center m-0"">¿Ya tienes cuenta?  <a href=""/login"">Ingresar</a></p>
                        <button type=""submit"" class=""btn btn-primary"">Registrarse</button>
                    </div>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor"
       
    private RegistroForm registroForm = new RegistroForm();

    public async Task encargadoRegistro()
    {
        var confirmacion = await js.Confirm("¿Estas seguro/a?", "Verifíque bien los datos ingresados.", IJSExtensions.TipoMensajeSweetAlert.question);
        if (!confirmacion)
        {
            return;
        }

        var responseMessage = await Http.GetAsync("http://localhost:8080/usuario/nombreUsuario/" + registroForm.nombreUsuario);
        if (responseMessage == null)
        {
            await js.MostrarMensaje("Ups!", "Nombre de usuario ya existente.", IJSExtensions.TipoMensajeSweetAlert.warning);
            return;
        }

        registroForm.rol = "1";

        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("POST"),
            RequestUri = new Uri("http://localhost:8080/usuario"),
            Content = new  StringContent(JsonConvert.SerializeObject(registroForm))
        };

        requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        requestMessage.Content.Headers.TryAddWithoutValidation("x-custom-header", "value");

        var respuesta = await Http.SendAsync(requestMessage);

        var respuestaContenido = await respuesta.Content.ReadAsStringAsync();
        var nuevoUsuario = JsonConvert.DeserializeObject<Usuario>(respuestaContenido);

        if (nuevoUsuario == null)
        {
            await js.MostrarMensaje("Error", "Al parecer hay problemas.", IJSExtensions.TipoMensajeSweetAlert.error);
            return;
        }

        await js.SetInLocalStorage("usuario", respuestaContenido);

        Navigation.NavigateTo("/home");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
