using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeContraseñas
{
    // Clase para generar passwords combinados
    public class GeneradorPasswordCombinado : GeneradorPassword
    {
        public GeneradorPasswordCombinado(int longitud, string caracteresPersonalizados) : base(longitud)
        {
            this.caracteres = caracteresPersonalizados;
        }

        public override void GenerarPassword()
        {
            password = GenerarCadenaAleatoria();
        }

        private string GenerarCadenaAleatoria()
        {
            var arregloCaracteres = new char[longitud];
            for (int i = 0; i < arregloCaracteres.Length; i++)
            {
                arregloCaracteres[i] = caracteres[random.Next(caracteres.Length)];
            }
            return new string(arregloCaracteres);
        }
    }
}
