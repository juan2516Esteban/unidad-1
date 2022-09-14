using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad1
{
    public partial class registrate : Form
    {
        public registrate()
        {
            InitializeComponent();
     
        }


        private void registrate_Load(object sender, EventArgs e)
        {
            Guardar_Usuarios.Enabled = false;
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            validar_campo_vacio();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validar_campo_vacio();
        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {
            validar_campo_vacio();
        }

        private void Nombre_Usuario_TextChanged(object sender, EventArgs e)
        {
            validar_campo_vacio();
        }

        public void validar_campo_vacio()
        {
            var comprobacion = !String.IsNullOrEmpty(Nombre.Text) && !String.IsNullOrEmpty(Apellido.Text) && !String.IsNullOrEmpty(Correo.Text) && !String.IsNullOrEmpty(Nombre_Usuario.Text) && !string.IsNullOrEmpty(Contraseña.Text) && !String.IsNullOrEmpty(confirmar_pass.Text);
            Guardar_Usuarios.Enabled = comprobacion;



        }
        private void Guardar_Usuarios_Click(object sender, EventArgs e)
        {
            almacenamiento_de_usuarios usuarios_registro = new almacenamiento_de_usuarios();

            string nombre = Nombre.Text;
            string apellido = Apellido.Text;
            string correo_ = Correo.Text;
            string nombre_de_usuario = Nombre_Usuario.Text;
            string contraseña = Contraseña.Text;
            string confirmar = confirmar_pass.Text;

            

            if (contraseña == confirmar)
            {
                usuarios_registro.usuarios_data_table(nombre, apellido, correo_, nombre_de_usuario, contraseña);
            }
            else
            {
                MessageBox.Show("las contraseñas no son iguales vuelve a intentarlo");
            }
      
        }

        private void confirmar_pass_TextChanged(object sender, EventArgs e)
        {
            validar_campo_vacio();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 inciar_seccion = new Form1();
            this.Hide();
            inciar_seccion.Show();

        }
    }
}
