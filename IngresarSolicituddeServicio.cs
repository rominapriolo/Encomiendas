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
    public partial class IngresarSolicituddeServicio : Form
    {
        public IngresarSolicituddeServicio()
        {
            InitializeComponent();
        }

        string ruta_archivo_usuarios = "../../datos/ClienteCorporativo.txt";
        string ruta_archivo_sucursales = "../../datos/Sucursales.txt";
        string ruta_archivo_tarifas_localidades = "../../datos/TarifasLocalidades.txt";
        

        private void IngresarSolicituddeServicio_Load(object sender, EventArgs e)
        {

            //VariablesGlobales.var_cuit_cliente_corporativo = "20-41615025-8";

            if (VariablesGlobales.var_cuit_cliente_corporativo != null && !VariablesGlobales.var_cuit_cliente_corporativo.Equals(""))
            {
                traer_datos_cliente(VariablesGlobales.var_cuit_cliente_corporativo);
                button_buscar_datos_cliente.Visible = false;
                button_buscar_datos_cliente.Enabled = false;
            }

            grisear_objetos();
            cargo_combos();
            lleno_data_grid();
            formato_grid();

            groupBox_internacional.Visible = false;
            groupBox_internacional.Enabled = false;

            groupBox_envio_nacional.Visible = true;
            groupBox_envio_nacional.Enabled = true;

            checkBox_retiro_en_sucursal.Checked = true;
            checkBox_internacional.Checked = false;
            checkBox_retiro_en_puerta.Checked = false;

            radioButton_tipo_envio_correspondencia.Checked = true;
            radioButton_urgencia_normal.Checked = true;

            //dataGridView_datos_del_servicio.Rows.Add();

            textBox_razon_social_receptor.Focus();
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

        private void cargo_combos()
        {
            if (!File.Exists(ruta_archivo_sucursales))
            {
                MessageBox.Show("Falta el Archivo de Sucursales, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
                //var reader = File.OpenRead(ruta_archivo_usuarios);
            }

            var stream = File.OpenRead(ruta_archivo_sucursales);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                string[] valores = linea.Split(';');
                string sucursal = valores[0] + "_" + valores[1] + "_" + valores[2];

                comboBox_sucursal_destino.Items.Add(sucursal);

            }

            stream.Close();


            if (!File.Exists(ruta_archivo_sucursales))
            {
                MessageBox.Show("Falta el Archivo de TarifasLocalidades, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
                //var reader = File.OpenRead(ruta_archivo_usuarios);
            }

            stream = File.OpenRead(ruta_archivo_tarifas_localidades);
            reader = new StreamReader(stream);
            string localidades_añadidas = "";
            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                
                string[] valores = linea.Split(';');
                string sucursal = valores[0];
                //MessageBox.Show(sucursal);

                if (!localidades_añadidas.Contains(sucursal)) 
                {
                    comboBox_provincia.Items.Add(sucursal);
                    localidades_añadidas = localidades_añadidas + ";" + sucursal;
                }

                
            }

            stream.Close();


            comboBox_region_internacional.Items.Add("Países Limítrofes");
            comboBox_region_internacional.Items.Add("Resto de América Latina");
            comboBox_region_internacional.Items.Add("América del Norte");
            comboBox_region_internacional.Items.Add("Europa");
            comboBox_region_internacional.Items.Add("Asia");
            comboBox_region_internacional.Items.Add("Otro");
        }

        private void grisear_objetos()
        {
            foreach (TextBox tb in groupBox_datos_del_cliente.Controls.OfType<TextBox>())
            {
                tb.Enabled = false;
            
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

                if(id_cliente.Equals(valores[1])) 
                {
                    //0-ID CLIENTE
                    //1-cuit
                    //2-razon_social
                    //3-direccion
                    //4-provincia
                    //5-localidad
                    //6-codigo_posital
                    //7-telefono
                    //8-mail
                    //9-ctacorriente
                    //10-responsable_inscripto
                    //11-fecha_registro
                    textBox_id_cliente.Text = valores[0];
                    textBox_cuit.Text = valores[1];
                    TextBox_razon_social.Text = valores[2];
                    textBox_direccion.Text = valores[3];
                    textBox_provincia.Text = valores[4];
                    textBox_localidad.Text = valores[5];
                    textBox_codigo_postal.Text = valores[6];
                    textBox_nroCelular.Text = valores[7];
                    textBox_correoElectronico.Text = valores[8];
                    //textBox_correoElectronico.Text = valores[9];
                    textBox_cond_iva.Text = valores[10];
                    //textBox_correoElectronico.Text = valores[11];
                    textBox_region_cliente.Text = valores[12];
                }

              

            }

            stream.Close();
        }

        private void button_buscar_datos_cliente_Click(object sender, EventArgs e)
        {
            string cuit;
            cuit = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el CUIT/DNI del cliente:", "Datos", "", 100, 0);

            if (cuit.Equals(""))
            {
                MessageBox.Show("El dato ingresado está vacío!");
                return;
            }

            traer_datos_cliente(cuit);

        }

        private void grisear_direccion_del_receptor(bool grisear) {

            textBox_direccion_receptor.Enabled = grisear;
            comboBox_provincia.Enabled = grisear;
            comboBox_localidad.Enabled = grisear;
            textBox_codigo_postal_receptor.Enabled = grisear;

            textBox_direccion_receptor.Text = "";
            comboBox_provincia.Text = "";
            comboBox_localidad.Text = "";
            textBox_codigo_postal_receptor.Text = "";
            //textBox_celular_receptor.Enabled = grisear;
            //textBox_correo_receptor.Enabled = grisear;
        }

        private void checkBox_retiro_en_sucursal_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_retiro_en_sucursal.Checked) { 
                grisear_direccion_del_receptor(false);
            } 
            else 
            { 
                grisear_direccion_del_receptor(true); 
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            //<---VALIDA DATOS

            if (textBox_id_cliente.Text.Equals("")) { MessageBox.Show("Por favor seleccione un cliente!"); return; }
            if (textBox_razon_social_receptor.Text.Equals("")) { MessageBox.Show("Por favor ingrese la Razón Social del receptor!"); textBox_razon_social_receptor.Focus(); return; }
            if (comboBox_sucursal_destino.SelectedIndex == -1) { MessageBox.Show("Por favor seleccione una sucursal de destino de la lista!"); comboBox_sucursal_destino.Focus(); return; }
            
            if (checkBox_internacional.Checked)
            {
                if (textBox_direccion_internacional.Text.Equals("")) { MessageBox.Show("Por favor ingrese la dirección de destino!"); textBox_direccion_internacional.Focus(); return; }
                if (comboBox_region_internacional.SelectedIndex == -1) { MessageBox.Show("Por favor seleccione una region de destino de la lista!"); comboBox_region_internacional.Focus(); return; }
            }
            else
            {

                if (!checkBox_retiro_en_sucursal.Checked)
                {
                    if (textBox_direccion_receptor.Text.Equals("")) { MessageBox.Show("Por favor ingrese la dirección de destino!"); textBox_direccion_receptor.Focus(); return; }
                    if (comboBox_provincia.SelectedIndex == -1) { MessageBox.Show("Por favor seleccione una provincia de la lista!"); comboBox_provincia.Focus(); return; }
                    if (comboBox_localidad.SelectedIndex == -1) { MessageBox.Show("Por favor seleccione una provincia de la lista!"); comboBox_localidad.Focus(); return; }
                    if (textBox_codigo_postal_receptor.Text.Equals("")) { MessageBox.Show("Por favor ingrese el código postal de destino!"); textBox_codigo_postal_receptor.Focus(); return; }
                }

                
            }

            //if (textBox_correo_receptor.Text.Equals("")) { MessageBox.Show("Por favor ingrese el correo electrónico del receptor!"); textBox_correo_receptor.Focus(); return; }
            if (textBox_celular_receptor.Text.Equals("")) { MessageBox.Show("Por favor ingrese el Nº Celular del receptor!"); textBox_celular_receptor.Focus(); return; }

            foreach (DataGridViewRow row in dataGridView_datos_del_servicio.Rows)
            {
                
                if (row.Cells["Peso"].Value == null)
                {
                    MessageBox.Show("Por favor ingrese el peso del item en la línea " + (row.Index + 1));
                    return;
                }
                
                if (row.Cells["Peso"].Value.ToString().Equals("")) 
                {
                    MessageBox.Show("Por favor ingrese el peso del item en la línea " + (row.Index +1));
                    return;
                }

            }


            ////VALIDA DATOS --->



            ServicioSolicitado servicioSolicitado = new ServicioSolicitado();
            servicioSolicitado.idCliente = int.Parse(textBox_id_cliente.Text);
            servicioSolicitado.razonSocialReceptor = textBox_razon_social_receptor.Text;
            servicioSolicitado.celularReceptor = textBox_celular_receptor.Text;
            servicioSolicitado.correoElectronicoReceptor = textBox_correo_receptor.Text;
            servicioSolicitado.direccionDestino = textBox_direccion_receptor.Text;

            if (checkBox_retiro_en_sucursal.Checked)
            {
                servicioSolicitado.retiroPorSucursal = "si";
            }
            else
            {
                servicioSolicitado.retiroPorSucursal = "no";
            }
            
            servicioSolicitado.idSucursalDeDestino = int.Parse(comboBox_sucursal_destino.Text.Substring(0, comboBox_sucursal_destino.Text.IndexOf("_")));
            servicioSolicitado.provincia = comboBox_provincia.Text;
            servicioSolicitado.localidad = comboBox_localidad.Text;
            servicioSolicitado.codigoPostal = textBox_codigo_postal_receptor.Text;
            servicioSolicitado.region = textBox_region.Text;
            servicioSolicitado.fechaDeLaSolicitud = dateTimePicker_fecha_solicitud.Value;
            
            if (radioButton_tipo_envio_correspondencia.Checked)
            {
                servicioSolicitado.tipoEnvio = "Correspondencia";
            } else 
            {
                servicioSolicitado.tipoEnvio = "Encomienda";
            }

            if (radioButton_urgencia_normal.Checked)
            {
                servicioSolicitado.urgencia = "Normal";
            }
            else
            {
                servicioSolicitado.urgencia = "Urgente";
            }

            servicioSolicitado.estadoServicio = "Recibida";
            servicioSolicitado.gravado = Decimal.Parse(textBox_gravado.Text);
            servicioSolicitado.exento = Decimal.Parse(textBox_exento.Text);
            servicioSolicitado.iva21 = Decimal.Parse(textBox_iva21.Text);
            servicioSolicitado.total = Decimal.Parse(textBox_total.Text);

            if (checkBox_retiro_en_puerta.Checked)
            {
                servicioSolicitado.retiroEnPuerta = "si";
            }
            else
            {
                servicioSolicitado.retiroEnPuerta = "no";
            }

            if (checkBox_internacional.Checked)
            {
                servicioSolicitado.internacional = "si";
            }
            else
            {
                servicioSolicitado.internacional = "no";
            }

            servicioSolicitado.direccionInternacional = textBox_direccion_internacional.Text;
            servicioSolicitado.regionInternacional = comboBox_region_internacional.Text;


            string unidad = "";

            if (servicioSolicitado.tipoEnvio.Equals("Correspondencia"))
            {
                unidad = "g";
            }
            else {
                unidad = "kg";
            }

            servicioSolicitado.detalle = new List<ServicioSolicitadoDetalle>();

            foreach (DataGridViewRow row in dataGridView_datos_del_servicio.Rows)
            {
                ServicioSolicitadoDetalle servicioSolicitadoDetalle = new ServicioSolicitadoDetalle();
                servicioSolicitadoDetalle.peso = Decimal.Parse(row.Cells["Peso"].Value.ToString());
                servicioSolicitadoDetalle.gravado = Decimal.Parse(row.Cells["Gravado"].Value.ToString());
                servicioSolicitadoDetalle.exento = Decimal.Parse(row.Cells["Exento"].Value.ToString());
                servicioSolicitadoDetalle.iva21 = Decimal.Parse(row.Cells["IVA 21%"].Value.ToString());
                servicioSolicitadoDetalle.total = Decimal.Parse(row.Cells["Total"].Value.ToString());
                servicioSolicitadoDetalle.unidad = unidad;
                
                servicioSolicitado.detalle.Add(servicioSolicitadoDetalle);
            }

            servicioSolicitado.guardarDatos();

            MessageBox.Show("La Solicitud se guardó con el número " + servicioSolicitado.idServicio);

            LimpiarForm();
        }

        private void comboBox_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stream = File.OpenRead(ruta_archivo_tarifas_localidades);
            var reader = new StreamReader(stream);

            comboBox_localidad.Items.Clear();
            comboBox_localidad.SelectedIndex = -1;
            comboBox_localidad.Text = "";
            string provincia_seleccionada = comboBox_provincia.Text;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                string[] valores = linea.Split(';');
                string provincia = valores[0];
                string localidad = valores[1];

                

                if (provincia_seleccionada.Equals(provincia))
                {
                    //MessageBox.Show(linea);
                    comboBox_localidad.Items.Add(localidad);
                }                

            }

            stream.Close();

            calcular_precio();
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

        private void comboBox_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stream = File.OpenRead(ruta_archivo_tarifas_localidades);
            var reader = new StreamReader(stream);

            
            textBox_region.Text = "";
            string provincia_seleccionada = comboBox_provincia.Text;
            string localidad_seleccionada = comboBox_localidad.Text;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                string[] valores = linea.Split(';');
                string provincia = valores[0];
                string localidad = valores[1];
                string region = valores[2];

                if (provincia_seleccionada.Equals(provincia) && localidad_seleccionada.Equals(localidad))
                {
                    textBox_region.Text = region;
                }

            }

            stream.Close();

            calcular_precio();
        }

        private void dataGridView_datos_del_servicio_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView_datos_del_servicio.Columns[e.ColumnIndex].HeaderText.Equals("Peso"))

            if (dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value == null)
            { return; }

            decimal valor;
            if (!Decimal.TryParse(dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value.ToString(), out valor)) 
            {
                MessageBox.Show("Por favor ingrese un número!");
                dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value = 0;
            }
            
            decimal peso = Decimal.Parse(dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value.ToString());

            if (peso < 0)
            {
                MessageBox.Show("El peso no puede ser menor a 0KG");
                dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value = 0;
                //return;
            }

            if (radioButton_tipo_envio_encomienda.Checked) 
            {
                if (peso > 30)
                {
                    MessageBox.Show("El peso no puede ser mayor a 30KG");
                    dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value = 0;
                    //return;
                }

            } else
            {
                if (peso > 500)
                {
                    MessageBox.Show("El peso no puede ser mayor a 500GR");
                    dataGridView_datos_del_servicio.Rows[e.RowIndex].Cells["Peso"].Value = 0;
                    //return;
                }
            }


            calcular_precio(); 
        }

        private void calcular_precio() 
        {

            decimal total_gravado = 0;
            decimal total_exento = 0;
            decimal total_iva = 0;


            for (int x  = 0; x<dataGridView_datos_del_servicio.Rows.Count; x++ )
            {

                //if (dataGridView_datos_del_servicio.Rows[x].Cells["Peso"].Value != null && dataGridView_datos_del_servicio.Rows[x].Cells["Tipo"].Value !=null)
                  if (dataGridView_datos_del_servicio.Rows[x].Cells["Peso"].Value != null)
                    {
                    //string tipo = dataGridView_datos_del_servicio.Rows[x].Cells["Tipo"].Value.ToString();
                    string tipo = "";
                    decimal peso = Decimal.Parse(dataGridView_datos_del_servicio.Rows[x].Cells["Peso"].Value.ToString());


                    
                    if (radioButton_tipo_envio_correspondencia.Checked) 
                    {
                        tipo = "Sobres";
                    }

                    if (radioButton_tipo_envio_encomienda.Checked)
                    {
                        tipo = "Bultos";
                    }



                    decimal gravado = traer_gravado(tipo, peso);

                    

                    if (textBox_cond_iva.Text.Equals("RI")) 
                    {
                        dataGridView_datos_del_servicio.Rows[x].Cells["Gravado"].Value = gravado;
                        dataGridView_datos_del_servicio.Rows[x].Cells["IVA 21%"].Value = (gravado*((decimal)21/(decimal)100));
                        dataGridView_datos_del_servicio.Rows[x].Cells["Exento"].Value = 0;
                        total_iva += gravado * ((decimal)21 / (decimal)100);
                        total_gravado += gravado;
                    } else
                    {
                        total_exento += gravado;
                        dataGridView_datos_del_servicio.Rows[x].Cells["Exento"].Value = gravado;
                        dataGridView_datos_del_servicio.Rows[x].Cells["Gravado"].Value = 0;
                        dataGridView_datos_del_servicio.Rows[x].Cells["IVA 21%"].Value = 0;

                    }

                    dataGridView_datos_del_servicio.Rows[x].Cells["Total"].Value = gravado * ((decimal)21 / (decimal)100) + gravado;

                }

                
            }

            textBox_gravado.Text = total_gravado.ToString();
            textBox_exento.Text = total_exento.ToString();
            textBox_iva21.Text = total_iva.ToString();
            textBox_total.Text = (total_exento + total_gravado + total_iva).ToString();
        }

        private decimal traer_gravado(string tipo, decimal peso) 
        {
            decimal gravado = 0;
            decimal porc_urgencia = (decimal)1;
            decimal tope_urgencia = (decimal)50;
            decimal monto_urgencia = (decimal)0;
            decimal fijo_retiro_en_puerta = (decimal)0;
            decimal fijo_entrega_en_puerta = (decimal)20;
            decimal internacional = (decimal)0;

            string provincia_cliente = textBox_provincia.Text;
            string localidad_cliente = textBox_localidad.Text;
            string region_cliente = textBox_region_cliente.Text;

            string provincia_receptor = comboBox_provincia.Text;
            string localidad_receptor = comboBox_localidad.Text;
            string region_receptor = textBox_region.Text;


            if (checkBox_internacional.Checked)
            {
                provincia_receptor = "CABA";

                switch (tipo)
                {
                    case "Sobres":

                        internacional = 40;
                      
                        break;
                    case "Bultos":


                        if (peso <= 10)
                        {
                            internacional = 50;                                
                        }

                        if (peso > 10 && peso <= 20)
                        {
                            internacional = 400;
                                                       
                        }

                        if (peso > 20 && peso <= 30)
                        {


                            internacional = 4000;
                                
                        }

                        break;
                }

            }

            if (checkBox_retiro_en_sucursal.Checked)
            {                
                fijo_entrega_en_puerta = (decimal)0;
            }

            if (checkBox_retiro_en_puerta.Checked)
            {
                fijo_retiro_en_puerta = (decimal)20;
            }

            if (radioButton_urgencia_urgente.Checked)                 
            {
                porc_urgencia = (decimal)1.2;
            }

            switch (tipo)
            {
                case "Sobres":
                    if (provincia_cliente.Equals(provincia_receptor)) 
                    { 
                        if (localidad_cliente.Equals(localidad_receptor))
                        {
                            gravado = 10;
                        } else
                        {
                            gravado = 20;
                        }

                    } else
                    {
                        if (region_cliente.Equals(region_receptor))
                        {
                            gravado = 30;
                        }
                        else
                        {
                            gravado = 40;
                        }
                    }
                    break;
                case "Bultos":


                    if (peso <= 10) {
                        if (provincia_cliente.Equals(provincia_receptor))
                        {
                            if (localidad_cliente.Equals(localidad_receptor))
                            {
                                gravado = 10;
                            }
                            else
                            {
                                gravado = 15;
                            }

                        }
                        else
                        {
                            if (region_cliente.Equals(region_receptor))
                            {
                                gravado = 20;
                            }
                            else
                            {
                                gravado = 30;
                            }
                        }
                    }

                    if (peso > 10 && peso <=20)
                    {
                        if (provincia_cliente.Equals(provincia_receptor))
                        {
                            if (localidad_cliente.Equals(localidad_receptor))
                            {
                                gravado = 35;
                            }
                            else
                            {
                                gravado = 40;
                            }

                        }
                        else
                        {
                            if (region_cliente.Equals(region_receptor))
                            {
                                gravado = 60;
                            }
                            else
                            {
                                gravado = 70;
                            }
                        }
                    }

                    if (peso > 20 && peso <= 30)
                    {
                        if (provincia_cliente.Equals(provincia_receptor))
                        {
                            if (localidad_cliente.Equals(localidad_receptor))
                            {
                                gravado = 75;
                            }
                            else
                            {
                                gravado = 80;
                            }

                        }
                        else
                        {
                            if (region_cliente.Equals(region_receptor))
                            {
                                gravado = 85;
                            }
                            else
                            {
                                gravado = 95;
                            }
                        }
                    }



                    break;
            }


            gravado += fijo_entrega_en_puerta + fijo_retiro_en_puerta + internacional;
            
            monto_urgencia = (decimal)gravado * (decimal)porc_urgencia;

            if (monto_urgencia > tope_urgencia)
            {
                gravado = (decimal)gravado + (decimal)tope_urgencia;
            } else
            {
                gravado = (decimal)gravado + (decimal)monto_urgencia;
            }

                       


            if (peso == 0 ) { gravado = 0; };

            return gravado;

        }

        private void groupBox_datos_del_cliente_Enter(object sender, EventArgs e)
        {

        }

        private void button_agregar_linea_Click(object sender, EventArgs e)
        {

        }

        private void añadirPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dvr = (DataGridViewRow)dataGridView_datos_del_servicio.Rows[0].Clone();
            dataGridView_datos_del_servicio.Rows.Add(dvr);
        }

        private void eliminarPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_datos_del_servicio.Rows.Count == 1) { return; }

            if (dataGridView_datos_del_servicio.CurrentCell == null) { return; }

            dataGridView_datos_del_servicio.Rows.RemoveAt(dataGridView_datos_del_servicio.CurrentCell.RowIndex);
        }

        private void groupBox_datos_del_receptor_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_internacional_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_internacional.Checked)
            {
                groupBox_internacional.Top = groupBox_envio_nacional.Top;
                groupBox_internacional.Left = groupBox_envio_nacional.Left;
                groupBox_internacional.Width = groupBox_envio_nacional.Width;
                groupBox_internacional.Height = groupBox_envio_nacional.Height;
                groupBox_envio_nacional.Visible = false;
                groupBox_envio_nacional.Enabled = false;
                groupBox_internacional.Visible = true;
                groupBox_internacional.Enabled = true;

                comboBox_sucursal_destino.SelectedIndex = 0;
                comboBox_sucursal_destino.Enabled = false;

                calcular_precio();

            } else
            {
                groupBox_envio_nacional.Visible = true;
                groupBox_envio_nacional.Enabled = true;
                groupBox_internacional.Visible = false;
                groupBox_internacional.Enabled = false;
                comboBox_sucursal_destino.SelectedIndex = -1;
                comboBox_sucursal_destino.Enabled = true;
            }
        }

        private void radioButton_urgencia_urgente_CheckedChanged(object sender, EventArgs e)
        {
            calcular_precio();
        }

        private void radioButton_urgencia_normal_CheckedChanged(object sender, EventArgs e)
        {
            calcular_precio();
        }

        private void radioButton_tipo_envio_correspondencia_CheckedChanged(object sender, EventArgs e)
        {
            lleno_data_grid();
            dataGridView_datos_del_servicio.Rows.Add();
            calcular_precio();
        }

        private void radioButton_tipo_envio_encomienda_CheckedChanged(object sender, EventArgs e)
        {
            lleno_data_grid();
            dataGridView_datos_del_servicio.Rows.Add();
            calcular_precio();
        }

        private void LimpiarForm()
        {

            textBox_id_cliente.Text = "";
            textBox_cond_iva.Text = "";
            TextBox_razon_social.Text = "";
            textBox_cuit.Text = "";
            textBox_direccion.Text = "";
            textBox_provincia.Text = "";
            textBox_region_cliente.Text = "";
            textBox_localidad.Text = "";
            textBox_codigo_postal.Text = "";
            textBox_nroCelular.Text = "";
            textBox_correoElectronico.Text = "";
            checkBox_retiro_en_puerta.Checked = false;


            if (VariablesGlobales.var_cuit_cliente_corporativo != null && !VariablesGlobales.var_cuit_cliente_corporativo.Equals(""))
            {
                traer_datos_cliente(VariablesGlobales.var_cuit_cliente_corporativo);
                button_buscar_datos_cliente.Visible = false;
                button_buscar_datos_cliente.Enabled = false;
            }

            grisear_objetos();
            //cargo_combos();
            lleno_data_grid();
            formato_grid();

            groupBox_internacional.Visible = false;
            groupBox_internacional.Enabled = false;

            checkBox_retiro_en_sucursal.Checked = true;
            checkBox_internacional.Checked = false;
            checkBox_retiro_en_puerta.Checked = false;
            radioButton_tipo_envio_correspondencia.Checked = true;
            radioButton_urgencia_normal.Checked = true;

            dataGridView_datos_del_servicio.Rows.Add();

            textBox_razon_social_receptor.Focus();

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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void textBox_celular_receptor_KeyPress(object sender, KeyPressEventArgs e)
        {
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


    }


}
