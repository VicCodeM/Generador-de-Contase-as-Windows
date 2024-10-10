using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeContraseñas
{
    // Clase para generar passwords con caracteres especiales
    public class GeneradorPasswordEspecial : GeneradorPassword
    {
        public GeneradorPasswordEspecial(int longitud) : base(longitud) { }

        public override void GenerarPassword()
        {
            caracteres = "#$%&/()=?¡¿!.,:{}[]+-*_~";
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
