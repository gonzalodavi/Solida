namespace Presentacion
{
    partial class FormularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panelArriba = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnRestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuAjustes = new System.Windows.Forms.Panel();
            this.btnConfSucursal = new FontAwesome.Sharp.IconButton();
            this.btnSesionesUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnAdminUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnAjustes = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuInformes = new System.Windows.Forms.Panel();
            this.btnInfCtasCtes = new FontAwesome.Sharp.IconButton();
            this.btnInfStock = new FontAwesome.Sharp.IconButton();
            this.btnInfCompras = new FontAwesome.Sharp.IconButton();
            this.btnInfVtas = new FontAwesome.Sharp.IconButton();
            this.btnInfCheques = new FontAwesome.Sharp.IconButton();
            this.btnInfBanco = new FontAwesome.Sharp.IconButton();
            this.btnInfCaja = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuCompras = new System.Windows.Forms.Panel();
            this.btnTablas = new FontAwesome.Sharp.IconButton();
            this.btnRemitos = new FontAwesome.Sharp.IconButton();
            this.btnOPago = new FontAwesome.Sharp.IconButton();
            this.btnFactCompra = new FontAwesome.Sharp.IconButton();
            this.btnProductosP = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuVentas = new System.Windows.Forms.Panel();
            this.btnNotaCred = new FontAwesome.Sharp.IconButton();
            this.btnRecibos = new FontAwesome.Sharp.IconButton();
            this.btnFacturacion = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelFechaHora = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnEditarPerfil = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuAjustes.SuspendLayout();
            this.panelSubMenuInformes.SuspendLayout();
            this.panelSubMenuCompras.SuspendLayout();
            this.panelSubMenuVentas.SuspendLayout();
            this.panelFechaHora.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelArriba
            // 
            this.panelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelArriba.Controls.Add(this.lblTitulo);
            this.panelArriba.Controls.Add(this.btnMinimizar);
            this.panelArriba.Controls.Add(this.btnRestaurar);
            this.panelArriba.Controls.Add(this.btnMaximizar);
            this.panelArriba.Controls.Add(this.btnSalir);
            this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(1280, 27);
            this.panelArriba.TabIndex = 0;
            this.panelArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelArriba_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "SOLIDA";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 27;
            this.btnMinimizar.Location = new System.Drawing.Point(1164, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(1);
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.White;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 27;
            this.btnRestaurar.Location = new System.Drawing.Point(1193, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(1);
            this.btnRestaurar.Size = new System.Drawing.Size(29, 27);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 27;
            this.btnMaximizar.Location = new System.Drawing.Point(1222, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Padding = new System.Windows.Forms.Padding(1);
            this.btnMaximizar.Size = new System.Drawing.Size(29, 27);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 27;
            this.btnSalir.Location = new System.Drawing.Point(1251, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(1);
            this.btnSalir.Size = new System.Drawing.Size(29, 27);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.panelMenu);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 27);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(230, 773);
            this.panelLateral.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelMenuLateral);
            this.panelMenu.Controls.Add(this.panelFechaHora);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 120);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 653);
            this.panelMenu.TabIndex = 1;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.Controls.Add(this.panelSubMenuAjustes);
            this.panelMenuLateral.Controls.Add(this.btnAjustes);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuInformes);
            this.panelMenuLateral.Controls.Add(this.btnInformes);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuCompras);
            this.panelMenuLateral.Controls.Add(this.btnCompras);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuVentas);
            this.panelMenuLateral.Controls.Add(this.btnVentas);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(230, 582);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // panelSubMenuAjustes
            // 
            this.panelSubMenuAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panelSubMenuAjustes.Controls.Add(this.btnConfSucursal);
            this.panelSubMenuAjustes.Controls.Add(this.btnSesionesUsuarios);
            this.panelSubMenuAjustes.Controls.Add(this.btnAdminUsuarios);
            this.panelSubMenuAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAjustes.Location = new System.Drawing.Point(0, 970);
            this.panelSubMenuAjustes.Name = "panelSubMenuAjustes";
            this.panelSubMenuAjustes.Size = new System.Drawing.Size(213, 125);
            this.panelSubMenuAjustes.TabIndex = 5;
            // 
            // btnConfSucursal
            // 
            this.btnConfSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfSucursal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfSucursal.FlatAppearance.BorderSize = 0;
            this.btnConfSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnConfSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfSucursal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfSucursal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfSucursal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfSucursal.IconColor = System.Drawing.Color.Black;
            this.btnConfSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfSucursal.Location = new System.Drawing.Point(0, 80);
            this.btnConfSucursal.Name = "btnConfSucursal";
            this.btnConfSucursal.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfSucursal.Size = new System.Drawing.Size(213, 40);
            this.btnConfSucursal.TabIndex = 2;
            this.btnConfSucursal.TabStop = false;
            this.btnConfSucursal.Text = "CONFIGURAR SUCURSAL Y DATOS EMPRESA";
            this.btnConfSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfSucursal.UseVisualStyleBackColor = true;
            this.btnConfSucursal.Click += new System.EventHandler(this.btnConfSucursal_Click);
            // 
            // btnSesionesUsuarios
            // 
            this.btnSesionesUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesionesUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSesionesUsuarios.FlatAppearance.BorderSize = 0;
            this.btnSesionesUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnSesionesUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesionesUsuarios.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesionesUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSesionesUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSesionesUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnSesionesUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSesionesUsuarios.Location = new System.Drawing.Point(0, 40);
            this.btnSesionesUsuarios.Name = "btnSesionesUsuarios";
            this.btnSesionesUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSesionesUsuarios.Size = new System.Drawing.Size(213, 40);
            this.btnSesionesUsuarios.TabIndex = 1;
            this.btnSesionesUsuarios.TabStop = false;
            this.btnSesionesUsuarios.Text = "HISTORIAL DE SESIONES ";
            this.btnSesionesUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesionesUsuarios.UseVisualStyleBackColor = true;
            this.btnSesionesUsuarios.Click += new System.EventHandler(this.btnSesionesUsuarios_Click);
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdminUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnAdminUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdminUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdminUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnAdminUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminUsuarios.Size = new System.Drawing.Size(213, 40);
            this.btnAdminUsuarios.TabIndex = 0;
            this.btnAdminUsuarios.TabStop = false;
            this.btnAdminUsuarios.Text = "GESTION DE USUARIOS";
            this.btnAdminUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            this.btnAdminUsuarios.Click += new System.EventHandler(this.btnAdminUsuarios_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnAjustes.IconColor = System.Drawing.Color.White;
            this.btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjustes.IconSize = 40;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Location = new System.Drawing.Point(0, 910);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAjustes.Size = new System.Drawing.Size(213, 60);
            this.btnAjustes.TabIndex = 0;
            this.btnAjustes.TabStop = false;
            this.btnAjustes.Text = "AJUSTES";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // panelSubMenuInformes
            // 
            this.panelSubMenuInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panelSubMenuInformes.Controls.Add(this.btnInfCtasCtes);
            this.panelSubMenuInformes.Controls.Add(this.btnInfStock);
            this.panelSubMenuInformes.Controls.Add(this.btnInfCompras);
            this.panelSubMenuInformes.Controls.Add(this.btnInfVtas);
            this.panelSubMenuInformes.Controls.Add(this.btnInfCheques);
            this.panelSubMenuInformes.Controls.Add(this.btnInfBanco);
            this.panelSubMenuInformes.Controls.Add(this.btnInfCaja);
            this.panelSubMenuInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuInformes.Location = new System.Drawing.Point(0, 625);
            this.panelSubMenuInformes.Name = "panelSubMenuInformes";
            this.panelSubMenuInformes.Size = new System.Drawing.Size(213, 285);
            this.panelSubMenuInformes.TabIndex = 4;
            // 
            // btnInfCtasCtes
            // 
            this.btnInfCtasCtes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfCtasCtes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfCtasCtes.FlatAppearance.BorderSize = 0;
            this.btnInfCtasCtes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfCtasCtes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfCtasCtes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfCtasCtes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfCtasCtes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfCtasCtes.IconColor = System.Drawing.Color.Black;
            this.btnInfCtasCtes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfCtasCtes.Location = new System.Drawing.Point(0, 240);
            this.btnInfCtasCtes.Name = "btnInfCtasCtes";
            this.btnInfCtasCtes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfCtasCtes.Size = new System.Drawing.Size(213, 40);
            this.btnInfCtasCtes.TabIndex = 0;
            this.btnInfCtasCtes.TabStop = false;
            this.btnInfCtasCtes.Text = "INFORME CUENTAS CORRIENTES";
            this.btnInfCtasCtes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfCtasCtes.UseVisualStyleBackColor = true;
            this.btnInfCtasCtes.Click += new System.EventHandler(this.btnInfCtasCtes_Click);
            // 
            // btnInfStock
            // 
            this.btnInfStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfStock.Enabled = false;
            this.btnInfStock.FlatAppearance.BorderSize = 0;
            this.btnInfStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfStock.IconColor = System.Drawing.Color.Black;
            this.btnInfStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfStock.Location = new System.Drawing.Point(0, 200);
            this.btnInfStock.Name = "btnInfStock";
            this.btnInfStock.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfStock.Size = new System.Drawing.Size(213, 40);
            this.btnInfStock.TabIndex = 0;
            this.btnInfStock.TabStop = false;
            this.btnInfStock.Text = "INFORME DE STOCK PRODUCTOS";
            this.btnInfStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfStock.UseVisualStyleBackColor = true;
            this.btnInfStock.Click += new System.EventHandler(this.btnInfStock_Click);
            // 
            // btnInfCompras
            // 
            this.btnInfCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfCompras.FlatAppearance.BorderSize = 0;
            this.btnInfCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfCompras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfCompras.IconColor = System.Drawing.Color.Black;
            this.btnInfCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfCompras.Location = new System.Drawing.Point(0, 160);
            this.btnInfCompras.Name = "btnInfCompras";
            this.btnInfCompras.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfCompras.Size = new System.Drawing.Size(213, 40);
            this.btnInfCompras.TabIndex = 0;
            this.btnInfCompras.TabStop = false;
            this.btnInfCompras.Text = "INFORME COMPRAS";
            this.btnInfCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfCompras.UseVisualStyleBackColor = true;
            this.btnInfCompras.Click += new System.EventHandler(this.btnInfCompras_Click);
            // 
            // btnInfVtas
            // 
            this.btnInfVtas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfVtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfVtas.FlatAppearance.BorderSize = 0;
            this.btnInfVtas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfVtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfVtas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfVtas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfVtas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfVtas.IconColor = System.Drawing.Color.Black;
            this.btnInfVtas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfVtas.Location = new System.Drawing.Point(0, 120);
            this.btnInfVtas.Name = "btnInfVtas";
            this.btnInfVtas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfVtas.Size = new System.Drawing.Size(213, 40);
            this.btnInfVtas.TabIndex = 0;
            this.btnInfVtas.TabStop = false;
            this.btnInfVtas.Text = "INFORME VENTAS";
            this.btnInfVtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfVtas.UseVisualStyleBackColor = true;
            this.btnInfVtas.Click += new System.EventHandler(this.btnInfVtas_Click);
            // 
            // btnInfCheques
            // 
            this.btnInfCheques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfCheques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfCheques.Enabled = false;
            this.btnInfCheques.FlatAppearance.BorderSize = 0;
            this.btnInfCheques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfCheques.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfCheques.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfCheques.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfCheques.IconColor = System.Drawing.Color.Black;
            this.btnInfCheques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfCheques.Location = new System.Drawing.Point(0, 80);
            this.btnInfCheques.Name = "btnInfCheques";
            this.btnInfCheques.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfCheques.Size = new System.Drawing.Size(213, 40);
            this.btnInfCheques.TabIndex = 0;
            this.btnInfCheques.TabStop = false;
            this.btnInfCheques.Text = "INFORME DE VALORES EN CARTERA";
            this.btnInfCheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfCheques.UseVisualStyleBackColor = true;
            this.btnInfCheques.Click += new System.EventHandler(this.btnInfCheques_Click);
            // 
            // btnInfBanco
            // 
            this.btnInfBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfBanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfBanco.Enabled = false;
            this.btnInfBanco.FlatAppearance.BorderSize = 0;
            this.btnInfBanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfBanco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfBanco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfBanco.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfBanco.IconColor = System.Drawing.Color.Black;
            this.btnInfBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfBanco.Location = new System.Drawing.Point(0, 40);
            this.btnInfBanco.Name = "btnInfBanco";
            this.btnInfBanco.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfBanco.Size = new System.Drawing.Size(213, 40);
            this.btnInfBanco.TabIndex = 0;
            this.btnInfBanco.TabStop = false;
            this.btnInfBanco.Text = "INFORME BANCO";
            this.btnInfBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfBanco.UseVisualStyleBackColor = true;
            this.btnInfBanco.Click += new System.EventHandler(this.btnInfBanco_Click);
            // 
            // btnInfCaja
            // 
            this.btnInfCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfCaja.Enabled = false;
            this.btnInfCaja.FlatAppearance.BorderSize = 0;
            this.btnInfCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInfCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfCaja.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInfCaja.IconColor = System.Drawing.Color.Black;
            this.btnInfCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfCaja.Location = new System.Drawing.Point(0, 0);
            this.btnInfCaja.Name = "btnInfCaja";
            this.btnInfCaja.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInfCaja.Size = new System.Drawing.Size(213, 40);
            this.btnInfCaja.TabIndex = 0;
            this.btnInfCaja.TabStop = false;
            this.btnInfCaja.Text = "INFORME CAJA";
            this.btnInfCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfCaja.UseVisualStyleBackColor = true;
            this.btnInfCaja.Click += new System.EventHandler(this.btnInfCaja_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnInformes.IconColor = System.Drawing.Color.White;
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.IconSize = 40;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 565);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInformes.Size = new System.Drawing.Size(213, 60);
            this.btnInformes.TabIndex = 0;
            this.btnInformes.TabStop = false;
            this.btnInformes.Text = "INFORMES";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // panelSubMenuCompras
            // 
            this.panelSubMenuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panelSubMenuCompras.Controls.Add(this.btnTablas);
            this.panelSubMenuCompras.Controls.Add(this.btnRemitos);
            this.panelSubMenuCompras.Controls.Add(this.btnOPago);
            this.panelSubMenuCompras.Controls.Add(this.btnFactCompra);
            this.panelSubMenuCompras.Controls.Add(this.btnProductosP);
            this.panelSubMenuCompras.Controls.Add(this.btnProveedores);
            this.panelSubMenuCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCompras.Location = new System.Drawing.Point(0, 325);
            this.panelSubMenuCompras.Name = "panelSubMenuCompras";
            this.panelSubMenuCompras.Size = new System.Drawing.Size(213, 240);
            this.panelSubMenuCompras.TabIndex = 3;
            // 
            // btnTablas
            // 
            this.btnTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablas.FlatAppearance.BorderSize = 0;
            this.btnTablas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTablas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTablas.IconColor = System.Drawing.Color.Black;
            this.btnTablas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTablas.Location = new System.Drawing.Point(0, 200);
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTablas.Size = new System.Drawing.Size(213, 40);
            this.btnTablas.TabIndex = 1;
            this.btnTablas.TabStop = false;
            this.btnTablas.Text = "MANTENIMIENTO DE TABLAS";
            this.btnTablas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablas.UseVisualStyleBackColor = true;
            this.btnTablas.Click += new System.EventHandler(this.btnRubros_Click);
            // 
            // btnRemitos
            // 
            this.btnRemitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemitos.FlatAppearance.BorderSize = 0;
            this.btnRemitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnRemitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemitos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemitos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemitos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemitos.IconColor = System.Drawing.Color.Black;
            this.btnRemitos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemitos.Location = new System.Drawing.Point(0, 160);
            this.btnRemitos.Name = "btnRemitos";
            this.btnRemitos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRemitos.Size = new System.Drawing.Size(213, 40);
            this.btnRemitos.TabIndex = 0;
            this.btnRemitos.TabStop = false;
            this.btnRemitos.Text = "REMITOS";
            this.btnRemitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemitos.UseVisualStyleBackColor = true;
            this.btnRemitos.Click += new System.EventHandler(this.btnRemitos_Click);
            // 
            // btnOPago
            // 
            this.btnOPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPago.FlatAppearance.BorderSize = 0;
            this.btnOPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnOPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPago.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOPago.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOPago.IconColor = System.Drawing.Color.Black;
            this.btnOPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOPago.Location = new System.Drawing.Point(0, 120);
            this.btnOPago.Name = "btnOPago";
            this.btnOPago.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOPago.Size = new System.Drawing.Size(213, 40);
            this.btnOPago.TabIndex = 0;
            this.btnOPago.TabStop = false;
            this.btnOPago.Text = "ORDEN DE PAGO";
            this.btnOPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOPago.UseVisualStyleBackColor = true;
            this.btnOPago.Click += new System.EventHandler(this.btnOPago_Click);
            // 
            // btnFactCompra
            // 
            this.btnFactCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactCompra.FlatAppearance.BorderSize = 0;
            this.btnFactCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnFactCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactCompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFactCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFactCompra.IconColor = System.Drawing.Color.Black;
            this.btnFactCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFactCompra.Location = new System.Drawing.Point(0, 80);
            this.btnFactCompra.Name = "btnFactCompra";
            this.btnFactCompra.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFactCompra.Size = new System.Drawing.Size(213, 40);
            this.btnFactCompra.TabIndex = 0;
            this.btnFactCompra.TabStop = false;
            this.btnFactCompra.Text = "FACTURAS DE COMPRA";
            this.btnFactCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactCompra.UseVisualStyleBackColor = true;
            this.btnFactCompra.Click += new System.EventHandler(this.btnFactCompra_Click);
            // 
            // btnProductosP
            // 
            this.btnProductosP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosP.FlatAppearance.BorderSize = 0;
            this.btnProductosP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnProductosP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductosP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductosP.IconColor = System.Drawing.Color.Black;
            this.btnProductosP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosP.Location = new System.Drawing.Point(0, 40);
            this.btnProductosP.Name = "btnProductosP";
            this.btnProductosP.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductosP.Size = new System.Drawing.Size(213, 40);
            this.btnProductosP.TabIndex = 0;
            this.btnProductosP.TabStop = false;
            this.btnProductosP.Text = "PRODUCTOS";
            this.btnProductosP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosP.UseVisualStyleBackColor = true;
            this.btnProductosP.Click += new System.EventHandler(this.btnProductosP_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.Location = new System.Drawing.Point(0, 0);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(213, 40);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.TabStop = false;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 40;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 265);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompras.Size = new System.Drawing.Size(213, 60);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.TabStop = false;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelSubMenuVentas
            // 
            this.panelSubMenuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panelSubMenuVentas.Controls.Add(this.btnNotaCred);
            this.panelSubMenuVentas.Controls.Add(this.btnRecibos);
            this.panelSubMenuVentas.Controls.Add(this.btnFacturacion);
            this.panelSubMenuVentas.Controls.Add(this.btnProductos);
            this.panelSubMenuVentas.Controls.Add(this.btnClientes);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 60);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(213, 205);
            this.panelSubMenuVentas.TabIndex = 1;
            // 
            // btnNotaCred
            // 
            this.btnNotaCred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotaCred.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotaCred.FlatAppearance.BorderSize = 0;
            this.btnNotaCred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnNotaCred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaCred.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaCred.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNotaCred.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNotaCred.IconColor = System.Drawing.Color.Black;
            this.btnNotaCred.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotaCred.Location = new System.Drawing.Point(0, 160);
            this.btnNotaCred.Name = "btnNotaCred";
            this.btnNotaCred.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNotaCred.Size = new System.Drawing.Size(213, 40);
            this.btnNotaCred.TabIndex = 0;
            this.btnNotaCred.TabStop = false;
            this.btnNotaCred.Text = "NOTA CRED/DEB";
            this.btnNotaCred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaCred.UseVisualStyleBackColor = true;
            this.btnNotaCred.Click += new System.EventHandler(this.btnNotaCred_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecibos.FlatAppearance.BorderSize = 0;
            this.btnRecibos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecibos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRecibos.IconColor = System.Drawing.Color.Black;
            this.btnRecibos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecibos.Location = new System.Drawing.Point(0, 120);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRecibos.Size = new System.Drawing.Size(213, 40);
            this.btnRecibos.TabIndex = 0;
            this.btnRecibos.TabStop = false;
            this.btnRecibos.Text = "RECIBOS";
            this.btnRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFacturacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFacturacion.IconColor = System.Drawing.Color.Black;
            this.btnFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 80);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(213, 40);
            this.btnFacturacion.TabIndex = 0;
            this.btnFacturacion.TabStop = false;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.Location = new System.Drawing.Point(0, 40);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(213, 40);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.TabStop = false;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(213, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(249)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 40;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(213, 60);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.TabStop = false;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelFechaHora
            // 
            this.panelFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelFechaHora.Controls.Add(this.lblFecha);
            this.panelFechaHora.Controls.Add(this.lblHora);
            this.panelFechaHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFechaHora.Location = new System.Drawing.Point(0, 582);
            this.panelFechaHora.Name = "panelFechaHora";
            this.panelFechaHora.Size = new System.Drawing.Size(230, 71);
            this.panelFechaHora.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblFecha.Location = new System.Drawing.Point(0, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new System.Windows.Forms.Padding(8, 0, 8, 2);
            this.lblFecha.Size = new System.Drawing.Size(230, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Miercoles, 31 de Septiembre de 2021";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHora.Location = new System.Drawing.Point(0, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblHora.Size = new System.Drawing.Size(230, 39);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "10:00 Hs";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.btnCerrarSesion);
            this.panelLogo.Controls.Add(this.btnEditarPerfil);
            this.panelLogo.Controls.Add(this.lblNombre);
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Controls.Add(this.lblRol);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 20;
            this.btnCerrarSesion.Location = new System.Drawing.Point(124, 77);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(90, 38);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditarPerfil.IconColor = System.Drawing.Color.White;
            this.btnEditarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPerfil.IconSize = 20;
            this.btnEditarPerfil.Location = new System.Drawing.Point(18, 77);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(90, 38);
            this.btnEditarPerfil.TabIndex = 0;
            this.btnEditarPerfil.TabStop = false;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblNombre.Location = new System.Drawing.Point(82, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(142, 35);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::CapaPresentacion.Properties.Resources._1;
            this.picLogo.Location = new System.Drawing.Point(8, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(76, 65);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRol.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblRol.Location = new System.Drawing.Point(82, 9);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(142, 27);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "ROL";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(230, 27);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 773);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.s_OSCURO;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1050, 773);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panelArriba.ResumeLayout(false);
            this.panelArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuAjustes.ResumeLayout(false);
            this.panelSubMenuInformes.ResumeLayout(false);
            this.panelSubMenuCompras.ResumeLayout(false);
            this.panelSubMenuVentas.ResumeLayout(false);
            this.panelFechaHora.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArriba;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnRestaurar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnEditarPerfil;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnCompras;
        private System.Windows.Forms.Panel panelSubMenuVentas;
        private FontAwesome.Sharp.IconButton btnNotaCred;
        private FontAwesome.Sharp.IconButton btnRecibos;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnInformes;
        private System.Windows.Forms.Panel panelSubMenuCompras;
        private FontAwesome.Sharp.IconButton btnRemitos;
        private FontAwesome.Sharp.IconButton btnOPago;
        private FontAwesome.Sharp.IconButton btnFactCompra;
        private FontAwesome.Sharp.IconButton btnProductosP;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.Panel panelSubMenuInformes;
        private FontAwesome.Sharp.IconButton btnInfCaja;
        private FontAwesome.Sharp.IconButton btnAjustes;
        private FontAwesome.Sharp.IconButton btnInfCtasCtes;
        private FontAwesome.Sharp.IconButton btnInfStock;
        private FontAwesome.Sharp.IconButton btnInfCompras;
        private FontAwesome.Sharp.IconButton btnInfVtas;
        private FontAwesome.Sharp.IconButton btnInfCheques;
        private FontAwesome.Sharp.IconButton btnInfBanco;
        private System.Windows.Forms.Panel panelSubMenuAjustes;
        private FontAwesome.Sharp.IconButton btnAdminUsuarios;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelFechaHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnSesionesUsuarios;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnTablas;
        private FontAwesome.Sharp.IconButton btnConfSucursal;
    }
}