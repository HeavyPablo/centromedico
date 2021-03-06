#pragma checksum "C:\centromedico\CentroMedico\Pages\RegistroUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca16f4c58f1a6809c85d096c6c7283b58c8fd3a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
