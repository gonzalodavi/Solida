namespace CapaPresentacion
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPie = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalIVA = new System.Windows.Forms.TextBox();
            this.lblDescripcionPie = new System.Windows.Forms.Label();
            this.lblTotalIva = new System.Windows.Forms.Label();
            this.tbTotalFact = new System.Windows.Forms.TextBox();
            this.lblImpTotal = new System.Windows.Forms.Label();
            this.gbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.tbSubtotalIVA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDetComp = new System.Windows.Forms.DataGridView();
            this.btnSelProd = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbIDprod = new System.Windows.Forms.TextBox();
            this.tbIVACompra = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbImporteCompra = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFacturaCompra = new System.Windows.Forms.GroupBox();
            this.tbNumComp = new System.Windows.Forms.TextBox();
            this.tbProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.gbPie.SuspendLayout();
            this.gbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetComp)).BeginInit();
            this.gbFacturaCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.gbPie);
            this.panel1.Controls.Add(this.gbDetalleCompra);
            this.panel1.Controls.Add(this.gbFacturaCompra);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 535);
            this.panel1.TabIndex = 0;
            // 
            // gbPie
            // 
            this.gbPie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPie.Controls.Add(this.label5);
            this.gbPie.Controls.Add(this.label4);
            this.gbPie.Controls.Add(this.tbTotalIVA);
            this.gbPie.Controls.Add(this.lblDescripcionPie);
            this.gbPie.Controls.Add(this.lblTotalIva);
            this.gbPie.Controls.Add(this.tbTotalFact);
            this.gbPie.Controls.Add(this.lblImpTotal);
            this.gbPie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPie.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbPie.Location = new System.Drawing.Point(24, 449);
            this.gbPie.Name = "gbPie";
            this.gbPie.Size = new System.Drawing.Size(627, 69);
            this.gbPie.TabIndex = 50;
            this.gbPie.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(489, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(332, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "$";
            // 
            // tbTotalIVA
            // 
            this.tbTotalIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalIVA.Enabled = false;
            this.tbTotalIVA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalIVA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbTotalIVA.Location = new System.Drawing.Point(348, 40);
            this.tbTotalIVA.Name = "tbTotalIVA";
            this.tbTotalIVA.Size = new System.Drawing.Size(108, 15);
            this.tbTotalIVA.TabIndex = 49;
            // 
            // lblDescripcionPie
            // 
            this.lblDescripcionPie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcionPie.AutoSize = true;
            this.lblDescripcionPie.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescripcionPie.Location = new System.Drawing.Point(29, 33);
            this.lblDescripcionPie.Name = "lblDescripcionPie";
            this.lblDescripcionPie.Size = new System.Drawing.Size(84, 14);
            this.lblDescripcionPie.TabIndex = 48;
            this.lblDescripcionPie.Text = "Descripcion";
            this.lblDescripcionPie.Visible = false;
            // 
            // lblTotalIva
            // 
            this.lblTotalIva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalIva.AutoSize = true;
            this.lblTotalIva.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIva.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalIva.Location = new System.Drawing.Point(368, 16);
            this.lblTotalIva.Name = "lblTotalIva";
            this.lblTotalIva.Size = new System.Drawing.Size(68, 14);
            this.lblTotalIva.TabIndex = 46;
            this.lblTotalIva.Text = "Total IVA";
            // 
            // tbTotalFact
            // 
            this.tbTotalFact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalFact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalFact.Enabled = false;
            this.tbTotalFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalFact.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbTotalFact.Location = new System.Drawing.Point(506, 40);
            this.tbTotalFact.Name = "tbTotalFact";
            this.tbTotalFact.Size = new System.Drawing.Size(108, 15);
            this.tbTotalFact.TabIndex = 47;
            // 
            // lblImpTotal
            // 
            this.lblImpTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImpTotal.AutoSize = true;
            this.lblImpTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblImpTotal.Location = new System.Drawing.Point(511, 16);
            this.lblImpTotal.Name = "lblImpTotal";
            this.lblImpTotal.Size = new System.Drawing.Size(97, 14);
            this.lblImpTotal.TabIndex = 46;
            this.lblImpTotal.Text = "Importe Total";
            // 
            // gbDetalleCompra
            // 
            this.gbDetalleCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDetalleCompra.Controls.Add(this.tbSubtotalIVA);
            this.gbDetalleCompra.Controls.Add(this.label8);
            this.gbDetalleCompra.Controls.Add(this.btnGuardar);
            this.gbDetalleCompra.Controls.Add(this.btnEliminar);
            this.gbDetalleCompra.Controls.Add(this.dgvDetComp);
            this.gbDetalleCompra.Controls.Add(this.btnSelProd);
            this.gbDetalleCompra.Controls.Add(this.btnAgregar);
            this.gbDetalleCompra.Controls.Add(this.tbCantidad);
            this.gbDetalleCompra.Controls.Add(this.lblCantidad);
            this.gbDetalleCompra.Controls.Add(this.tbIDprod);
            this.gbDetalleCompra.Controls.Add(this.tbIVACompra);
            this.gbDetalleCompra.Controls.Add(this.tbProducto);
            this.gbDetalleCompra.Controls.Add(this.tbSubtotal);
            this.gbDetalleCompra.Controls.Add(this.tbImporteCompra);
            this.gbDetalleCompra.Controls.Add(this.lblSubtotal);
            this.gbDetalleCompra.Controls.Add(this.label6);
            this.gbDetalleCompra.Controls.Add(this.label7);
            this.gbDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleCompra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbDetalleCompra.Location = new System.Drawing.Point(24, 166);
            this.gbDetalleCompra.Name = "gbDetalleCompra";
            this.gbDetalleCompra.Size = new System.Drawing.Size(627, 277);
            this.gbDetalleCompra.TabIndex = 47;
            this.gbDetalleCompra.TabStop = false;
            this.gbDetalleCompra.Text = "Detalle de Compra";
            // 
            // tbSubtotalIVA
            // 
            this.tbSubtotalIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSubtotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSubtotalIVA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotalIVA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbSubtotalIVA.Location = new System.Drawing.Point(424, 34);
            this.tbSubtotalIVA.Name = "tbSubtotalIVA";
            this.tbSubtotalIVA.Size = new System.Drawing.Size(81, 15);
            this.tbSubtotalIVA.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(391, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "IVA:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(526, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 29);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(526, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 29);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "QUITAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDetComp
            // 
            this.dgvDetComp.AllowUserToAddRows = false;
            this.dgvDetComp.AllowUserToDeleteRows = false;
            this.dgvDetComp.AllowUserToResizeColumns = false;
            this.dgvDetComp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvDetComp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetComp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetComp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetComp.EnableHeadersVisualStyles = false;
            this.dgvDetComp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvDetComp.Location = new System.Drawing.Point(17, 98);
            this.dgvDetComp.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvDetComp.Name = "dgvDetComp";
            this.dgvDetComp.ReadOnly = true;
            this.dgvDetComp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetComp.RowHeadersVisible = false;
            this.dgvDetComp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetComp.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetComp.Size = new System.Drawing.Size(500, 153);
            this.dgvDetComp.TabIndex = 51;
            this.dgvDetComp.TabStop = false;
            // 
            // btnSelProd
            // 
            this.btnSelProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSelProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelProd.FlatAppearance.BorderSize = 0;
            this.btnSelProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelProd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelProd.ForeColor = System.Drawing.Color.White;
            this.btnSelProd.Location = new System.Drawing.Point(267, 30);
            this.btnSelProd.Name = "btnSelProd";
            this.btnSelProd.Size = new System.Drawing.Size(59, 23);
            this.btnSelProd.TabIndex = 50;
            this.btnSelProd.TabStop = false;
            this.btnSelProd.Text = "Elegir";
            this.btnSelProd.UseVisualStyleBackColor = false;
            this.btnSelProd.Click += new System.EventHandler(this.btnSelProd_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(526, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 29);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCantidad.Location = new System.Drawing.Point(81, 62);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(60, 15);
            this.tbCantidad.TabIndex = 49;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(43, 63);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(40, 13);
            this.lblCantidad.TabIndex = 48;
            this.lblCantidad.Text = "Cant:";
            // 
            // tbIDprod
            // 
            this.tbIDprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDprod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDprod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbIDprod.Location = new System.Drawing.Point(533, 157);
            this.tbIDprod.Name = "tbIDprod";
            this.tbIDprod.Size = new System.Drawing.Size(81, 15);
            this.tbIDprod.TabIndex = 47;
            this.tbIDprod.Visible = false;
            // 
            // tbIVACompra
            // 
            this.tbIVACompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIVACompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIVACompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIVACompra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbIVACompra.Location = new System.Drawing.Point(533, 178);
            this.tbIVACompra.Name = "tbIVACompra";
            this.tbIVACompra.Size = new System.Drawing.Size(81, 15);
            this.tbIVACompra.TabIndex = 47;
            this.tbIVACompra.Visible = false;
            // 
            // tbProducto
            // 
            this.tbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProducto.Enabled = false;
            this.tbProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProducto.Location = new System.Drawing.Point(81, 35);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(180, 15);
            this.tbProducto.TabIndex = 47;
            this.tbProducto.TextChanged += new System.EventHandler(this.cbProducto_TextChanged);
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSubtotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbSubtotal.Location = new System.Drawing.Point(424, 62);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(81, 15);
            this.tbSubtotal.TabIndex = 47;
            // 
            // tbImporteCompra
            // 
            this.tbImporteCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImporteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbImporteCompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporteCompra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbImporteCompra.Location = new System.Drawing.Point(245, 62);
            this.tbImporteCompra.Name = "tbImporteCompra";
            this.tbImporteCompra.Size = new System.Drawing.Size(81, 15);
            this.tbImporteCompra.TabIndex = 47;
            this.tbImporteCompra.TextChanged += new System.EventHandler(this.tbImporteCompra_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSubtotal.Location = new System.Drawing.Point(345, 63);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(80, 13);
            this.lblSubtotal.TabIndex = 43;
            this.lblSubtotal.Text = "SubTotal: $";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(171, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Importe: $";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Producto:";
            // 
            // gbFacturaCompra
            // 
            this.gbFacturaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFacturaCompra.Controls.Add(this.tbNumComp);
            this.gbFacturaCompra.Controls.Add(this.tbProveedor);
            this.gbFacturaCompra.Controls.Add(this.label2);
            this.gbFacturaCompra.Controls.Add(this.tbCuit);
            this.gbFacturaCompra.Controls.Add(this.lblCuit);
            this.gbFacturaCompra.Controls.Add(this.btnBuscaProveedor);
            this.gbFacturaCompra.Controls.Add(this.tbDireccion);
            this.gbFacturaCompra.Controls.Add(this.lblDireccion);
            this.gbFacturaCompra.Controls.Add(this.label1);
            this.gbFacturaCompra.Controls.Add(this.lblFecha);
            this.gbFacturaCompra.Controls.Add(this.dtpFecha);
            this.gbFacturaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFacturaCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFacturaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbFacturaCompra.Location = new System.Drawing.Point(24, 3);
            this.gbFacturaCompra.Name = "gbFacturaCompra";
            this.gbFacturaCompra.Size = new System.Drawing.Size(627, 138);
            this.gbFacturaCompra.TabIndex = 46;
            this.gbFacturaCompra.TabStop = false;
            this.gbFacturaCompra.Text = "Factura de Compra";
            // 
            // tbNumComp
            // 
            this.tbNumComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumComp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumComp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNumComp.Location = new System.Drawing.Point(484, 65);
            this.tbNumComp.Name = "tbNumComp";
            this.tbNumComp.Size = new System.Drawing.Size(130, 15);
            this.tbNumComp.TabIndex = 49;
            // 
            // tbProveedor
            // 
            this.tbProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProveedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProveedor.Location = new System.Drawing.Point(104, 37);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Size = new System.Drawing.Size(191, 15);
            this.tbProveedor.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(394, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nº Compra:";
            // 
            // tbCuit
            // 
            this.tbCuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCuit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCuit.Location = new System.Drawing.Point(104, 67);
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(191, 15);
            this.tbCuit.TabIndex = 47;
            // 
            // lblCuit
            // 
            this.lblCuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCuit.Location = new System.Drawing.Point(53, 66);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(45, 14);
            this.lblCuit.TabIndex = 46;
            this.lblCuit.Text = "CUIT:";
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscaProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscaProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscaProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProveedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscaProveedor.Location = new System.Drawing.Point(301, 33);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(88, 23);
            this.btnBuscaProveedor.TabIndex = 50;
            this.btnBuscaProveedor.TabStop = false;
            this.btnBuscaProveedor.Text = "Buscar";
            this.btnBuscaProveedor.UseVisualStyleBackColor = false;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDireccion.Location = new System.Drawing.Point(104, 97);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(374, 15);
            this.tbDireccion.TabIndex = 47;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(24, 97);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 14);
            this.lblDireccion.TabIndex = 46;
            this.lblDireccion.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Proveedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(427, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 14);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(484, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 22);
            this.dtpFecha.TabIndex = 44;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.panel1.ResumeLayout(false);
            this.gbPie.ResumeLayout(false);
            this.gbPie.PerformLayout();
            this.gbDetalleCompra.ResumeLayout(false);
            this.gbDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetComp)).EndInit();
            this.gbFacturaCompra.ResumeLayout(false);
            this.gbFacturaCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFacturaCompra;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbDetalleCompra;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDetComp;
        private System.Windows.Forms.GroupBox gbPie;
        private System.Windows.Forms.TextBox tbTotalIVA;
        private System.Windows.Forms.Label lblDescripcionPie;
        private System.Windows.Forms.Label lblTotalIva;
        private System.Windows.Forms.TextBox tbTotalFact;
        private System.Windows.Forms.Label lblImpTotal;
        private System.Windows.Forms.Button btnSelProd;
        public System.Windows.Forms.TextBox tbImporteCompra;
        public System.Windows.Forms.TextBox tbIVACompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbSubtotalIVA;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbProducto;
        public System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        public System.Windows.Forms.TextBox tbIDprod;
        private System.Windows.Forms.Button btnBuscaProveedor;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbCuit;
        public System.Windows.Forms.TextBox tbProveedor;
    }
}