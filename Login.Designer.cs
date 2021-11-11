
namespace Encomiendas
{
    partial class Login
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
            this.Button_entrar = new System.Windows.Forms.Button();
            this.Button_salir = new System.Windows.Forms.Button();
            this.TextBox_contraseña = new System.Windows.Forms.TextBox();
            this.TextBox_nombre_usuario = new System.Windows.Forms.TextBox();
            this.Label_contraseña = new System.Windows.Forms.Label();
            this.Label_nombre_usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_entrar
            // 
            this.Button_entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_entrar.Location = new System.Drawing.Point(334, 78);
            this.Button_entrar.Name = "Button_entrar";
            this.Button_entrar.Size = new System.Drawing.Size(62, 27);
            this.Button_entrar.TabIndex = 11;
            this.Button_entrar.Text = "Entrar";
            this.Button_entrar.UseVisualStyleBackColor = true;
            this.Button_entrar.Click += new System.EventHandler(this.Button_entrar_Click);
            // 
            // Button_salir
            // 
            this.Button_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_salir.Location = new System.Drawing.Point(402, 78);
            this.Button_salir.Name = "Button_salir";
            this.Button_salir.Size = new System.Drawing.Size(50, 27);
            this.Button_salir.TabIndex = 12;
            this.Button_salir.Text = "Salir";
            this.Button_salir.UseVisualStyleBackColor = true;
            this.Button_salir.Click += new System.EventHandler(this.Button_salir_Click);
            // 
            // TextBox_contraseña
            // 
            this.TextBox_contraseña.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TextBox_contraseña.Location = new System.Drawing.Point(221, 50);
            this.TextBox_contraseña.MaxLength = 8;
            this.TextBox_contraseña.Name = "TextBox_contraseña";
            this.TextBox_contraseña.PasswordChar = 'l';
            this.TextBox_contraseña.Size = new System.Drawing.Size(231, 22);
            this.TextBox_contraseña.TabIndex = 10;
            this.TextBox_contraseña.Text = "Text_contraseña";
            this.TextBox_contraseña.TextChanged += new System.EventHandler(this.TextBox_contraseña_TextChanged);
            this.TextBox_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_contraseña_KeyPress);
            // 
            // TextBox_nombre_usuario
            // 
            this.TextBox_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_nombre_usuario.Location = new System.Drawing.Point(221, 19);
            this.TextBox_nombre_usuario.Name = "TextBox_nombre_usuario";
            this.TextBox_nombre_usuario.Size = new System.Drawing.Size(231, 22);
            this.TextBox_nombre_usuario.TabIndex = 8;
            this.TextBox_nombre_usuario.Text = "Text_nombre_usuario";
            this.TextBox_nombre_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_nombre_usuario_KeyPress);
            // 
            // Label_contraseña
            // 
            this.Label_contraseña.AutoSize = true;
            this.Label_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_contraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_contraseña.Location = new System.Drawing.Point(14, 53);
            this.Label_contraseña.Name = "Label_contraseña";
            this.Label_contraseña.Size = new System.Drawing.Size(87, 16);
            this.Label_contraseña.TabIndex = 9;
            this.Label_contraseña.Text = "Contraseña";
            // 
            // Label_nombre_usuario
            // 
            this.Label_nombre_usuario.AutoSize = true;
            this.Label_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_nombre_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label_nombre_usuario.Location = new System.Drawing.Point(14, 22);
            this.Label_nombre_usuario.Name = "Label_nombre_usuario";
            this.Label_nombre_usuario.Size = new System.Drawing.Size(62, 16);
            this.Label_nombre_usuario.TabIndex = 7;
            this.Label_nombre_usuario.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_nombre_usuario);
            this.groupBox1.Controls.Add(this.Button_entrar);
            this.groupBox1.Controls.Add(this.Label_nombre_usuario);
            this.groupBox1.Controls.Add(this.Button_salir);
            this.groupBox1.Controls.Add(this.Label_contraseña);
            this.groupBox1.Controls.Add(this.TextBox_contraseña);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 115);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 133);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button_entrar;
        internal System.Windows.Forms.Button Button_salir;
        internal System.Windows.Forms.TextBox TextBox_contraseña;
        internal System.Windows.Forms.TextBox TextBox_nombre_usuario;
        internal System.Windows.Forms.Label Label_contraseña;
        internal System.Windows.Forms.Label Label_nombre_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}