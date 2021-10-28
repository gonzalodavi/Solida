namespace CapaPresentacion
{
    partial class FormDetalleCCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleCCC));
            this.panelFormCompras = new System.Windows.Forms.Panel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTitSaldo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.dgvDetCtaCte = new System.Windows.Forms.DataGridView();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFecha2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblChekAnul = new Guna.UI.WinForms.GunaLabel();
            this.chekFecha = new Guna.UI.WinForms.GunaSwitch();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.chekFechaProv = new Guna.UI.WinForms.GunaSwitch();
            this.dtpFecha1Prov = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFecha2Prov = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lblSaldoProv = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarProv = new FontAwesome.Sharp.IconButton();
            this.btnImprimirProv = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvDetCtaCteProveedores = new System.Windows.Forms.DataGridView();
            this.panelFormCompras.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCteProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormCompras
            // 
            this.panelFormCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormCompras.Controls.Add(this.btnRegresar);
            this.panelFormCompras.Controls.Add(this.lblTitulo);
            this.panelFormCompras.Controls.Add(this.tabVentas);
            this.panelFormCompras.Location = new System.Drawing.Point(12, 12);
            this.panelFormCompras.Name = "panelFormCompras";
            this.panelFormCompras.Size = new System.Drawing.Size(1026, 749);
            this.panelFormCompras.TabIndex = 2;
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
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(396, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 18);
            this.lblTitulo.TabIndex = 87;
            this.lblTitulo.Text = "Detalle Cuentas Corrientes";
            // 
            // tabVentas
            // 
            this.tabVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabVentas.Controls.Add(this.tabClientes);
            this.tabVentas.Controls.Add(this.tabProveedores);
            this.tabVentas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVentas.HotTrack = true;
            this.tabVentas.Location = new System.Drawing.Point(35, 65);
            this.tabVentas.Multiline = true;
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(956, 607);
            this.tabVentas.TabIndex = 86;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabClientes.Controls.Add(this.lblChekAnul);
            this.tabClientes.Controls.Add(this.chekFecha);
            this.tabClientes.Controls.Add(this.dtpFecha1);
            this.tabClientes.Controls.Add(this.dtpFecha2);
            this.tabClientes.Controls.Add(this.label5);
            this.tabClientes.Controls.Add(this.label4);
            this.tabClientes.Controls.Add(this.label2);
            this.tabClientes.Controls.Add(this.cbCliente);
            this.tabClientes.Controls.Add(this.lblSaldo);
            this.tabClientes.Controls.Add(this.lblTitSaldo);
            this.tabClientes.Controls.Add(this.label9);
            this.tabClientes.Controls.Add(this.label6);
            this.tabClientes.Controls.Add(this.label3);
            this.tabClientes.Controls.Add(this.btnBuscar);
            this.tabClientes.Controls.Add(this.btnImprimir);
            this.tabClientes.Controls.Add(this.lblFecha2);
            this.tabClientes.Controls.Add(this.label1);
            this.tabClientes.Controls.Add(this.lblFecha1);
            this.tabClientes.Controls.Add(this.dgvDetCtaCte);
            this.tabClientes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(948, 578);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(468, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 119;
            this.label4.Text = "IMPORTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(597, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "SALDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbCliente.Location = new System.Drawing.Point(360, 42);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(240, 22);
            this.cbCliente.TabIndex = 117;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Gold;
            this.lblSaldo.Location = new System.Drawing.Point(635, 519);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(17, 16);
            this.lblSaldo.TabIndex = 110;
            this.lblSaldo.Text = "0";
            // 
            // lblTitSaldo
            // 
            this.lblTitSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitSaldo.AutoSize = true;
            this.lblTitSaldo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitSaldo.Location = new System.Drawing.Point(555, 519);
            this.lblTitSaldo.Name = "lblTitSaldo";
            this.lblTitSaldo.Size = new System.Drawing.Size(61, 16);
            this.lblTitSaldo.TabIndex = 110;
            this.lblTitSaldo.Text = "SALDO:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(227, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 18);
            this.label9.TabIndex = 104;
            this.label9.Text = "CONCEPTO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(44, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 107;
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
            this.label3.Location = new System.Drawing.Point(150, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nº";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
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
            this.btnBuscar.Location = new System.Drawing.Point(773, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 98;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
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
            this.btnImprimir.Location = new System.Drawing.Point(773, 513);
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
            this.lblFecha2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(801, 230);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(56, 16);
            this.lblFecha2.TabIndex = 94;
            this.lblFecha2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(208, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Seleccione Cliente:";
            // 
            // lblFecha1
            // 
            this.lblFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha1.AutoEllipsis = true;
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha1.Location = new System.Drawing.Point(801, 166);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(58, 16);
            this.lblFecha1.TabIndex = 93;
            this.lblFecha1.Text = "Desde:";
            // 
            // dgvDetCtaCte
            // 
            this.dgvDetCtaCte.AllowUserToAddRows = false;
            this.dgvDetCtaCte.AllowUserToDeleteRows = false;
            this.dgvDetCtaCte.AllowUserToResizeColumns = false;
            this.dgvDetCtaCte.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvDetCtaCte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetCtaCte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetCtaCte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetCtaCte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetCtaCte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetCtaCte.ColumnHeadersVisible = false;
            this.dgvDetCtaCte.EnableHeadersVisualStyles = false;
            this.dgvDetCtaCte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCte.Location = new System.Drawing.Point(44, 125);
            this.dgvDetCtaCte.MaximumSize = new System.Drawing.Size(900, 800);
            this.dgvDetCtaCte.Name = "dgvDetCtaCte";
            this.dgvDetCtaCte.ReadOnly = true;
            this.dgvDetCtaCte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetCtaCte.RowHeadersVisible = false;
            this.dgvDetCtaCte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetCtaCte.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetCtaCte.Size = new System.Drawing.Size(674, 355);
            this.dgvDetCtaCte.TabIndex = 92;
            this.dgvDetCtaCte.TabStop = false;
            // 
            // tabProveedores
            // 
            this.tabProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabProveedores.Controls.Add(this.gunaLabel1);
            this.tabProveedores.Controls.Add(this.chekFechaProv);
            this.tabProveedores.Controls.Add(this.dtpFecha1Prov);
            this.tabProveedores.Controls.Add(this.dtpFecha2Prov);
            this.tabProveedores.Controls.Add(this.label7);
            this.tabProveedores.Controls.Add(this.label8);
            this.tabProveedores.Controls.Add(this.label10);
            this.tabProveedores.Controls.Add(this.cbProveedores);
            this.tabProveedores.Controls.Add(this.lblSaldoProv);
            this.tabProveedores.Controls.Add(this.label12);
            this.tabProveedores.Controls.Add(this.label13);
            this.tabProveedores.Controls.Add(this.label14);
            this.tabProveedores.Controls.Add(this.label15);
            this.tabProveedores.Controls.Add(this.btnBuscarProv);
            this.tabProveedores.Controls.Add(this.btnImprimirProv);
            this.tabProveedores.Controls.Add(this.label16);
            this.tabProveedores.Controls.Add(this.label17);
            this.tabProveedores.Controls.Add(this.label18);
            this.tabProveedores.Controls.Add(this.dgvDetCtaCteProveedores);
            this.tabProveedores.Location = new System.Drawing.Point(4, 25);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(948, 578);
            this.tabProveedores.TabIndex = 1;
            this.tabProveedores.Text = "Proveedores";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(622, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "$";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha1.BaseColor = System.Drawing.Color.White;
            this.dtpFecha1.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha1.CustomFormat = null;
            this.dtpFecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha1.Enabled = false;
            this.dtpFecha1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha1.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(773, 185);
            this.dtpFecha1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1.Radius = 10;
            this.dtpFecha1.Size = new System.Drawing.Size(116, 28);
            this.dtpFecha1.TabIndex = 152;
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
            this.dtpFecha2.Enabled = false;
            this.dtpFecha2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha2.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(773, 249);
            this.dtpFecha2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2.Radius = 10;
            this.dtpFecha2.Size = new System.Drawing.Size(116, 28);
            this.dtpFecha2.TabIndex = 151;
            this.dtpFecha2.Text = "22/10/2021";
            this.dtpFecha2.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // lblChekAnul
            // 
            this.lblChekAnul.AutoSize = true;
            this.lblChekAnul.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChekAnul.ForeColor = System.Drawing.Color.White;
            this.lblChekAnul.Location = new System.Drawing.Point(778, 294);
            this.lblChekAnul.Name = "lblChekAnul";
            this.lblChekAnul.Size = new System.Drawing.Size(78, 13);
            this.lblChekAnul.TabIndex = 154;
            this.lblChekAnul.Text = "POR FECHA";
            // 
            // chekFecha
            // 
            this.chekFecha.BaseColor = System.Drawing.SystemColors.Control;
            this.chekFecha.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekFecha.FillColor = System.Drawing.Color.White;
            this.chekFecha.Location = new System.Drawing.Point(856, 291);
            this.chekFecha.Name = "chekFecha";
            this.chekFecha.Size = new System.Drawing.Size(28, 20);
            this.chekFecha.TabIndex = 153;
            this.chekFecha.CheckedChanged += new System.EventHandler(this.chekFecha_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(778, 294);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 13);
            this.gunaLabel1.TabIndex = 173;
            this.gunaLabel1.Text = "POR FECHA";
            // 
            // chekFechaProv
            // 
            this.chekFechaProv.BaseColor = System.Drawing.SystemColors.Control;
            this.chekFechaProv.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekFechaProv.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekFechaProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekFechaProv.FillColor = System.Drawing.Color.White;
            this.chekFechaProv.Location = new System.Drawing.Point(856, 291);
            this.chekFechaProv.Name = "chekFechaProv";
            this.chekFechaProv.Size = new System.Drawing.Size(28, 20);
            this.chekFechaProv.TabIndex = 172;
            this.chekFechaProv.CheckedChanged += new System.EventHandler(this.chekFechaProv_CheckedChanged);
            // 
            // dtpFecha1Prov
            // 
            this.dtpFecha1Prov.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha1Prov.BaseColor = System.Drawing.Color.White;
            this.dtpFecha1Prov.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha1Prov.CustomFormat = null;
            this.dtpFecha1Prov.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha1Prov.Enabled = false;
            this.dtpFecha1Prov.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1Prov.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha1Prov.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha1Prov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1Prov.Location = new System.Drawing.Point(773, 185);
            this.dtpFecha1Prov.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1Prov.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1Prov.Name = "dtpFecha1Prov";
            this.dtpFecha1Prov.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1Prov.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1Prov.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1Prov.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1Prov.Radius = 10;
            this.dtpFecha1Prov.Size = new System.Drawing.Size(116, 28);
            this.dtpFecha1Prov.TabIndex = 171;
            this.dtpFecha1Prov.Text = "22/10/2021";
            this.dtpFecha1Prov.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // dtpFecha2Prov
            // 
            this.dtpFecha2Prov.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha2Prov.BaseColor = System.Drawing.Color.White;
            this.dtpFecha2Prov.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha2Prov.CustomFormat = null;
            this.dtpFecha2Prov.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha2Prov.Enabled = false;
            this.dtpFecha2Prov.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2Prov.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha2Prov.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha2Prov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2Prov.Location = new System.Drawing.Point(773, 249);
            this.dtpFecha2Prov.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2Prov.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2Prov.Name = "dtpFecha2Prov";
            this.dtpFecha2Prov.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2Prov.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2Prov.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2Prov.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2Prov.Radius = 10;
            this.dtpFecha2Prov.Size = new System.Drawing.Size(116, 28);
            this.dtpFecha2Prov.TabIndex = 170;
            this.dtpFecha2Prov.Text = "22/10/2021";
            this.dtpFecha2Prov.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(622, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 169;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(468, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 168;
            this.label8.Text = "IMPORTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(597, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 167;
            this.label10.Text = "SALDO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbProveedores
            // 
            this.cbProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.ItemHeight = 14;
            this.cbProveedores.Location = new System.Drawing.Point(360, 42);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(240, 22);
            this.cbProveedores.TabIndex = 166;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // lblSaldoProv
            // 
            this.lblSaldoProv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldoProv.AutoSize = true;
            this.lblSaldoProv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoProv.ForeColor = System.Drawing.Color.Gold;
            this.lblSaldoProv.Location = new System.Drawing.Point(635, 519);
            this.lblSaldoProv.Name = "lblSaldoProv";
            this.lblSaldoProv.Size = new System.Drawing.Size(17, 16);
            this.lblSaldoProv.TabIndex = 165;
            this.lblSaldoProv.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(555, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 164;
            this.label12.Text = "SALDO:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(227, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 18);
            this.label13.TabIndex = 161;
            this.label13.Text = "CONCEPTO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoEllipsis = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(44, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 162;
            this.label14.Text = "FECHA";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoEllipsis = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Location = new System.Drawing.Point(150, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 163;
            this.label15.Text = "Nº";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProv.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProv.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarProv.IconColor = System.Drawing.Color.White;
            this.btnBuscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProv.IconSize = 25;
            this.btnBuscarProv.Location = new System.Drawing.Point(773, 38);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(116, 31);
            this.btnBuscarProv.TabIndex = 159;
            this.btnBuscarProv.TabStop = false;
            this.btnBuscarProv.Text = "BUSCAR";
            this.btnBuscarProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // btnImprimirProv
            // 
            this.btnImprimirProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnImprimirProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirProv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimirProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimirProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImprimirProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirProv.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirProv.ForeColor = System.Drawing.Color.White;
            this.btnImprimirProv.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirProv.IconColor = System.Drawing.Color.White;
            this.btnImprimirProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirProv.IconSize = 25;
            this.btnImprimirProv.Location = new System.Drawing.Point(773, 513);
            this.btnImprimirProv.Name = "btnImprimirProv";
            this.btnImprimirProv.Size = new System.Drawing.Size(116, 31);
            this.btnImprimirProv.TabIndex = 160;
            this.btnImprimirProv.TabStop = false;
            this.btnImprimirProv.Text = "IMPRIMIR";
            this.btnImprimirProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirProv.UseVisualStyleBackColor = false;
            this.btnImprimirProv.Click += new System.EventHandler(this.btnImprimirProv_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label16.Location = new System.Drawing.Point(801, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 158;
            this.label16.Text = "Hasta:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label17.Location = new System.Drawing.Point(184, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 16);
            this.label17.TabIndex = 156;
            this.label17.Text = "Seleccione Proveedor:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoEllipsis = true;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label18.Location = new System.Drawing.Point(801, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 157;
            this.label18.Text = "Desde:";
            // 
            // dgvDetCtaCteProveedores
            // 
            this.dgvDetCtaCteProveedores.AllowUserToAddRows = false;
            this.dgvDetCtaCteProveedores.AllowUserToDeleteRows = false;
            this.dgvDetCtaCteProveedores.AllowUserToResizeColumns = false;
            this.dgvDetCtaCteProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            this.dgvDetCtaCteProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetCtaCteProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetCtaCteProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetCtaCteProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCteProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetCtaCteProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetCtaCteProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetCtaCteProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetCtaCteProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetCtaCteProveedores.ColumnHeadersVisible = false;
            this.dgvDetCtaCteProveedores.EnableHeadersVisualStyles = false;
            this.dgvDetCtaCteProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetCtaCteProveedores.Location = new System.Drawing.Point(44, 125);
            this.dgvDetCtaCteProveedores.MaximumSize = new System.Drawing.Size(900, 800);
            this.dgvDetCtaCteProveedores.Name = "dgvDetCtaCteProveedores";
            this.dgvDetCtaCteProveedores.ReadOnly = true;
            this.dgvDetCtaCteProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetCtaCteProveedores.RowHeadersVisible = false;
            this.dgvDetCtaCteProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetCtaCteProveedores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetCtaCteProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetCtaCteProveedores.Size = new System.Drawing.Size(674, 355);
            this.dgvDetCtaCteProveedores.TabIndex = 155;
            this.dgvDetCtaCteProveedores.TabStop = false;
            // 
            // FormDetalleCCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panelFormCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetalleCCC";
            this.Text = "FormDetalleCCC";
            this.Load += new System.EventHandler(this.FormDetalleCCC_Load);
            this.panelFormCompras.ResumeLayout(false);
            this.panelFormCompras.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCte)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            this.tabProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCtaCteProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormCompras;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.DataGridView dgvDetCtaCte;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTitSaldo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2;
        private Guna.UI.WinForms.GunaLabel lblChekAnul;
        private Guna.UI.WinForms.GunaSwitch chekFecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaSwitch chekFechaProv;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1Prov;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2Prov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lblSaldoProv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton btnBuscarProv;
        private FontAwesome.Sharp.IconButton btnImprimirProv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvDetCtaCteProveedores;
    }
}