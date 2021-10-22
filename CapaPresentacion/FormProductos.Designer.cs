namespace CapaPresentacion
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabConsultaProducto = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnActualizaListaProd = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tabNuevoProducto = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbGanancia = new System.Windows.Forms.TextBox();
            this.lblSubTitutlo = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbAli = new System.Windows.Forms.ComboBox();
            this.tbStockMin = new System.Windows.Forms.TextBox();
            this.tbVenta = new System.Windows.Forms.TextBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblAlicuota = new System.Windows.Forms.Label();
            this.tbCodBarra = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodBar = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabConsultaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabNuevoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Controls.Add(this.btnRegresar);
            this.panelContenedor.Controls.Add(this.tabProductos);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1026, 749);
            this.panelContenedor.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(466, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PRODUCTOS";
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
            this.btnRegresar.Location = new System.Drawing.Point(849, 28);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 84;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tabProductos
            // 
            this.tabProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabProductos.Controls.Add(this.tabConsultaProducto);
            this.tabProductos.Controls.Add(this.tabNuevoProducto);
            this.tabProductos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.HotTrack = true;
            this.tabProductos.Location = new System.Drawing.Point(35, 65);
            this.tabProductos.Multiline = true;
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(956, 607);
            this.tabProductos.TabIndex = 83;
            // 
            // tabConsultaProducto
            // 
            this.tabConsultaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabConsultaProducto.Controls.Add(this.label15);
            this.tabConsultaProducto.Controls.Add(this.label14);
            this.tabConsultaProducto.Controls.Add(this.label13);
            this.tabConsultaProducto.Controls.Add(this.label12);
            this.tabConsultaProducto.Controls.Add(this.label11);
            this.tabConsultaProducto.Controls.Add(this.label9);
            this.tabConsultaProducto.Controls.Add(this.label3);
            this.tabConsultaProducto.Controls.Add(this.label4);
            this.tabConsultaProducto.Controls.Add(this.label10);
            this.tabConsultaProducto.Controls.Add(this.btnActualizaListaProd);
            this.tabConsultaProducto.Controls.Add(this.btnImprimir);
            this.tabConsultaProducto.Controls.Add(this.btnNuevoProducto);
            this.tabConsultaProducto.Controls.Add(this.btnBuscar);
            this.tabConsultaProducto.Controls.Add(this.tbBusca);
            this.tabConsultaProducto.Controls.Add(this.btnEliminar);
            this.tabConsultaProducto.Controls.Add(this.btnModificar);
            this.tabConsultaProducto.Controls.Add(this.lblBuscar);
            this.tabConsultaProducto.Controls.Add(this.dgvProductos);
            this.tabConsultaProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabConsultaProducto.Location = new System.Drawing.Point(4, 25);
            this.tabConsultaProducto.Name = "tabConsultaProducto";
            this.tabConsultaProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaProducto.Size = new System.Drawing.Size(948, 578);
            this.tabConsultaProducto.TabIndex = 0;
            this.tabConsultaProducto.Text = "Consulta";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoEllipsis = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Location = new System.Drawing.Point(810, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 18);
            this.label15.TabIndex = 141;
            this.label15.Text = "MARCA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoEllipsis = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(696, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 140;
            this.label14.Text = "MODELO";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(623, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 139;
            this.label13.Text = "CANT.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(430, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 18);
            this.label12.TabIndex = 138;
            this.label12.Text = "IMPORTE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoEllipsis = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(533, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 137;
            this.label11.Text = "VENTA $";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(299, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 133;
            this.label9.Text = "RUBRO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(430, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 134;
            this.label3.Text = "COSTO $";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 135;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(74, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 18);
            this.label10.TabIndex = 136;
            this.label10.Text = "NOMBRE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnActualizaListaProd
            // 
            this.btnActualizaListaProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizaListaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnActualizaListaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizaListaProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizaListaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizaListaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizaListaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaListaProd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizaListaProd.ForeColor = System.Drawing.Color.White;
            this.btnActualizaListaProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActualizaListaProd.IconColor = System.Drawing.Color.White;
            this.btnActualizaListaProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizaListaProd.IconSize = 5;
            this.btnActualizaListaProd.Location = new System.Drawing.Point(810, 31);
            this.btnActualizaListaProd.Name = "btnActualizaListaProd";
            this.btnActualizaListaProd.Size = new System.Drawing.Size(116, 31);
            this.btnActualizaListaProd.TabIndex = 132;
            this.btnActualizaListaProd.TabStop = false;
            this.btnActualizaListaProd.Text = "ACTUALIZAR";
            this.btnActualizaListaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizaListaProd.UseVisualStyleBackColor = false;
            this.btnActualizaListaProd.Click += new System.EventHandler(this.btnActualizaListaProd_Click);
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
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(810, 531);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 84;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(26, 531);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(116, 31);
            this.btnNuevoProducto.TabIndex = 131;
            this.btnNuevoProducto.TabStop = false;
            this.btnNuevoProducto.Text = "NUEVO";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
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
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(365, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 119;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = " BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBusca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbBusca.Location = new System.Drawing.Point(121, 36);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(221, 22);
            this.tbBusca.TabIndex = 114;
            this.tbBusca.TabStop = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(365, 531);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 31);
            this.btnEliminar.TabIndex = 115;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(197, 531);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 31);
            this.btnModificar.TabIndex = 116;
            this.btnModificar.TabStop = false;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(52, 38);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 16);
            this.lblBuscar.TabIndex = 118;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.ColumnHeadersVisible = false;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvProductos.Location = new System.Drawing.Point(26, 129);
            this.dgvProductos.MaximumSize = new System.Drawing.Size(900, 400);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(900, 386);
            this.dgvProductos.TabIndex = 117;
            this.dgvProductos.TabStop = false;
            this.dgvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentDoubleClick);
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // tabNuevoProducto
            // 
            this.tabNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabNuevoProducto.Controls.Add(this.label22);
            this.tabNuevoProducto.Controls.Add(this.label18);
            this.tabNuevoProducto.Controls.Add(this.label21);
            this.tabNuevoProducto.Controls.Add(this.label19);
            this.tabNuevoProducto.Controls.Add(this.label20);
            this.tabNuevoProducto.Controls.Add(this.label17);
            this.tabNuevoProducto.Controls.Add(this.label16);
            this.tabNuevoProducto.Controls.Add(this.tbStock);
            this.tabNuevoProducto.Controls.Add(this.tbGanancia);
            this.tabNuevoProducto.Controls.Add(this.lblSubTitutlo);
            this.tabNuevoProducto.Controls.Add(this.btnCancela);
            this.tabNuevoProducto.Controls.Add(this.cbModelo);
            this.tabNuevoProducto.Controls.Add(this.cbMarca);
            this.tabNuevoProducto.Controls.Add(this.cbAli);
            this.tabNuevoProducto.Controls.Add(this.tbStockMin);
            this.tabNuevoProducto.Controls.Add(this.tbVenta);
            this.tabNuevoProducto.Controls.Add(this.tbCosto);
            this.tabNuevoProducto.Controls.Add(this.tbID);
            this.tabNuevoProducto.Controls.Add(this.label1);
            this.tabNuevoProducto.Controls.Add(this.label5);
            this.tabNuevoProducto.Controls.Add(this.label6);
            this.tabNuevoProducto.Controls.Add(this.label7);
            this.tabNuevoProducto.Controls.Add(this.lblPrecioCosto);
            this.tabNuevoProducto.Controls.Add(this.lblRubro);
            this.tabNuevoProducto.Controls.Add(this.lblAlicuota);
            this.tabNuevoProducto.Controls.Add(this.tbCodBarra);
            this.tabNuevoProducto.Controls.Add(this.lblMarca);
            this.tabNuevoProducto.Controls.Add(this.lblCodBar);
            this.tabNuevoProducto.Controls.Add(this.lblMail);
            this.tabNuevoProducto.Controls.Add(this.lblModelo);
            this.tabNuevoProducto.Controls.Add(this.tbDescripcion);
            this.tabNuevoProducto.Controls.Add(this.lblDescripcion);
            this.tabNuevoProducto.Controls.Add(this.btAceptar);
            this.tabNuevoProducto.Controls.Add(this.cbRubro);
            this.tabNuevoProducto.Controls.Add(this.label2);
            this.tabNuevoProducto.Controls.Add(this.label8);
            this.tabNuevoProducto.Location = new System.Drawing.Point(4, 25);
            this.tabNuevoProducto.Name = "tabNuevoProducto";
            this.tabNuevoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevoProducto.Size = new System.Drawing.Size(948, 578);
            this.tabNuevoProducto.TabIndex = 1;
            this.tabNuevoProducto.Text = "Mantenimiento";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Yellow;
            this.label22.Location = new System.Drawing.Point(755, 350);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 16);
            this.label22.TabIndex = 138;
            this.label22.Text = "*";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(755, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 16);
            this.label18.TabIndex = 138;
            this.label18.Text = "*";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Yellow;
            this.label21.Location = new System.Drawing.Point(783, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 16);
            this.label21.TabIndex = 138;
            this.label21.Text = "*";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(783, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 16);
            this.label19.TabIndex = 138;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Yellow;
            this.label20.Location = new System.Drawing.Point(755, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 16);
            this.label20.TabIndex = 138;
            this.label20.Text = "*";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(478, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 16);
            this.label17.TabIndex = 138;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(399, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 16);
            this.label16.TabIndex = 137;
            this.label16.Text = "(*) Campos Obligatorios";
            // 
            // tbStock
            // 
            this.tbStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbStock.Location = new System.Drawing.Point(676, 302);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(73, 22);
            this.tbStock.TabIndex = 9;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // tbGanancia
            // 
            this.tbGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGanancia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGanancia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbGanancia.Location = new System.Drawing.Point(676, 207);
            this.tbGanancia.Name = "tbGanancia";
            this.tbGanancia.Size = new System.Drawing.Size(73, 22);
            this.tbGanancia.TabIndex = 8;
            this.tbGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGanancia_KeyPress);
            this.tbGanancia.Leave += new System.EventHandler(this.tbGanancia_Leave);
            // 
            // lblSubTitutlo
            // 
            this.lblSubTitutlo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubTitutlo.AutoEllipsis = true;
            this.lblSubTitutlo.AutoSize = true;
            this.lblSubTitutlo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitutlo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSubTitutlo.Location = new System.Drawing.Point(399, 17);
            this.lblSubTitutlo.Name = "lblSubTitutlo";
            this.lblSubTitutlo.Size = new System.Drawing.Size(183, 16);
            this.lblSubTitutlo.TabIndex = 135;
            this.lblSubTitutlo.Text = "Ingrese Nuevo Producto";
            // 
            // btnCancela
            // 
            this.btnCancela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancela.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.White;
            this.btnCancela.Location = new System.Drawing.Point(516, 465);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(116, 31);
            this.btnCancela.TabIndex = 108;
            this.btnCancela.TabStop = false;
            this.btnCancela.Text = "CANCELAR";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModelo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.ItemHeight = 14;
            this.cbModelo.Location = new System.Drawing.Point(249, 348);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(223, 22);
            this.cbModelo.TabIndex = 5;
            // 
            // cbMarca
            // 
            this.cbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.ItemHeight = 14;
            this.cbMarca.Location = new System.Drawing.Point(249, 302);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(223, 22);
            this.cbMarca.TabIndex = 4;
            // 
            // cbAli
            // 
            this.cbAli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAli.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbAli.FormattingEnabled = true;
            this.cbAli.ItemHeight = 14;
            this.cbAli.Location = new System.Drawing.Point(676, 113);
            this.cbAli.Name = "cbAli";
            this.cbAli.Size = new System.Drawing.Size(73, 22);
            this.cbAli.TabIndex = 6;
            // 
            // tbStockMin
            // 
            this.tbStockMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStockMin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockMin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbStockMin.Location = new System.Drawing.Point(676, 348);
            this.tbStockMin.Name = "tbStockMin";
            this.tbStockMin.Size = new System.Drawing.Size(73, 22);
            this.tbStockMin.TabIndex = 10;
            this.tbStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockMin_KeyPress);
            // 
            // tbVenta
            // 
            this.tbVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVenta.Enabled = false;
            this.tbVenta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbVenta.Location = new System.Drawing.Point(676, 255);
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.Size = new System.Drawing.Size(73, 22);
            this.tbVenta.TabIndex = 0;
            this.tbVenta.TabStop = false;
            // 
            // tbCosto
            // 
            this.tbCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCosto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCosto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCosto.Location = new System.Drawing.Point(676, 160);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(73, 22);
            this.tbCosto.TabIndex = 7;
            this.tbCosto.TextChanged += new System.EventHandler(this.tbCosto_TextChanged);
            this.tbCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCosto_KeyPress);
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbID.Location = new System.Drawing.Point(249, 113);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(73, 22);
            this.tbID.TabIndex = 0;
            this.tbID.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(594, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "Stock Min:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(597, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 133;
            this.label5.Text = "Ganancia:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(621, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 132;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(569, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 14);
            this.label7.TabIndex = 134;
            this.label7.Text = "Precio Venta: $";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioCosto.Location = new System.Drawing.Point(570, 162);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(108, 14);
            this.lblPrecioCosto.TabIndex = 130;
            this.lblPrecioCosto.Text = "Precio Costo: $";
            // 
            // lblRubro
            // 
            this.lblRubro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRubro.Location = new System.Drawing.Point(192, 258);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(51, 14);
            this.lblRubro.TabIndex = 128;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblAlicuota
            // 
            this.lblAlicuota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlicuota.AutoSize = true;
            this.lblAlicuota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlicuota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAlicuota.Location = new System.Drawing.Point(605, 116);
            this.lblAlicuota.Name = "lblAlicuota";
            this.lblAlicuota.Size = new System.Drawing.Size(65, 14);
            this.lblAlicuota.TabIndex = 129;
            this.lblAlicuota.Text = "Alicuota:";
            // 
            // tbCodBarra
            // 
            this.tbCodBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodBarra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodBarra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCodBarra.Location = new System.Drawing.Point(249, 207);
            this.tbCodBarra.Name = "tbCodBarra";
            this.tbCodBarra.Size = new System.Drawing.Size(223, 22);
            this.tbCodBarra.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(191, 305);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 14);
            this.lblMarca.TabIndex = 110;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodBar
            // 
            this.lblCodBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodBar.AutoSize = true;
            this.lblCodBar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodBar.Location = new System.Drawing.Point(145, 211);
            this.lblCodBar.Name = "lblCodBar";
            this.lblCodBar.Size = new System.Drawing.Size(98, 14);
            this.lblCodBar.TabIndex = 109;
            this.lblCodBar.Text = "Codigo Barra:";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblMail.Location = new System.Drawing.Point(214, 115);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 16);
            this.lblMail.TabIndex = 114;
            this.lblMail.Text = "ID:";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Location = new System.Drawing.Point(184, 351);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 14);
            this.lblModelo.TabIndex = 116;
            this.lblModelo.Text = "Modelo:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDescripcion.Location = new System.Drawing.Point(249, 160);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(223, 22);
            this.tbDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescripcion.Location = new System.Drawing.Point(154, 163);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 14);
            this.lblDescripcion.TabIndex = 112;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.White;
            this.btAceptar.Location = new System.Drawing.Point(356, 465);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(116, 31);
            this.btAceptar.TabIndex = 121;
            this.btAceptar.TabStop = false;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // cbRubro
            // 
            this.cbRubro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRubro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.ItemHeight = 14;
            this.cbRubro.Location = new System.Drawing.Point(249, 255);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(223, 22);
            this.cbRubro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(755, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 136;
            this.label2.Text = "%";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(755, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 14);
            this.label8.TabIndex = 136;
            this.label8.Text = "%";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.tabConsultaProducto.ResumeLayout(false);
            this.tabConsultaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabNuevoProducto.ResumeLayout(false);
            this.tabNuevoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabConsultaProducto;
        private System.Windows.Forms.TabPage tabNuevoProducto;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbGanancia;
        private System.Windows.Forms.Label lblSubTitutlo;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbAli;
        private System.Windows.Forms.TextBox tbStockMin;
        private System.Windows.Forms.TextBox tbVenta;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblAlicuota;
        private System.Windows.Forms.TextBox tbCodBarra;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodBar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Button btnNuevoProducto;
        private FontAwesome.Sharp.IconButton btnActualizaListaProd;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
    }
}