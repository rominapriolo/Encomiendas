using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encomiendas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string ruta_archivo_usuarios = "../../datos/usuarios.txt";

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ruta_archivo_usuarios)) 
            {                               
                MessageBox.Show("Falta el Archivo de Usuarios, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
                //var reader = File.OpenRead(ruta_archivo_usuarios);
            }


            this.CenterToScreen();
            TextBox_contraseña.Text = "";
            TextBox_nombre_usuario.Text = "";


        }

        private void Button_entrar_Click(object sender, EventArgs e)
        {
            if (TextBox_contraseña.Text.Equals("")) {
                MessageBox.Show("Por favor ingrese la contraseña!");
                TextBox_contraseña.Focus();
                return;
            }

            if (TextBox_nombre_usuario.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el usuario!");
                TextBox_nombre_usuario.Focus();
                return;
            }

            Usuario usuario = new Usuario();

            usuario.usuario = TextBox_nombre_usuario.Text;
            usuario.contrasena = TextBox_contraseña.Text;

            bool usuario_valido = usuario.verificarUsuario();

            if (usuario_valido)
            {
                //MessageBox.Show("Bienvenido!");
                VariablesGlobales.var_global_usuario = TextBox_nombre_usuario.Text;
                //MenuPrincipal form = new MenuPrincipal();

                //form.Show();
                this.Close();
                
                //this.Close();
                //

            }
            else {
                MessageBox.Show("Por favor revise los datos ingresados!");
            }


        }


       
             


        private void TextBox_nombre_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string aceptados = "-0123456789";

            if (aceptados.Contains(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }            

        }

        private void TextBox_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                Button_entrar.PerformClick();
            }
            
            
        }

        private void Button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_contraseña_TextChanged(object sender, EventArgs e)
        {

        }



        //If e.KeyChar = "," Or e.KeyChar = "." Then
        //        If TextBox_importe.Text.Contains(",") Then
        //        e.Handled = True
        //        Exit Sub
        //    End If
        //    End If
        //    If e.KeyChar = "-" Then

        //        If TextBox_importe.Text.Length > 0 Then
        //            e.Handled = True
        //            Exit Sub
        //        End If

        //        If TextBox_importe.Text.Contains("-") Then
        //            e.Handled = True
        //            Exit Sub
        //        End If

        //    End If


        //    Dim aceptados As String = "-0123456789,"
        //    If aceptados.Contains(e.KeyChar) Then
        //        e.Handled = False
        //    Else
        //        If e.KeyChar = "." Then
        //            e.KeyChar = ","
        //            e.Handled = False
        //        Else
        //            e.Handled = True
        //        End If
        //    End If

        //    pintar_importe_en_rojo()
        //End Sub
        //    }
    }
}
