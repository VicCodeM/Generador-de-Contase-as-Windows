using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeContraseñas
{
    // Clase para evaluar la seguridad del password
    public class EvaluadorSeguridadPassword
    {
        public static string EvaluarSeguridad(int longitud)
        {
            if (longitud >= 1 && longitud <= 12)
            {
                return "Password con " + longitud + " caracteres, seguridad muy baja no recomendada";
            }
            else if (longitud >= 12 && longitud <= 16)
            {
                return "Password con " + longitud + " caracteres, seguridad media recomendada";
            }
            else if (longitud >= 17 && longitud <= 25)
            {
                return "Password con " + longitud + " caracteres, seguridad alta recomendada";
            }
            else if (longitud >= 30 && longitud < 127)
            {
                return "Password con " + longitud + " caracteres, seguridad muy alta mejor recomendada";
            }
            return "Seguridad desconocida";
        }
    }
}
