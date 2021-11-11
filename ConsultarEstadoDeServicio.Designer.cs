
namespace Encomiendas
{
    partial class ConsultarEstadoDeServicio
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_datos_del_servicio = new System.Windows.Forms.GroupBox();
            this.dataGridView_datos_del_servicio = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_totales = new System.Windows.Forms.GroupBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_iva21 = new System.Windows.Forms.TextBox();
            this.label_iva21 = new System.Windows.Forms.Label();
            this.textBox_exento = new System.Windows.Forms.TextBox();
            this.label_exento = new System.Windows.Forms.Label();
            this.textBox_gravado = new System.Windows.Forms.TextBox();
            this.label_gravado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_cuit = new System.Windows.Forms.TextBox();
            this.label_cuit = new System.Windows.Forms.Label();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label_estado_del_servicio_resultado = new System.Windows.Forms.Label();
            this.label_estado_del_servicio = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textBox_id_serivicio = new System.Windows.Forms.TextBox();
            this.label_id_servicio = new System.Windows.Forms.Label();
            this.groupBox_datos_del_receptor = new System.Windows.Forms.GroupBox();
            this.groupBox_envio_nacional = new System.Windows.Forms.GroupBox();
            this.groupBox_internacional = new System.Windows.Forms.GroupBox();
            this.comboBox_region_internacional = new System.Windows.Forms.ComboBox();
            this.label_region_internacional = new System.Windows.Forms.Label();
            this.textBox_direccion_internacional = new System.Windows.Forms.TextBox();
            this.label_direccion_internacional = new System.Windows.Forms.Label();
            this.textBox_region = new System.Windows.Forms.TextBox();
            this.label_region = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_localidad = new System.Windows.Forms.ComboBox();
            this.comboBox_provincia = new System.Windows.Forms.ComboBox();
            this.textBox_direccion_receptor = new System.Windows.Forms.TextBox();
            this.label_direccion_destino = new System.Windows.Forms.Label();
            this.textBox_codigo_postal_receptor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_internacional = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_fecha_solicitud = new System.Windows.Forms.DateTimePicker();
            this.label_fecha_solicitud = new System.Windows.Forms.Label();
            this.groupBox_urgencia = new System.Windows.Forms.GroupBox();
            this.radioButton_urgencia_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_urgencia_urgente = new System.Windows.Forms.RadioButton();
            this.groupBox_tipo_envio = new System.Windows.Forms.GroupBox();
            this.radioButton_tipo_envio_encomienda = new System.Windows.Forms.RadioButton();
            this.radioButton_tipo_envio_correspondencia = new System.Windows.Forms.RadioButton();
            this.comboBox_sucursal_destino = new System.Windows.Forms.ComboBox();
            this.label_sucursal_destino = new System.Windows.Forms.Label();
            this.checkBox_retiro_en_sucursal = new System.Windows.Forms.CheckBox();
            this.textBox_correo_receptor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_celular_receptor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_razon_social_receptor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_datos_del_servicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos_del_servicio)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_totales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_datos_del_receptor.SuspendLayout();
            this.groupBox_envio_nacional.SuspendLayout();
            this.groupBox_internacional.SuspendLayout();
            this.groupBox_urgencia.SuspendLayout();
            this.groupBox_tipo_envio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_datos_del_servicio
            // 
            this.groupBox_datos_del_servicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_datos_del_servicio.Controls.Add(this.dataGridView_datos_del_servicio);
            this.groupBox_datos_del_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datos_del_servicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_datos_del_servicio.Location = new System.Drawing.Point(14, 371);
            this.groupBox_datos_del_servicio.Name = "groupBox_datos_del_servicio";
            this.groupBox_datos_del_servicio.Size = new System.Drawing.Size(980, 167);
            this.groupBox_datos_del_servicio.TabIndex = 19;
            this.groupBox_datos_del_servicio.TabStop = false;
            this.groupBox_datos_del_servicio.Text = "Datos del Servicio";
            // 
            // dataGridView_datos_del_servicio
            // 
            this.dataGridView_datos_del_servicio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_datos_del_servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datos_del_servicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_datos_del_servicio.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_datos_del_servicio.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_datos_del_servicio.Name = "dataGridView_datos_del_servicio";
            this.dataGridView_datos_del_servicio.Size = new System.Drawing.Size(974, 146);
            this.dataGridView_datos_del_servicio.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPosiciónToolStripMenuItem,
            this.eliminarPosiciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // añadirPosiciónToolStripMenuItem
            // 
            this.añadirPosiciónToolStripMenuItem.Name = "añadirPosiciónToolStripMenuItem";
            this.añadirPosiciónToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.añadirPosiciónToolStripMenuItem.Text = "Añadir Posición";
            // 
            // eliminarPosiciónToolStripMenuItem
            // 
            this.eliminarPosiciónToolStripMenuItem.Name = "eliminarPosiciónToolStripMenuItem";
            this.eliminarPosiciónToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarPosiciónToolStripMenuItem.Text = "Eliminar Posición";
            // 
            // groupBox_totales
            // 
            this.groupBox_totales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_totales.Controls.Add(this.textBox_total);
            this.groupBox_totales.Controls.Add(this.label_total);
            this.groupBox_totales.Controls.Add(this.textBox_iva21);
            this.groupBox_totales.Controls.Add(this.label_iva21);
            this.groupBox_totales.Controls.Add(this.textBox_exento);
            this.groupBox_totales.Controls.Add(this.label_exento);
            this.groupBox_totales.Controls.Add(this.textBox_gravado);
            this.groupBox_totales.Controls.Add(this.label_gravado);
            this.groupBox_totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_totales.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_totales.Location = new System.Drawing.Point(12, 544);
            this.groupBox_totales.Name = "groupBox_totales";
            this.groupBox_totales.Size = new System.Drawing.Size(774, 63);
            this.groupBox_totales.TabIndex = 21;
            this.groupBox_totales.TabStop = false;
            this.groupBox_totales.Text = "Totales";
            // 
            // textBox_total
            // 
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(616, 20);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(137, 22);
            this.textBox_total.TabIndex = 33;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_total.Location = new System.Drawing.Point(566, 24);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(44, 16);
            this.label_total.TabIndex = 32;
            this.label_total.Text = "Total";
            // 
            // textBox_iva21
            // 
            this.textBox_iva21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iva21.Location = new System.Drawing.Point(443, 20);
            this.textBox_iva21.Name = "textBox_iva21";
            this.textBox_iva21.Size = new System.Drawing.Size(116, 22);
            this.textBox_iva21.TabIndex = 31;
            // 
            // label_iva21
            // 
            this.label_iva21.AutoSize = true;
            this.label_iva21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_iva21.Location = new System.Drawing.Point(372, 24);
            this.label_iva21.Name = "label_iva21";
            this.label_iva21.Size = new System.Drawing.Size(65, 16);
            this.label_iva21.TabIndex = 30;
            this.label_iva21.Text = "IVA 21%";
            // 
            // textBox_exento
            // 
            this.textBox_exento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_exento.Location = new System.Drawing.Point(261, 21);
            this.textBox_exento.Name = "textBox_exento";
            this.textBox_exento.Size = new System.Drawing.Size(105, 22);
            this.textBox_exento.TabIndex = 29;
            // 
            // label_exento
            // 
            this.label_exento.AutoSize = true;
            this.label_exento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_exento.Location = new System.Drawing.Point(200, 23);
            this.label_exento.Name = "label_exento";
            this.label_exento.Size = new System.Drawing.Size(55, 16);
            this.label_exento.TabIndex = 28;
            this.label_exento.Text = "Exento";
            // 
            // textBox_gravado
            // 
            this.textBox_gravado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gravado.Location = new System.Drawing.Point(81, 21);
            this.textBox_gravado.Name = "textBox_gravado";
            this.textBox_gravado.Size = new System.Drawing.Size(113, 22);
            this.textBox_gravado.TabIndex = 27;
            // 
            // label_gravado
            // 
            this.label_gravado.AutoSize = true;
            this.label_gravado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_gravado.Location = new System.Drawing.Point(7, 24);
            this.label_gravado.Name = "label_gravado";
            this.label_gravado.Size = new System.Drawing.Size(68, 16);
            this.label_gravado.TabIndex = 0;
            this.label_gravado.Text = "Gravado";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_cuit);
            this.groupBox1.Controls.Add(this.label_cuit);
            this.groupBox1.Controls.Add(this.textBox_cliente);
            this.groupBox1.Controls.Add(this.label_cliente);
            this.groupBox1.Controls.Add(this.label_estado_del_servicio_resultado);
            this.groupBox1.Controls.Add(this.label_estado_del_servicio);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textBox_id_serivicio);
            this.groupBox1.Controls.Add(this.label_id_servicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 83);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cuit.Enabled = false;
            this.textBox_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cuit.Location = new System.Drawing.Point(804, 50);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Size = new System.Drawing.Size(171, 22);
            this.textBox_cuit.TabIndex = 23;
            // 
            // label_cuit
            // 
            this.label_cuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_cuit.Location = new System.Drawing.Point(755, 53);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(43, 16);
            this.label_cuit.TabIndex = 22;
            this.label_cuit.Text = "CUIT";
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cliente.Enabled = false;
            this.textBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cliente.Location = new System.Drawing.Point(375, 50);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(374, 22);
            this.textBox_cliente.TabIndex = 21;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_cliente.Location = new System.Drawing.Point(313, 53);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(56, 16);
            this.label_cliente.TabIndex = 20;
            this.label_cliente.Text = "Cliente";
            // 
            // label_estado_del_servicio_resultado
            // 
            this.label_estado_del_servicio_resultado.AutoSize = true;
            this.label_estado_del_servicio_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado_del_servicio_resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_estado_del_servicio_resultado.Location = new System.Drawing.Point(212, 54);
            this.label_estado_del_servicio_resultado.Name = "label_estado_del_servicio_resultado";
            this.label_estado_del_servicio_resultado.Size = new System.Drawing.Size(0, 16);
            this.label_estado_del_servicio_resultado.TabIndex = 19;
            // 
            // label_estado_del_servicio
            // 
            this.label_estado_del_servicio.AutoSize = true;
            this.label_estado_del_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado_del_servicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_estado_del_servicio.Location = new System.Drawing.Point(14, 54);
            this.label_estado_del_servicio.Name = "label_estado_del_servicio";
            this.label_estado_del_servicio.Size = new System.Drawing.Size(192, 16);
            this.label_estado_del_servicio.TabIndex = 18;
            this.label_estado_del_servicio.Text = "label_estado_del_servicio";
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_buscar.Location = new System.Drawing.Point(876, 20);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 23);
            this.button_buscar.TabIndex = 17;
            this.button_buscar.Text = "BUSCAR";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // textBox_id_serivicio
            // 
            this.textBox_id_serivicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id_serivicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id_serivicio.Location = new System.Drawing.Point(106, 21);
            this.textBox_id_serivicio.Name = "textBox_id_serivicio";
            this.textBox_id_serivicio.Size = new System.Drawing.Size(763, 22);
            this.textBox_id_serivicio.TabIndex = 16;            
            this.textBox_id_serivicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_serivicio_KeyPress);
            // 
            // label_id_servicio
            // 
            this.label_id_servicio.AutoSize = true;
            this.label_id_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_servicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_id_servicio.Location = new System.Drawing.Point(14, 24);
            this.label_id_servicio.Name = "label_id_servicio";
            this.label_id_servicio.Size = new System.Drawing.Size(86, 16);
            this.label_id_servicio.TabIndex = 15;
            this.label_id_servicio.Text = "Nº Servicio";
            // 
            // groupBox_datos_del_receptor
            // 
            this.groupBox_datos_del_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_datos_del_receptor.Controls.Add(this.groupBox_envio_nacional);
            this.groupBox_datos_del_receptor.Controls.Add(this.checkBox_internacional);
            this.groupBox_datos_del_receptor.Controls.Add(this.dateTimePicker_fecha_solicitud);
            this.groupBox_datos_del_receptor.Controls.Add(this.label_fecha_solicitud);
            this.groupBox_datos_del_receptor.Controls.Add(this.groupBox_urgencia);
            this.groupBox_datos_del_receptor.Controls.Add(this.groupBox_tipo_envio);
            this.groupBox_datos_del_receptor.Controls.Add(this.comboBox_sucursal_destino);
            this.groupBox_datos_del_receptor.Controls.Add(this.label_sucursal_destino);
            this.groupBox_datos_del_receptor.Controls.Add(this.checkBox_retiro_en_sucursal);
            this.groupBox_datos_del_receptor.Controls.Add(this.textBox_correo_receptor);
            this.groupBox_datos_del_receptor.Controls.Add(this.label5);
            this.groupBox_datos_del_receptor.Controls.Add(this.textBox_celular_receptor);
            this.groupBox_datos_del_receptor.Controls.Add(this.label6);
            this.groupBox_datos_del_receptor.Controls.Add(this.textBox_razon_social_receptor);
            this.groupBox_datos_del_receptor.Controls.Add(this.label1);
            this.groupBox_datos_del_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datos_del_receptor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_datos_del_receptor.Location = new System.Drawing.Point(14, 94);
            this.groupBox_datos_del_receptor.Name = "groupBox_datos_del_receptor";
            this.groupBox_datos_del_receptor.Size = new System.Drawing.Size(980, 271);
            this.groupBox_datos_del_receptor.TabIndex = 23;
            this.groupBox_datos_del_receptor.TabStop = false;
            this.groupBox_datos_del_receptor.Text = "Datos del Receptor";
            // 
            // groupBox_envio_nacional
            // 
            this.groupBox_envio_nacional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_envio_nacional.Controls.Add(this.groupBox_internacional);
            this.groupBox_envio_nacional.Controls.Add(this.textBox_region);
            this.groupBox_envio_nacional.Controls.Add(this.label_region);
            this.groupBox_envio_nacional.Controls.Add(this.label2);
            this.groupBox_envio_nacional.Controls.Add(this.comboBox_localidad);
            this.groupBox_envio_nacional.Controls.Add(this.comboBox_provincia);
            this.groupBox_envio_nacional.Controls.Add(this.textBox_direccion_receptor);
            this.groupBox_envio_nacional.Controls.Add(this.label_direccion_destino);
            this.groupBox_envio_nacional.Controls.Add(this.textBox_codigo_postal_receptor);
            this.groupBox_envio_nacional.Controls.Add(this.label3);
            this.groupBox_envio_nacional.Controls.Add(this.label4);
            this.groupBox_envio_nacional.Location = new System.Drawing.Point(10, 77);
            this.groupBox_envio_nacional.Name = "groupBox_envio_nacional";
            this.groupBox_envio_nacional.Size = new System.Drawing.Size(963, 77);
            this.groupBox_envio_nacional.TabIndex = 53;
            this.groupBox_envio_nacional.TabStop = false;
            // 
            // groupBox_internacional
            // 
            this.groupBox_internacional.Controls.Add(this.comboBox_region_internacional);
            this.groupBox_internacional.Controls.Add(this.label_region_internacional);
            this.groupBox_internacional.Controls.Add(this.textBox_direccion_internacional);
            this.groupBox_internacional.Controls.Add(this.label_direccion_internacional);
            this.groupBox_internacional.Location = new System.Drawing.Point(158, 3);
            this.groupBox_internacional.Name = "groupBox_internacional";
            this.groupBox_internacional.Size = new System.Drawing.Size(336, 76);
            this.groupBox_internacional.TabIndex = 1;
            this.groupBox_internacional.TabStop = false;
            // 
            // comboBox_region_internacional
            // 
            this.comboBox_region_internacional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_region_internacional.FormattingEnabled = true;
            this.comboBox_region_internacional.Location = new System.Drawing.Point(137, 43);
            this.comboBox_region_internacional.Name = "comboBox_region_internacional";
            this.comboBox_region_internacional.Size = new System.Drawing.Size(191, 24);
            this.comboBox_region_internacional.TabIndex = 52;
            // 
            // label_region_internacional
            // 
            this.label_region_internacional.AutoSize = true;
            this.label_region_internacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_region_internacional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_region_internacional.Location = new System.Drawing.Point(6, 46);
            this.label_region_internacional.Name = "label_region_internacional";
            this.label_region_internacional.Size = new System.Drawing.Size(58, 16);
            this.label_region_internacional.TabIndex = 51;
            this.label_region_internacional.Text = "Región";
            // 
            // textBox_direccion_internacional
            // 
            this.textBox_direccion_internacional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_direccion_internacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion_internacional.Location = new System.Drawing.Point(137, 15);
            this.textBox_direccion_internacional.Name = "textBox_direccion_internacional";
            this.textBox_direccion_internacional.Size = new System.Drawing.Size(191, 22);
            this.textBox_direccion_internacional.TabIndex = 41;
            // 
            // label_direccion_internacional
            // 
            this.label_direccion_internacional.AutoSize = true;
            this.label_direccion_internacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion_internacional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_direccion_internacional.Location = new System.Drawing.Point(6, 18);
            this.label_direccion_internacional.Name = "label_direccion_internacional";
            this.label_direccion_internacional.Size = new System.Drawing.Size(74, 16);
            this.label_direccion_internacional.TabIndex = 40;
            this.label_direccion_internacional.Text = "Dirección";
            // 
            // textBox_region
            // 
            this.textBox_region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_region.Enabled = false;
            this.textBox_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_region.Location = new System.Drawing.Point(852, 15);
            this.textBox_region.Name = "textBox_region";
            this.textBox_region.Size = new System.Drawing.Size(103, 22);
            this.textBox_region.TabIndex = 59;
            // 
            // label_region
            // 
            this.label_region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_region.AutoSize = true;
            this.label_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_region.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_region.Location = new System.Drawing.Point(789, 18);
            this.label_region.Name = "label_region";
            this.label_region.Size = new System.Drawing.Size(58, 16);
            this.label_region.TabIndex = 58;
            this.label_region.Text = "Región";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(810, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "C.P.";
            // 
            // comboBox_localidad
            // 
            this.comboBox_localidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_localidad.FormattingEnabled = true;
            this.comboBox_localidad.Location = new System.Drawing.Point(615, 43);
            this.comboBox_localidad.Name = "comboBox_localidad";
            this.comboBox_localidad.Size = new System.Drawing.Size(189, 24);
            this.comboBox_localidad.TabIndex = 56;
            // 
            // comboBox_provincia
            // 
            this.comboBox_provincia.FormattingEnabled = true;
            this.comboBox_provincia.Location = new System.Drawing.Point(137, 43);
            this.comboBox_provincia.Name = "comboBox_provincia";
            this.comboBox_provincia.Size = new System.Drawing.Size(382, 24);
            this.comboBox_provincia.TabIndex = 55;
            // 
            // textBox_direccion_receptor
            // 
            this.textBox_direccion_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_direccion_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion_receptor.Location = new System.Drawing.Point(137, 15);
            this.textBox_direccion_receptor.Name = "textBox_direccion_receptor";
            this.textBox_direccion_receptor.Size = new System.Drawing.Size(646, 22);
            this.textBox_direccion_receptor.TabIndex = 54;
            // 
            // label_direccion_destino
            // 
            this.label_direccion_destino.AutoSize = true;
            this.label_direccion_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion_destino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_direccion_destino.Location = new System.Drawing.Point(6, 18);
            this.label_direccion_destino.Name = "label_direccion_destino";
            this.label_direccion_destino.Size = new System.Drawing.Size(74, 16);
            this.label_direccion_destino.TabIndex = 53;
            this.label_direccion_destino.Text = "Dirección";
            // 
            // textBox_codigo_postal_receptor
            // 
            this.textBox_codigo_postal_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_codigo_postal_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigo_postal_receptor.Location = new System.Drawing.Point(852, 43);
            this.textBox_codigo_postal_receptor.Name = "textBox_codigo_postal_receptor";
            this.textBox_codigo_postal_receptor.Size = new System.Drawing.Size(103, 22);
            this.textBox_codigo_postal_receptor.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(532, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Provincia";
            // 
            // checkBox_internacional
            // 
            this.checkBox_internacional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_internacional.AutoSize = true;
            this.checkBox_internacional.Location = new System.Drawing.Point(857, 54);
            this.checkBox_internacional.Name = "checkBox_internacional";
            this.checkBox_internacional.Size = new System.Drawing.Size(116, 20);
            this.checkBox_internacional.TabIndex = 52;
            this.checkBox_internacional.Text = "Internacional";
            this.checkBox_internacional.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fecha_solicitud
            // 
            this.dateTimePicker_fecha_solicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha_solicitud.Location = new System.Drawing.Point(147, 217);
            this.dateTimePicker_fecha_solicitud.Name = "dateTimePicker_fecha_solicitud";
            this.dateTimePicker_fecha_solicitud.Size = new System.Drawing.Size(357, 22);
            this.dateTimePicker_fecha_solicitud.TabIndex = 47;
            // 
            // label_fecha_solicitud
            // 
            this.label_fecha_solicitud.AutoSize = true;
            this.label_fecha_solicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_solicitud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_fecha_solicitud.Location = new System.Drawing.Point(16, 222);
            this.label_fecha_solicitud.Name = "label_fecha_solicitud";
            this.label_fecha_solicitud.Size = new System.Drawing.Size(112, 16);
            this.label_fecha_solicitud.TabIndex = 46;
            this.label_fecha_solicitud.Text = "Fecha Servicio";
            // 
            // groupBox_urgencia
            // 
            this.groupBox_urgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_urgencia.Controls.Add(this.radioButton_urgencia_normal);
            this.groupBox_urgencia.Controls.Add(this.radioButton_urgencia_urgente);
            this.groupBox_urgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_urgencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_urgencia.Location = new System.Drawing.Point(796, 189);
            this.groupBox_urgencia.Name = "groupBox_urgencia";
            this.groupBox_urgencia.Size = new System.Drawing.Size(177, 59);
            this.groupBox_urgencia.TabIndex = 45;
            this.groupBox_urgencia.TabStop = false;
            this.groupBox_urgencia.Text = "Urgencia";
            // 
            // radioButton_urgencia_normal
            // 
            this.radioButton_urgencia_normal.AutoSize = true;
            this.radioButton_urgencia_normal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_urgencia_normal.Location = new System.Drawing.Point(6, 21);
            this.radioButton_urgencia_normal.Name = "radioButton_urgencia_normal";
            this.radioButton_urgencia_normal.Size = new System.Drawing.Size(76, 20);
            this.radioButton_urgencia_normal.TabIndex = 40;
            this.radioButton_urgencia_normal.TabStop = true;
            this.radioButton_urgencia_normal.Text = "Normal";
            this.radioButton_urgencia_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_urgencia_urgente
            // 
            this.radioButton_urgencia_urgente.AutoSize = true;
            this.radioButton_urgencia_urgente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_urgencia_urgente.Location = new System.Drawing.Point(88, 21);
            this.radioButton_urgencia_urgente.Name = "radioButton_urgencia_urgente";
            this.radioButton_urgencia_urgente.Size = new System.Drawing.Size(81, 20);
            this.radioButton_urgencia_urgente.TabIndex = 41;
            this.radioButton_urgencia_urgente.TabStop = true;
            this.radioButton_urgencia_urgente.Text = "Urgente";
            this.radioButton_urgencia_urgente.UseVisualStyleBackColor = true;
            // 
            // groupBox_tipo_envio
            // 
            this.groupBox_tipo_envio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_tipo_envio.Controls.Add(this.radioButton_tipo_envio_encomienda);
            this.groupBox_tipo_envio.Controls.Add(this.radioButton_tipo_envio_correspondencia);
            this.groupBox_tipo_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipo_envio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_tipo_envio.Location = new System.Drawing.Point(513, 189);
            this.groupBox_tipo_envio.Name = "groupBox_tipo_envio";
            this.groupBox_tipo_envio.Size = new System.Drawing.Size(275, 59);
            this.groupBox_tipo_envio.TabIndex = 44;
            this.groupBox_tipo_envio.TabStop = false;
            this.groupBox_tipo_envio.Text = "Tipo Envío";
            // 
            // radioButton_tipo_envio_encomienda
            // 
            this.radioButton_tipo_envio_encomienda.AutoSize = true;
            this.radioButton_tipo_envio_encomienda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_tipo_envio_encomienda.Location = new System.Drawing.Point(6, 21);
            this.radioButton_tipo_envio_encomienda.Name = "radioButton_tipo_envio_encomienda";
            this.radioButton_tipo_envio_encomienda.Size = new System.Drawing.Size(112, 20);
            this.radioButton_tipo_envio_encomienda.TabIndex = 41;
            this.radioButton_tipo_envio_encomienda.TabStop = true;
            this.radioButton_tipo_envio_encomienda.Text = "Encomienda";
            this.radioButton_tipo_envio_encomienda.UseVisualStyleBackColor = true;
            // 
            // radioButton_tipo_envio_correspondencia
            // 
            this.radioButton_tipo_envio_correspondencia.AutoSize = true;
            this.radioButton_tipo_envio_correspondencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_tipo_envio_correspondencia.Location = new System.Drawing.Point(124, 21);
            this.radioButton_tipo_envio_correspondencia.Name = "radioButton_tipo_envio_correspondencia";
            this.radioButton_tipo_envio_correspondencia.Size = new System.Drawing.Size(145, 20);
            this.radioButton_tipo_envio_correspondencia.TabIndex = 40;
            this.radioButton_tipo_envio_correspondencia.TabStop = true;
            this.radioButton_tipo_envio_correspondencia.Text = "Correspondencia";
            this.radioButton_tipo_envio_correspondencia.UseVisualStyleBackColor = true;
            // 
            // comboBox_sucursal_destino
            // 
            this.comboBox_sucursal_destino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sucursal_destino.FormattingEnabled = true;
            this.comboBox_sucursal_destino.Location = new System.Drawing.Point(147, 50);
            this.comboBox_sucursal_destino.Name = "comboBox_sucursal_destino";
            this.comboBox_sucursal_destino.Size = new System.Drawing.Size(705, 24);
            this.comboBox_sucursal_destino.TabIndex = 37;
            // 
            // label_sucursal_destino
            // 
            this.label_sucursal_destino.AutoSize = true;
            this.label_sucursal_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sucursal_destino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sucursal_destino.Location = new System.Drawing.Point(16, 53);
            this.label_sucursal_destino.Name = "label_sucursal_destino";
            this.label_sucursal_destino.Size = new System.Drawing.Size(125, 16);
            this.label_sucursal_destino.TabIndex = 36;
            this.label_sucursal_destino.Text = "Sucursal Destino";
            // 
            // checkBox_retiro_en_sucursal
            // 
            this.checkBox_retiro_en_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_retiro_en_sucursal.AutoSize = true;
            this.checkBox_retiro_en_sucursal.Location = new System.Drawing.Point(820, 23);
            this.checkBox_retiro_en_sucursal.Name = "checkBox_retiro_en_sucursal";
            this.checkBox_retiro_en_sucursal.Size = new System.Drawing.Size(154, 20);
            this.checkBox_retiro_en_sucursal.TabIndex = 35;
            this.checkBox_retiro_en_sucursal.Text = "Retiro en Sucursal";
            this.checkBox_retiro_en_sucursal.UseVisualStyleBackColor = true;
            // 
            // textBox_correo_receptor
            // 
            this.textBox_correo_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_correo_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_correo_receptor.Location = new System.Drawing.Point(147, 161);
            this.textBox_correo_receptor.Name = "textBox_correo_receptor";
            this.textBox_correo_receptor.Size = new System.Drawing.Size(827, 22);
            this.textBox_correo_receptor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Correo";
            // 
            // textBox_celular_receptor
            // 
            this.textBox_celular_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_celular_receptor.Location = new System.Drawing.Point(147, 189);
            this.textBox_celular_receptor.Name = "textBox_celular_receptor";
            this.textBox_celular_receptor.Size = new System.Drawing.Size(357, 22);
            this.textBox_celular_receptor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(16, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nº Celular";
            // 
            // textBox_razon_social_receptor
            // 
            this.textBox_razon_social_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_razon_social_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_razon_social_receptor.Location = new System.Drawing.Point(147, 21);
            this.textBox_razon_social_receptor.Name = "textBox_razon_social_receptor";
            this.textBox_razon_social_receptor.Size = new System.Drawing.Size(667, 22);
            this.textBox_razon_social_receptor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Razón Social";
            // 
            // ConsultarEstadoDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 619);
            this.Controls.Add(this.groupBox_datos_del_receptor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_totales);
            this.Controls.Add(this.groupBox_datos_del_servicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEstadoDeServicio";
            this.Text = "ConsultarEstadoDeServicio";
            this.Load += new System.EventHandler(this.ConsultarEstadoDeServicio_Load);
            this.groupBox_datos_del_servicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos_del_servicio)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_totales.ResumeLayout(false);
            this.groupBox_totales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_datos_del_receptor.ResumeLayout(false);
            this.groupBox_datos_del_receptor.PerformLayout();
            this.groupBox_envio_nacional.ResumeLayout(false);
            this.groupBox_envio_nacional.PerformLayout();
            this.groupBox_internacional.ResumeLayout(false);
            this.groupBox_internacional.PerformLayout();
            this.groupBox_urgencia.ResumeLayout(false);
            this.groupBox_urgencia.PerformLayout();
            this.groupBox_tipo_envio.ResumeLayout(false);
            this.groupBox_tipo_envio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_datos_del_servicio;
        private System.Windows.Forms.DataGridView dataGridView_datos_del_servicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirPosiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPosiciónToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_totales;
        internal System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label_total;
        internal System.Windows.Forms.TextBox textBox_iva21;
        private System.Windows.Forms.Label label_iva21;
        internal System.Windows.Forms.TextBox textBox_exento;
        private System.Windows.Forms.Label label_exento;
        internal System.Windows.Forms.TextBox textBox_gravado;
        private System.Windows.Forms.Label label_gravado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar;
        internal System.Windows.Forms.TextBox textBox_id_serivicio;
        internal System.Windows.Forms.Label label_id_servicio;
        private System.Windows.Forms.GroupBox groupBox_datos_del_receptor;
        private System.Windows.Forms.GroupBox groupBox_envio_nacional;
        private System.Windows.Forms.GroupBox groupBox_internacional;
        private System.Windows.Forms.ComboBox comboBox_region_internacional;
        internal System.Windows.Forms.Label label_region_internacional;
        internal System.Windows.Forms.TextBox textBox_direccion_internacional;
        internal System.Windows.Forms.Label label_direccion_internacional;
        internal System.Windows.Forms.TextBox textBox_region;
        internal System.Windows.Forms.Label label_region;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_localidad;
        private System.Windows.Forms.ComboBox comboBox_provincia;
        internal System.Windows.Forms.TextBox textBox_direccion_receptor;
        internal System.Windows.Forms.Label label_direccion_destino;
        internal System.Windows.Forms.TextBox textBox_codigo_postal_receptor;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_internacional;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha_solicitud;
        internal System.Windows.Forms.Label label_fecha_solicitud;
        private System.Windows.Forms.GroupBox groupBox_urgencia;
        private System.Windows.Forms.RadioButton radioButton_urgencia_normal;
        private System.Windows.Forms.RadioButton radioButton_urgencia_urgente;
        private System.Windows.Forms.GroupBox groupBox_tipo_envio;
        private System.Windows.Forms.RadioButton radioButton_tipo_envio_encomienda;
        private System.Windows.Forms.RadioButton radioButton_tipo_envio_correspondencia;
        private System.Windows.Forms.ComboBox comboBox_sucursal_destino;
        internal System.Windows.Forms.Label label_sucursal_destino;
        private System.Windows.Forms.CheckBox checkBox_retiro_en_sucursal;
        internal System.Windows.Forms.TextBox textBox_correo_receptor;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox_celular_receptor;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBox_razon_social_receptor;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label_estado_del_servicio;
        internal System.Windows.Forms.Label label_estado_del_servicio_resultado;
        internal System.Windows.Forms.TextBox textBox_cuit;
        internal System.Windows.Forms.Label label_cuit;
        internal System.Windows.Forms.TextBox textBox_cliente;
        internal System.Windows.Forms.Label label_cliente;
    }
}