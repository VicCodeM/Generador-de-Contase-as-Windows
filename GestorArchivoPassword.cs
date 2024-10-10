using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeContraseñas
{
    // Clase para gestionar el almacenamiento del password en un archivo
    public class GestorArchivoPassword
    {
        private static int conteo = 0;

        public static void GuardarPasswordEnArchivo(string password)
        {
            conteo++;
            using (StreamWriter escritor = new StreamWriter("Passwords.txt", true))
            {
                escritor.WriteLine("Password: " + password);
            }
        }
    }
}
