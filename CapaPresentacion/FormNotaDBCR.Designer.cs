namespace CapaPresentacion
{
    partial class FormNotaDBCR
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
            this.tabNotasDBCR = new System.Windows.Forms.TabControl();
            this.tabListaNotas = new System.Windows.Forms.TabPage();
            this.lblChekAnul = new Guna.UI.WinForms.GunaLabel();
            this.chekVerAnulados = new Guna.UI.WinForms.GunaSwitch();
            this.dtpFecha1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFecha2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarReg = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.dgvNotasDBCR = new System.Windows.Forms.DataGridView();
            this.tabNuevaNotasDBCR = new System.Windows.Forms.TabPage();
            this.lblTotalNota = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbDetalleNota = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.gpDetinatario = new System.Windows.Forms.GroupBox();
            this.dtpFechaNota = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tbNumNota = new System.Windows.Forms.TextBox();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new Guna.UI.WinForms.GunaPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tabNotasDBCR.SuspendLayout();
            this.tabListaNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDBCR)).BeginInit();
            this.tabNuevaNotasDBCR.SuspendLayout();
            this.gpDetinatario.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNotasDBCR
            // 
            this.tabNotasDBCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabNotasDBCR.Controls.Add(this.tabListaNotas);
            this.tabNotasDBCR.Controls.Add(this.tabNuevaNotasDBCR);
            this.tabNotasDBCR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNotasDBCR.HotTrack = true;
            this.tabNotasDBCR.Location = new System.Drawing.Point(35, 65);
            this.tabNotasDBCR.Multiline = true;
            this.tabNotasDBCR.Name = "tabNotasDBCR";
            this.tabNotasDBCR.SelectedIndex = 0;
            this.tabNotasDBCR.Size = new System.Drawing.Size(956, 607);
            this.tabNotasDBCR.TabIndex = 86;
            // 
            // tabListaNotas
            // 
            this.tabListaNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabListaNotas.Controls.Add(this.lblChekAnul);
            this.tabListaNotas.Controls.Add(this.chekVerAnulados);
            this.tabListaNotas.Controls.Add(this.dtpFecha1);
            this.tabListaNotas.Controls.Add(this.dtpFecha2);
            this.tabListaNotas.Controls.Add(this.label9);
            this.tabListaNotas.Controls.Add(this.label8);
            this.tabListaNotas.Controls.Add(this.label7);
            this.tabListaNotas.Controls.Add(this.label6);
            this.tabListaNotas.Controls.Add(this.label3);
            this.tabListaNotas.Controls.Add(this.btnActualizar);
            this.tabListaNotas.Controls.Add(this.btnBuscarReg);
            this.tabListaNotas.Controls.Add(this.btnNuevo);
            this.tabListaNotas.Controls.Add(this.btnAnular);
            this.tabListaNotas.Controls.Add(this.btnImprimir);
            this.tabListaNotas.Controls.Add(this.lblFecha2);
            this.tabListaNotas.Controls.Add(this.lblFecha1);
            this.tabListaNotas.Controls.Add(this.dgvNotasDBCR);
            this.tabListaNotas.Controls.Add(this.label10);
            this.tabListaNotas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListaNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabListaNotas.Location = new System.Drawing.Point(4, 26);
            this.tabListaNotas.Name = "tabListaNotas";
            this.tabListaNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaNotas.Size = new System.Drawing.Size(948, 577);
            this.tabListaNotas.TabIndex = 0;
            this.tabListaNotas.Text = "Consulta";
            // 
            // lblChekAnul
            // 
            this.lblChekAnul.AutoSize = true;
            this.lblChekAnul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChekAnul.ForeColor = System.Drawing.Color.White;
            this.lblChekAnul.Location = new System.Drawing.Point(777, 316);
            this.lblChekAnul.Name = "lblChekAnul";
            this.lblChekAnul.Size = new System.Drawing.Size(78, 17);
            this.lblChekAnul.TabIndex = 148;
            this.lblChekAnul.Text = "ANULADAS";
            // 
            // chekVerAnulados
            // 
            this.chekVerAnulados.BaseColor = System.Drawing.SystemColors.Control;
            this.chekVerAnulados.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekVerAnulados.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekVerAnulados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekVerAnulados.FillColor = System.Drawing.Color.White;
            this.chekVerAnulados.Location = new System.Drawing.Point(856, 315);
            this.chekVerAnulados.Name = "chekVerAnulados";
            this.chekVerAnulados.Size = new System.Drawing.Size(28, 20);
            this.chekVerAnulados.TabIndex = 147;
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
            this.dtpFecha1.Location = new System.Drawing.Point(61, 44);
            this.dtpFecha1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1.Radius = 10;
            this.dtpFecha1.Size = new System.Drawing.Size(121, 28);
            this.dtpFecha1.TabIndex = 146;
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
            this.dtpFecha2.Location = new System.Drawing.Point(221, 44);
            this.dtpFecha2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2.Radius = 10;
            this.dtpFecha2.Size = new System.Drawing.Size(121, 28);
            this.dtpFecha2.TabIndex = 145;
            this.dtpFecha2.Text = "22/10/2021";
            this.dtpFecha2.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(628, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 103;
            this.label9.Text = "TIPO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(508, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 103;
            this.label8.Text = "IMPORTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(265, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "CLIENTE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(171, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nº";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(55, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "FECHA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnActualizar.Location = new System.Drawing.Point(773, 42);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 31);
            this.btnActualizar.TabIndex = 97;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarReg
            // 
            this.btnBuscarReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarReg.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarReg.IconColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReg.IconSize = 25;
            this.btnBuscarReg.Location = new System.Drawing.Point(391, 42);
            this.btnBuscarReg.Name = "btnBuscarReg";
            this.btnBuscarReg.Size = new System.Drawing.Size(116, 31);
            this.btnBuscarReg.TabIndex = 98;
            this.btnBuscarReg.TabStop = false;
            this.btnBuscarReg.Text = "BUSCAR";
            this.btnBuscarReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReg.UseVisualStyleBackColor = false;
            this.btnBuscarReg.Click += new System.EventHandler(this.btnBuscarReg_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.Location = new System.Drawing.Point(773, 154);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 31);
            this.btnNuevo.TabIndex = 99;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "NUEVO ";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnAnular.IconColor = System.Drawing.Color.White;
            this.btnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnular.IconSize = 25;
            this.btnAnular.Location = new System.Drawing.Point(773, 250);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(116, 31);
            this.btnAnular.TabIndex = 100;
            this.btnAnular.TabStop = false;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir
            // 
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
            this.btnImprimir.Location = new System.Drawing.Point(773, 475);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 101;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha2.AutoEllipsis = true;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(242, 23);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(77, 17);
            this.lblFecha2.TabIndex = 94;
            this.lblFecha2.Text = "Fecha Final";
            // 
            // lblFecha1
            // 
            this.lblFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha1.AutoEllipsis = true;
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha1.Location = new System.Drawing.Point(77, 23);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(84, 17);
            this.lblFecha1.TabIndex = 93;
            this.lblFecha1.Text = "Fecha Inicial";
            // 
            // dgvNotasDBCR
            // 
            this.dgvNotasDBCR.AllowUserToAddRows = false;
            this.dgvNotasDBCR.AllowUserToDeleteRows = false;
            this.dgvNotasDBCR.AllowUserToResizeColumns = false;
            this.dgvNotasDBCR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvNotasDBCR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotasDBCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNotasDBCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotasDBCR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvNotasDBCR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotasDBCR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotasDBCR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasDBCR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotasDBCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotasDBCR.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotasDBCR.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotasDBCR.EnableHeadersVisualStyles = false;
            this.dgvNotasDBCR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvNotasDBCR.Location = new System.Drawing.Point(56, 133);
            this.dgvNotasDBCR.MaximumSize = new System.Drawing.Size(900, 700);
            this.dgvNotasDBCR.Name = "dgvNotasDBCR";
            this.dgvNotasDBCR.ReadOnly = true;
            this.dgvNotasDBCR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasDBCR.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotasDBCR.RowHeadersVisible = false;
            this.dgvNotasDBCR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotasDBCR.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotasDBCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasDBCR.Size = new System.Drawing.Size(646, 391);
            this.dgvNotasDBCR.TabIndex = 92;
            this.dgvNotasDBCR.TabStop = false;
            // 
            // tabNuevaNotasDBCR
            // 
            this.tabNuevaNotasDBCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabNuevaNotasDBCR.Controls.Add(this.lblTotalNota);
            this.tabNuevaNotasDBCR.Controls.Add(this.tbImporte);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl5);
            this.tabNuevaNotasDBCR.Controls.Add(this.tbDetalleNota);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl4);
            this.tabNuevaNotasDBCR.Controls.Add(this.cbCliente);
            this.tabNuevaNotasDBCR.Controls.Add(this.gpDetinatario);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl1);
            this.tabNuevaNotasDBCR.Controls.Add(this.btnGuardar);
            this.tabNuevaNotasDBCR.Location = new System.Drawing.Point(4, 26);
            this.tabNuevaNotasDBCR.Name = "tabNuevaNotasDBCR";
            this.tabNuevaNotasDBCR.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevaNotasDBCR.Size = new System.Drawing.Size(948, 577);
            this.tabNuevaNotasDBCR.TabIndex = 1;
            this.tabNuevaNotasDBCR.Text = "Nuevo";
            // 
            // lblTotalNota
            // 
            this.lblTotalNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalNota.AutoEllipsis = true;
            this.lblTotalNota.AutoSize = true;
            this.lblTotalNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalNota.Location = new System.Drawing.Point(691, 281);
            this.lblTotalNota.Name = "lblTotalNota";
            this.lblTotalNota.Size = new System.Drawing.Size(33, 17);
            this.lblTotalNota.TabIndex = 137;
            this.lblTotalNota.Text = "0,00";
            this.lblTotalNota.Visible = false;
            // 
            // tbImporte
            // 
            this.tbImporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbImporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbImporte.Location = new System.Drawing.Point(651, 241);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(116, 25);
            this.tbImporte.TabIndex = 136;
            this.tbImporte.TabStop = false;
            this.tbImporte.Text = "0,00";
            this.tbImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImporte_KeyPress);
            this.tbImporte.Leave += new System.EventHandler(this.tbImporte_Leave);
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoEllipsis = true;
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl5.Location = new System.Drawing.Point(571, 243);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(72, 17);
            this.lbl5.TabIndex = 135;
            this.lbl5.Text = "Importe: $";
            // 
            // tbDetalleNota
            // 
            this.tbDetalleNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetalleNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetalleNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDetalleNota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDetalleNota.Location = new System.Drawing.Point(162, 330);
            this.tbDetalleNota.Multiline = true;
            this.tbDetalleNota.Name = "tbDetalleNota";
            this.tbDetalleNota.Size = new System.Drawing.Size(293, 90);
            this.tbDetalleNota.TabIndex = 134;
            this.tbDetalleNota.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoEllipsis = true;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl4.Location = new System.Drawing.Point(171, 311);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 17);
            this.lbl4.TabIndex = 133;
            this.lbl4.Text = "Detalle:";
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 17;
            this.cbCliente.Location = new System.Drawing.Point(162, 241);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(293, 25);
            this.cbCliente.TabIndex = 132;
            // 
            // gpDetinatario
            // 
            this.gpDetinatario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpDetinatario.Controls.Add(this.dtpFechaNota);
            this.gpDetinatario.Controls.Add(this.tbNumNota);
            this.gpDetinatario.Controls.Add(this.rbCredito);
            this.gpDetinatario.Controls.Add(this.label1);
            this.gpDetinatario.Controls.Add(this.rbDebito);
            this.gpDetinatario.Controls.Add(this.lbl2);
            this.gpDetinatario.Controls.Add(this.lbl3);
            this.gpDetinatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpDetinatario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpDetinatario.Location = new System.Drawing.Point(104, 46);
            this.gpDetinatario.Name = "gpDetinatario";
            this.gpDetinatario.Size = new System.Drawing.Size(744, 116);
            this.gpDetinatario.TabIndex = 88;
            this.gpDetinatario.TabStop = false;
            // 
            // dtpFechaNota
            // 
            this.dtpFechaNota.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaNota.BaseColor = System.Drawing.Color.White;
            this.dtpFechaNota.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaNota.CustomFormat = null;
            this.dtpFechaNota.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaNota.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFechaNota.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNota.Location = new System.Drawing.Point(547, 43);
            this.dtpFechaNota.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNota.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNota.Name = "dtpFechaNota";
            this.dtpFechaNota.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaNota.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaNota.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaNota.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaNota.Radius = 10;
            this.dtpFechaNota.Size = new System.Drawing.Size(121, 28);
            this.dtpFechaNota.TabIndex = 144;
            this.dtpFechaNota.Text = "22/10/2021";
            this.dtpFechaNota.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // tbNumNota
            // 
            this.tbNumNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumNota.Enabled = false;
            this.tbNumNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNumNota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNumNota.Location = new System.Drawing.Point(377, 43);
            this.tbNumNota.Name = "tbNumNota";
            this.tbNumNota.Size = new System.Drawing.Size(94, 25);
            this.tbNumNota.TabIndex = 135;
            this.tbNumNota.TabStop = false;
            this.tbNumNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumNota_KeyPress);
            // 
            // rbCredito
            // 
            this.rbCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbCredito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCredito.Location = new System.Drawing.Point(156, 72);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(81, 21);
            this.rbCredito.TabIndex = 51;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "CRÉDITO";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo de Nota:";
            // 
            // rbDebito
            // 
            this.rbDebito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbDebito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDebito.Location = new System.Drawing.Point(156, 45);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(73, 21);
            this.rbDebito.TabIndex = 51;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "DÉBITO";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoEllipsis = true;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl2.Location = new System.Drawing.Point(312, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 17);
            this.lbl2.TabIndex = 133;
            this.lbl2.Text = "Número:";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoEllipsis = true;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl3.Location = new System.Drawing.Point(494, 47);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 17);
            this.lbl3.TabIndex = 132;
            this.lbl3.Text = "Fecha:";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoEllipsis = true;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl1.Location = new System.Drawing.Point(171, 222);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 17);
            this.lbl1.TabIndex = 131;
            this.lbl1.Text = "Cliente:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(651, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 31);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(319, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 25);
            this.lblTitulo.TabIndex = 87;
            this.lblTitulo.Text = "DÉBITOS Y CRÉDITOS A CUENTA CORRIENTE";
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
            this.btnRegresar.TabIndex = 88;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Controls.Add(this.tabNotasDBCR);
            this.panelContenedor.Controls.Add(this.btnRegresar);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1026, 749);
            this.panelContenedor.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(55, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(648, 395);
            this.label10.TabIndex = 185;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormNotaDBCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotaDBCR";
            this.Text = "FormNotaDBCR";
            this.Load += new System.EventHandler(this.FormNotaDBCR_Load);
            this.tabNotasDBCR.ResumeLayout(false);
            this.tabListaNotas.ResumeLayout(false);
            this.tabListaNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDBCR)).EndInit();
            this.tabNuevaNotasDBCR.ResumeLayout(false);
            this.tabNuevaNotasDBCR.PerformLayout();
            this.gpDetinatario.ResumeLayout(false);
            this.gpDetinatario.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNotasDBCR;
        private System.Windows.Forms.TabPage tabListaNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnBuscarReg;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnAnular;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.DataGridView dgvNotasDBCR;
        private System.Windows.Forms.TabPage tabNuevaNotasDBCR;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.GroupBox gpDetinatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbNumNota;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbl1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TextBox tbDetalleNota;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label lbl5;
        private Guna.UI.WinForms.GunaPanel panelContenedor;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaNota;
        private Guna.UI.WinForms.GunaLabel lblChekAnul;
        private Guna.UI.WinForms.GunaSwitch chekVerAnulados;
        private System.Windows.Forms.Label lblTotalNota;
        private System.Windows.Forms.Label label10;
    }
}