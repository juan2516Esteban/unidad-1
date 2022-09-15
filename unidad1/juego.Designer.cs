namespace unidad1
{
    partial class juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.preguntas = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::unidad1.Properties.Resources.juego;
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 248);
            this.panel1.TabIndex = 0;
            // 
            // preguntas
            // 
            this.preguntas.AutoSize = true;
            this.preguntas.Location = new System.Drawing.Point(222, 278);
            this.preguntas.Name = "preguntas";
            this.preguntas.Size = new System.Drawing.Size(35, 13);
            this.preguntas.TabIndex = 1;
            this.preguntas.Text = "label1";
            this.preguntas.Click += new System.EventHandler(this.preguntas_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(9, 310);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(200, 36);
            this.buttonA.TabIndex = 2;
            this.buttonA.Text = "butto";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(264, 310);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(217, 36);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "button2";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(9, 380);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(200, 36);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "button3";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(264, 380);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(217, 36);
            this.buttonD.TabIndex = 5;
            this.buttonD.Text = "button4";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opción A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Opción B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opción C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opción D";
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.preguntas);
            this.Controls.Add(this.panel1);
            this.Name = "juego";
            this.Text = "juego";
            this.Load += new System.EventHandler(this.juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label preguntas;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}