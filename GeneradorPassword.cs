using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeContraseñas
{
    // Clase base abstracta para la generación de passwords
    public abstract class GeneradorPassword
    {
        protected int longitud;
        protected string password;
        protected string caracteres;
        protected Random random;

        public GeneradorPassword(int longitud)
        {
            this.longitud = longitud;
            this.random = new Random();
        }

        public abstract void GenerarPassword();

        public string ObtenerPassword()
        {
            return password;
        }
    }
}
