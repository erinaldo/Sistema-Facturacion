﻿namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_DetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DetalleVenta));
            this.text_fecha = new System.Windows.Forms.DateTimePicker();
            this.text_NumeroDoc = new System.Windows.Forms.TextBox();
            this.text_ClienteId = new System.Windows.Forms.TextBox();
            this.text_ClienteNombre = new System.Windows.Forms.TextBox();
            this.textVentaId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noencontrado = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.text_DescripcionVenta = new System.Windows.Forms.TextBox();
            this.Lbl_Comentario = new System.Windows.Forms.Label();
            this.text_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.text_ProductoId = new System.Windows.Forms.TextBox();
            this.text_ProductoDescripcion = new System.Windows.Forms.TextBox();
            this.lab_stock = new System.Windows.Forms.Label();
            this.lab_valor = new System.Windows.Forms.Label();
            this.lab_Cantidad = new System.Windows.Forms.Label();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_ProdSer = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnl_Lista_Categoria = new System.Windows.Forms.Panel();
            this.lab_encabezado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Cantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_Lista_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_fecha
            // 
            this.text_fecha.Enabled = false;
            this.text_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_fecha.Location = new System.Drawing.Point(153, 132);
            this.text_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(265, 26);
            this.text_fecha.TabIndex = 1;
            // 
            // text_NumeroDoc
            // 
            this.text_NumeroDoc.Enabled = false;
            this.text_NumeroDoc.Location = new System.Drawing.Point(153, 171);
            this.text_NumeroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.text_NumeroDoc.Name = "text_NumeroDoc";
            this.text_NumeroDoc.Size = new System.Drawing.Size(265, 26);
            this.text_NumeroDoc.TabIndex = 2;
            // 
            // text_ClienteId
            // 
            this.text_ClienteId.Enabled = false;
            this.text_ClienteId.Location = new System.Drawing.Point(356, 53);
            this.text_ClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteId.Name = "text_ClienteId";
            this.text_ClienteId.Size = new System.Drawing.Size(11, 26);
            this.text_ClienteId.TabIndex = 7;
            this.text_ClienteId.Visible = false;
            // 
            // text_ClienteNombre
            // 
            this.text_ClienteNombre.Enabled = false;
            this.text_ClienteNombre.Location = new System.Drawing.Point(153, 93);
            this.text_ClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteNombre.Name = "text_ClienteNombre";
            this.text_ClienteNombre.Size = new System.Drawing.Size(265, 26);
            this.text_ClienteNombre.TabIndex = 0;
            // 
            // textVentaId
            // 
            this.textVentaId.Enabled = false;
            this.textVentaId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textVentaId.Location = new System.Drawing.Point(375, 53);
            this.textVentaId.Margin = new System.Windows.Forms.Padding(4);
            this.textVentaId.Name = "textVentaId";
            this.textVentaId.Size = new System.Drawing.Size(11, 26);
            this.textVentaId.TabIndex = 6;
            this.textVentaId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "No. Doc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(50, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cliente";
            // 
            // noencontrado
            // 
            this.noencontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noencontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(42, 154);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(895, 362);
            this.noencontrado.TabIndex = 4;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            this.noencontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvVentas.Location = new System.Drawing.Point(42, 127);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dgvVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.dgvVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(895, 396);
            this.dgvVentas.TabIndex = 3;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(210, 93);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(727, 26);
            this.Buscar.TabIndex = 1;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Nombre",
            "Cantidad",
            "PrecioUnitario"});
            this.CMB_Buscar.Location = new System.Drawing.Point(42, 93);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(160, 28);
            this.CMB_Buscar.TabIndex = 0;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.CMB_Buscar_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(42, 520);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(895, 46);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Eliminar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // text_DescripcionVenta
            // 
            this.text_DescripcionVenta.Location = new System.Drawing.Point(153, 288);
            this.text_DescripcionVenta.Margin = new System.Windows.Forms.Padding(4);
            this.text_DescripcionVenta.Multiline = true;
            this.text_DescripcionVenta.Name = "text_DescripcionVenta";
            this.text_DescripcionVenta.Size = new System.Drawing.Size(265, 74);
            this.text_DescripcionVenta.TabIndex = 6;
            this.text_DescripcionVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_DescripcionVenta_KeyPress);
            // 
            // Lbl_Comentario
            // 
            this.Lbl_Comentario.AutoSize = true;
            this.Lbl_Comentario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Comentario.Location = new System.Drawing.Point(50, 293);
            this.Lbl_Comentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Comentario.Name = "Lbl_Comentario";
            this.Lbl_Comentario.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Comentario.TabIndex = 10;
            this.Lbl_Comentario.Text = "Descripción";
            // 
            // text_Cantidad
            // 
            this.text_Cantidad.Location = new System.Drawing.Point(153, 371);
            this.text_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.text_Cantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.text_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_Cantidad.Name = "text_Cantidad";
            this.text_Cantidad.Size = new System.Drawing.Size(105, 26);
            this.text_Cantidad.TabIndex = 7;
            this.text_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Cantidad_KeyPress);
            // 
            // text_stock
            // 
            this.text_stock.Enabled = false;
            this.text_stock.Location = new System.Drawing.Point(333, 371);
            this.text_stock.Margin = new System.Windows.Forms.Padding(4);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(85, 26);
            this.text_stock.TabIndex = 8;
            this.text_stock.Text = "0";
            this.text_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_stock_KeyPress);
            // 
            // text_PrecioUnitario
            // 
            this.text_PrecioUnitario.Location = new System.Drawing.Point(153, 249);
            this.text_PrecioUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.text_PrecioUnitario.Name = "text_PrecioUnitario";
            this.text_PrecioUnitario.Size = new System.Drawing.Size(265, 26);
            this.text_PrecioUnitario.TabIndex = 5;
            this.text_PrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_PrecioUnitario_KeyPress);
            // 
            // text_ProductoId
            // 
            this.text_ProductoId.Enabled = false;
            this.text_ProductoId.Location = new System.Drawing.Point(333, 53);
            this.text_ProductoId.Margin = new System.Windows.Forms.Padding(4);
            this.text_ProductoId.Name = "text_ProductoId";
            this.text_ProductoId.Size = new System.Drawing.Size(12, 26);
            this.text_ProductoId.TabIndex = 7;
            this.text_ProductoId.Visible = false;
            // 
            // text_ProductoDescripcion
            // 
            this.text_ProductoDescripcion.Location = new System.Drawing.Point(153, 210);
            this.text_ProductoDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.text_ProductoDescripcion.Name = "text_ProductoDescripcion";
            this.text_ProductoDescripcion.ReadOnly = true;
            this.text_ProductoDescripcion.Size = new System.Drawing.Size(265, 26);
            this.text_ProductoDescripcion.TabIndex = 4;
            this.text_ProductoDescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_ProductoDescripcion_MouseClick);
            this.text_ProductoDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_ProductoDescripcion_KeyPress);
            // 
            // lab_stock
            // 
            this.lab_stock.AutoSize = true;
            this.lab_stock.ForeColor = System.Drawing.Color.White;
            this.lab_stock.Location = new System.Drawing.Point(277, 374);
            this.lab_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_stock.Name = "lab_stock";
            this.lab_stock.Size = new System.Drawing.Size(51, 20);
            this.lab_stock.TabIndex = 14;
            this.lab_stock.Text = "Stock";
            // 
            // lab_valor
            // 
            this.lab_valor.AutoSize = true;
            this.lab_valor.ForeColor = System.Drawing.Color.White;
            this.lab_valor.Location = new System.Drawing.Point(50, 252);
            this.lab_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_valor.Name = "lab_valor";
            this.lab_valor.Size = new System.Drawing.Size(88, 20);
            this.lab_valor.TabIndex = 8;
            this.lab_valor.Text = "Valor/Prod";
            // 
            // lab_Cantidad
            // 
            this.lab_Cantidad.AutoSize = true;
            this.lab_Cantidad.ForeColor = System.Drawing.Color.White;
            this.lab_Cantidad.Location = new System.Drawing.Point(50, 374);
            this.lab_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Cantidad.Name = "lab_Cantidad";
            this.lab_Cantidad.Size = new System.Drawing.Size(75, 20);
            this.lab_Cantidad.TabIndex = 12;
            this.lab_Cantidad.Text = "Cantidad";
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(396, 53);
            this.txtFlag.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(12, 26);
            this.txtFlag.TabIndex = 9;
            this.txtFlag.Visible = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(53, 520);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(365, 46);
            this.btn_Cerrar.TabIndex = 11;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cbx_ProdSer);
            this.panel2.Controls.Add(this.txtFlag);
            this.panel2.Controls.Add(this.text_ClienteNombre);
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.text_ClienteId);
            this.panel2.Controls.Add(this.text_DescripcionVenta);
            this.panel2.Controls.Add(this.textVentaId);
            this.panel2.Controls.Add(this.Lbl_Comentario);
            this.panel2.Controls.Add(this.text_ProductoDescripcion);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.text_Cantidad);
            this.panel2.Controls.Add(this.text_ProductoId);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.text_PrecioUnitario);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lab_stock);
            this.panel2.Controls.Add(this.text_fecha);
            this.panel2.Controls.Add(this.text_stock);
            this.panel2.Controls.Add(this.lab_valor);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.text_NumeroDoc);
            this.panel2.Controls.Add(this.lab_Cantidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 608);
            this.panel2.TabIndex = 0;
            // 
            // cbx_ProdSer
            // 
            this.cbx_ProdSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cbx_ProdSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ProdSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_ProdSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ProdSer.ForeColor = System.Drawing.Color.White;
            this.cbx_ProdSer.FormattingEnabled = true;
            this.cbx_ProdSer.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.cbx_ProdSer.Location = new System.Drawing.Point(50, 209);
            this.cbx_ProdSer.Name = "cbx_ProdSer";
            this.cbx_ProdSer.Size = new System.Drawing.Size(88, 28);
            this.cbx_ProdSer.TabIndex = 3;
            this.cbx_ProdSer.SelectedIndexChanged += new System.EventHandler(this.cbx_ProdSer_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(293, 415);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(4, 0, 7, 0);
            this.btnImprimir.Size = new System.Drawing.Size(125, 46);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Facturar";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(153, 415);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 7, 0);
            this.btnAgregar.Size = new System.Drawing.Size(125, 46);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnl_Lista_Categoria
            // 
            this.pnl_Lista_Categoria.Controls.Add(this.lab_encabezado);
            this.pnl_Lista_Categoria.Controls.Add(this.noencontrado);
            this.pnl_Lista_Categoria.Controls.Add(this.Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.btnQuitar);
            this.pnl_Lista_Categoria.Controls.Add(this.CMB_Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.dgvVentas);
            this.pnl_Lista_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Categoria.Location = new System.Drawing.Point(461, 0);
            this.pnl_Lista_Categoria.Name = "pnl_Lista_Categoria";
            this.pnl_Lista_Categoria.Size = new System.Drawing.Size(983, 608);
            this.pnl_Lista_Categoria.TabIndex = 25;
            // 
            // lab_encabezado
            // 
            this.lab_encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lab_encabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_encabezado.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_encabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(102)))), ((int)(((byte)(145)))));
            this.lab_encabezado.Location = new System.Drawing.Point(42, 20);
            this.lab_encabezado.Margin = new System.Windows.Forms.Padding(0);
            this.lab_encabezado.Name = "lab_encabezado";
            this.lab_encabezado.Size = new System.Drawing.Size(895, 54);
            this.lab_encabezado.TabIndex = 10;
            this.lab_encabezado.Text = "Detalles Venta";
            this.lab_encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_DetalleVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1444, 608);
            this.Controls.Add(this.pnl_Lista_Categoria);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Cantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Lista_Categoria.ResumeLayout(false);
            this.pnl_Lista_Categoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker text_fecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox text_NumeroDoc;
        private System.Windows.Forms.TextBox text_ClienteId;
        private System.Windows.Forms.TextBox textVentaId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.NumericUpDown text_Cantidad;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.TextBox text_PrecioUnitario;
        private System.Windows.Forms.TextBox text_ProductoId;
        private System.Windows.Forms.TextBox text_ProductoDescripcion;
        private System.Windows.Forms.Label lab_stock;
        private System.Windows.Forms.Label lab_valor;
        private System.Windows.Forms.Label lab_Cantidad;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.TextBox text_DescripcionVenta;
        private System.Windows.Forms.Label Lbl_Comentario;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Lista_Categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        public System.Windows.Forms.Label lab_encabezado;
        public System.Windows.Forms.TextBox text_ClienteNombre;
        public System.Windows.Forms.ComboBox cbx_ProdSer;
    }
}