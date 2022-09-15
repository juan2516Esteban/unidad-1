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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre de usuario";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(40, 57);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 20);
            this.Nombre.TabIndex = 6;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.Location = new System.Drawing.Point(40, 256);
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.Size = new System.Drawing.Size(192, 20);
            this.Nombre_Usuario.TabIndex = 7;
            this.Nombre_Usuario.TextChanged += new System.EventHandler(this.Nombre_Usuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(40, 332);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(192, 20);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.UseSystemPasswordChar = true;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(40, 189);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(192, 20);
            this.Correo.TabIndex = 9;
            this.Correo.TextChanged += new System.EventHandler(this.Correo_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(40, 124);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(192, 20);
            this.Apellido.TabIndex = 10;
            this.Apellido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // confirmar_pass
            // 
            this.confirmar_pass.Location = new System.Drawing.Point(40, 392);
            this.confirmar_pass.Name = "confirmar_pass";
            this.confirmar_pass.PasswordChar = '*';
            this.confirmar_pass.Size = new System.Drawing.Size(192, 20);
            this.confirmar_pass.TabIndex = 11;
            this.confirmar_pass.UseSystemPasswordChar = true;
            this.confirmar_pass.TextChanged += new System.EventHandler(this.confirmar_pass_TextChanged);
            // 
            // Guardar_Usuarios
            // 
            this.Guardar_Usuarios.Location = new System.Drawing.Point(346, 365);
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
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(392, 339);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Prefiero Iniciar Seccion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Guardar_Usuarios);
            this.Controls.Add(this.confirmar_pass);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Nombre_Usuario);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrate";
            this.Text = "registrate";
            this.Load += new System.EventHandler(this.registrate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}