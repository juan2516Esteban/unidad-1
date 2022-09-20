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
        int sub_indice=0;
       
        protected void otra_interfaz()
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


        protected void guardar_preguntas()
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
        protected void guardar_opciones_A()
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
        protected void guardar_opciones_B()
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

        protected void guardar_opciones_C()
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

        protected void guardar_opciones_D()
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

        protected void comprobacion()
        {
            if (precionar_A == true || precionar_B==true || precionar_C==true || precionar_D == true)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
        }

        protected void cambiar_interface()
        {
            guardar_preguntas();
            preguntas.Text = preguntas_info.Rows[sub_indice]["preguntas?"].ToString();

            guardar_opciones_A();
            buttonA.Text = opcion_A.Rows[sub_indice]["opciones A"].ToString();

            guardar_opciones_B();
            buttonB.Text = opcion_B.Rows[sub_indice]["opciones B"].ToString();

            guardar_opciones_C();
            buttonC.Text = opcion_C.Rows[sub_indice]["opciones C"].ToString();

            guardar_opciones_D();
            buttonD.Text = opcion_D.Rows[sub_indice]["opciones D"].ToString();

            sub_indice++;
            otra_interfaz();
        }

        private void cambiar_color()
        {
            if (ColorA == true)
            {
                buttonA.BackColor = Color.FromArgb(11,212,84);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(245, 112, 76);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if(ColorB == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(11,212,84);
                buttonC.BackColor = Color.FromArgb(245, 112, 76);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if(ColorC == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(11,212,84);
                buttonD.BackColor = Color.FromArgb(245, 112, 76);
            }
            else if(ColorD == true)
            {
                buttonA.BackColor = Color.FromArgb(245, 112, 76);
                buttonB.BackColor = Color.FromArgb(245, 112, 76);
                buttonC.BackColor = Color.FromArgb(245,112,76);
                buttonD.BackColor = Color.FromArgb(11,212,84);
            }
              
         }
        
        protected void opcion_A_correcta()
        {
                if (precionar_A == true)
                {
                    ColorA = true;
                    monto_dinero += 500000;
                    Dinero.Text = monto_dinero.ToString();
                    cambiar_color();
                    MessageBox.Show("la respuesta A es la correcta ganaste 500,000 pesos !!!");

                 cambiar_interface();

                }

                else
                {
                    if (monto_dinero > 0)
                    {
                        ColorA = true;
                        monto_dinero -= 250000;
                        Dinero.Text = monto_dinero.ToString();
                        cambiar_color();
                        MessageBox.Show("Lo sentimos la respuesta correcta es la A");

                        cambiar_interface();
                }

                else
                {
                    ColorA=true;
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la A , como tu valor actual de dinero es 0 no se te descontara nada");

                    cambiar_interface();
                }

                }
        }

        protected void opcion_B_correcta()
        {

            if (precionar_B == true)
            {
                ColorB = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                cambiar_color();
                MessageBox.Show("la respuesta B es la correcta ganaste 500,000 pesos !!!");

                cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorB = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la B");

                    cambiar_interface();
                }

                else
                {
                    ColorB = true;
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la B , como tu valor actual de dinero es 0 no se te descontara nada");

                    cambiar_interface();
                }

            }
        }

        protected void opcion_C_correcta()
        {

            if (precionar_C == true)
            {
                ColorC = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                cambiar_color();
                MessageBox.Show("la respuesta C es la correcta ganaste 500,000 pesos !!!");

                cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorC = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la C");

                    cambiar_interface();
                }

                else
                {
                    ColorC = true;
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la C , como tu valor actual de dinero es 0 no se te descontara nada");

                    cambiar_interface();
                }

            }
        }

        protected void opcion_D_correcta()
        {

            if (precionar_D == true)
            {
                ColorD = true;
                monto_dinero += 500000;
                Dinero.Text = monto_dinero.ToString();
                cambiar_color();
                MessageBox.Show("la respuesta D es la correcta ganaste 500,000 pesos !!!");

                cambiar_interface();

            }

            else
            {
                if (monto_dinero > 0)
                {
                    ColorD = true;
                    monto_dinero -= 250000;
                    Dinero.Text = monto_dinero.ToString();
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la D");

                    cambiar_interface();
                }

                else
                {
                    ColorD = true;
                    cambiar_color();
                    MessageBox.Show("Lo sentimos la respuesta correcta es la D , como tu valor actual de dinero es 0 no se te descontara nada");

                    cambiar_interface();
                }

            }
        }


        protected void cacular_cual_es_correcta()
        {
            if (sub_indice == 1)
            {
                opcion_A_correcta();
            }
            else if(sub_indice == 2)
            {
                opcion_C_correcta();
            }
            else if(sub_indice == 3)
            {
                opcion_C_correcta();
            }
            else if(sub_indice == 4)
            {
                opcion_A_correcta();
            }
            else if(sub_indice == 5)
            {
                opcion_B_correcta();
            }
            else if (sub_indice == 6) { 
                opcion_D_correcta();
            }
            else if (sub_indice == 7)
            {
                opcion_D_correcta();
                MessageBox.Show("Felicitaciones has terminado el juego, acabas de llebarte la suma total de: " + monto_dinero);

                this.Hide();
            }



            

        }

        private void juego_Load(object sender, EventArgs e)
        { 
            cambiar_interface();
            Dinero.Text = monto_dinero.ToString();
        }

        private void preguntas_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            precionar_A = true;
            comprobacion();
            cacular_cual_es_correcta();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            precionar_B = true;
            comprobacion();
            cacular_cual_es_correcta();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            precionar_C = true;
            comprobacion();
            cacular_cual_es_correcta();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            precionar_D = true;
            comprobacion();
            cacular_cual_es_correcta();
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
    }
}
