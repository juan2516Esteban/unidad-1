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
    public partial class juego : Form
    {
        public juego()
        {
            InitializeComponent();
        }
        protected DataTable preguntas_info = new DataTable();

        protected void guardar_preguntas()
        {
            preguntas_info.Columns.Add("preguntas?");
            preguntas_info.Rows.Add(new object[] { "esto es una pregunta" });
        }

        private void juego_Load(object sender, EventArgs e)
        {
            guardar_preguntas();
            preguntas.Text = preguntas_info.Rows[0]["preguntas?"].ToString();
        }

        private void preguntas_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {

        }
    }
}
