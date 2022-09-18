using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad1
{
    internal static class almacenamiento_de_usuarios

    {
        public static DataTable registrate_Usuar = new DataTable("usuarios");

        public static bool validacion;

        public static void creacion_de_filas()
        {
            registrate_Usuar.Columns.Add("Nombre", typeof(String));
            registrate_Usuar.Columns.Add("Apellido", typeof(String));
            registrate_Usuar.Columns.Add("Correo Electronico", typeof(String));
            registrate_Usuar.Columns.Add("Nombre de usuario", typeof(String));
            registrate_Usuar.Columns.Add("Contraseña", typeof(string));
        }

        public static void usuarios_data_table(string nombre, string apellido, string correo_, string nombre_de_usuario, string contraseña)
        {
            Form1 iniciar_seccion = new Form1();
            registrate_Usuar.Rows.Add(new object[] { "juan esteban", "salazar", "juanesteban.salaza1@gmail.com", "papa", "2345juan" });
            registrate_Usuar.Rows.Add(new object[] { nombre, apellido, correo_, nombre_de_usuario, contraseña });
            MessageBox.Show("el registro a sido exitoso");
            iniciar_seccion.Show();
            
        }
      
       
        public static void comparación(String correo, String contraseña)
        {

            foreach (DataRow i in registrate_Usuar.Rows)
            {

                String correo_conparacion = i["Correo Electronico"].ToString();
                String contraseña_conparacion = i["Contraseña"].ToString();

                if (correo == correo_conparacion && contraseña == contraseña_conparacion)
                {
                    validacion = true;
                    break;

                }

            }
            if (validacion)
            {
                juego Juego = new juego();
                MessageBox.Show("su usuario fue encontrado, ya puedes iniciar a jugar");
                Juego.Show(); 
            }
            else
            {
                MessageBox.Show("el usuario no esta ingresado, por favor registrate");
            }


        }

    }
   
    }

