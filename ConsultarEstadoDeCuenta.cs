using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encomiendas
{
    public partial class ConsultarEstadoDeCuenta : Form
    {
        public ConsultarEstadoDeCuenta()
        {
            InitializeComponent();

            if (VariablesGlobales.var_cuit_cliente_corporativo != null && !VariablesGlobales.var_cuit_cliente_corporativo.Equals(""))
            {
                traer_datos_cliente(VariablesGlobales.var_cuit_cliente_corporativo);
                textBox_cuit.Enabled = false;
            }

            //lleno_data_grid_facturacion_paga();
            //lleno_data_grid_facturacion_impaga();
            //lleno_data_grid_servicios_cumplidos();
            //lleno_data_grid_servicios_pdtes_de_facturar();
            formato_grid(dataGridView_facturacion_impaga);
            formato_grid(dataGridView_facturacion_paga);
            formato_grid(dataGridView_servicios_cumplidos);
            formato_grid(dataGridView_servicios_pdtes_de_facturacion);

        }

        string ruta_archivo_usuarios = "../../datos/ClienteCorporativo.txt";
        private void button_buscar_Click(object sender, EventArgs e)
        {

            if (textBox_cuit.Text.Equals("")) { MessageBox.Show("Por favor ingres un CUIT!"); textBox_cuit.Focus(); return; }

                       

            EstadoDeCuenta estadoDeCuenta = new EstadoDeCuenta();
            estadoDeCuenta.cuit = textBox_cuit.Text;
            estadoDeCuenta.pagos = new List<Pago>();
            estadoDeCuenta.FacturacionImpaga = new List<Factura>();
            estadoDeCuenta.FacturacionPaga = new List<Factura>();
            estadoDeCuenta.serviciosCumplidos = new List<ServicioSolicitado>();
            estadoDeCuenta.serviciosPendientes = new List<ServicioSolicitado>();
            estadoDeCuenta.servicios_del_cliente = new List<ServicioSolicitado>();

            estadoDeCuenta.traerEstadoDeCuenta();

            if (estadoDeCuenta.FacturacionImpaga.Count == 0 && estadoDeCuenta.FacturacionPaga.Count == 0 && estadoDeCuenta.serviciosCumplidos.Count == 0 && estadoDeCuenta.serviciosPendientes.Count == 0) 
            {
                MessageBox.Show("No existe información disponible para el CUIT ingresado!");
                return;
            }

            lleno_data_grid_facturacion_paga();
            lleno_data_grid_facturacion_impaga();
            lleno_data_grid_servicios_cumplidos();
            lleno_data_grid_servicios_pdtes_de_facturar();
            textBox_saldo.Text = 0.ToString("N2");

            foreach (Factura factura_impaga in estadoDeCuenta.FacturacionImpaga) 
            {
                DataGridViewRow dr = (DataGridViewRow)dataGridView_facturacion_impaga.Rows[0].Clone();
                dr.Cells[0].Value = factura_impaga.letraComprobante+factura_impaga.nroFactura;
                dr.Cells[1].Value = factura_impaga.fechaFactura.ToString("dd/MM/yyyy");
                dr.Cells[2].Value = factura_impaga.exento;
                dr.Cells[3].Value = factura_impaga.gravado;
                dr.Cells[4].Value = factura_impaga.iva21;
                dr.Cells[5].Value = factura_impaga.totalFactura;

                dataGridView_facturacion_impaga.Rows.Add(dr);
            }
            dataGridView_facturacion_impaga.Rows.RemoveAt(0);
            formato_grid_facturas(dataGridView_facturacion_impaga);


            foreach (Factura factura_paga in estadoDeCuenta.FacturacionPaga)
            {
                DataGridViewRow dr = (DataGridViewRow)dataGridView_facturacion_paga.Rows[0].Clone();
                dr.Cells[0].Value = factura_paga.letraComprobante + factura_paga.nroFactura;
                dr.Cells[1].Value = factura_paga.fechaFactura.ToString("dd/MM/yyyy");
                dr.Cells[2].Value = factura_paga.exento;
                dr.Cells[3].Value = factura_paga.gravado;
                dr.Cells[4].Value = factura_paga.iva21;
                dr.Cells[5].Value = factura_paga.totalFactura;

                dataGridView_facturacion_paga.Rows.Add(dr);
            }

            dataGridView_facturacion_paga.Rows.RemoveAt(0);
            formato_grid_facturas(dataGridView_facturacion_paga);

            foreach (ServicioSolicitado servicio_cumplido in estadoDeCuenta.serviciosCumplidos)
            {
                DataGridViewRow dr = (DataGridViewRow)dataGridView_servicios_cumplidos.Rows[0].Clone();
                dr.Cells[0].Value = servicio_cumplido.idServicio;
                dr.Cells[1].Value = servicio_cumplido.fechaDeLaSolicitud.ToString("dd/MM/yyyy");
                dr.Cells[2].Value = servicio_cumplido.razonSocialReceptor;
                dr.Cells[3].Value = servicio_cumplido.tipoEnvio;

                

                if (servicio_cumplido.internacional.Equals("si"))
                {
                    dr.Cells[4].Value = servicio_cumplido.direccionInternacional;
                }
                else {
                    dr.Cells[4].Value = servicio_cumplido.direccionDestino;
                }
                
                
                dr.Cells[5].Value = servicio_cumplido.localidad;
                dr.Cells[6].Value = servicio_cumplido.provincia;
                dr.Cells[7].Value = servicio_cumplido.internacional;
                dr.Cells[8].Value = servicio_cumplido.regionInternacional;

                dataGridView_servicios_cumplidos.Rows.Add(dr);
            }

            dataGridView_servicios_cumplidos.Rows.RemoveAt(0);
            formato_grid_servicios(dataGridView_servicios_cumplidos);


            //MessageBox.Show(estadoDeCuenta.serviciosCumplidos.Count.ToString());


            foreach (ServicioSolicitado servicio_pdte_facturar in estadoDeCuenta.serviciosPendientes)
            {
                DataGridViewRow dr = (DataGridViewRow)dataGridView_servicios_pdtes_de_facturacion.Rows[0].Clone();
                dr.Cells[0].Value = servicio_pdte_facturar.idServicio;
                dr.Cells[1].Value = servicio_pdte_facturar.fechaDeLaSolicitud.ToString("dd/MM/yyyy");
                dr.Cells[2].Value = servicio_pdte_facturar.razonSocialReceptor;
                dr.Cells[3].Value = servicio_pdte_facturar.tipoEnvio;



                if (servicio_pdte_facturar.internacional.Equals("si"))
                {
                    dr.Cells[4].Value = servicio_pdte_facturar.direccionInternacional;
                }
                else
                {
                    dr.Cells[4].Value = servicio_pdte_facturar.direccionDestino;
                }


                dr.Cells[5].Value = servicio_pdte_facturar.localidad;
                dr.Cells[6].Value = servicio_pdte_facturar.provincia;
                dr.Cells[7].Value = servicio_pdte_facturar.internacional;
                dr.Cells[8].Value = servicio_pdte_facturar.regionInternacional;

                dataGridView_servicios_pdtes_de_facturacion.Rows.Add(dr);
            }

            dataGridView_servicios_pdtes_de_facturacion.Rows.RemoveAt(0);
            formato_grid_servicios(dataGridView_servicios_pdtes_de_facturacion);


            //MessageBox.Show(estadoDeCuenta.serviciosCumplidos.Count.ToString());



            textBox_saldo.Text = estadoDeCuenta.saldo.ToString("N2"); 
            
        }

        private void formato_grid_facturas(DataGridView dv)
        {
            foreach (DataGridViewColumn col in dv.Columns)
            {
                switch (col.HeaderText)
                {
                                        
                    case "Exento":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                    case "Gravado":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                    case "IVA 21%":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;

                    case "Total":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                }

            }
        }

        private void formato_grid_servicios(DataGridView dv)
        {
            foreach (DataGridViewColumn col in dv.Columns)
            {
                switch (col.HeaderText)
                {

                    case "Exento":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                    case "Gravado":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                    case "IVA 21%":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;

                    case "Total":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
                }

            }
        }

        private void textBox_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                button_buscar.PerformClick();
                return;
            }

            string aceptados = "-0123456789";

            if (aceptados.Contains(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void traer_datos_cliente(string id_cliente)
        {

            if (!File.Exists(ruta_archivo_usuarios))
            {
                MessageBox.Show("Falta el Archivo de ClienteCorporativo, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
                //var reader = File.OpenRead(ruta_archivo_usuarios);
            }

            var stream = File.OpenRead(ruta_archivo_usuarios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] valores = linea.Split(';');

                if (id_cliente.Equals(valores[1]))
                {
                    textBox_cuit.Text = valores[1];
                }
                    
            }

            stream.Close();
        }
        
        private void lleno_data_grid_facturacion_paga()
        {
            //DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid                        
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.Add("Sobres");
            //cell.Items.Add("Bultos");
            //newCol.CellTemplate = cell;
            //newCol.HeaderText = "Tipo";
            //newCol.Name = "Tipo";
            //newCol.Visible = true;

            dataGridView_facturacion_paga.Columns.Clear();
            //dataGridView_datos_del_servicio.Columns.Add(newCol);

         
            DataGridViewColumn newCol2 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            newCol2.CellTemplate = cell2;
            newCol2.HeaderText = "Nº Factura";
            newCol2.Name = "Nº Factura";
            newCol2.Visible = true;            
            newCol2.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol2);


            DataGridViewColumn newCol3 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            newCol3.CellTemplate = cell3;
            newCol3.HeaderText = "Fecha";
            newCol3.Name = "Fecha";
            newCol3.Visible = true;
            newCol3.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol3);


            DataGridViewColumn newCol4 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            newCol4.CellTemplate = cell4;
            newCol4.HeaderText = "Exento";
            newCol4.Name = "Exento";
            newCol4.Visible = true;
            newCol4.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol4);

            DataGridViewColumn newCol5 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            newCol5.CellTemplate = cell5;
            newCol5.HeaderText = "Gravado";
            newCol5.Name = "Gravado";
            newCol5.Visible = true;
            newCol5.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol5);

            DataGridViewColumn newCol6 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            newCol6.CellTemplate = cell6;
            newCol6.HeaderText = "IVA 21%";
            newCol6.Name = "IVA 21%";
            newCol6.Visible = true;
            newCol6.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol6);

            DataGridViewColumn newCol7 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            newCol7.CellTemplate = cell7;
            newCol7.HeaderText = "Total";
            newCol7.Name = "Total";
            newCol7.Visible = true;
            newCol7.ReadOnly = true;

            dataGridView_facturacion_paga.Columns.Add(newCol7);

            dataGridView_facturacion_paga.Rows.Add();
        }

        private void lleno_data_grid_facturacion_impaga()
        {
            //DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid                        
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.Add("Sobres");
            //cell.Items.Add("Bultos");
            //newCol.CellTemplate = cell;
            //newCol.HeaderText = "Tipo";
            //newCol.Name = "Tipo";
            //newCol.Visible = true;

            dataGridView_facturacion_impaga.Columns.Clear();
            //dataGridView_datos_del_servicio.Columns.Add(newCol);


            DataGridViewColumn newCol2 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            newCol2.CellTemplate = cell2;
            newCol2.HeaderText = "Nº Factura";
            newCol2.Name = "Nº Factura";
            newCol2.Visible = true;
            newCol2.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol2);


            DataGridViewColumn newCol3 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            newCol3.CellTemplate = cell3;
            newCol3.HeaderText = "Fecha";
            newCol3.Name = "Fecha";
            newCol3.Visible = true;
            newCol3.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol3);


            DataGridViewColumn newCol4 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            newCol4.CellTemplate = cell4;
            newCol4.HeaderText = "Exento";
            newCol4.Name = "Exento";
            newCol4.Visible = true;
            newCol4.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol4);

            DataGridViewColumn newCol5 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            newCol5.CellTemplate = cell5;
            newCol5.HeaderText = "Gravado";
            newCol5.Name = "Gravado";
            newCol5.Visible = true;
            newCol5.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol5);

            DataGridViewColumn newCol6 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            newCol6.CellTemplate = cell6;
            newCol6.HeaderText = "IVA 21%";
            newCol6.Name = "IVA 21%";
            newCol6.Visible = true;
            newCol6.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol6);

            DataGridViewColumn newCol7 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            newCol7.CellTemplate = cell7;
            newCol7.HeaderText = "Total";
            newCol7.Name = "Total";
            newCol7.Visible = true;
            newCol7.ReadOnly = true;

            dataGridView_facturacion_impaga.Columns.Add(newCol7);

            dataGridView_facturacion_impaga.Rows.Add();
        }

        private void lleno_data_grid_servicios_cumplidos()
        {
            //DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid                        
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.Add("Sobres");
            //cell.Items.Add("Bultos");
            //newCol.CellTemplate = cell;
            //newCol.HeaderText = "Tipo";
            //newCol.Name = "Tipo";
            //newCol.Visible = true;

            dataGridView_servicios_cumplidos.Columns.Clear();
            //dataGridView_datos_del_servicio.Columns.Add(newCol);


            DataGridViewColumn newCol2 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            newCol2.CellTemplate = cell2;
            newCol2.HeaderText = "Nº Servicio";
            newCol2.Name = "Nº Servicio";
            newCol2.Visible = true;
            newCol2.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol2);


            DataGridViewColumn newCol3 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            newCol3.CellTemplate = cell3;
            newCol3.HeaderText = "Fecha";
            newCol3.Name = "Fecha";
            newCol3.Visible = true;
            newCol3.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol3);


            DataGridViewColumn newCol7 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            newCol7.CellTemplate = cell7;
            newCol7.HeaderText = "Destinatario";
            newCol7.Name = "Destinatario";
            newCol7.Visible = true;
            newCol7.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol7);

            DataGridViewColumn newCol4 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            newCol4.CellTemplate = cell4;
            newCol4.HeaderText = "Tipo Envío";
            newCol4.Name = "Tipo Envío";
            newCol4.Visible = true;
            newCol4.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol4);

            DataGridViewColumn newCol5 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            newCol5.CellTemplate = cell5;
            newCol5.HeaderText = "Dirección";
            newCol5.Name = "Dirección";
            newCol5.Visible = true;
            newCol5.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol5);

            DataGridViewColumn newCol6 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            newCol6.CellTemplate = cell6;
            newCol6.HeaderText = "Localidad";
            newCol6.Name = "Localidad";
            newCol6.Visible = true;
            newCol6.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol6);


            DataGridViewColumn newCol1 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            newCol1.CellTemplate = cell1;
            newCol1.HeaderText = "Provincia";
            newCol1.Name = "Provincia";
            newCol1.Visible = true;
            newCol1.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol1);

            DataGridViewColumn newCol8 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell8 = new DataGridViewTextBoxCell();
            newCol8.CellTemplate = cell8;
            newCol8.HeaderText = "Internacional";
            newCol8.Name = "Internacional";
            newCol8.Visible = true;
            newCol8.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol8);

            DataGridViewColumn newCol9 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell9 = new DataGridViewTextBoxCell();
            newCol9.CellTemplate = cell9;
            newCol9.HeaderText = "Región Internacional";
            newCol9.Name = "Región Internacional";
            newCol9.Visible = true;
            newCol9.ReadOnly = true;

            dataGridView_servicios_cumplidos.Columns.Add(newCol9);

            dataGridView_servicios_cumplidos.Rows.Add();
        }

        private void lleno_data_grid_servicios_pdtes_de_facturar()
        {
            //DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid                        
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.Add("Sobres");
            //cell.Items.Add("Bultos");
            //newCol.CellTemplate = cell;
            //newCol.HeaderText = "Tipo";
            //newCol.Name = "Tipo";
            //newCol.Visible = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Clear();
            //dataGridView_datos_del_servicio.Columns.Add(newCol);


            DataGridViewColumn newCol2 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            newCol2.CellTemplate = cell2;
            newCol2.HeaderText = "Nº Servicio";
            newCol2.Name = "Nº Servicio";
            newCol2.Visible = true;
            newCol2.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol2);


            DataGridViewColumn newCol3 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            newCol3.CellTemplate = cell3;
            newCol3.HeaderText = "Fecha";
            newCol3.Name = "Fecha";
            newCol3.Visible = true;
            newCol3.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol3);


            DataGridViewColumn newCol7 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            newCol7.CellTemplate = cell7;
            newCol7.HeaderText = "Destinatario";
            newCol7.Name = "Destinatario";
            newCol7.Visible = true;
            newCol7.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol7);

            DataGridViewColumn newCol4 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            newCol4.CellTemplate = cell4;
            newCol4.HeaderText = "Tipo Envío";
            newCol4.Name = "Tipo Envío";
            newCol4.Visible = true;
            newCol4.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol4);

            DataGridViewColumn newCol5 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            newCol5.CellTemplate = cell5;
            newCol5.HeaderText = "Dirección";
            newCol5.Name = "Dirección";
            newCol5.Visible = true;
            newCol5.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol5);

            DataGridViewColumn newCol6 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            newCol6.CellTemplate = cell6;
            newCol6.HeaderText = "Localidad";
            newCol6.Name = "Localidad";
            newCol6.Visible = true;
            newCol6.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol6);

            DataGridViewColumn newCol1 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            newCol1.CellTemplate = cell1;
            newCol1.HeaderText = "Provincia";
            newCol1.Name = "Provincia";
            newCol1.Visible = true;
            newCol1.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol1);

            DataGridViewColumn newCol8 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell8 = new DataGridViewTextBoxCell();
            newCol8.CellTemplate = cell8;
            newCol8.HeaderText = "Internacional";
            newCol8.Name = "Internacional";
            newCol8.Visible = true;
            newCol8.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol8);

            DataGridViewColumn newCol9 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell9 = new DataGridViewTextBoxCell();
            newCol9.CellTemplate = cell9;
            newCol9.HeaderText = "Región Internacional";
            newCol9.Name = "Región Internacional";
            newCol9.Visible = true;
            newCol9.ReadOnly = true;

            dataGridView_servicios_pdtes_de_facturacion.Columns.Add(newCol9);


            dataGridView_servicios_pdtes_de_facturacion.Rows.Add();
        }


        private void formato_grid(DataGridView dv)
        {
            dv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dv.ForeColor = Color.Black;
            dv.RowHeadersVisible = false;
            dv.EnableHeadersVisualStyles = false;
            dv.BorderStyle = BorderStyle.Fixed3D;
            //dataGridView_datos_del_servicio.EditMode = DataGridViewEditMode.EditProgrammatically;
            dv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dv.AllowUserToAddRows = false;
            dv.AllowUserToDeleteRows = false;
            dv.AllowUserToOrderColumns = true;
            ////dataGridView_datos_del_servicio.ReadOnly = True
            //dataGridView_datos_del_servicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv.MultiSelect = false;
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dv.AllowUserToResizeColumns = true;
            dv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

        }

        private void ConsultarEstadoDeCuenta_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_datos_del_receptor_Enter(object sender, EventArgs e)
        {

        }
    }



}
