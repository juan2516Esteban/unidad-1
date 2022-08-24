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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void Fahrenheit1(double x)
        {
            double y = (x * 1.8) + 32;
            MessageBox.Show("la convercion de Centidragos a Fahrenheit es: " + y);

        }
        public void Centigrados1(double x)
        {
            double p = (x - 32) / 1.8;
            MessageBox.Show("la convercion de Fahrenheit a Centigrados es: " + p);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Double.Parse(Centigrados.Text);
            Fahrenheit1(r);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Double.Parse(Fahrenheit.Text);
            Centigrados1(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Palabras palabras = new Palabras();
            palabras.Show();
        }
    }
}
