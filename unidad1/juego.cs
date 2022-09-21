using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        protected DataTable opcion_A = new DataTable();
        protected DataTable opcion_B = new DataTable();
        protected DataTable opcion_C = new DataTable();
        protected DataTable opcion_D = new DataTable();

        bool precionar_A = false;
        bool precionar_B = false;
        bool precionar_C = false;
        bool precionar_D = false;

        bool ColorA = false;
        bool ColorB = false;
        bool ColorC = false;
        bool ColorD = false;

        bool solo_crear_una_vez = true;
        double monto_dinero = 0;
        int sub_indice = 0;
        int comodin = 2;
        protected void Otra_interfaz()
        {
            solo_crear_una_vez = false;

            precionar_A = false;
            precionar_B = false;
            precionar_C = false;
            precionar_D = false;

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;

            ColorA = false;
            ColorB = false;
            ColorC = false;
            ColorD = false;

        }


        protected void Guardar_preguntas()
        {
            if (solo_crear_una_vez == true)
            {
                preguntas_info.Columns.Add("preguntas?");
            }
            preguntas_info.Rows.Add(new object[] { "Si un día decidieras sembrar semillas de Quercus robur. ¿Qué crecería?" });
            preguntas_info.Rows.Add(new object[] { "¿Los neurólogos creen que la corteza prefrontal del cerebro se activa cuando haces qué?" });
            preguntas_info.Rows.Add(new object[] { "¿Quién fue el primero en recibir un premio Nobel de Literatura?" });
            preguntas_info.Rows.Add(new object[] { "¿Con qué letra comienza la palabra del tomo 21 de la Enciclopedia Espasa?" });
            preguntas_info.Rows.Add(new object[] { "¿Qué elemento químico fue nombrado en honor a un malvado duende del subsuelo?" });
            preguntas_info.Rows.Add(new object[] { "¿Cuántos mares rodean la península de los Balcanes?" });
            preguntas_info.Rows.Add(new object[] { "¿Cual es el valor equivalente de 2^3?" });

        }
        protected void Guardar_opciones_A()
        {
            if (solo_crear_una_vez == true)
            {
                opcion_A.Columns.Add("opciones A");
            }
            opcion_A.Rows.Add(new object[] { "¿Un Árbol?" });
            opcion_A.Rows.Add(new object[] { "Tienes un ataque de pánico" });
            opcion_A.Rows.Add(new object[] { "Novelista" });
            opcion_A.Rows.Add(new object[] { "E" });
            opcion_A.Rows.Add(new object[] { "Hafnio" });
            opcion_A.Rows.Add(new object[] { "3" });
            opcion_A.Rows.Add(new object[] { "6" });


        }
        protected void Guardar_opciones_B()
        {
            if (solo_crear_una_vez == true)
            {
                opcion_B.Columns.Add("opciones B");
            }
            opcion_B.Rows.Add(new object[] { "¿Flores?" });
            opcion_B.Rows.Add(new object[] { "Recuerdas un nombre" });
            opcion_B.Rows.Add(new object[] { "Dramaturgo" });
            opcion_B.Rows.Add(new object[] { "F" });
            opcion_B.Rows.Add(new object[] { "Cobalto" });
            opcion_B.Rows.Add(new object[] { "4" });
            opcion_B.Rows.Add(new object[] { "16" });

        }

        protected void Guardar_opciones_C()
        {
            if (solo_crear_una_vez == true)
            {
                opcion_C.Columns.Add("opciones C");
            }

            opcion_C.Rows.Add(new object[] { "¿Verduras?" });
            opcion_C.Rows.Add(new object[] { "Entiendes una broma" });
            opcion_C.Rows.Add(new object[] { "Poeta" });
            opcion_C.Rows.Add(new object[] { "G" });
            opcion_C.Rows.Add(new object[] { "Berilio" });
            opcion_C.Rows.Add(new object[] { "5" });
            opcion_C.Rows.Add(new object[] { "4" });
        }

        protected void Guardar_opciones_D()
        {
            if (solo_crear_una_vez == true)
            {
                opcion_D.Columns.Add("opciones D");
            }

            opcion_D.Rows.Add(new object[] { "¿Granos?" });
            opcion_D.Rows.Add(new object[] { "Escuchas música" });
            opcion_D.Rows.Add(new object[] { "Ensayista" });
            opcion_D.Rows.Add(new object[] { "H" });
            opcion_D.Rows.Add(new object[] { "Telurio" });
            opcion_D.Rows.Add(new object[] { "6" });
            opcion_D.Rows.Add(new object[] { "8" });

        }

        protected void Comprobacion()
        {
            if (precionar_A == true || precionar_B == true || precionar_C == true || precionar_D == true)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
        }

        protected void Cambiar_interface()
        {
            Guardar_preguntas();
            preguntas.Text = preguntas_info.Rows[sub_indice]["preguntas?"].ToString();

            Guardar_opciones_A();
            buttonA.Text = opcion_A.Rows[sub_indice]["opciones A"].ToString();

            Guardar_opciones_B();
            buttonB.Text = opcion_B.Rows[sub_indice]["opciones B"].ToString();

            Guardar_opciones_C();
            buttonC.Text = opcion_C.Rows[sub_indice]["opciones C"].ToString();

            Guardar_opciones_D();
            buttonD.Text = opcion_D.Rows[sub_indice]["opciones D"].ToString();

            sub_indice++;
            Otra_interfaz();
        }

        private void Cambiar_color()
        {
            if (ColorA == true)
            {
                buttonA.BackColor = Color.FromArgb(11, 212, 84);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(245, 112, 76);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if (ColorB == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(11, 212, 84);
                buttonC.BackColor = Color.FromArgb(245, 112, 76);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if (ColorC == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(11, 212, 84);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if (ColorD == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(245, 112, 76);
                buttonD.BackColor = Color.FromArgb(11, 212, 84);
            }

        }

        protected void Opcion_A_correcta()
        {
            if (precionar_A == true)
            {
                ColorA = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                Cambiar_color();
                MessageBox.Show("la respuesta A es la correcta ganaste 500,000 pesos !!!");

                Cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorA = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la A");

                    Cambiar_interface();
                }

                else
                {
                    ColorA = true;
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la A , como tu valor actual de dinero es 0 no se te descontara nada");

                    Cambiar_interface();
                }

            }
        }

        protected void Opcion_B_correcta()
        {

            if (precionar_B == true)
            {
                ColorB = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                Cambiar_color();
                MessageBox.Show("la respuesta B es la correcta ganaste 500,000 pesos !!!");

                Cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorB = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la B");

                    Cambiar_interface();
                }

                else
                {
                    ColorB = true;
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la B , como tu valor actual de dinero es 0 no se te descontara nada");

                    Cambiar_interface();
                }

            }
        }

        protected void Opcion_C_correcta()
        {

            if (precionar_C == true)
            {
                ColorC = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                Cambiar_color();
                MessageBox.Show("la respuesta C es la correcta ganaste 500,000 pesos !!!");

                Cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorC = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la C");

                    Cambiar_interface();
                }

                else
                {
                    ColorC = true;
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la C , como tu valor actual de dinero es 0 no se te descontara nada");

                    Cambiar_interface();
                }

            }
        }

        protected void Opcion_D_correcta()
        {

            if (precionar_D == true)
            {
                ColorD = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                Cambiar_color();
                MessageBox.Show("la respuesta D es la correcta ganaste 500,000 pesos !!!");

                Cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorD = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la D");

                    Cambiar_interface();
                }

                else
                {
                    ColorD = true;
                    Cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la D , como tu valor actual de dinero es 0 no se te descontara nada");

                    Cambiar_interface();
                }

            }
        }


        protected void Cacular_cual_es_correcta()
        {
            if (sub_indice == 1)
            {
                Opcion_A_correcta();
            }
            else if (comodin == 3)
            {
                comodin += 1;
                Opcion_A_correcta();
                Otra_interfaz();
            }
            else if (sub_indice == 2)
            {
                Opcion_C_correcta();
            }
            else if (sub_indice == 3)
            {
                Opcion_C_correcta();
            }
            else if (sub_indice == 4)
            {
                Opcion_A_correcta();
            }
            else if (sub_indice == 5)
            {
                Opcion_B_correcta();
            }
            else if (sub_indice == 6)
            {
                Opcion_D_correcta();
            }
            else if (sub_indice == 7)
            {
                Opcion_D_correcta();

                MessageBox.Show("Felicitaciones has terminado el juego, acabas de llebarte la suma total de: " + monto_dinero);

                this.Hide();
            }
        }

        private void juego_Load(object sender, EventArgs e)
        {
            Cambiar_interface();
            Dinero.Text = monto_dinero.ToString();
        }

        private void preguntas_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            precionar_A = true;
            Comprobacion();
            Cacular_cual_es_correcta();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            precionar_B = true;
            Comprobacion();
            Cacular_cual_es_correcta();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            precionar_C = true;
            Comprobacion();
            Cacular_cual_es_correcta();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            precionar_D = true;
            Comprobacion();
            Cacular_cual_es_correcta();
        }

        private void Dinero_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(62, 63, 214);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Cincuenta_Cincuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acabas de utilizar el 50/50 aprobechalo ya que solo lo podras utilizar una vez !!!");

            if (sub_indice == 1 || sub_indice == 4)
            {
                CincuentaA();
            }
            else if (sub_indice == 5)
            {
                CincuentaB();
            }
            else if (sub_indice==2 || sub_indice == 3)
            {
                CincuentaC();
            }
            else if (sub_indice == 6 || sub_indice == 7)
            {
                CincuentaD();
            }

            Cincuenta_Cincuenta.Enabled = false;
        }

        protected void CincuentaA()
        {
                Random rd = new Random();
                int rd1=rd.Next(0,2);

                if(rd1 == 0)
            {
                buttonB.Enabled= false;
                buttonD.Enabled= false;
            }
               else if (rd1 == 1)
            {
                buttonC.Enabled=false;
                buttonD.Enabled=false;
            }
                else if(rd1 == 2)
            {
                buttonC.Enabled= false;
                buttonB.Enabled= false;
            }
           
            
        }

        protected void CincuentaB()
        {
            Random rd = new Random();
            int rd1 = rd.Next(0, 2);

            if (rd1 == 0)
            {
                buttonA.Enabled = false;
                buttonD.Enabled = false;
            }
            else if (rd1 == 1)
            {
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            else if (rd1 == 2)
            {
                buttonC.Enabled = false;
                buttonA.Enabled = false;
            }
            


        }

        protected void CincuentaC()
        {
            Random rd = new Random();
            int rd1 = rd.Next(0, 2);

            if (rd1 == 0)
            {
                buttonA.Enabled = false;
                buttonD.Enabled = false;
            }
            else if (rd1 == 1)
            {
                buttonB.Enabled = false;
                buttonD.Enabled = false;
            }
            else if (rd1 == 2)
            {
                buttonB.Enabled = false;
                buttonA.Enabled = false;
            }


        }

        protected void CincuentaD()
        {
            Random rd = new Random();
            int rd1 = rd.Next(0, 2);

            if (rd1 == 0)
            {
                buttonA.Enabled = false;
                buttonC.Enabled = false;
            }
            else if (rd1 == 1)
            {
                buttonB.Enabled = false;
                buttonC.Enabled = false;
            }
            else if (rd1 == 2)
            {
                buttonB.Enabled = false;
                buttonA.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acabas de escoger cambio de pregunta, esto te dara otra oportunidad aprovechala!!!");
            preguntas.Text = "¿Qué palabra aparece tradicionalmente en la pantalla al terminar un largometraje?";
            buttonA.Text= "Fin";
            buttonB.Text = "Conclucion";
            buttonC.Text = "Final";
            buttonD.Text = "acabo";

            comodin += 1;

            button2.Enabled = false;
        }
    }
}
