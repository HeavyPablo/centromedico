using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Helpers
{
    public static class IJSExtensions
    {
        // --- Metodos para SweetAlert2 ---
        public static ValueTask<object> MostrarMensaje(this IJSRuntime js, string mensaje)
        {
            return js.InvokeAsync<object>("Swal.fire", mensaje);
        }

        public static ValueTask<object> MostrarMensaje(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            return js.InvokeAsync<object>("Swal.fire", titulo, mensaje, tipoMensajeSweetAlert.ToString());
        }

        public async static ValueTask<bool> Confirm(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            return await js.InvokeAsync<bool>("methods.CustomConfirm", titulo, mensaje, tipoMensajeSweetAlert.ToString());
        }

        // --- Metodos para los modals ---
        public static ValueTask ShowModal(this IJSRuntime js, string idModal)
        {
            return js.InvokeVoidAsync("methods.ShowModal", idModal);
        }

        public static ValueTask CloseModal(this IJSRuntime js, string idModal)
        {
            return js.InvokeVoidAsync("methods.CloseModal", idModal);
        }

        // --- Metodos para setear, obenter y borrar elementos en el Local Storage ---
        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content)
            => js.InvokeAsync<object>(
                "localStorage.setItem",
                key, content
                );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key)
            => js.InvokeAsync<object>(
                "localStorage.removeItem",
                key);

        public enum TipoMensajeSweetAlert
        {
            question, warning, error, success, info
        }
    }
}
