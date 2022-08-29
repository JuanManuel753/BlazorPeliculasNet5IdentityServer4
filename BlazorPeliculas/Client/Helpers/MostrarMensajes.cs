using BlazorPeliculas.Client.Helpers.AlertasMensajes;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime _js;

        public MostrarMensajes(IJSRuntime js)
        {
            _js = js;
        }

        public async Task MostrarMensajeError(string mensaje)
        {
            await _js.InvokeVoidAsync("Swal.fire", MostrarAlertaError.Param(mensaje));
        }

        public async Task MostrarMensajeExitoso(string mensaje)
        {
            await _js.InvokeVoidAsync("Swal.fire", MostrarAlertaBuena.Param(mensaje));
        }
    }
}
