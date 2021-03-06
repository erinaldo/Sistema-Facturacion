﻿namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ventas));
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.noencontrado = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.CMB_Buscar = new System.Windows.Forms.ComboBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.text_fecha = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.text_NumeroDoc = new System.Windows.Forms.TextBox();
            this.text_ClienteId = new System.Windows.Forms.TextBox();
            this.text_ClienteNombre = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lab_DocNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_clienteNuevoORegistrado = new System.Windows.Forms.ComboBox();
            this.pbx_Ventas = new System.Windows.Forms.PictureBox();
            this.pnl_Lista_Categoria = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).BeginInit();
            this.pnl_Lista_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(44, 445);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(335, 46);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // noencontrado
            // 
            this.noencontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noencontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.noencontrado.ForeColor = System.Drawing.Color.White;
            this.noencontrado.Location = new System.Drawing.Point(42, 129);
            this.noencontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noencontrado.Name = "noencontrado";
            this.noencontrado.Size = new System.Drawing.Size(945, 362);
            this.noencontrado.TabIndex = 3;
            this.noencontrado.Text = "\"DATOS NO ENCONTRADOS\"";
            this.noencontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(216, 66);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(771, 26);
            this.Buscar.TabIndex = 2;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // CMB_Buscar
            // 
            this.CMB_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Buscar.FormattingEnabled = true;
            this.CMB_Buscar.Items.AddRange(new object[] {
            "Id",
            "ClienteId",
            "NumeroDocumento",
            "TipoDocumento",
            "Nombre",
            "Apellido"});
            this.CMB_Buscar.Location = new System.Drawing.Point(42, 65);
            this.CMB_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_Buscar.Name = "CMB_Buscar";
            this.CMB_Buscar.Size = new System.Drawing.Size(166, 28);
            this.CMB_Buscar.TabIndex = 1;
            this.CMB_Buscar.SelectedIndexChanged += new System.EventHandler(this.CMB_Buscar_SelectedIndexChanged);
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
            this.dgvVentas.Location = new System.Drawing.Point(42, 102);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(945, 389);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // text_fecha
            // 
            this.text_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_fecha.Location = new System.Drawing.Point(114, 186);
            this.text_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(265, 26);
            this.text_fecha.TabIndex = 6;
            this.text_fecha.ValueChanged += new System.EventHandler(this.text_fecha_ValueChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(254, 227);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 40);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(114, 227);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(254, 227);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(114, 227);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 40);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // text_NumeroDoc
            // 
            this.text_NumeroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.text_NumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_NumeroDoc.Enabled = false;
            this.text_NumeroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.text_NumeroDoc.ForeColor = System.Drawing.Color.White;
            this.text_NumeroDoc.Location = new System.Drawing.Point(114, 69);
            this.text_NumeroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.text_NumeroDoc.Name = "text_NumeroDoc";
            this.text_NumeroDoc.Size = new System.Drawing.Size(265, 19);
            this.text_NumeroDoc.TabIndex = 1;
            // 
            // text_ClienteId
            // 
            this.text_ClienteId.Enabled = false;
            this.text_ClienteId.Location = new System.Drawing.Point(349, 19);
            this.text_ClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteId.Name = "text_ClienteId";
            this.text_ClienteId.Size = new System.Drawing.Size(10, 26);
            this.text_ClienteId.TabIndex = 7;
            this.text_ClienteId.Visible = false;
            // 
            // text_ClienteNombre
            // 
            this.text_ClienteNombre.Enabled = false;
            this.text_ClienteNombre.Location = new System.Drawing.Point(114, 146);
            this.text_ClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.text_ClienteNombre.Name = "text_ClienteNombre";
            this.text_ClienteNombre.ReadOnly = true;
            this.text_ClienteNombre.Size = new System.Drawing.Size(265, 26);
            this.text_ClienteNombre.TabIndex = 4;
            this.text_ClienteNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_ClienteNombre_MouseClick);
            this.text_ClienteNombre.Enter += new System.EventHandler(this.text_ClienteNombre_Enter);
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textId.Location = new System.Drawing.Point(367, 19);
            this.textId.Margin = new System.Windows.Forms.Padding(4);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(12, 26);
            this.textId.TabIndex = 6;
            this.textId.Visible = false;
            // 
            // lab_DocNum
            // 
            this.lab_DocNum.AutoSize = true;
            this.lab_DocNum.ForeColor = System.Drawing.Color.White;
            this.lab_DocNum.Location = new System.Drawing.Point(41, 69);
            this.lab_DocNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_DocNum.Name = "lab_DocNum";
            this.lab_DocNum.Size = new System.Drawing.Size(74, 20);
            this.lab_DocNum.TabIndex = 0;
            this.lab_DocNum.Text = "Doc. No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(41, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.cbx_clienteNuevoORegistrado);
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.text_fecha);
            this.panel2.Controls.Add(this.text_ClienteId);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.text_ClienteNombre);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.textId);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.lab_DocNum);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.text_NumeroDoc);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pbx_Ventas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 537);
            this.panel2.TabIndex = 0;
            // 
            // cbx_clienteNuevoORegistrado
            // 
            this.cbx_clienteNuevoORegistrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cbx_clienteNuevoORegistrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_clienteNuevoORegistrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_clienteNuevoORegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_clienteNuevoORegistrado.ForeColor = System.Drawing.Color.White;
            this.cbx_clienteNuevoORegistrado.FormattingEnabled = true;
            this.cbx_clienteNuevoORegistrado.Items.AddRange(new object[] {
            "Cliente Nuevo",
            "Cliente Registrado"});
            this.cbx_clienteNuevoORegistrado.Location = new System.Drawing.Point(114, 105);
            this.cbx_clienteNuevoORegistrado.Name = "cbx_clienteNuevoORegistrado";
            this.cbx_clienteNuevoORegistrado.Size = new System.Drawing.Size(265, 28);
            this.cbx_clienteNuevoORegistrado.TabIndex = 2;
            // 
            // pbx_Ventas
            // 
            this.pbx_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Ventas.Image = global::Sistema_de_Venta.Properties.Resources.VentasBig;
            this.pbx_Ventas.Location = new System.Drawing.Point(162, 262);
            this.pbx_Ventas.Name = "pbx_Ventas";
            this.pbx_Ventas.Size = new System.Drawing.Size(100, 187);
            this.pbx_Ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_Ventas.TabIndex = 17;
            this.pbx_Ventas.TabStop = false;
            // 
            // pnl_Lista_Categoria
            // 
            this.pnl_Lista_Categoria.Controls.Add(this.noencontrado);
            this.pnl_Lista_Categoria.Controls.Add(this.dgvVentas);
            this.pnl_Lista_Categoria.Controls.Add(this.Buscar);
            this.pnl_Lista_Categoria.Controls.Add(this.CMB_Buscar);
            this.pnl_Lista_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lista_Categoria.Location = new System.Drawing.Point(423, 0);
            this.pnl_Lista_Categoria.Name = "pnl_Lista_Categoria";
            this.pnl_Lista_Categoria.Size = new System.Drawing.Size(1031, 537);
            this.pnl_Lista_Categoria.TabIndex = 1;
            // 
            // FRM_Ventas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1454, 537);
            this.Controls.Add(this.pnl_Lista_Categoria);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Ventas_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Ventas_Load);
            this.Enter += new System.EventHandler(this.FRM_Ventas_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ventas)).EndInit();
            this.pnl_Lista_Categoria.ResumeLayout(false);
            this.pnl_Lista_Categoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label noencontrado;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.ComboBox CMB_Buscar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox text_NumeroDoc;
        private System.Windows.Forms.TextBox text_ClienteNombre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lab_DocNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker text_fecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox text_ClienteId;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbx_Ventas;
        private System.Windows.Forms.Panel pnl_Lista_Categoria;
        private System.Windows.Forms.ComboBox cbx_clienteNuevoORegistrado;
    }
}