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
            this.rbEmpresa = new Guna.UI.WinForms.GunaRadioButton();
            this.rbSucursal = new Guna.UI.WinForms.GunaRadioButton();
            this.panelSucursal = new Guna.UI.WinForms.GunaPanel();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.lblAlicuota = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNuevaSucursal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarSucursal = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.panelEmpresa = new Guna.UI.WinForms.GunaPanel();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDniCuit = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIIBB = new System.Windows.Forms.TextBox();
            this.cbCondIVA = new System.Windows.Forms.ComboBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.panelEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rbEmpresa);
            this.panel1.Controls.Add(this.rbSucursal);
            this.panel1.Controls.Add(this.panelSucursal);
            this.panel1.Controls.Add(this.panelEmpresa);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 749);
            this.panel1.TabIndex = 0;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.BaseColor = System.Drawing.SystemColors.Control;
            this.rbEmpresa.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbEmpresa.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmpresa.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rbEmpresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.rbEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbEmpresa.Location = new System.Drawing.Point(209, 64);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(203, 20);
            this.rbEmpresa.TabIndex = 202;
            this.rbEmpresa.Text = "Modificar Datos Empresa";
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbSucursal
            // 
            this.rbSucursal.BaseColor = System.Drawing.SystemColors.Control;
            this.rbSucursal.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbSucursal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSucursal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rbSucursal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.rbSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbSucursal.Location = new System.Drawing.Point(209, 103);
            this.rbSucursal.Name = "rbSucursal";
            this.rbSucursal.Size = new System.Drawing.Size(149, 20);
            this.rbSucursal.TabIndex = 203;
            this.rbSucursal.Text = "Agregar Sucursal";
            this.rbSucursal.CheckedChanged += new System.EventHandler(this.rbSucursal_CheckedChanged);
            // 
            // panelSucursal
            // 
            this.panelSucursal.Controls.Add(this.dgvEmpresa);
            this.panelSucursal.Controls.Add(this.dgvSucursal);
            this.panelSucursal.Controls.Add(this.lblAlicuota);
            this.panelSucursal.Controls.Add(this.label15);
            this.panelSucursal.Controls.Add(this.tbNuevaSucursal);
            this.panelSucursal.Controls.Add(this.label12);
            this.panelSucursal.Controls.Add(this.btnRegistrarSucursal);
            this.panelSucursal.Controls.Add(this.label13);
            this.panelSucursal.Enabled = false;
            this.panelSucursal.Location = new System.Drawing.Point(29, 479);
            this.panelSucursal.Name = "panelSucursal";
            this.panelSucursal.Size = new System.Drawing.Size(966, 240);
            this.panelSucursal.TabIndex = 206;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvEmpresa.Location = new System.Drawing.Point(735, 18);
            this.dgvEmpresa.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSucursal.ColumnHeadersVisible = false;
            this.dgvSucursal.EnableHeadersVisualStyles = false;
            this.dgvSucursal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvSucursal.Location = new System.Drawing.Point(216, 68);
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
            this.dgvSucursal.TabIndex = 195;
            this.dgvSucursal.TabStop = false;
            // 
            // lblAlicuota
            // 
            this.lblAlicuota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlicuota.AutoEllipsis = true;
            this.lblAlicuota.AutoSize = true;
            this.lblAlicuota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlicuota.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblAlicuota.Location = new System.Drawing.Point(513, 155);
            this.lblAlicuota.Name = "lblAlicuota";
            this.lblAlicuota.Size = new System.Drawing.Size(105, 16);
            this.lblAlicuota.TabIndex = 197;
            this.lblAlicuota.Text = "Nº SUCURSAL";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Location = new System.Drawing.Point(281, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 201;
            this.label15.Text = "Sucursales";
            // 
            // tbNuevaSucursal
            // 
            this.tbNuevaSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNuevaSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNuevaSucursal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaSucursal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNuevaSucursal.Location = new System.Drawing.Point(624, 154);
            this.tbNuevaSucursal.Name = "tbNuevaSucursal";
            this.tbNuevaSucursal.Size = new System.Drawing.Size(159, 22);
            this.tbNuevaSucursal.TabIndex = 194;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(216, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 199;
            this.label12.Text = "ID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnRegistrarSucursal.Location = new System.Drawing.Point(827, 148);
            this.btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            this.btnRegistrarSucursal.Size = new System.Drawing.Size(116, 31);
            this.btnRegistrarSucursal.TabIndex = 198;
            this.btnRegistrarSucursal.TabStop = false;
            this.btnRegistrarSucursal.Text = "GUARDAR";
            this.btnRegistrarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarSucursal.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(318, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 200;
            this.label13.Text = "SUCURSAL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Controls.Add(this.tbRazonSocial);
            this.panelEmpresa.Controls.Add(this.tbProvincia);
            this.panelEmpresa.Controls.Add(this.label1);
            this.panelEmpresa.Controls.Add(this.tbApellidoyNombre);
            this.panelEmpresa.Controls.Add(this.label2);
            this.panelEmpresa.Controls.Add(this.label5);
            this.panelEmpresa.Controls.Add(this.label10);
            this.panelEmpresa.Controls.Add(this.label11);
            this.panelEmpresa.Controls.Add(this.label6);
            this.panelEmpresa.Controls.Add(this.label7);
            this.panelEmpresa.Controls.Add(this.label3);
            this.panelEmpresa.Controls.Add(this.btnGuardar);
            this.panelEmpresa.Controls.Add(this.label4);
            this.panelEmpresa.Controls.Add(this.tbDniCuit);
            this.panelEmpresa.Controls.Add(this.dtpFecha);
            this.panelEmpresa.Controls.Add(this.tbDireccion);
            this.panelEmpresa.Controls.Add(this.label8);
            this.panelEmpresa.Controls.Add(this.tbIIBB);
            this.panelEmpresa.Controls.Add(this.cbCondIVA);
            this.panelEmpresa.Controls.Add(this.tbLocalidad);
            this.panelEmpresa.Controls.Add(this.tbCodPostal);
            this.panelEmpresa.Enabled = false;
            this.panelEmpresa.Location = new System.Drawing.Point(29, 153);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(966, 295);
            this.panelEmpresa.TabIndex = 205;
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRazonSocial.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbRazonSocial.Location = new System.Drawing.Point(180, 15);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(279, 22);
            this.tbRazonSocial.TabIndex = 1;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProvincia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvincia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProvincia.Location = new System.Drawing.Point(180, 105);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(279, 22);
            this.tbProvincia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 170;
            this.label1.Text = "APELLIDO Y NOMBRE:";
            // 
            // tbApellidoyNombre
            // 
            this.tbApellidoyNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidoyNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidoyNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoyNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbApellidoyNombre.Location = new System.Drawing.Point(180, 60);
            this.tbApellidoyNombre.Name = "tbApellidoyNombre";
            this.tbApellidoyNombre.Size = new System.Drawing.Size(279, 22);
            this.tbApellidoyNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(528, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 171;
            this.label2.Text = "CUIT / DNI:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(80, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 172;
            this.label5.Text = "DIRECCIÓN:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(573, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 172;
            this.label10.Text = "IIBB:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(472, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 172;
            this.label11.Text = "INICIO ACTIVIDAD:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(78, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "LOCALIDAD:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(80, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 175;
            this.label7.Text = "PROVINCIA:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(491, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 169;
            this.label3.Text = "CONDICION IVA:";
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
            this.btnGuardar.Location = new System.Drawing.Point(827, 189);
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
            this.label4.Location = new System.Drawing.Point(54, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 176;
            this.label4.Text = "RAZÓN SOCIAL:";
            // 
            // tbDniCuit
            // 
            this.tbDniCuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDniCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDniCuit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDniCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDniCuit.Location = new System.Drawing.Point(624, 15);
            this.tbDniCuit.Name = "tbDniCuit";
            this.tbDniCuit.Size = new System.Drawing.Size(159, 22);
            this.tbDniCuit.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(624, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(159, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDireccion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDireccion.Location = new System.Drawing.Point(180, 195);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(279, 22);
            this.tbDireccion.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(586, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 185;
            this.label8.Text = "CP:";
            // 
            // tbIIBB
            // 
            this.tbIIBB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIIBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIIBB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIIBB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbIIBB.Location = new System.Drawing.Point(624, 150);
            this.tbIIBB.Name = "tbIIBB";
            this.tbIIBB.Size = new System.Drawing.Size(159, 22);
            this.tbIIBB.TabIndex = 6;
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
            this.cbCondIVA.Location = new System.Drawing.Point(624, 60);
            this.cbCondIVA.Name = "cbCondIVA";
            this.cbCondIVA.Size = new System.Drawing.Size(159, 22);
            this.cbCondIVA.TabIndex = 4;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbLocalidad.Location = new System.Drawing.Point(180, 150);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(279, 22);
            this.tbLocalidad.TabIndex = 8;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodPostal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodPostal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCodPostal.Location = new System.Drawing.Point(624, 195);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(159, 22);
            this.tbCodPostal.TabIndex = 9;
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
            this.btnRegresar.Location = new System.Drawing.Point(856, 53);
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
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(388, 3);
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
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSucursales";
            this.Text = "FormSucursales";
            this.Load += new System.EventHandler(this.FormSucursales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSucursal.ResumeLayout(false);
            this.panelSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
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
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TextBox tbIIBB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnRegistrarSucursal;
        private System.Windows.Forms.TextBox tbNuevaSucursal;
        private System.Windows.Forms.Label lblAlicuota;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private Guna.UI.WinForms.GunaPanel panelSucursal;
        private Guna.UI.WinForms.GunaPanel panelEmpresa;
        private Guna.UI.WinForms.GunaRadioButton rbEmpresa;
        private Guna.UI.WinForms.GunaRadioButton rbSucursal;
    }
}