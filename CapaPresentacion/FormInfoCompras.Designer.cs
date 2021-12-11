namespace CapaPresentacion
{
    partial class FormInfoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoCompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabListadoCompras = new System.Windows.Forms.TabPage();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.lblChekAnul = new Guna.UI.WinForms.GunaLabel();
            this.chekPorFecha = new Guna.UI.WinForms.GunaSwitch();
            this.rbImporte = new Guna.UI.WinForms.GunaRadioButton();
            this.rbCantidad = new Guna.UI.WinForms.GunaRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabListadoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tabVentas);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 749);
            this.panel1.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabVentas.Controls.Add(this.tabListadoCompras);
            this.tabVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVentas.HotTrack = true;
            this.tabVentas.Location = new System.Drawing.Point(35, 65);
            this.tabVentas.Multiline = true;
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(956, 607);
            this.tabVentas.TabIndex = 88;
            // 
            // tabListadoCompras
            // 
            this.tabListadoCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabListadoCompras.Controls.Add(this.gunaLabel1);
            this.tabListadoCompras.Controls.Add(this.btnActualizar);
            this.tabListadoCompras.Controls.Add(this.lblChekAnul);
            this.tabListadoCompras.Controls.Add(this.chekPorFecha);
            this.tabListadoCompras.Controls.Add(this.rbImporte);
            this.tabListadoCompras.Controls.Add(this.rbCantidad);
            this.tabListadoCompras.Controls.Add(this.label5);
            this.tabListadoCompras.Controls.Add(this.dtpFecha2);
            this.tabListadoCompras.Controls.Add(this.label1);
            this.tabListadoCompras.Controls.Add(this.dtpFecha1);
            this.tabListadoCompras.Controls.Add(this.label9);
            this.tabListadoCompras.Controls.Add(this.label7);
            this.tabListadoCompras.Controls.Add(this.btnImprimir);
            this.tabListadoCompras.Controls.Add(this.label6);
            this.tabListadoCompras.Controls.Add(this.label3);
            this.tabListadoCompras.Controls.Add(this.btnBuscar);
            this.tabListadoCompras.Controls.Add(this.label2);
            this.tabListadoCompras.Controls.Add(this.label4);
            this.tabListadoCompras.Controls.Add(this.dgvCompras);
            this.tabListadoCompras.Controls.Add(this.label10);
            this.tabListadoCompras.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListadoCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabListadoCompras.Location = new System.Drawing.Point(4, 26);
            this.tabListadoCompras.Name = "tabListadoCompras";
            this.tabListadoCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabListadoCompras.Size = new System.Drawing.Size(948, 577);
            this.tabListadoCompras.TabIndex = 0;
            this.tabListadoCompras.Text = "Consultas";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(66, 528);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(297, 17);
            this.gunaLabel1.TabIndex = 189;
            this.gunaLabel1.Text = "* Doble Click para ver Detalle de Comprobante";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 25;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(774, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 31);
            this.btnActualizar.TabIndex = 188;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblChekAnul
            // 
            this.lblChekAnul.AutoSize = true;
            this.lblChekAnul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChekAnul.ForeColor = System.Drawing.Color.White;
            this.lblChekAnul.Location = new System.Drawing.Point(780, 226);
            this.lblChekAnul.Name = "lblChekAnul";
            this.lblChekAnul.Size = new System.Drawing.Size(79, 17);
            this.lblChekAnul.TabIndex = 122;
            this.lblChekAnul.Text = "POR FECHA";
            // 
            // chekPorFecha
            // 
            this.chekPorFecha.BaseColor = System.Drawing.SystemColors.Control;
            this.chekPorFecha.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekPorFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekPorFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekPorFecha.FillColor = System.Drawing.Color.White;
            this.chekPorFecha.Location = new System.Drawing.Point(859, 225);
            this.chekPorFecha.Name = "chekPorFecha";
            this.chekPorFecha.Size = new System.Drawing.Size(28, 20);
            this.chekPorFecha.TabIndex = 121;
            this.chekPorFecha.CheckedChanged += new System.EventHandler(this.chekPorFecha_CheckedChanged);
            // 
            // rbImporte
            // 
            this.rbImporte.BaseColor = System.Drawing.SystemColors.Control;
            this.rbImporte.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbImporte.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbImporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbImporte.FillColor = System.Drawing.Color.White;
            this.rbImporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbImporte.ForeColor = System.Drawing.SystemColors.Control;
            this.rbImporte.Location = new System.Drawing.Point(773, 418);
            this.rbImporte.Name = "rbImporte";
            this.rbImporte.Size = new System.Drawing.Size(117, 21);
            this.rbImporte.TabIndex = 118;
            this.rbImporte.Text = "Importe Total";
            // 
            // rbCantidad
            // 
            this.rbCantidad.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCantidad.Checked = true;
            this.rbCantidad.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCantidad.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCantidad.FillColor = System.Drawing.Color.White;
            this.rbCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCantidad.Location = new System.Drawing.Point(773, 389);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(87, 21);
            this.rbCantidad.TabIndex = 117;
            this.rbCantidad.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(65, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 21);
            this.label5.TabIndex = 116;
            this.label5.Text = "Listado de Compras Registradas";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha2.BaseColor = System.Drawing.Color.White;
            this.dtpFecha2.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha2.CustomFormat = null;
            this.dtpFecha2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha2.Enabled = false;
            this.dtpFecha2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha2.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(773, 179);
            this.dtpFecha2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2.Radius = 10;
            this.dtpFecha2.Size = new System.Drawing.Size(116, 30);
            this.dtpFecha2.TabIndex = 114;
            this.dtpFecha2.Text = "22/10/2021";
            this.dtpFecha2.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(745, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Productos Mas Comprados:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha1.BaseColor = System.Drawing.Color.White;
            this.dtpFecha1.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha1.CustomFormat = null;
            this.dtpFecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha1.Enabled = false;
            this.dtpFecha1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha1.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(773, 116);
            this.dtpFecha1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1.Radius = 10;
            this.dtpFecha1.Size = new System.Drawing.Size(116, 30);
            this.dtpFecha1.TabIndex = 115;
            this.dtpFecha1.Text = "22/10/2021";
            this.dtpFecha1.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(390, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 18);
            this.label9.TabIndex = 110;
            this.label9.Text = "ESTADO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(546, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 111;
            this.label7.Text = "CUIT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(773, 478);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 79;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(69, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 112;
            this.label6.Text = "Nº COMPROBANTE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(230, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "FECHA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(773, 268);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 98;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarReg_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(792, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(789, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Fecha Inicial";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCompras.ColumnHeadersVisible = false;
            this.dgvCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCompras.EnableHeadersVisualStyles = false;
            this.dgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCompras.Location = new System.Drawing.Point(70, 97);
            this.dgvCompras.MaximumSize = new System.Drawing.Size(900, 700);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(637, 418);
            this.dgvCompras.TabIndex = 92;
            this.dgvCompras.TabStop = false;
            this.dgvCompras.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentDoubleClick);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(69, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(639, 422);
            this.label10.TabIndex = 183;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnRegresar.IconColor = System.Drawing.Color.White;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 25;
            this.btnRegresar.Location = new System.Drawing.Point(812, 28);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 79;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(408, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "INFORME DE COMPRAS";
            // 
            // FormInfoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoCompras";
            this.Load += new System.EventHandler(this.FormInfoCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabListadoCompras.ResumeLayout(false);
            this.tabListadoCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabListadoCompras;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaRadioButton rbImporte;
        private Guna.UI.WinForms.GunaRadioButton rbCantidad;
        private Guna.UI.WinForms.GunaLabel lblChekAnul;
        private Guna.UI.WinForms.GunaSwitch chekPorFecha;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}