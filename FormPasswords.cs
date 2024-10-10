using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradordeContraseñas
{
    public partial class FormPasswords : Form
    {
        private string conexionString;
       
        public FormPasswords(string dbPath)
        {
            InitializeComponent();
            conexionString = $"Data Source={dbPath};Version=3;";
            dataGridViewPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas
            dataGridViewPasswords.Dock = DockStyle.Fill; // Hacer que el DataGridView llene todo el espacio
            CargarPasswords(); // Llamar al método para cargar las contraseñas
            
        }

        private void CargarPasswords()
        {
            using (var conexion = new SQLiteConnection(conexionString))
            {
                conexion.Open();
                string query = "SELECT Password, Fecha FROM Passwords"; // Asegúrate de que esta tabla y columnas existan
                using (var comando = new SQLiteCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(lector);  // Cargar los datos en un DataTable
                        dataGridViewPasswords.DataSource = dt;  // Asignar el DataTable al DataGridView
                    }
                }
            }
        }

        private void FormPasswords_Load(object sender, EventArgs e)
        {
          EstablecerColoresDataGridView();
        }

        private void EstablecerColoresDataGridView()
        {
            // Define los colores
            Color rojo = Color.FromArgb(255, 0, 0); // Rojo
            Color colorEspecificado = Color.FromArgb(27, 30, 43); // Color especificado

            // Combinar colores promediando los componentes
            Color colorCombinado = Color.FromArgb(
                (rojo.R + colorEspecificado.R) / 2,
                (rojo.G + colorEspecificado.G) / 2,
                (rojo.B + colorEspecificado.B) / 2
            );

            // Establecer colores para las columnas del DataGridView
            foreach (DataGridViewColumn columna in dataGridViewPasswords.Columns)
            {
                columna.HeaderCell.Style.BackColor = colorCombinado; // Color del encabezado
                columna.HeaderCell.Style.ForeColor = Color.White; // Color del texto del encabezado
                columna.DefaultCellStyle.BackColor = Color.LightYellow; // Color de las celdas
                columna.DefaultCellStyle.ForeColor = Color.Black; // Color del texto de las celdas
            }
        }
    }
}
