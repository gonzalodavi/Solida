namespace CapaPresentacion
{
    partial class FormOPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOPagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tabOrdenPagos = new System.Windows.Forms.TabControl();
            this.tabConsultaOPagos = new System.Windows.Forms.TabPage();
            this.lblChekAnul = new Guna.UI.WinForms.GunaLabel();
            this.chekVerAnulados = new Guna.UI.WinForms.GunaSwitch();
            this.dtpFecha1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFecha2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnNuevaOPago = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizaLista = new FontAwesome.Sharp.IconButton();
            this.dgvOPago = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.tabNuevaOPago = new System.Windows.Forms.TabPage();
            this.dtpFechaRecibo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTitSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDetCtaCte = new System.Windows.Forms.DataGridView();
            this.tbBanco = new System.Windows.Forms.TextBox();
            this.tbDetalleOPago = new System.Windows.Forms.TextBox();
            this.tbValores = new System.Windows.Forms.TextBox();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.tbNumOPago = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalOPago = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnAceptaOPago = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabOrdenPagos.SuspendLayout();
            this.tabConsultaOPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPago)).BeginInit();
            this.tabNuevaOPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tabOrdenPagos);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 749);
            this.panel1.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(427, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 18);
            this.label12.TabIndex = 81;
            this.label12.Text = "ORDEN DE PAGO";
            // 
            // tabOrdenPagos
            // 
            this.tabOrdenPagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabOrdenPagos.Controls.Add(this.tabConsultaOPagos);
            this.tabOrdenPagos.Controls.Add(this.tabNuevaOPago);
            this.tabOrdenPagos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOrdenPagos.HotTrack = true;
            this.tabOrdenPagos.Location = new System.Drawing.Point(35, 65);
            this.tabOrdenPagos.Multiline = true;
            this.tabOrdenPagos.Name = "tabOrdenPagos";
            this.tabOrdenPagos.SelectedIndex = 0;
            this.tabOrdenPagos.Size = new System.Drawing.Size(956, 607);
            this.tabOrdenPagos.TabIndex = 80;
            // 
            // tabConsultaOPagos
            // 
            this.tabConsultaOPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabConsultaOPagos.Controls.Add(this.lblChekAnul);
            this.tabConsultaOPagos.Controls.Add(this.chekVerAnulados);
            this.tabConsultaOPagos.Controls.Add(this.dtpFecha1);
            this.tabConsultaOPagos.Controls.Add(this.dtpFecha2);
            this.tabConsultaOPagos.Controls.Add(this.lblFecha2);
            this.tabConsultaOPagos.Controls.Add(this.lblFecha1);
            this.tabConsultaOPagos.Controls.Add(this.label1);
            this.tabConsultaOPagos.Controls.Add(this.label9);
            this.tabConsultaOPagos.Controls.Add(this.label7);
            this.tabConsultaOPagos.Controls.Add(this.label6);
            this.tabConsultaOPagos.Controls.Add(this.label3);
            this.tabConsultaOPagos.Controls.Add(this.btnImprimir);
            this.tabConsultaOPagos.Controls.Add(this.btnNuevaOPago);
            this.tabConsultaOPagos.Controls.Add(this.btnEliminar);
            this.tabConsultaOPagos.Controls.Add(this.btnActualizaLista);
            this.tabConsultaOPagos.Controls.Add(this.dgvOPago);
            this.tabConsultaOPagos.Controls.Add(this.btnBuscar);
            this.tabConsultaOPagos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaOPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabConsultaOPagos.Location = new System.Drawing.Point(4, 25);
            this.tabConsultaOPagos.Name = "tabConsultaOPagos";
            this.tabConsultaOPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaOPagos.Size = new System.Drawing.Size(948, 578);
            this.tabConsultaOPagos.TabIndex = 0;
            this.tabConsultaOPagos.Text = "Consulta";
            // 
            // lblChekAnul
            // 
            this.lblChekAnul.AutoSize = true;
            this.lblChekAnul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChekAnul.ForeColor = System.Drawing.Color.White;
            this.lblChekAnul.Location = new System.Drawing.Point(781, 261);
            this.lblChekAnul.Name = "lblChekAnul";
            this.lblChekAnul.Size = new System.Drawing.Size(72, 15);
            this.lblChekAnul.TabIndex = 152;
            this.lblChekAnul.Text = "ANULADOS";
            // 
            // chekVerAnulados
            // 
            this.chekVerAnulados.BaseColor = System.Drawing.SystemColors.Control;
            this.chekVerAnulados.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekVerAnulados.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekVerAnulados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekVerAnulados.FillColor = System.Drawing.Color.White;
            this.chekVerAnulados.Location = new System.Drawing.Point(858, 258);
            this.chekVerAnulados.Name = "chekVerAnulados";
            this.chekVerAnulados.Size = new System.Drawing.Size(28, 20);
            this.chekVerAnulados.TabIndex = 151;
            this.chekVerAnulados.CheckedChanged += new System.EventHandler(this.chekVerAnulados_CheckedChanged);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha1.BaseColor = System.Drawing.Color.White;
            this.dtpFecha1.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha1.CustomFormat = null;
            this.dtpFecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha1.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(62, 42);
            this.dtpFecha1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1.Radius = 10;
            this.dtpFecha1.Size = new System.Drawing.Size(121, 28);
            this.dtpFecha1.TabIndex = 150;
            this.dtpFecha1.Text = "22/10/2021";
            this.dtpFecha1.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha2.BaseColor = System.Drawing.Color.White;
            this.dtpFecha2.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha2.CustomFormat = null;
            this.dtpFecha2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha2.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(222, 42);
            this.dtpFecha2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2.Radius = 10;
            this.dtpFecha2.Size = new System.Drawing.Size(121, 28);
            this.dtpFecha2.TabIndex = 149;
            this.dtpFecha2.Text = "22/10/2021";
            this.dtpFecha2.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha2.AutoEllipsis = true;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(234, 23);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(91, 16);
            this.lblFecha2.TabIndex = 148;
            this.lblFecha2.Text = "Fecha Final";
            // 
            // lblFecha1
            // 
            this.lblFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha1.AutoEllipsis = true;
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha1.Location = new System.Drawing.Point(72, 23);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(100, 16);
            this.lblFecha1.TabIndex = 147;
            this.lblFecha1.Text = "Fecha Inicial";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(576, 106);
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
            this.label9.Location = new System.Drawing.Point(263, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 18);
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
            this.label7.Location = new System.Drawing.Point(418, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
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
            this.label6.Location = new System.Drawing.Point(45, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
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
            this.label3.Location = new System.Drawing.Point(169, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 132;
            this.label3.Text = "Nº";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnImprimir.Location = new System.Drawing.Point(773, 478);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 128;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNuevaOPago
            // 
            this.btnNuevaOPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevaOPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevaOPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaOPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevaOPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevaOPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevaOPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaOPago.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOPago.ForeColor = System.Drawing.Color.White;
            this.btnNuevaOPago.Location = new System.Drawing.Point(773, 127);
            this.btnNuevaOPago.Name = "btnNuevaOPago";
            this.btnNuevaOPago.Size = new System.Drawing.Size(116, 31);
            this.btnNuevaOPago.TabIndex = 119;
            this.btnNuevaOPago.TabStop = false;
            this.btnNuevaOPago.Text = "NUEVA";
            this.btnNuevaOPago.UseVisualStyleBackColor = false;
            this.btnNuevaOPago.Click += new System.EventHandler(this.btnNuevaOPago_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(773, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 31);
            this.btnEliminar.TabIndex = 116;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "ANULAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnActualizaLista.Location = new System.Drawing.Point(773, 39);
            this.btnActualizaLista.Name = "btnActualizaLista";
            this.btnActualizaLista.Size = new System.Drawing.Size(116, 31);
            this.btnActualizaLista.TabIndex = 88;
            this.btnActualizaLista.TabStop = false;
            this.btnActualizaLista.Text = " ACTUALIZAR";
            this.btnActualizaLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizaLista.UseVisualStyleBackColor = false;
            this.btnActualizaLista.Click += new System.EventHandler(this.btnActualizaLista_Click);
            // 
            // dgvOPago
            // 
            this.dgvOPago.AllowUserToAddRows = false;
            this.dgvOPago.AllowUserToDeleteRows = false;
            this.dgvOPago.AllowUserToResizeColumns = false;
            this.dgvOPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvOPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvOPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOPago.ColumnHeadersVisible = false;
            this.dgvOPago.EnableHeadersVisualStyles = false;
            this.dgvOPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvOPago.Location = new System.Drawing.Point(45, 127);
            this.dgvOPago.MaximumSize = new System.Drawing.Size(650, 400);
            this.dgvOPago.Name = "dgvOPago";
            this.dgvOPago.ReadOnly = true;
            this.dgvOPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOPago.RowHeadersVisible = false;
            this.dgvOPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOPago.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOPago.Size = new System.Drawing.Size(612, 400);
            this.dgvOPago.TabIndex = 86;
            this.dgvOPago.TabStop = false;
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
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(394, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabNuevaOPago
            // 
            this.tabNuevaOPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabNuevaOPago.Controls.Add(this.dtpFechaRecibo);
            this.tabNuevaOPago.Controls.Add(this.lblSaldo);
            this.tabNuevaOPago.Controls.Add(this.lblTitSaldo);
            this.tabNuevaOPago.Controls.Add(this.label2);
            this.tabNuevaOPago.Controls.Add(this.label11);
            this.tabNuevaOPago.Controls.Add(this.label4);
            this.tabNuevaOPago.Controls.Add(this.label5);
            this.tabNuevaOPago.Controls.Add(this.label8);
            this.tabNuevaOPago.Controls.Add(this.label10);
            this.tabNuevaOPago.Controls.Add(this.dgvDetCtaCte);
            this.tabNuevaOPago.Controls.Add(this.tbBanco);
            this.tabNuevaOPago.Controls.Add(this.tbDetalleOPago);
            this.tabNuevaOPago.Controls.Add(this.tbValores);
            this.tabNuevaOPago.Controls.Add(this.tbEfectivo);
            this.tabNuevaOPago.Controls.Add(this.tbNumOPago);
            this.tabNuevaOPago.Controls.Add(this.cbProveedor);
            this.tabNuevaOPago.Controls.Add(this.lbl2);
            this.tabNuevaOPago.Controls.Add(this.lbl4);
            this.tabNuevaOPago.Controls.Add(this.lbl1);
            this.tabNuevaOPago.Controls.Add(this.lblTotalOPago);
            this.tabNuevaOPago.Controls.Add(this.lbl8);
            this.tabNuevaOPago.Controls.Add(this.lbl7);
            this.tabNuevaOPago.Controls.Add(this.lbl6);
            this.tabNuevaOPago.Controls.Add(this.lbl5);
            this.tabNuevaOPago.Controls.Add(this.lbl3);
            this.tabNuevaOPago.Controls.Add(this.btnAceptaOPago);
            this.tabNuevaOPago.Location = new System.Drawing.Point(4, 25);
            this.tabNuevaOPago.Name = "tabNuevaOPago";
            this.tabNuevaOPago.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevaOPago.Size = new System.Drawing.Size(948, 578);
            this.tabNuevaOPago.TabIndex = 4;
            this.tabNuevaOPago.Text = "Nueva";
            // 
            // dtpFechaRecibo
            // 
            this.dtpFechaRecibo.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaRecibo.BaseColor = System.Drawing.Color.White;
            this.dtpFechaRecibo.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaRecibo.CustomFormat = null;
            this.dtpFechaRecibo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRecibo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRecibo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFechaRecibo.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaRecibo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecibo.Location = new System.Drawing.Point(212, 69);
            this.dtpFechaRecibo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRecibo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRecibo.Name = "dtpFechaRecibo";
            this.dtpFechaRecibo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaRecibo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRecibo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRecibo.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaRecibo.Radius = 10;
            this.dtpFechaRecibo.Size = new System.Drawing.Size(121, 28);
            this.dtpFechaRecibo.TabIndex = 143;
            this.dtpFechaRecibo.Text = "22/10/2021";
            this.dtpFechaRecibo.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaldo.Location = new System.Drawing.Point(788, 519);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(17, 16);
            this.lblSaldo.TabIndex = 141;
            this.lblSaldo.Text = "0";
            // 
            // lblTitSaldo
            // 
            this.lblTitSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitSaldo.AutoSize = true;
            this.lblTitSaldo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitSaldo.Location = new System.Drawing.Point(715, 519);
            this.lblTitSaldo.Name = "lblTitSaldo";
            this.lblTitSaldo.Size = new System.Drawing.Size(74, 16);
            this.lblTitSaldo.TabIndex = 142;
            this.lblTitSaldo.Text = "SALDO: $";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(746, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 140;
            this.label2.Text = "SUBTOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoEllipsis = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(611, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 18);
            this.label11.TabIndex = 139;
            this.label11.Text = "HABER";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(476, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 134;
            this.label4.Text = "DEBE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(328, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 135;
            this.label5.Text = "CONCEPTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(66, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 136;
            this.label8.Text = "FECHA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(195, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 137;
            this.label10.Text = "Nº";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.dgvDetCtaCte.Location = new System.Drawing.Point(66, 272);
            this.dgvDetCtaCte.MaximumSize = new System.Drawing.Size(900, 700);
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
            this.dgvDetCtaCte.Size = new System.Drawing.Size(823, 216);
            this.dgvDetCtaCte.TabIndex = 132;
            this.dgvDetCtaCte.TabStop = false;
            // 
            // tbBanco
            // 
            this.tbBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBanco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBanco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbBanco.Location = new System.Drawing.Point(468, 151);
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Size = new System.Drawing.Size(95, 22);
            this.tbBanco.TabIndex = 131;
            this.tbBanco.TabStop = false;
            this.tbBanco.Text = "0,00";
            this.tbBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBanco_KeyPress);
            this.tbBanco.Leave += new System.EventHandler(this.tbBanco_Leave);
            // 
            // tbDetalleOPago
            // 
            this.tbDetalleOPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetalleOPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetalleOPago.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalleOPago.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDetalleOPago.Location = new System.Drawing.Point(622, 71);
            this.tbDetalleOPago.Multiline = true;
            this.tbDetalleOPago.Name = "tbDetalleOPago";
            this.tbDetalleOPago.Size = new System.Drawing.Size(267, 102);
            this.tbDetalleOPago.TabIndex = 131;
            this.tbDetalleOPago.TabStop = false;
            // 
            // tbValores
            // 
            this.tbValores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbValores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbValores.Location = new System.Drawing.Point(469, 110);
            this.tbValores.Name = "tbValores";
            this.tbValores.Size = new System.Drawing.Size(95, 22);
            this.tbValores.TabIndex = 131;
            this.tbValores.TabStop = false;
            this.tbValores.Text = "0,00";
            this.tbValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValores_KeyPress);
            this.tbValores.Leave += new System.EventHandler(this.tbValores_Leave);
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEfectivo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfectivo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEfectivo.Location = new System.Drawing.Point(469, 70);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(95, 22);
            this.tbEfectivo.TabIndex = 131;
            this.tbEfectivo.TabStop = false;
            this.tbEfectivo.Text = "0,00";
            this.tbEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEfectivo_KeyPress);
            this.tbEfectivo.Leave += new System.EventHandler(this.tbEfectivo_Leave);
            // 
            // tbNumOPago
            // 
            this.tbNumOPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumOPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumOPago.Enabled = false;
            this.tbNumOPago.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumOPago.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNumOPago.Location = new System.Drawing.Point(66, 71);
            this.tbNumOPago.Name = "tbNumOPago";
            this.tbNumOPago.Size = new System.Drawing.Size(94, 20);
            this.tbNumOPago.TabIndex = 131;
            this.tbNumOPago.TabStop = false;
            this.tbNumOPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumOPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumOPago_KeyPress);
            // 
            // cbProveedor
            // 
            this.cbProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.ItemHeight = 14;
            this.cbProveedor.Location = new System.Drawing.Point(66, 151);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(267, 22);
            this.cbProveedor.TabIndex = 130;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoEllipsis = true;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl2.Location = new System.Drawing.Point(75, 52);
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
            this.lbl4.Location = new System.Drawing.Point(631, 52);
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
            this.lbl1.Location = new System.Drawing.Point(75, 132);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 16);
            this.lbl1.TabIndex = 124;
            this.lbl1.Text = "Proveedor:";
            // 
            // lblTotalOPago
            // 
            this.lblTotalOPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalOPago.AutoEllipsis = true;
            this.lblTotalOPago.AutoSize = true;
            this.lblTotalOPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalOPago.Location = new System.Drawing.Point(466, 200);
            this.lblTotalOPago.Name = "lblTotalOPago";
            this.lblTotalOPago.Size = new System.Drawing.Size(0, 16);
            this.lblTotalOPago.TabIndex = 121;
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl8.AutoEllipsis = true;
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl8.Location = new System.Drawing.Point(397, 200);
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
            this.lbl7.Location = new System.Drawing.Point(391, 152);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(71, 16);
            this.lbl7.TabIndex = 121;
            this.lbl7.Text = "Banco: $";
            // 
            // lbl6
            // 
            this.lbl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl6.AutoEllipsis = true;
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl6.Location = new System.Drawing.Point(384, 111);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(81, 16);
            this.lbl6.TabIndex = 121;
            this.lbl6.Text = "Valores: $";
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoEllipsis = true;
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl5.Location = new System.Drawing.Point(380, 73);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(85, 16);
            this.lbl5.TabIndex = 121;
            this.lbl5.Text = "Efectivo: $";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoEllipsis = true;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl3.Location = new System.Drawing.Point(245, 52);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 16);
            this.lbl3.TabIndex = 122;
            this.lbl3.Text = "Fecha:";
            // 
            // btnAceptaOPago
            // 
            this.btnAceptaOPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptaOPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAceptaOPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptaOPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptaOPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptaOPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptaOPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptaOPago.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptaOPago.ForeColor = System.Drawing.Color.White;
            this.btnAceptaOPago.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAceptaOPago.IconColor = System.Drawing.Color.White;
            this.btnAceptaOPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptaOPago.IconSize = 25;
            this.btnAceptaOPago.Location = new System.Drawing.Point(773, 193);
            this.btnAceptaOPago.Name = "btnAceptaOPago";
            this.btnAceptaOPago.Size = new System.Drawing.Size(116, 31);
            this.btnAceptaOPago.TabIndex = 79;
            this.btnAceptaOPago.TabStop = false;
            this.btnAceptaOPago.Text = "GRABAR";
            this.btnAceptaOPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptaOPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptaOPago.UseVisualStyleBackColor = false;
            this.btnAceptaOPago.Click += new System.EventHandler(this.btnAceptaOPago_Click);
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
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(430, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Recibos de Ingreso";
            // 
            // FormOPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOPagos";
            this.Text = "FormOPagos";
            this.Load += new System.EventHandler(this.FormOPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabOrdenPagos.ResumeLayout(false);
            this.tabConsultaOPagos.ResumeLayout(false);
            this.tabConsultaOPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPago)).EndInit();
            this.tabNuevaOPago.ResumeLayout(false);
            this.tabNuevaOPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabOrdenPagos;
        private System.Windows.Forms.TabPage tabConsultaOPagos;
        private Guna.UI.WinForms.GunaLabel lblChekAnul;
        private Guna.UI.WinForms.GunaSwitch chekVerAnulados;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Button btnNuevaOPago;
        private System.Windows.Forms.Button btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizaLista;
        private System.Windows.Forms.DataGridView dgvOPago;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TabPage tabNuevaOPago;
        public Guna.UI.WinForms.GunaDateTimePicker dtpFechaRecibo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTitSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDetCtaCte;
        private System.Windows.Forms.TextBox tbBanco;
        public System.Windows.Forms.TextBox tbDetalleOPago;
        private System.Windows.Forms.TextBox tbValores;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.TextBox tbNumOPago;
        public System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTotalOPago;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private FontAwesome.Sharp.IconButton btnAceptaOPago;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label lblTitulo;
    }
}