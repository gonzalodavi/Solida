namespace CapaPresentacion
{
    partial class FormRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabRecibos = new System.Windows.Forms.TabControl();
            this.tabConsultaRecibos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabNuevoRecibo = new System.Windows.Forms.TabPage();
            this.dgvDetCtaCte = new System.Windows.Forms.DataGridView();
            this.tbBanco = new System.Windows.Forms.TextBox();
            this.tbDetalleRecibo = new System.Windows.Forms.TextBox();
            this.tbValores = new System.Windows.Forms.TextBox();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.tbNumRecibo = new System.Windows.Forms.TextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dtpFechaRecibo = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalRecibo = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnActualizaLista = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnAceptaRecibo = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tabRecibos.SuspendLayout();
            this.tabConsultaRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.tabNuevoRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tabRecibos);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 549);
            this.panel1.TabIndex = 2;
            // 
            // tabRecibos
            // 
            this.tabRecibos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabRecibos.Controls.Add(this.tabConsultaRecibos);
            this.tabRecibos.Controls.Add(this.tabNuevoRecibo);
            this.tabRecibos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecibos.HotTrack = true;
            this.tabRecibos.Location = new System.Drawing.Point(15, 23);
            this.tabRecibos.Multiline = true;
            this.tabRecibos.Name = "tabRecibos";
            this.tabRecibos.SelectedIndex = 0;
            this.tabRecibos.Size = new System.Drawing.Size(647, 475);
            this.tabRecibos.TabIndex = 80;
            // 
            // tabConsultaRecibos
            // 
            this.tabConsultaRecibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabConsultaRecibos.Controls.Add(this.label1);
            this.tabConsultaRecibos.Controls.Add(this.label9);
            this.tabConsultaRecibos.Controls.Add(this.label7);
            this.tabConsultaRecibos.Controls.Add(this.label6);
            this.tabConsultaRecibos.Controls.Add(this.label3);
            this.tabConsultaRecibos.Controls.Add(this.btnImprimir);
            this.tabConsultaRecibos.Controls.Add(this.btnNuevoCliente);
            this.tabConsultaRecibos.Controls.Add(this.btnEliminar);
            this.tabConsultaRecibos.Controls.Add(this.btnActualizaLista);
            this.tabConsultaRecibos.Controls.Add(this.dgvRecibos);
            this.tabConsultaRecibos.Controls.Add(this.btnBuscar);
            this.tabConsultaRecibos.Controls.Add(this.tbBusca);
            this.tabConsultaRecibos.Controls.Add(this.lblBuscar);
            this.tabConsultaRecibos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaRecibos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabConsultaRecibos.Location = new System.Drawing.Point(4, 25);
            this.tabConsultaRecibos.Name = "tabConsultaRecibos";
            this.tabConsultaRecibos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaRecibos.Size = new System.Drawing.Size(639, 446);
            this.tabConsultaRecibos.TabIndex = 0;
            this.tabConsultaRecibos.Text = "Consulta";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(545, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "IMPORTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(165, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 18);
            this.label9.TabIndex = 129;
            this.label9.Text = "CLIENTE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(358, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 18);
            this.label7.TabIndex = 130;
            this.label7.Text = "CONCEPTO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(14, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 131;
            this.label6.Text = "FECHA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(112, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 132;
            this.label3.Text = "Nº";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(14, 405);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(111, 32);
            this.btnNuevoCliente.TabIndex = 119;
            this.btnNuevoCliente.TabStop = false;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(361, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 32);
            this.btnEliminar.TabIndex = 116;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "ANULAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.AllowUserToResizeColumns = false;
            this.dgvRecibos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvRecibos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvRecibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecibos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecibos.ColumnHeadersVisible = false;
            this.dgvRecibos.EnableHeadersVisualStyles = false;
            this.dgvRecibos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvRecibos.Location = new System.Drawing.Point(14, 87);
            this.dgvRecibos.MaximumSize = new System.Drawing.Size(650, 400);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecibos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(612, 295);
            this.dgvRecibos.TabIndex = 86;
            this.dgvRecibos.TabStop = false;
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBusca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbBusca.Location = new System.Drawing.Point(154, 34);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(206, 15);
            this.tbBusca.TabIndex = 0;
            this.tbBusca.TabStop = false;
            this.tbBusca.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(77, 34);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 16);
            this.lblBuscar.TabIndex = 84;
            this.lblBuscar.Text = "BUSCAR:";
            this.lblBuscar.Visible = false;
            // 
            // tabNuevoRecibo
            // 
            this.tabNuevoRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabNuevoRecibo.Controls.Add(this.dgvDetCtaCte);
            this.tabNuevoRecibo.Controls.Add(this.tbBanco);
            this.tabNuevoRecibo.Controls.Add(this.tbDetalleRecibo);
            this.tabNuevoRecibo.Controls.Add(this.tbValores);
            this.tabNuevoRecibo.Controls.Add(this.tbEfectivo);
            this.tabNuevoRecibo.Controls.Add(this.tbNumRecibo);
            this.tabNuevoRecibo.Controls.Add(this.cbCliente);
            this.tabNuevoRecibo.Controls.Add(this.dtpFechaRecibo);
            this.tabNuevoRecibo.Controls.Add(this.lbl2);
            this.tabNuevoRecibo.Controls.Add(this.lbl4);
            this.tabNuevoRecibo.Controls.Add(this.lbl1);
            this.tabNuevoRecibo.Controls.Add(this.lblTotalRecibo);
            this.tabNuevoRecibo.Controls.Add(this.lbl8);
            this.tabNuevoRecibo.Controls.Add(this.lbl7);
            this.tabNuevoRecibo.Controls.Add(this.lbl6);
            this.tabNuevoRecibo.Controls.Add(this.lbl5);
            this.tabNuevoRecibo.Controls.Add(this.lbl3);
            this.tabNuevoRecibo.Controls.Add(this.btnAceptaRecibo);
            this.tabNuevoRecibo.Location = new System.Drawing.Point(4, 25);
            this.tabNuevoRecibo.Name = "tabNuevoRecibo";
            this.tabNuevoRecibo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevoRecibo.Size = new System.Drawing.Size(639, 446);
            this.tabNuevoRecibo.TabIndex = 4;
            this.tabNuevoRecibo.Text = "NUEVO";
            // 
            // dgvDetCtaCte
            // 
            this.dgvDetCtaCte.AllowUserToAddRows = false;
            this.dgvDetCtaCte.AllowUserToDeleteRows = false;
            this.dgvDetCtaCte.AllowUserToResizeColumns = false;
            this.dgvDetCtaCte.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            this.dgvDetCtaCte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetCtaCte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetCtaCte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetCtaCte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetCtaCte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetCtaCte.ColumnHeadersVisible = false;
            this.dgvDetCtaCte.EnableHeadersVisualStyles = false;
            this.dgvDetCtaCte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCte.Location = new System.Drawing.Point(19, 237);
            this.dgvDetCtaCte.MaximumSize = new System.Drawing.Size(650, 650);
            this.dgvDetCtaCte.Name = "dgvDetCtaCte";
            this.dgvDetCtaCte.ReadOnly = true;
            this.dgvDetCtaCte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetCtaCte.RowHeadersVisible = false;
            this.dgvDetCtaCte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetCtaCte.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetCtaCte.Size = new System.Drawing.Size(600, 192);
            this.dgvDetCtaCte.TabIndex = 132;
            this.dgvDetCtaCte.TabStop = false;
            // 
            // tbBanco
            // 
            this.tbBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBanco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBanco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbBanco.Location = new System.Drawing.Point(405, 101);
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Size = new System.Drawing.Size(95, 15);
            this.tbBanco.TabIndex = 131;
            this.tbBanco.TabStop = false;
            this.tbBanco.Text = "0,00";
            this.tbBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBanco_KeyPress);
            this.tbBanco.Leave += new System.EventHandler(this.tbBanco_Leave);
            // 
            // tbDetalleRecibo
            // 
            this.tbDetalleRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetalleRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetalleRecibo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalleRecibo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDetalleRecibo.Location = new System.Drawing.Point(36, 153);
            this.tbDetalleRecibo.Multiline = true;
            this.tbDetalleRecibo.Name = "tbDetalleRecibo";
            this.tbDetalleRecibo.Size = new System.Drawing.Size(249, 60);
            this.tbDetalleRecibo.TabIndex = 131;
            this.tbDetalleRecibo.TabStop = false;
            // 
            // tbValores
            // 
            this.tbValores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbValores.Location = new System.Drawing.Point(405, 73);
            this.tbValores.Name = "tbValores";
            this.tbValores.Size = new System.Drawing.Size(95, 15);
            this.tbValores.TabIndex = 131;
            this.tbValores.TabStop = false;
            this.tbValores.Text = "0,00";
            this.tbValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValores_KeyPress);
            this.tbValores.Leave += new System.EventHandler(this.tbValores_Leave);
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEfectivo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfectivo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEfectivo.Location = new System.Drawing.Point(405, 46);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(95, 15);
            this.tbEfectivo.TabIndex = 131;
            this.tbEfectivo.TabStop = false;
            this.tbEfectivo.Text = "0,00";
            this.tbEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEfectivo_KeyPress);
            this.tbEfectivo.Leave += new System.EventHandler(this.tbEfectivo_Leave);
            // 
            // tbNumRecibo
            // 
            this.tbNumRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumRecibo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumRecibo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNumRecibo.Location = new System.Drawing.Point(36, 46);
            this.tbNumRecibo.Name = "tbNumRecibo";
            this.tbNumRecibo.Size = new System.Drawing.Size(94, 20);
            this.tbNumRecibo.TabIndex = 131;
            this.tbNumRecibo.TabStop = false;
            this.tbNumRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 14;
            this.cbCliente.Location = new System.Drawing.Point(36, 97);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(249, 22);
            this.cbCliente.TabIndex = 130;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // dtpFechaRecibo
            // 
            this.dtpFechaRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaRecibo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecibo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecibo.Location = new System.Drawing.Point(178, 45);
            this.dtpFechaRecibo.Name = "dtpFechaRecibo";
            this.dtpFechaRecibo.Size = new System.Drawing.Size(107, 22);
            this.dtpFechaRecibo.TabIndex = 125;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoEllipsis = true;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl2.Location = new System.Drawing.Point(45, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 16);
            this.lbl2.TabIndex = 123;
            this.lbl2.Text = "Número:";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoEllipsis = true;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl4.Location = new System.Drawing.Point(45, 134);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(64, 16);
            this.lbl4.TabIndex = 124;
            this.lbl4.Text = "Detalle:";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoEllipsis = true;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl1.Location = new System.Drawing.Point(45, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 16);
            this.lbl1.TabIndex = 124;
            this.lbl1.Text = "Cliente:";
            // 
            // lblTotalRecibo
            // 
            this.lblTotalRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRecibo.AutoEllipsis = true;
            this.lblTotalRecibo.AutoSize = true;
            this.lblTotalRecibo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalRecibo.Location = new System.Drawing.Point(401, 172);
            this.lblTotalRecibo.Name = "lblTotalRecibo";
            this.lblTotalRecibo.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRecibo.TabIndex = 121;
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl8.AutoEllipsis = true;
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl8.Location = new System.Drawing.Point(333, 172);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(66, 16);
            this.lbl8.TabIndex = 121;
            this.lbl8.Text = "Total:  $";
            // 
            // lbl7
            // 
            this.lbl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl7.AutoEllipsis = true;
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl7.Location = new System.Drawing.Point(341, 100);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(58, 16);
            this.lbl7.TabIndex = 121;
            this.lbl7.Text = "Banco:";
            // 
            // lbl6
            // 
            this.lbl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl6.AutoEllipsis = true;
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl6.Location = new System.Drawing.Point(331, 72);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(68, 16);
            this.lbl6.TabIndex = 121;
            this.lbl6.Text = "Valores:";
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoEllipsis = true;
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl5.Location = new System.Drawing.Point(327, 45);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(72, 16);
            this.lbl5.TabIndex = 121;
            this.lbl5.Text = "Efectivo:";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoEllipsis = true;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl3.Location = new System.Drawing.Point(200, 27);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 16);
            this.lbl3.TabIndex = 122;
            this.lbl3.Text = "Fecha:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(255, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Recibos de Ingreso";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(508, 405);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 32);
            this.btnImprimir.TabIndex = 128;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnActualizaLista
            // 
            this.btnActualizaLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizaLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnActualizaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizaLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizaLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizaLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaLista.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaLista.ForeColor = System.Drawing.Color.White;
            this.btnActualizaLista.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnActualizaLista.IconColor = System.Drawing.Color.White;
            this.btnActualizaLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizaLista.IconSize = 18;
            this.btnActualizaLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaLista.Location = new System.Drawing.Point(444, 27);
            this.btnActualizaLista.Name = "btnActualizaLista";
            this.btnActualizaLista.Size = new System.Drawing.Size(28, 23);
            this.btnActualizaLista.TabIndex = 88;
            this.btnActualizaLista.TabStop = false;
            this.btnActualizaLista.Text = " ";
            this.btnActualizaLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizaLista.UseVisualStyleBackColor = false;
            this.btnActualizaLista.Visible = false;
            this.btnActualizaLista.Click += new System.EventHandler(this.btnActualizaLista_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(399, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 23);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " ";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            // 
            // btnAceptaRecibo
            // 
            this.btnAceptaRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptaRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAceptaRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptaRecibo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptaRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptaRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptaRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptaRecibo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptaRecibo.ForeColor = System.Drawing.Color.White;
            this.btnAceptaRecibo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAceptaRecibo.IconColor = System.Drawing.Color.White;
            this.btnAceptaRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptaRecibo.IconSize = 25;
            this.btnAceptaRecibo.Location = new System.Drawing.Point(508, 164);
            this.btnAceptaRecibo.Name = "btnAceptaRecibo";
            this.btnAceptaRecibo.Size = new System.Drawing.Size(111, 32);
            this.btnAceptaRecibo.TabIndex = 79;
            this.btnAceptaRecibo.TabStop = false;
            this.btnAceptaRecibo.Text = "GRABAR";
            this.btnAceptaRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptaRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptaRecibo.UseVisualStyleBackColor = false;
            this.btnAceptaRecibo.Click += new System.EventHandler(this.btnAceptaRecibo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnRegresar.IconColor = System.Drawing.Color.White;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 25;
            this.btnRegresar.Location = new System.Drawing.Point(527, 504);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(111, 32);
            this.btnRegresar.TabIndex = 79;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecibos";
            this.Text = "FormRecibos";
            this.Load += new System.EventHandler(this.FormRecibos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabRecibos.ResumeLayout(false);
            this.tabConsultaRecibos.ResumeLayout(false);
            this.tabConsultaRecibos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.tabNuevoRecibo.ResumeLayout(false);
            this.tabNuevoRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabRecibos;
        private System.Windows.Forms.TabPage tabConsultaRecibos;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizaLista;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TabPage tabNuevoRecibo;
        private System.Windows.Forms.DataGridView dgvDetCtaCte;
        private System.Windows.Forms.TextBox tbBanco;
        private System.Windows.Forms.TextBox tbValores;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.TextBox tbNumRecibo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaRecibo;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbDetalleRecibo;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblTotalRecibo;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private FontAwesome.Sharp.IconButton btnAceptaRecibo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}