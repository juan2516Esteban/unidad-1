namespace unidad1
{
    partial class registrate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Nombre_Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.confirmar_pass = new System.Windows.Forms.TextBox();
            this.Guardar_Usuarios = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre de usuario";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(17, 33);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 20);
            this.Nombre.TabIndex = 6;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.Location = new System.Drawing.Point(250, 116);
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.Size = new System.Drawing.Size(192, 20);
            this.Nombre_Usuario.TabIndex = 7;
            this.Nombre_Usuario.TextChanged += new System.EventHandler(this.Nombre_Usuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(17, 202);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(192, 20);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.UseSystemPasswordChar = true;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(17, 115);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(192, 20);
            this.Correo.TabIndex = 9;
            this.Correo.TextChanged += new System.EventHandler(this.Correo_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(250, 33);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(192, 20);
            this.Apellido.TabIndex = 10;
            this.Apellido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // confirmar_pass
            // 
            this.confirmar_pass.Location = new System.Drawing.Point(250, 202);
            this.confirmar_pass.Name = "confirmar_pass";
            this.confirmar_pass.PasswordChar = '*';
            this.confirmar_pass.Size = new System.Drawing.Size(192, 20);
            this.confirmar_pass.TabIndex = 11;
            this.confirmar_pass.UseSystemPasswordChar = true;
            this.confirmar_pass.TextChanged += new System.EventHandler(this.confirmar_pass_TextChanged);
            // 
            // Guardar_Usuarios
            // 
            this.Guardar_Usuarios.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Usuarios.Location = new System.Drawing.Point(126, 254);
            this.Guardar_Usuarios.Name = "Guardar_Usuarios";
            this.Guardar_Usuarios.Size = new System.Drawing.Size(203, 47);
            this.Guardar_Usuarios.TabIndex = 12;
            this.Guardar_Usuarios.Text = "registrate";
            this.Guardar_Usuarios.UseVisualStyleBackColor = true;
            this.Guardar_Usuarios.Click += new System.EventHandler(this.Guardar_Usuarios_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(14, 318);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Prefiero Iniciar Seccion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::unidad1.Properties.Resources.interfaz;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(471, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 365);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Guardar_Usuarios);
            this.panel2.Controls.Add(this.confirmar_pass);
            this.panel2.Controls.Add(this.Apellido);
            this.panel2.Controls.Add(this.Correo);
            this.panel2.Controls.Add(this.Contraseña);
            this.panel2.Controls.Add(this.Nombre_Usuario);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 359);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // registrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "registrate";
            this.Text = "registrate";
            this.Load += new System.EventHandler(this.registrate_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Nombre_Usuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox confirmar_pass;
        private System.Windows.Forms.Button Guardar_Usuarios;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}