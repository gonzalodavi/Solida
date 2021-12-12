namespace Presentacion
{
    partial class FormGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuarios));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEliminarUser = new FontAwesome.Sharp.IconButton();
            this.btnModificarUser = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorRol = new System.Windows.Forms.Label();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.lblNuevoOModUser = new System.Windows.Forms.Label();
            this.lblSeleDom = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.Controls.Add(this.btnEliminarUser);
            this.panelContenedor.Controls.Add(this.btnModificarUser);
            this.panelContenedor.Controls.Add(this.btnNuevo);
            this.panelContenedor.Controls.Add(this.lblErrorMail);
            this.panelContenedor.Controls.Add(this.lblErrorApellido);
            this.panelContenedor.Controls.Add(this.lblErrorNombre);
            this.panelContenedor.Controls.Add(this.lblErrorRol);
            this.panelContenedor.Controls.Add(this.lblErrorClave);
            this.panelContenedor.Controls.Add(this.lblErrorUsuario);
            this.panelContenedor.Controls.Add(this.btnRegresar);
            this.panelContenedor.Controls.Add(this.lblNuevoOModUser);
            this.panelContenedor.Controls.Add(this.lblSeleDom);
            this.panelContenedor.Controls.Add(this.dgvUsuarios);
            this.panelContenedor.Controls.Add(this.label13);
            this.panelContenedor.Controls.Add(this.label9);
            this.panelContenedor.Controls.Add(this.label7);
            this.panelContenedor.Controls.Add(this.label6);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label24);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.label11);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.label5);
            this.panelContenedor.Controls.Add(this.label8);
            this.panelContenedor.Controls.Add(this.label10);
            this.panelContenedor.Controls.Add(this.btnCancela);
            this.panelContenedor.Controls.Add(this.btnAgregarUser);
            this.panelContenedor.Controls.Add(this.cbRoles);
            this.panelContenedor.Controls.Add(this.lblEmail);
            this.panelContenedor.Controls.Add(this.lblRol);
            this.panelContenedor.Controls.Add(this.lblApellido);
            this.panelContenedor.Controls.Add(this.tbEmail);
            this.panelContenedor.Controls.Add(this.tbApellido);
            this.panelContenedor.Controls.Add(this.tbNombre);
            this.panelContenedor.Controls.Add(this.lblNombre);
            this.panelContenedor.Controls.Add(this.tbClave);
            this.panelContenedor.Controls.Add(this.lblClave);
            this.panelContenedor.Controls.Add(this.tbUsuario);
            this.panelContenedor.Controls.Add(this.lblUsuario);
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1026, 749);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUser.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarUser.IconColor = System.Drawing.Color.White;
            this.btnEliminarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUser.IconSize = 25;
            this.btnEliminarUser.Location = new System.Drawing.Point(842, 290);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(116, 31);
            this.btnEliminarUser.TabIndex = 190;
            this.btnEliminarUser.TabStop = false;
            this.btnEliminarUser.Text = "ELIMINAR";
            this.btnEliminarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUser.UseVisualStyleBackColor = false;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnModificarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModificarUser.ForeColor = System.Drawing.Color.White;
            this.btnModificarUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnModificarUser.IconColor = System.Drawing.Color.White;
            this.btnModificarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarUser.IconSize = 25;
            this.btnModificarUser.Location = new System.Drawing.Point(842, 224);
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(116, 31);
            this.btnModificarUser.TabIndex = 189;
            this.btnModificarUser.TabStop = false;
            this.btnModificarUser.Text = "MODIFICAR";
            this.btnModificarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarUser.UseVisualStyleBackColor = false;
            this.btnModificarUser.Click += new System.EventHandler(this.btnModificarUser_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.Location = new System.Drawing.Point(842, 158);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 31);
            this.btnNuevo.TabIndex = 188;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorMail.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorMail.Location = new System.Drawing.Point(527, 640);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(144, 13);
            this.lblErrorMail.TabIndex = 186;
            this.lblErrorMail.Text = "Este Campo es Obligatorio";
            this.lblErrorMail.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorApellido.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorApellido.Location = new System.Drawing.Point(527, 582);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(144, 13);
            this.lblErrorApellido.TabIndex = 185;
            this.lblErrorApellido.Text = "Este Campo es Obligatorio";
            this.lblErrorApellido.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorNombre.Location = new System.Drawing.Point(527, 525);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(144, 13);
            this.lblErrorNombre.TabIndex = 184;
            this.lblErrorNombre.Text = "Este Campo es Obligatorio";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorRol
            // 
            this.lblErrorRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorRol.AutoSize = true;
            this.lblErrorRol.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorRol.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorRol.Location = new System.Drawing.Point(152, 639);
            this.lblErrorRol.Name = "lblErrorRol";
            this.lblErrorRol.Size = new System.Drawing.Size(98, 13);
            this.lblErrorRol.TabIndex = 183;
            this.lblErrorRol.Text = "Seleccione un Rol";
            this.lblErrorRol.Visible = false;
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorClave.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorClave.Location = new System.Drawing.Point(152, 582);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(144, 13);
            this.lblErrorClave.TabIndex = 182;
            this.lblErrorClave.Text = "Este Campo es Obligatorio";
            this.lblErrorClave.Visible = false;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorUsuario.Location = new System.Drawing.Point(152, 525);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(144, 13);
            this.lblErrorUsuario.TabIndex = 181;
            this.lblErrorUsuario.Text = "Este Campo es Obligatorio";
            this.lblErrorUsuario.Visible = false;
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
            this.btnRegresar.Location = new System.Drawing.Point(842, 22);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 180;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblNuevoOModUser
            // 
            this.lblNuevoOModUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevoOModUser.AutoEllipsis = true;
            this.lblNuevoOModUser.AutoSize = true;
            this.lblNuevoOModUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevoOModUser.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblNuevoOModUser.Location = new System.Drawing.Point(50, 452);
            this.lblNuevoOModUser.Name = "lblNuevoOModUser";
            this.lblNuevoOModUser.Size = new System.Drawing.Size(124, 21);
            this.lblNuevoOModUser.TabIndex = 179;
            this.lblNuevoOModUser.Text = "Nuevo Usuario";
            this.lblNuevoOModUser.Visible = false;
            // 
            // lblSeleDom
            // 
            this.lblSeleDom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeleDom.AutoEllipsis = true;
            this.lblSeleDom.AutoSize = true;
            this.lblSeleDom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeleDom.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSeleDom.Location = new System.Drawing.Point(50, 63);
            this.lblSeleDom.Name = "lblSeleDom";
            this.lblSeleDom.Size = new System.Drawing.Size(138, 21);
            this.lblSeleDom.TabIndex = 178;
            this.lblSeleDom.Text = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.ColumnHeadersVisible = false;
            this.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(54, 118);
            this.dgvUsuarios.MaximumSize = new System.Drawing.Size(900, 700);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(725, 302);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(53, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(727, 307);
            this.label13.TabIndex = 177;
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(756, 612);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 175;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(756, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 174;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(756, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 173;
            this.label6.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(381, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 172;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(381, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 171;
            this.label2.Text = "*";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.Yellow;
            this.label24.Location = new System.Drawing.Point(381, 497);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 20);
            this.label24.TabIndex = 170;
            this.label24.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(351, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 169;
            this.label1.Text = "(*) Campos Obligatorios";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoEllipsis = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(564, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 18);
            this.label11.TabIndex = 145;
            this.label11.Text = "MAIL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(438, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 141;
            this.label4.Text = "ROL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(310, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 142;
            this.label5.Text = "APELLIDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(53, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 143;
            this.label8.Text = "USUARIO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(176, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 144;
            this.label10.Text = "NOMBRE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancela
            // 
            this.btnCancela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancela.Enabled = false;
            this.btnCancela.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancela.ForeColor = System.Drawing.Color.White;
            this.btnCancela.Location = new System.Drawing.Point(842, 580);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(116, 31);
            this.btnCancela.TabIndex = 69;
            this.btnCancela.TabStop = false;
            this.btnCancela.Text = "CANCELAR";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAgregarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUser.Enabled = false;
            this.btnAgregarUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUser.Location = new System.Drawing.Point(842, 516);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(116, 31);
            this.btnAgregarUser.TabIndex = 0;
            this.btnAgregarUser.TabStop = false;
            this.btnAgregarUser.Text = "ACEPTAR";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // cbRoles
            // 
            this.cbRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRoles.Enabled = false;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbRoles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(155, 611);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(220, 25);
            this.cbRoles.TabIndex = 3;
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            this.cbRoles.Leave += new System.EventHandler(this.cbRoles_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(478, 614);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRol.Location = new System.Drawing.Point(117, 614);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 17);
            this.lblRol.TabIndex = 28;
            this.lblRol.Text = "Rol:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(460, 556);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 17);
            this.lblApellido.TabIndex = 27;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEmail.Location = new System.Drawing.Point(530, 612);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(220, 25);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellido.Enabled = false;
            this.tbApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbApellido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbApellido.Location = new System.Drawing.Point(530, 554);
            this.tbApellido.MaxLength = 50;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(220, 25);
            this.tbApellido.TabIndex = 5;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            this.tbApellido.Leave += new System.EventHandler(this.tbApellido_Leave);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNombre.Location = new System.Drawing.Point(530, 497);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(220, 25);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(462, 499);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbClave
            // 
            this.tbClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClave.Enabled = false;
            this.tbClave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbClave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbClave.Location = new System.Drawing.Point(155, 554);
            this.tbClave.MaxLength = 20;
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(220, 25);
            this.tbClave.TabIndex = 2;
            this.tbClave.UseSystemPasswordChar = true;
            this.tbClave.TextChanged += new System.EventHandler(this.tbClave_TextChanged);
            this.tbClave.Leave += new System.EventHandler(this.tbClave_Leave);
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClave.Location = new System.Drawing.Point(104, 556);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(45, 17);
            this.lblClave.TabIndex = 20;
            this.lblClave.Text = "Clave:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbUsuario.Location = new System.Drawing.Point(155, 497);
            this.tbUsuario.MaxLength = 20;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(220, 25);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(90, 499);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 17);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(358, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 25);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "MANTENIMIENTO DE USUARIOS";
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panelContenedor);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionUsuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormGestionUsuarios_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNuevoOModUser;
        private System.Windows.Forms.Label lblSeleDom;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorRol;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.Label lblErrorUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUser;
        private FontAwesome.Sharp.IconButton btnModificarUser;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}