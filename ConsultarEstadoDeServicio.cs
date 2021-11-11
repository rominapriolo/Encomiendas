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
    public partial class ConsultarEstadoDeServicio : Form
    {
        public ConsultarEstadoDeServicio()
        {
            InitializeComponent();
        }

        string ruta_archivo_clientes = @"../../datos/ClienteCorporativo.txt";
        string ruta_archivo_servicio_solicitado_detalle = @"../../datos/ServicioSolicitadoDetalle.txt";
        string ruta_archivo_servicio_solicitado = @"../../datos/ServicioSolicitado.txt";
        string ruta_archivo_sucursales = @"../../datos/Sucursales.txt";

        private void ConsultarEstadoDeServicio_Load(object sender, EventArgs e)
        {
            label_estado_del_servicio.Text = "";

            groupBox_internacional.Visible = false;
            groupBox_internacional.Enabled = false;

            groupBox_datos_del_receptor.Enabled = false;
            groupBox_totales.Enabled = false;
            groupBox_datos_del_servicio.Enabled = false;

            

            lleno_data_grid();
            formato_grid();

            dataGridView_datos_del_servicio.Rows.Add();

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            label_estado_del_servicio.Text = "";
            //string estado = "";
            if (textBox_id_serivicio.Text.Equals("")) { MessageBox.Show("Por favor ingrese un número de solicitud"); return; }


            
            ClienteCorporativo clienteCorporativo = new ClienteCorporativo();
            if (VariablesGlobales.var_cuit_cliente_corporativo != null && !VariablesGlobales.var_cuit_cliente_corporativo.Equals(""))
            {                
                clienteCorporativo.cuit = VariablesGlobales.var_cuit_cliente_corporativo;
                clienteCorporativo.traerIdCliente();
            }

            ServicioSolicitado solicitudbuscada = new ServicioSolicitado();
            solicitudbuscada.idServicio = int.Parse(textBox_id_serivicio.Text);
            solicitudbuscada.idCliente = clienteCorporativo.idCliente;
            solicitudbuscada.detalle = new List<ServicioSolicitadoDetalle>();
            solicitudbuscada.buscarDatosSolicitud();

            //if (!File.Exists(ruta_archivo_servicio_solicitado))
            //{
            //    MessageBox.Show("Falta el Archivo de ServicioSolicitado, por favor genere el archivo y lanze la aplicación nuevamnete");
            //    Application.Exit();
            //}

            //var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            //var reader = new StreamReader(stream);

            //if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var linea = reader.ReadLine();
            //        string[] valores = linea.Split(';');

            //        if (valores[0].Equals(textBox_id_serivicio.Text))
            //        {

            //            if (VariablesGlobales.var_cuit_cliente_corporativo != null && !VariablesGlobales.var_cuit_cliente_corporativo.Equals(""))
            //            { 
            //                if (clienteCorporativo.idCliente != int.Parse(valores[1]))
            //                {
            //                    label_estado_del_servicio.Text = "No se encontró la solicitud ingresada";
            //                    label_estado_del_servicio.ForeColor = Color.Red;
            //                    label_estado_del_servicio_resultado.Text = "";
            //                    LimpiarForm();
            //                    MessageBox.Show("No se encontró la solicitud ingresada!");
            //                    return;
            //                } 

            //            }

            //            estado = valores[15];

            //        }

            //    }
            //}

            //stream.Close();



            if (solicitudbuscada.estadoServicio == null)
            {
                label_estado_del_servicio.Text = "No se encontró la solicitud ingresada";
                label_estado_del_servicio.ForeColor = Color.Red;
                label_estado_del_servicio_resultado.Text = "";
                LimpiarForm();
                MessageBox.Show("No se encontró la solicitud ingresada!");
                
            } else
            {
                label_estado_del_servicio.Text = "El estado es:";
                label_estado_del_servicio.ForeColor = Color.Black;
                label_estado_del_servicio_resultado.Text = solicitudbuscada.estadoServicio;

                switch (solicitudbuscada.estadoServicio)
                {
                    case "Recibida":
                        label_estado_del_servicio_resultado.ForeColor = Color.Blue;
                        break;
                    case "En Tránsito":
                        label_estado_del_servicio_resultado.ForeColor = Color.Purple;
                        break;
                    case "Cerrada":
                        label_estado_del_servicio_resultado.ForeColor = Color.Green;
                        break;
                }

           

                textBox_razon_social_receptor.Text = solicitudbuscada.razonSocialReceptor;
                if (solicitudbuscada.retiroPorSucursal.Equals("si"))
                {
                    checkBox_retiro_en_sucursal.Checked = true;
                }
                else 
                {
                    checkBox_retiro_en_sucursal.Checked = false;
                }


                var stream_sucursales = File.OpenRead(ruta_archivo_sucursales);
                var reader_sucursales = new StreamReader(stream_sucursales);
                

                if (new FileInfo(ruta_archivo_sucursales).Length != 0)
                {
                    while (!reader_sucursales.EndOfStream)
                    {
                        var linea = reader_sucursales.ReadLine();
                        string[] valores = linea.Split(';');
                        
                        if (valores[0].Equals(solicitudbuscada.idSucursalDeDestino.ToString()))
                        {                            
                            comboBox_sucursal_destino.Text = valores[0] + "_" + valores[1] + "_" + valores[2];
                        }

                    }
                }

                stream_sucursales.Close();



                if (solicitudbuscada.internacional.Equals("si"))
                {
                    checkBox_internacional.Checked = true;
                    groupBox_internacional.Top = groupBox_envio_nacional.Top;
                    groupBox_internacional.Left = groupBox_envio_nacional.Left;
                    groupBox_internacional.Width = groupBox_envio_nacional.Width;
                    groupBox_internacional.Height = groupBox_envio_nacional.Height;
                    groupBox_envio_nacional.Visible = false;
                    groupBox_envio_nacional.Enabled = false;
                    groupBox_internacional.Visible = true;
                    groupBox_internacional.Enabled = true;
                }
                else
                {
                    checkBox_internacional.Checked = false;
                    groupBox_envio_nacional.Visible = true;
                    groupBox_envio_nacional.Enabled = true;
                    groupBox_internacional.Visible = false;
                    groupBox_internacional.Enabled = false;
                }

                textBox_direccion_receptor.Text = solicitudbuscada.direccionDestino;
                textBox_region.Text = solicitudbuscada.region;
                comboBox_provincia.Text = solicitudbuscada.provincia;
                comboBox_localidad.Text = solicitudbuscada.localidad;
                textBox_codigo_postal_receptor.Text = solicitudbuscada.codigoPostal;
                textBox_correo_receptor.Text = solicitudbuscada.correoElectronicoReceptor;
                textBox_celular_receptor.Text = solicitudbuscada.celularReceptor;
                dateTimePicker_fecha_solicitud.Value = solicitudbuscada.fechaDeLaSolicitud;
                if (solicitudbuscada.tipoEnvio.Equals("Encomienda"))
                {
                    radioButton_tipo_envio_encomienda.Checked = true;
                    radioButton_tipo_envio_correspondencia.Checked = false;
                } else
                {
                    radioButton_tipo_envio_correspondencia.Checked = true;
                    radioButton_tipo_envio_encomienda.Checked = false;
                }

                if (solicitudbuscada.urgencia.Equals("Normal"))
                {
                    radioButton_urgencia_normal.Checked = true;
                    radioButton_urgencia_urgente.Checked = false;
                }
                else
                {
                    radioButton_urgencia_urgente.Checked = true;
                    radioButton_urgencia_normal.Checked = false;
                }

                textBox_exento.Text = solicitudbuscada.exento.ToString();
                textBox_gravado.Text = solicitudbuscada.gravado.ToString();
                textBox_iva21.Text = solicitudbuscada.iva21.ToString();
                textBox_total.Text = solicitudbuscada.total.ToString();


                foreach (ServicioSolicitadoDetalle item in solicitudbuscada.detalle)
                {
                    DataGridViewRow dr = (DataGridViewRow)dataGridView_datos_del_servicio.Rows[0].Clone();

                    //DataGridViewRow dr = new DataGridViewRow();
                    dr.Cells[0].Value = item.peso;
                    dr.Cells[1].Value = item.gravado;
                    dr.Cells[2].Value = item.exento;
                    dr.Cells[3].Value = item.iva21;
                    dr.Cells[4].Value = item.total;
                    dataGridView_datos_del_servicio.Rows.Add(dr);
                }

                dataGridView_datos_del_servicio.Rows.RemoveAt(0);

                buscarDatosCliente(solicitudbuscada.idCliente);

            }

        }

        private void buscarDatosCliente(int id_cliente)
        {
            var stream_clientes = File.OpenRead(ruta_archivo_clientes);
            var reader_clientes = new StreamReader(stream_clientes);


            if (new FileInfo(ruta_archivo_clientes).Length != 0)
            {
                while (!reader_clientes.EndOfStream)
                {
                    var linea = reader_clientes.ReadLine();

                    string[] valores = linea.Split(';');
                    //MessageBox.Show(linea);
                    //MessageBox.Show(id_cliente.ToString());
                    if (valores[0].Equals(id_cliente.ToString()))
                    {
                        textBox_cuit.Text = valores[1];
                        textBox_cliente.Text = valores[2];
                        //id_cliente = int.Parse(valores[0]);
                    }

                }
            }

            stream_clientes.Close();

        }

        private void textBox_id_serivicio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                button_buscar.PerformClick();
                return;
            }



            string aceptados = "0123456789";

            if (aceptados.Contains(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void LimpiarForm()
        {

            lleno_data_grid();
            formato_grid();


            groupBox_internacional.Visible = false;
            groupBox_internacional.Enabled = false;

            checkBox_retiro_en_sucursal.Checked = true;
            checkBox_internacional.Checked = false;            
            radioButton_tipo_envio_correspondencia.Checked = true;
            radioButton_urgencia_normal.Checked = true;

            dataGridView_datos_del_servicio.Rows.Add();

            //textBox_razon_social_receptor.Focus();
            textBox_cuit.Text = "";
            textBox_cliente.Text = "";
            textBox_razon_social_receptor.Text = "";
            comboBox_sucursal_destino.Text = "";
            comboBox_sucursal_destino.SelectedIndex = -1;
            textBox_direccion_receptor.Text = "";
            textBox_region.Text = "";
            comboBox_provincia.Text = "";
            comboBox_localidad.Text = "";
            textBox_codigo_postal_receptor.Text = "";
            textBox_direccion_internacional.Text = "";
            comboBox_region_internacional.Text = "";
            textBox_correo_receptor.Text = "";
            textBox_celular_receptor.Text = "";
            dateTimePicker_fecha_solicitud.Value = DateTime.Today;
            textBox_gravado.Text = "";
            textBox_exento.Text = "";
            textBox_iva21.Text = "";
            textBox_total.Text = "";

            groupBox_envio_nacional.Visible = true;
            groupBox_envio_nacional.Enabled = true;

        }

        private void lleno_data_grid()
        {
            //DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid                        
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.Add("Sobres");
            //cell.Items.Add("Bultos");
            //newCol.CellTemplate = cell;
            //newCol.HeaderText = "Tipo";
            //newCol.Name = "Tipo";
            //newCol.Visible = true;

            dataGridView_datos_del_servicio.Columns.Clear();
            //dataGridView_datos_del_servicio.Columns.Add(newCol);

            DataGridViewColumn newCol1 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            newCol1.CellTemplate = cell1;
            newCol1.HeaderText = "Peso";
            newCol1.Name = "Peso";
            newCol1.Visible = true;
            //newCol1.Width = 100;

            dataGridView_datos_del_servicio.Columns.Add(newCol1);

            DataGridViewColumn newCol2 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            newCol2.CellTemplate = cell2;
            newCol2.HeaderText = "Gravado";
            newCol2.Name = "Gravado";
            newCol2.Visible = true;
            //newCol2.Width = 100;
            newCol2.ReadOnly = true;

            dataGridView_datos_del_servicio.Columns.Add(newCol2);

            DataGridViewColumn newCol6 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            newCol6.CellTemplate = cell6;
            newCol6.HeaderText = "Exento";
            newCol6.Name = "Exento";
            newCol6.Visible = true;
            //newCol2.Width = 100;
            newCol6.ReadOnly = true;

            dataGridView_datos_del_servicio.Columns.Add(newCol6);

            DataGridViewColumn newCol3 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            newCol3.CellTemplate = cell3;
            newCol3.HeaderText = "IVA 21%";
            newCol3.Name = "IVA 21%";
            newCol3.Visible = true;
            //newCol3.Width = 100;
            newCol3.ReadOnly = true;

            dataGridView_datos_del_servicio.Columns.Add(newCol3);

            DataGridViewColumn newCol4 = new DataGridViewColumn(); // add a column to the grid                        
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            newCol4.CellTemplate = cell4;
            newCol4.HeaderText = "Total";
            newCol4.Name = "Total";
            newCol4.Visible = true;
            //newCol4.Width = 100;
            newCol4.ReadOnly = true;


            dataGridView_datos_del_servicio.Columns.Add(newCol4);
            dataGridView_datos_del_servicio.ContextMenuStrip = contextMenuStrip1;


        }

        private void formato_grid()
        {
            dataGridView_datos_del_servicio.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView_datos_del_servicio.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dataGridView_datos_del_servicio.ForeColor = Color.Black;
            dataGridView_datos_del_servicio.RowHeadersVisible = false;
            dataGridView_datos_del_servicio.EnableHeadersVisualStyles = false;
            dataGridView_datos_del_servicio.BorderStyle = BorderStyle.Fixed3D;
            //dataGridView_datos_del_servicio.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_datos_del_servicio.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView_datos_del_servicio.AllowUserToAddRows = false;
            dataGridView_datos_del_servicio.AllowUserToDeleteRows = false;
            dataGridView_datos_del_servicio.AllowUserToOrderColumns = true;
            ////dataGridView_datos_del_servicio.ReadOnly = True
            //dataGridView_datos_del_servicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_datos_del_servicio.MultiSelect = false;
            dataGridView_datos_del_servicio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView_datos_del_servicio.AllowUserToResizeColumns = true;
            dataGridView_datos_del_servicio.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            foreach (DataGridViewColumn col in dataGridView_datos_del_servicio.Columns)
            {
                switch (col.HeaderText)
                {
                    //case "Tipo":
                    //    col.Width = 150;
                    //    break;
                    case "Peso":
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "N2";
                        break;
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

       
    }
}
