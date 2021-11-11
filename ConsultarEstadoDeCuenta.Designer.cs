
namespace Encomiendas
{
    partial class ConsultarEstadoDeCuenta
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
            this.groupBox_datos_del_receptor = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textBox_cuit = new System.Windows.Forms.TextBox();
            this.label_cuit_cliente = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_resultado = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_facturacion_paga = new System.Windows.Forms.GroupBox();
            this.dataGridView_facturacion_paga = new System.Windows.Forms.DataGridView();
            this.groupBox_facturacion_impaga = new System.Windows.Forms.GroupBox();
            this.dataGridView_facturacion_impaga = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox_servicios_cumplidos = new System.Windows.Forms.GroupBox();
            this.dataGridView_servicios_cumplidos = new System.Windows.Forms.DataGridView();
            this.groupBox_servicios_pdtes_de_facturacion = new System.Windows.Forms.GroupBox();
            this.dataGridView_servicios_pdtes_de_facturacion = new System.Windows.Forms.DataGridView();
            this.textBox_saldo = new System.Windows.Forms.TextBox();
            this.label_saldo = new System.Windows.Forms.Label();
            this.groupBox_datos_del_receptor.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_facturacion_paga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturacion_paga)).BeginInit();
            this.groupBox_facturacion_impaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturacion_impaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_servicios_cumplidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios_cumplidos)).BeginInit();
            this.groupBox_servicios_pdtes_de_facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios_pdtes_de_facturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_datos_del_receptor
            // 
            this.groupBox_datos_del_receptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_datos_del_receptor.Controls.Add(this.button_buscar);
            this.groupBox_datos_del_receptor.Controls.Add(this.textBox_cuit);
            this.groupBox_datos_del_receptor.Controls.Add(this.label_cuit_cliente);
            this.groupBox_datos_del_receptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datos_del_receptor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_datos_del_receptor.Location = new System.Drawing.Point(9, 12);
            this.groupBox_datos_del_receptor.Name = "groupBox_datos_del_receptor";
            this.groupBox_datos_del_receptor.Size = new System.Drawing.Size(1186, 60);
            this.groupBox_datos_del_receptor.TabIndex = 16;
            this.groupBox_datos_del_receptor.TabStop = false;
            this.groupBox_datos_del_receptor.Text = "Datos";
            this.groupBox_datos_del_receptor.Enter += new System.EventHandler(this.groupBox_datos_del_receptor_Enter);
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_buscar.Location = new System.Drawing.Point(1083, 20);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 23);
            this.button_buscar.TabIndex = 17;
            this.button_buscar.Text = "BUSCAR";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cuit.Location = new System.Drawing.Point(63, 21);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Size = new System.Drawing.Size(1013, 22);
            this.textBox_cuit.TabIndex = 16;
            this.textBox_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cuit_KeyPress);
            // 
            // label_cuit_cliente
            // 
            this.label_cuit_cliente.AutoSize = true;
            this.label_cuit_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_cuit_cliente.Location = new System.Drawing.Point(14, 24);
            this.label_cuit_cliente.Name = "label_cuit_cliente";
            this.label_cuit_cliente.Size = new System.Drawing.Size(43, 16);
            this.label_cuit_cliente.TabIndex = 15;
            this.label_cuit_cliente.Text = "CUIT";
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
            // groupBox_resultado
            // 
            this.groupBox_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_resultado.Controls.Add(this.splitContainer3);
            this.groupBox_resultado.Controls.Add(this.textBox_saldo);
            this.groupBox_resultado.Controls.Add(this.label_saldo);
            this.groupBox_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_resultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_resultado.Location = new System.Drawing.Point(9, 78);
            this.groupBox_resultado.Name = "groupBox_resultado";
            this.groupBox_resultado.Size = new System.Drawing.Size(1186, 566);
            this.groupBox_resultado.TabIndex = 17;
            this.groupBox_resultado.TabStop = false;
            this.groupBox_resultado.Text = "Resultados";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(6, 21);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(1171, 480);
            this.splitContainer3.SplitterDistance = 240;
            this.splitContainer3.TabIndex = 33;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_facturacion_paga);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_facturacion_impaga);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 240);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 31;
            // 
            // groupBox_facturacion_paga
            // 
            this.groupBox_facturacion_paga.Controls.Add(this.dataGridView_facturacion_paga);
            this.groupBox_facturacion_paga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_facturacion_paga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_facturacion_paga.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_facturacion_paga.Location = new System.Drawing.Point(0, 0);
            this.groupBox_facturacion_paga.Name = "groupBox_facturacion_paga";
            this.groupBox_facturacion_paga.Size = new System.Drawing.Size(1171, 100);
            this.groupBox_facturacion_paga.TabIndex = 27;
            this.groupBox_facturacion_paga.TabStop = false;
            this.groupBox_facturacion_paga.Text = "Facturación Paga";
            // 
            // dataGridView_facturacion_paga
            // 
            this.dataGridView_facturacion_paga.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_facturacion_paga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facturacion_paga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_facturacion_paga.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_facturacion_paga.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_facturacion_paga.Name = "dataGridView_facturacion_paga";
            this.dataGridView_facturacion_paga.Size = new System.Drawing.Size(1165, 79);
            this.dataGridView_facturacion_paga.TabIndex = 101;
            // 
            // groupBox_facturacion_impaga
            // 
            this.groupBox_facturacion_impaga.Controls.Add(this.dataGridView_facturacion_impaga);
            this.groupBox_facturacion_impaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_facturacion_impaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_facturacion_impaga.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_facturacion_impaga.Location = new System.Drawing.Point(0, 0);
            this.groupBox_facturacion_impaga.Name = "groupBox_facturacion_impaga";
            this.groupBox_facturacion_impaga.Size = new System.Drawing.Size(1171, 136);
            this.groupBox_facturacion_impaga.TabIndex = 28;
            this.groupBox_facturacion_impaga.TabStop = false;
            this.groupBox_facturacion_impaga.Text = "Facturación Impaga";
            // 
            // dataGridView_facturacion_impaga
            // 
            this.dataGridView_facturacion_impaga.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_facturacion_impaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facturacion_impaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_facturacion_impaga.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_facturacion_impaga.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_facturacion_impaga.Name = "dataGridView_facturacion_impaga";
            this.dataGridView_facturacion_impaga.Size = new System.Drawing.Size(1165, 115);
            this.dataGridView_facturacion_impaga.TabIndex = 101;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_servicios_cumplidos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_servicios_pdtes_de_facturacion);
            this.splitContainer2.Size = new System.Drawing.Size(1171, 236);
            this.splitContainer2.SplitterDistance = 118;
            this.splitContainer2.TabIndex = 32;
            // 
            // groupBox_servicios_cumplidos
            // 
            this.groupBox_servicios_cumplidos.Controls.Add(this.dataGridView_servicios_cumplidos);
            this.groupBox_servicios_cumplidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_servicios_cumplidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_servicios_cumplidos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_servicios_cumplidos.Location = new System.Drawing.Point(0, 0);
            this.groupBox_servicios_cumplidos.Name = "groupBox_servicios_cumplidos";
            this.groupBox_servicios_cumplidos.Size = new System.Drawing.Size(1171, 118);
            this.groupBox_servicios_cumplidos.TabIndex = 29;
            this.groupBox_servicios_cumplidos.TabStop = false;
            this.groupBox_servicios_cumplidos.Text = "Servicios Cumplidos";
            // 
            // dataGridView_servicios_cumplidos
            // 
            this.dataGridView_servicios_cumplidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_servicios_cumplidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_servicios_cumplidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_servicios_cumplidos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_servicios_cumplidos.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_servicios_cumplidos.Name = "dataGridView_servicios_cumplidos";
            this.dataGridView_servicios_cumplidos.Size = new System.Drawing.Size(1165, 97);
            this.dataGridView_servicios_cumplidos.TabIndex = 101;
            // 
            // groupBox_servicios_pdtes_de_facturacion
            // 
            this.groupBox_servicios_pdtes_de_facturacion.Controls.Add(this.dataGridView_servicios_pdtes_de_facturacion);
            this.groupBox_servicios_pdtes_de_facturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_servicios_pdtes_de_facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_servicios_pdtes_de_facturacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_servicios_pdtes_de_facturacion.Location = new System.Drawing.Point(0, 0);
            this.groupBox_servicios_pdtes_de_facturacion.Name = "groupBox_servicios_pdtes_de_facturacion";
            this.groupBox_servicios_pdtes_de_facturacion.Size = new System.Drawing.Size(1171, 114);
            this.groupBox_servicios_pdtes_de_facturacion.TabIndex = 30;
            this.groupBox_servicios_pdtes_de_facturacion.TabStop = false;
            this.groupBox_servicios_pdtes_de_facturacion.Text = "Servicios Pdtes de Facturación";
            // 
            // dataGridView_servicios_pdtes_de_facturacion
            // 
            this.dataGridView_servicios_pdtes_de_facturacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_servicios_pdtes_de_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_servicios_pdtes_de_facturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_servicios_pdtes_de_facturacion.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_servicios_pdtes_de_facturacion.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_servicios_pdtes_de_facturacion.Name = "dataGridView_servicios_pdtes_de_facturacion";
            this.dataGridView_servicios_pdtes_de_facturacion.Size = new System.Drawing.Size(1165, 93);
            this.dataGridView_servicios_pdtes_de_facturacion.TabIndex = 101;
            // 
            // textBox_saldo
            // 
            this.textBox_saldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_saldo.Location = new System.Drawing.Point(894, 520);
            this.textBox_saldo.Name = "textBox_saldo";
            this.textBox_saldo.Size = new System.Drawing.Size(283, 22);
            this.textBox_saldo.TabIndex = 26;
            // 
            // label_saldo
            // 
            this.label_saldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_saldo.AutoSize = true;
            this.label_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_saldo.Location = new System.Drawing.Point(839, 523);
            this.label_saldo.Name = "label_saldo";
            this.label_saldo.Size = new System.Drawing.Size(49, 16);
            this.label_saldo.TabIndex = 25;
            this.label_saldo.Text = "Saldo";
            // 
            // ConsultarEstadoDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 656);
            this.Controls.Add(this.groupBox_resultado);
            this.Controls.Add(this.groupBox_datos_del_receptor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEstadoDeCuenta";
            this.Text = "ConsultarEstadoDeCuenta";
            this.Load += new System.EventHandler(this.ConsultarEstadoDeCuenta_Load);
            this.groupBox_datos_del_receptor.ResumeLayout(false);
            this.groupBox_datos_del_receptor.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_resultado.ResumeLayout(false);
            this.groupBox_resultado.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_facturacion_paga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturacion_paga)).EndInit();
            this.groupBox_facturacion_impaga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturacion_impaga)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_servicios_cumplidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios_cumplidos)).EndInit();
            this.groupBox_servicios_pdtes_de_facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios_pdtes_de_facturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_datos_del_receptor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirPosiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPosiciónToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_resultado;
        private System.Windows.Forms.Button button_buscar;
        internal System.Windows.Forms.TextBox textBox_cuit;
        internal System.Windows.Forms.Label label_cuit_cliente;
        internal System.Windows.Forms.TextBox textBox_saldo;
        internal System.Windows.Forms.Label label_saldo;
        private System.Windows.Forms.GroupBox groupBox_facturacion_paga;
        private System.Windows.Forms.DataGridView dataGridView_facturacion_paga;
        private System.Windows.Forms.GroupBox groupBox_servicios_pdtes_de_facturacion;
        private System.Windows.Forms.DataGridView dataGridView_servicios_pdtes_de_facturacion;
        private System.Windows.Forms.GroupBox groupBox_servicios_cumplidos;
        private System.Windows.Forms.DataGridView dataGridView_servicios_cumplidos;
        private System.Windows.Forms.GroupBox groupBox_facturacion_impaga;
        private System.Windows.Forms.DataGridView dataGridView_facturacion_impaga;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}