#pragma checksum "C:\centromedico\CentroMedico\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13139ff9b17c62c2d4158fd30937a67066736fb9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\centromedico\CentroMedico\Pages\Login.razor"
       
    private LoginForm loginForm = new LoginForm();

    private async Task encargadoLogin()
    {
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("POST"),
            RequestUri = new Uri("http://localhost:8080/login"),
            Content = new StringContent(
                        @"{""nombreUsuario"": """ + loginForm.nombreUsuario + @""", ""contrasena"": """ + loginForm.contrasena + @"""}"
                    )
        };

        requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        requestMessage.Content.Headers.TryAddWithoutValidation("x-custom-header", "value");

        var respuesta = await Http.SendAsync(requestMessage);

        var respuestaContenido = await respuesta.Content.ReadAsStringAsync();
        var usuario = JsonConvert.DeserializeObject<Usuario>(respuestaContenido);

        if (usuario == null)
        {
            await js.MostrarMensaje("Error", "Compruebe bien sus credenciales.", IJSExtensions.TipoMensajeSweetAlert.error);
            return;
        }

        await js.SetInLocalStorage("usuario", respuestaContenido);

        Navigation.NavigateTo("/");
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
