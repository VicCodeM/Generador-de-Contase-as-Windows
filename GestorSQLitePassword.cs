using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneradordeContraseñas
{
    public class GestorSQLitePassword
    {
        private string conexionString;

        public GestorSQLitePassword(string dbPath)
        {
            // Constructor que establece la conexión a la base de datos SQLite
            conexionString = $"Data Source={dbPath};Version=3;";
            CrearTablaSiNoExiste();
        }

        // Método para crear la tabla si no existe
        private void CrearTablaSiNoExiste()
        {
            using (var conexion = new SQLiteConnection(conexionString))
            {
                conexion.Open();
                string query = "CREATE TABLE IF NOT EXISTS Passwords (Id INTEGER PRIMARY KEY AUTOINCREMENT, Password TEXT, Fecha DATETIME)";
                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para insertar una nueva password en la base de datos
        public void GuardarPasswordEnBD(string password)
        {
            using (var conexion = new SQLiteConnection(conexionString))
            {
                conexion.Open();
                string query = "INSERT INTO Passwords (Password, Fecha) VALUES (@password, @fecha)";
                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@password", password);
                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.ExecuteNonQuery();
                }
            }

            //MessageBox.Show("Password guardada correctamente en SQLite.", "Información");
        }

        // Método para mostrar todas las passwords en un popup
        public void MostrarPasswordsEnPopup()
        {
            {
                using (var conexion = new SQLiteConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT Password, Fecha FROM Passwords";
                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            string passwords = "";
                            while (lector.Read())
                            {
                                passwords += $"Password: {lector["Password"]}, Fecha: {lector["Fecha"]}\n";
                            }

                            if (string.IsNullOrEmpty(passwords))
                            {
                                MessageBox.Show("No hay passwords guardadas.", "Información");
                            }
                            else
                            {
                                MessageBox.Show(passwords, "Passwords guardadas");
                            }
                        }
                    }
                }
            }
    }
    }
}