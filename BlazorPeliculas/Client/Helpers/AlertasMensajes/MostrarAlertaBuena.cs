using System.Collections.Generic;

namespace BlazorPeliculas.Client.Helpers.AlertasMensajes
{
    public class MostrarAlertaBuena
    {
        public static Dictionary<string, object> Param(string mensaje)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();

            param.Add("title", "Exitoso");
            param.Add("icon", "success");
            param.Add("text", mensaje);
            param.Add("showConfirmButton", false);
            param.Add("timer", 2000);

            return param;

        }
    }
}
