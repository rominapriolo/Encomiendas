using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encomiendas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

          
             MenuVertical.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFE1DE");
            treeView1.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFE1DE");
            panelContenedor.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFE1DE");

            GenerarMenu();

            Login login = new Login();
            login.ShowDialog();
        }

 

        private void GenerarMenu() {
            
            //0 - Operaciones
            treeView1.Nodes.Add("Principal", "Operaciones", 2, 2);
            treeView1.Nodes[0].Nodes.Add("Solicitar un servicio de correspondencia o encomienda") ;
            treeView1.Nodes[0].Nodes[0].Name = "IngresarSolicituddeServicio";            

            //1 - Consultas
            
            treeView1.Nodes[0].Nodes.Add("Consultar el estado de cuenta");
            treeView1.Nodes[0].Nodes[1].Name = "ConsultarEstadoDeCuenta";
            treeView1.Nodes[0].Nodes.Add("Consultar el estado de un servicio");
            treeView1.Nodes[0].Nodes[2].Name = "ConsultarEstadoDeServicio";


            

            treeView1.MouseDoubleClick+= treeList_MouseDoubleClick;

        }     

        private  void treeList_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            //MessageBox.Show(treeView1.SelectedNode.Name);

            switch (treeView1.SelectedNode.Name)
            {
                case "IngresarSolicituddeServicio":
                    // code block
                    abrirForm(new IngresarSolicituddeServicio());
                    break;
                case "ConsultarEstadoDeCuenta":
                    // code block
                    abrirForm(new ConsultarEstadoDeCuenta());
                    break;
                case "ConsultarEstadoDeServicio":
                    // code block
                    abrirForm(new ConsultarEstadoDeServicio());
                    break;
                default:
                    // code block
                    break;
            }


        }

        private void abrirForm(object frm) 
        { 
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);

            }

            Form form = frm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            panelContenedor.Tag = form;
            form.Show();


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
