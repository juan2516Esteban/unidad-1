using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad1
{
    internal class almacenamiento_de_usuarios
    {
        public void usuarios_data_table(string nombre, string apellido, string correo_, string nombre_de_usuario, string contraseña)
        {
            var registrate_Usuar = new DataTable("usuarios");
            registrate_Usuar.Columns.Add("Nombre", typeof(String));
            registrate_Usuar.Columns.Add("Apellido", typeof(String));
            registrate_Usuar.Columns.Add("Correo Electronico", typeof(String));
            registrate_Usuar.Columns.Add("Nombre de usuario", typeof(String));
            registrate_Usuar.Columns.Add("Contraseña", typeof(string));

            registrate_Usuar.Rows.Add(new object[] { "juan esteban", "salazar", "juanesteban.salaza1@gmail.com", "papa", "2345juan" });
            registrate_Usuar.Rows.Add(new object[] { nombre, apellido, correo_, nombre_de_usuario, contraseña });

            foreach (DataRow i in registrate_Usuar.Rows)
            {
                MessageBox.Show(i["Nombre"].ToString());
            }
        }

        public void comparación(String correo,String contraseña)
        {
            
        } 
    }
}
