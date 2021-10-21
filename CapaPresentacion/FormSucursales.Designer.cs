namespace CapaPresentacion
{
    partial class FormSucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSucursales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.tabConfiguraEmpresa = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCondIVA = new System.Windows.Forms.ComboBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbIIBB = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbDniCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.tabSucursales = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegistrarSucursal = new FontAwesome.Sharp.IconButton();
            this.tbNuevaSucursal = new System.Windows.Forms.TextBox();
            this.lblAlicuota = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabConfiguraEmpresa.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.tabSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.tabConfiguraEmpresa);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 549);
            this.panel1.TabIndex = 0;
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
            this.btnRegresar.Location = new System.Drawing.Point(532, 503);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 192;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tabConfiguraEmpresa
            // 
            this.tabConfiguraEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabConfiguraEmpresa.Controls.Add(this.tabEmpresa);
            this.tabConfiguraEmpresa.Controls.Add(this.tabSucursales);
            this.tabConfiguraEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConfiguraEmpresa.HotTrack = true;
            this.tabConfiguraEmpresa.Location = new System.Drawing.Point(14, 37);
            this.tabConfiguraEmpresa.Multiline = true;
            this.tabConfiguraEmpresa.Name = "tabConfiguraEmpresa";
            this.tabConfiguraEmpresa.SelectedIndex = 0;
            this.tabConfiguraEmpresa.Size = new System.Drawing.Size(649, 449);
            this.tabConfiguraEmpresa.TabIndex = 89;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabEmpresa.Controls.Add(this.btnGuardar);
            this.tabEmpresa.Controls.Add(this.label4);
            this.tabEmpresa.Controls.Add(this.dtpFecha);
            this.tabEmpresa.Controls.Add(this.label8);
            this.tabEmpresa.Controls.Add(this.cbCondIVA);
            this.tabEmpresa.Controls.Add(this.tbCodPostal);
            this.tabEmpresa.Controls.Add(this.tbLocalidad);
            this.tabEmpresa.Controls.Add(this.tbIIBB);
            this.tabEmpresa.Controls.Add(this.tbDireccion);
            this.tabEmpresa.Controls.Add(this.tbDniCuit);
            this.tabEmpresa.Controls.Add(this.label3);
            this.tabEmpresa.Controls.Add(this.label7);
            this.tabEmpresa.Controls.Add(this.label6);
            this.tabEmpresa.Controls.Add(this.label11);
            this.tabEmpresa.Controls.Add(this.label10);
            this.tabEmpresa.Controls.Add(this.label5);
            this.tabEmpresa.Controls.Add(this.label2);
            this.tabEmpresa.Controls.Add(this.tbApellidoyNombre);
            this.tabEmpresa.Controls.Add(this.label1);
            this.tabEmpresa.Controls.Add(this.tbProvincia);
            this.tabEmpresa.Controls.Add(this.tbRazonSocial);
            this.tabEmpresa.Controls.Add(this.dgvEmpresa);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpresa.Size = new System.Drawing.Size(641, 420);
            this.tabEmpresa.TabIndex = 1;
            this.tabEmpresa.Text = "Empresa";
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
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(514, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 31);
            this.btnGuardar.TabIndex = 186;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(72, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 176;
            this.label4.Text = "RAZÓN SOCIAL:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(198, 188);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(134, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(398, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 185;
            this.label8.Text = "CP:";
            // 
            // cbCondIVA
            // 
            this.cbCondIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCondIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondIVA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondIVA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbCondIVA.FormattingEnabled = true;
            this.cbCondIVA.ItemHeight = 14;
            this.cbCondIVA.Items.AddRange(new object[] {
            "Consumidor Final",
            "Exento",
            "Monotributista",
            "Responsable Inscripto"});
            this.cbCondIVA.Location = new System.Drawing.Point(198, 151);
            this.cbCondIVA.Name = "cbCondIVA";
            this.cbCondIVA.Size = new System.Drawing.Size(313, 22);
            this.cbCondIVA.TabIndex = 4;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodPostal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodPostal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCodPostal.Location = new System.Drawing.Point(436, 262);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(75, 15);
            this.tbCodPostal.TabIndex = 9;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocalidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbLocalidad.Location = new System.Drawing.Point(198, 262);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(185, 15);
            this.tbLocalidad.TabIndex = 8;
            // 
            // tbIIBB
            // 
            this.tbIIBB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIIBB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIIBB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIIBB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbIIBB.Location = new System.Drawing.Point(391, 193);
            this.tbIIBB.Name = "tbIIBB";
            this.tbIIBB.Size = new System.Drawing.Size(120, 15);
            this.tbIIBB.TabIndex = 6;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDireccion.Location = new System.Drawing.Point(198, 292);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(313, 15);
            this.tbDireccion.TabIndex = 10;
            // 
            // tbDniCuit
            // 
            this.tbDniCuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDniCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDniCuit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDniCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDniCuit.Location = new System.Drawing.Point(198, 121);
            this.tbDniCuit.Name = "tbDniCuit";
            this.tbDniCuit.Size = new System.Drawing.Size(313, 15);
            this.tbDniCuit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(65, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 169;
            this.label3.Text = "CONDICION IVA:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(98, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 175;
            this.label7.Text = "PROVINCIA:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(96, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "LOCALIDAD:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(46, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 172;
            this.label11.Text = "INICIO ACTIVIDAD:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(338, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 172;
            this.label10.Text = "IIBB:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(98, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 172;
            this.label5.Text = "DIRECCIÓN:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(102, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 171;
            this.label2.Text = "CUIT / DNI:";
            // 
            // tbApellidoyNombre
            // 
            this.tbApellidoyNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidoyNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellidoyNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoyNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbApellidoyNombre.Location = new System.Drawing.Point(198, 91);
            this.tbApellidoyNombre.Name = "tbApellidoyNombre";
            this.tbApellidoyNombre.Size = new System.Drawing.Size(313, 15);
            this.tbApellidoyNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 170;
            this.label1.Text = "APELLIDO Y NOMBRE:";
            // 
            // tbProvincia
            // 
            this.tbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProvincia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvincia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProvincia.Location = new System.Drawing.Point(198, 227);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(313, 15);
            this.tbProvincia.TabIndex = 7;
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRazonSocial.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbRazonSocial.Location = new System.Drawing.Point(198, 61);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(313, 15);
            this.tbRazonSocial.TabIndex = 1;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.AllowUserToResizeColumns = false;
            this.dgvEmpresa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvEmpresa.Location = new System.Drawing.Point(548, 389);
            this.dgvEmpresa.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpresa.RowHeadersVisible = false;
            this.dgvEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(48, 16);
            this.dgvEmpresa.TabIndex = 188;
            this.dgvEmpresa.TabStop = false;
            // 
            // tabSucursales
            // 
            this.tabSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabSucursales.Controls.Add(this.label12);
            this.tabSucursales.Controls.Add(this.label13);
            this.tabSucursales.Controls.Add(this.btnRegistrarSucursal);
            this.tabSucursales.Controls.Add(this.tbNuevaSucursal);
            this.tabSucursales.Controls.Add(this.lblAlicuota);
            this.tabSucursales.Controls.Add(this.label9);
            this.tabSucursales.Controls.Add(this.dgvSucursal);
            this.tabSucursales.Location = new System.Drawing.Point(4, 25);
            this.tabSucursales.Name = "tabSucursales";
            this.tabSucursales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSucursales.Size = new System.Drawing.Size(641, 420);
            this.tabSucursales.TabIndex = 3;
            this.tabSucursales.Text = "Sucursales";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(223, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 192;
            this.label12.Text = "ID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(325, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 193;
            this.label13.Text = "SUCURSAL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrarSucursal
            // 
            this.btnRegistrarSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRegistrarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSucursal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSucursal.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnRegistrarSucursal.IconColor = System.Drawing.Color.White;
            this.btnRegistrarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarSucursal.IconSize = 25;
            this.btnRegistrarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSucursal.Location = new System.Drawing.Point(514, 364);
            this.btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            this.btnRegistrarSucursal.Size = new System.Drawing.Size(116, 31);
            this.btnRegistrarSucursal.TabIndex = 191;
            this.btnRegistrarSucursal.TabStop = false;
            this.btnRegistrarSucursal.Text = "GUARDAR";
            this.btnRegistrarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarSucursal.UseVisualStyleBackColor = false;
            this.btnRegistrarSucursal.Click += new System.EventHandler(this.btnRegistrarSucursal_Click);
            // 
            // tbNuevaSucursal
            // 
            this.tbNuevaSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNuevaSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNuevaSucursal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaSucursal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNuevaSucursal.Location = new System.Drawing.Point(239, 301);
            this.tbNuevaSucursal.Name = "tbNuevaSucursal";
            this.tbNuevaSucursal.Size = new System.Drawing.Size(174, 15);
            this.tbNuevaSucursal.TabIndex = 11;
            this.tbNuevaSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevaSucursal_KeyPress);
            // 
            // lblAlicuota
            // 
            this.lblAlicuota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlicuota.AutoEllipsis = true;
            this.lblAlicuota.AutoSize = true;
            this.lblAlicuota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlicuota.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblAlicuota.Location = new System.Drawing.Point(258, 275);
            this.lblAlicuota.Name = "lblAlicuota";
            this.lblAlicuota.Size = new System.Drawing.Size(136, 16);
            this.lblAlicuota.TabIndex = 189;
            this.lblAlicuota.Text = "NUEVA SUCURSAL";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(271, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 188;
            this.label9.Text = "SUCURSALES";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AllowUserToAddRows = false;
            this.dgvSucursal.AllowUserToDeleteRows = false;
            this.dgvSucursal.AllowUserToResizeColumns = false;
            this.dgvSucursal.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            this.dgvSucursal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSucursal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSucursal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSucursal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSucursal.ColumnHeadersVisible = false;
            this.dgvSucursal.EnableHeadersVisualStyles = false;
            this.dgvSucursal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvSucursal.Location = new System.Drawing.Point(223, 114);
            this.dgvSucursal.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.ReadOnly = true;
            this.dgvSucursal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSucursal.RowHeadersVisible = false;
            this.dgvSucursal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSucursal.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursal.Size = new System.Drawing.Size(205, 127);
            this.dgvSucursal.TabIndex = 187;
            this.dgvSucursal.TabStop = false;
            this.dgvSucursal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlicuota_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(213, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 18);
            this.lblTitulo.TabIndex = 88;
            this.lblTitulo.Text = "Datos Empresa y Sucursales";
            // 
            // FormSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSucursales";
            this.Text = "FormSucursales";
            this.Load += new System.EventHandler(this.FormSucursales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabConfiguraEmpresa.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.tabSucursales.ResumeLayout(false);
            this.tabSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabConfiguraEmpresa;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabSucursales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCondIVA;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbDniCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApellidoyNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnRegistrarSucursal;
        private System.Windows.Forms.TextBox tbNuevaSucursal;
        private System.Windows.Forms.Label lblAlicuota;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TextBox tbIIBB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}