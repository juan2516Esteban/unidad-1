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
    public partial class Palabras : Form
    {
        public Palabras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z, a;
            string letras;
            z = 0;
            for(a = 0; a < Palabras2.Text.Length; a++)
            {
                letras = Palabras2.Text.Substring(a,1);
                if (letras == " ")
                {
                    z++;
                }
            }
            MessageBox.Show("la frase tiene " + z +" espacios");
        }

        private void Palabras_Load(object sender, EventArgs e)
        {

        }
    }
}
