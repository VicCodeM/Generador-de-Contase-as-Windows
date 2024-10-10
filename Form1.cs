using BespokeFusion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrasesAzar;
using System.IO;
using System.Diagnostics;

namespace GeneradordeContraseñas
{
    public partial class Form1 : Form
    {
        //Mover Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        int conteo = 0;
        string fresedia = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

      

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.WindowState = FormWindowState.Minimized;

        }

      

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int longitud = Convert.ToInt32(textBox2.Text);
            if (longitud > 126)
            {
                MessageBox.Show("Solo se perimte hasta 126 Caracteres", "Atención");
                textBox1.Text = "iDbmIc-Rz}L9jKVUqVJL*$Ef0^9xE[2<gX1ZrwWmFR$1u^M't!k!8r00}`(O8iN7kYnL7{(_}#F1~1;6-/Ei6[T>#[bw!H8#EQRV5ASx]q°`l>0vKLh/e*BsFyo69f";
                textBox2.Text = "126";
                
            }
            if (checkBox1.Checked)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
               
            }
            if (checkBox2.Checked)
            {
                var characters = "12345678910123456789";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
             
            }
           if (checkBox3.Checked)
            {
                var characters = "#$%&/()=?¡¿!.,:{}[]+-*_~";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
                
            }
           if (checkBox1.Checked && checkBox2.Checked)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890123456789";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
              
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!°#$%&'()*+,-./:;<=>?@[]^_`{|}~";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
              
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                var characters = "123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
                
            }
            if (checkBox2.Checked && checkBox1.Checked)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890123456789";
                var Charsarr = new char[longitud];
                var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
              
            }

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~";
                var Charsarr = new char[longitud];
                var random = new Random();
                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                textBox1.Text = resultString;
                

            }

            System.IO.StreamWriter guardar = new System.IO.StreamWriter("Password.txt", true);
            conteo++;
            string ido = conteo.ToString();
            
            guardar.WriteLine("Pwd: "+ textBox1.Text );
           
            guardar.Close();
           // listBox1.Items.Add("Pwd: " + textBox1.Text);
            if (longitud >= 1 && longitud <= 12)
            {
                label3.ForeColor = System.Drawing.Color.Salmon;
                label3.Text = "Password con " + longitud + " caracteres, seguridad muy baja no recomendada";
            }
           else if (longitud >= 12 && longitud <=16)
            {
                label3.ForeColor = System.Drawing.Color.Tomato;
                label3.Text = "Password con " + longitud + " caracteres, seguridad media recomendada";
            }

            else if (longitud >= 17 && longitud <= 25)
            {
                label3.ForeColor = System.Drawing.Color.Crimson;
                label3.Text = "Password con " + longitud + " caracteres, seguridad alta recomendada";
            }
            else if (longitud >= 30 && longitud < 127)
            {
                label3.ForeColor = System.Drawing.Color.Crimson;
                label3.Text = "Password con " + longitud + " caracteres, seguridad muy alta mejor recomendada";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrasedelDia fg = new FrasedelDia();
            label1.Text = fg.FrasedeHoy(fresedia);
            //agregar txt
            int longitud = Convert.ToInt32(textBox2.Text);
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            var Charsarr = new char[longitud];
            var random = new Random(); for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);

            textBox1.Text = resultString;
            System.IO.StreamWriter guardar = new System.IO.StreamWriter("Password.txt", true);
            //conteo++;
           // guardar.WriteLine("Pwd: " + textBox1.Text);
            guardar.Close();

            //leer txt
            string ido = conteo.ToString();
            System.IO.StreamReader guardar2 = new System.IO.StreamReader("Password.txt", true);
            while ((ido = guardar2.ReadLine()) != null)
            {
               // listBox1.Items.Add(ido);
            }
            guardar2.Close();




        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("El campo no debe estar vacio. Pulsa generar para una contraseña nueva.", "Campo Vacio");
            }else if (textBox1.SelectionLength == 0)
            {
                textBox1.SelectAll();
                textBox1.Copy();
                MessageBox.Show("La contraseña generada se cargo al portapapeles.", "Copiado al Portapapeles"); 
            }
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textBox1.Focus();
            if (textBox1.Text == "")
            {

            }
            else if (textBox1.SelectionLength == 0)
            {
                textBox1.SelectAll();
                textBox1.Copy();

            }

            if (true)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.IO.File.WriteAllText("Password.txt", string.Empty);
            FileStream borrarcontenido = File.Open("Password.txt", FileMode.Open);
            borrarcontenido.SetLength(0); 
            borrarcontenido.Close();
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process P = new Process();
            P.StartInfo.FileName = "Password.txt";
            P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            P.Start();
            //Espera el proceso para que lo termine y continuar
            P.WaitForExit();
            //Liberar
            P.Close();
        }
    }
}
