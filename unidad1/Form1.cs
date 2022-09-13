using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void usuario(string x, string y)
        {

            string usuario1Name = "juan esteban";
            string usuario1pass = "25162833j";

            if (usuario1Name == x && usuario1pass == y)
            {

                MessageBox.Show("Bienvenido " + x + " Acabas de entrar a esta aplicacion");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("El Usuario ingresado no ha sido registrado por favor vuelve a intentarlo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = Nombre.Text;
            string pass = Password.Text;
            usuario(nom, pass);
            this.Hide();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrate registrate = new registrate();
            this.Hide();
            registrate.Show();
        }
    }

}
