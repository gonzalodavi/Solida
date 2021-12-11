
namespace CapaPresentacion
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.btnAgregaSucursal = new FontAwesome.Sharp.IconButton();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDniCuit = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIIBB = new System.Windows.Forms.TextBox();
            this.cbCondIVA = new System.Windows.Forms.ComboBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmpresa);
            this.panel1.Controls.Add(this.btnAgregaSucursal);
            this.panel1.Controls.Add(this.cbSucursal);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.tbRazonSocial);
            this.panel1.Controls.Add(this.tbProvincia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbApellidoyNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDniCuit);
            this.panel1.Controls.Add(this.tbDireccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbIIBB);
            this.panel1.Controls.Add(this.cbCondIVA);
            this.panel1.Controls.Add(this.tbLocalidad);
            this.panel1.Controls.Add(this.tbCodPostal);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 749);
            this.panel1.TabIndex = 0;
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
            this.dgvEmpresa.Location = new System.Drawing.Point(55, 187);
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
            this.dgvEmpresa.TabIndex = 218;
            this.dgvEmpresa.TabStop = false;
            // 
            // btnAgregaSucursal
            // 
            this.btnAgregaSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregaSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAgregaSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaSucursal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregaSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregaSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregaSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaSucursal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregaSucursal.ForeColor = System.Drawing.Color.White;
            this.btnAgregaSucursal.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregaSucursal.IconColor = System.Drawing.Color.White;
            this.btnAgregaSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregaSucursal.IconSize = 25;
            this.btnAgregaSucursal.Location = new System.Drawing.Point(799, 371);
            this.btnAgregaSucursal.Name = "btnAgregaSucursal";
            this.btnAgregaSucursal.Size = new System.Drawing.Size(29, 29);
            this.btnAgregaSucursal.TabIndex = 217;
            this.btnAgregaSucursal.TabStop = false;
            this.btnAgregaSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregaSucursal.UseVisualStyleBackColor = false;
            this.btnAgregaSucursal.Click += new System.EventHandler(this.btnAgregaSucursal_Click);
            // 
            // cbSucursal
            // 
            this.cbSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSucursal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbSucursal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.ItemHeight = 17;
            this.cbSucursal.Items.AddRange(new object[] {
            "Consumidor Final",
            "Exento",
            "Monotributista",
            "Responsable Inscripto"});
            this.cbSucursal.Location = new System.Drawing.Point(646, 373);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(147, 25);
            this.cbSucursal.TabIndex = 216;
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.BaseColor = System.Drawing.Color.White;
            this.dtpFecha.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.CustomFormat = null;
            this.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(646, 308);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha.Radius = 10;
            this.dtpFecha.Size = new System.Drawing.Size(147, 28);
            this.dtpFecha.TabIndex = 215;
            this.dtpFecha.Text = "22/10/2021";
            this.dtpFecha.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbRazonSocial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbRazonSocial.Location = new System.Drawing.Point(221, 184);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(253, 25);
            this.tbRazonSocial.TabIndex = 195;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProvincia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbProvincia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProvincia.Location = new System.Drawing.Point(221, 374);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(253, 25);
            this.tbProvincia.TabIndex = 200;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 205;
            this.label1.Text = "APELLIDO Y NOMBRE:";
            // 
            // tbApellidoyNombre
            // 
            this.tbApellidoyNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidoyNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidoyNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbApellidoyNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbApellidoyNombre.Location = new System.Drawing.Point(221, 246);
            this.tbApellidoyNombre.Name = "tbApellidoyNombre";
            this.tbApellidoyNombre.Size = new System.Drawing.Size(253, 25);
            this.tbApellidoyNombre.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(561, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "CUIT / DNI:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(564, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 210;
            this.label9.Text = "SUCURSAL:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(134, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 209;
            this.label5.Text = "DIRECCIÓN:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(604, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 208;
            this.label10.Text = "IIBB:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(513, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 207;
            this.label11.Text = "INICIO ACTIVIDAD:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(129, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 211;
            this.label6.Text = "LOCALIDAD:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(133, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 212;
            this.label7.Text = "PROVINCIA:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(104, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 204;
            this.label3.Text = "CONDICION IVA:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(109, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 213;
            this.label4.Text = "RAZÓN SOCIAL:";
            // 
            // tbDniCuit
            // 
            this.tbDniCuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDniCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDniCuit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDniCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDniCuit.Location = new System.Drawing.Point(646, 184);
            this.tbDniCuit.Name = "tbDniCuit";
            this.tbDniCuit.Size = new System.Drawing.Size(147, 25);
            this.tbDniCuit.TabIndex = 197;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDireccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDireccion.Location = new System.Drawing.Point(221, 499);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(253, 25);
            this.tbDireccion.TabIndex = 203;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(612, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 214;
            this.label8.Text = "CP:";
            // 
            // tbIIBB
            // 
            this.tbIIBB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIIBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIIBB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbIIBB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbIIBB.Location = new System.Drawing.Point(646, 246);
            this.tbIIBB.Name = "tbIIBB";
            this.tbIIBB.Size = new System.Drawing.Size(147, 25);
            this.tbIIBB.TabIndex = 199;
            // 
            // cbCondIVA
            // 
            this.cbCondIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCondIVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCondIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondIVA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCondIVA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbCondIVA.FormattingEnabled = true;
            this.cbCondIVA.ItemHeight = 17;
            this.cbCondIVA.Items.AddRange(new object[] {
            "Consumidor Final",
            "Exento",
            "Monotributista",
            "Responsable Inscripto"});
            this.cbCondIVA.Location = new System.Drawing.Point(221, 310);
            this.cbCondIVA.Name = "cbCondIVA";
            this.cbCondIVA.Size = new System.Drawing.Size(253, 25);
            this.cbCondIVA.TabIndex = 198;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbLocalidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbLocalidad.Location = new System.Drawing.Point(221, 436);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(253, 25);
            this.tbLocalidad.TabIndex = 201;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodPostal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCodPostal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCodPostal.Location = new System.Drawing.Point(646, 436);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(147, 25);
            this.tbCodPostal.TabIndex = 202;
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
            this.btnGuardar.Location = new System.Drawing.Point(453, 633);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 31);
            this.btnGuardar.TabIndex = 193;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnRegresar.Location = new System.Drawing.Point(873, 46);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 194;
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
            this.lblTitulo.Location = new System.Drawing.Point(379, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 18);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "Datos Empresa y Sucursales";
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpresa";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.ComboBox cbSucursal;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApellidoyNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDniCuit;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIIBB;
        private System.Windows.Forms.ComboBox cbCondIVA;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbCodPostal;
        private FontAwesome.Sharp.IconButton btnAgregaSucursal;
        private System.Windows.Forms.DataGridView dgvEmpresa;
    }
}