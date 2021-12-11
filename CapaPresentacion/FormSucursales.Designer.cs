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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSucursales));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbNuevaSucursal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegistrarSucursal = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMod = new FontAwesome.Sharp.IconButton();
            this.btnNueva = new FontAwesome.Sharp.IconButton();
            this.btnElim = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(121, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 25);
            this.lblTitulo.TabIndex = 88;
            this.lblTitulo.Text = "SUCURSALES";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AllowUserToAddRows = false;
            this.dgvSucursal.AllowUserToDeleteRows = false;
            this.dgvSucursal.AllowUserToResizeColumns = false;
            this.dgvSucursal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvSucursal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSucursal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSucursal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSucursal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSucursal.ColumnHeadersVisible = false;
            this.dgvSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSucursal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSucursal.EnableHeadersVisualStyles = false;
            this.dgvSucursal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvSucursal.Location = new System.Drawing.Point(41, 102);
            this.dgvSucursal.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.ReadOnly = true;
            this.dgvSucursal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSucursal.RowHeadersVisible = false;
            this.dgvSucursal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSucursal.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursal.Size = new System.Drawing.Size(103, 137);
            this.dgvSucursal.TabIndex = 208;
            this.dgvSucursal.TabStop = false;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSucursal.AutoEllipsis = true;
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSucursal.Location = new System.Drawing.Point(48, 367);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(92, 17);
            this.lblSucursal.TabIndex = 209;
            this.lblSucursal.Text = "Nº SUCURSAL";
            // 
            // tbNuevaSucursal
            // 
            this.tbNuevaSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNuevaSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNuevaSucursal.Enabled = false;
            this.tbNuevaSucursal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNuevaSucursal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNuevaSucursal.Location = new System.Drawing.Point(41, 387);
            this.tbNuevaSucursal.Name = "tbNuevaSucursal";
            this.tbNuevaSucursal.Size = new System.Drawing.Size(104, 25);
            this.tbNuevaSucursal.TabIndex = 207;
            this.tbNuevaSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNuevaSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevaSucursal_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(40, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 212;
            this.label13.Text = "NOMBRE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrarSucursal
            // 
            this.btnRegistrarSucursal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRegistrarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarSucursal.Enabled = false;
            this.btnRegistrarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSucursal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSucursal.Location = new System.Drawing.Point(213, 349);
            this.btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            this.btnRegistrarSucursal.Size = new System.Drawing.Size(116, 31);
            this.btnRegistrarSucursal.TabIndex = 216;
            this.btnRegistrarSucursal.TabStop = false;
            this.btnRegistrarSucursal.Text = "ACEPTAR";
            this.btnRegistrarSucursal.UseVisualStyleBackColor = false;
            this.btnRegistrarSucursal.Click += new System.EventHandler(this.btnRegistrarSucursal_Click);
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
            this.btnCancela.Location = new System.Drawing.Point(213, 407);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(116, 31);
            this.btnCancela.TabIndex = 217;
            this.btnCancela.TabStop = false;
            this.btnCancela.Text = "CANCELAR";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitulo.AutoEllipsis = true;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 297);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(0, 21);
            this.lblSubtitulo.TabIndex = 219;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSalir.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 26;
            this.btnSalir.Location = new System.Drawing.Point(342, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 26);
            this.btnSalir.TabIndex = 220;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 140);
            this.label1.TabIndex = 221;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMod
            // 
            this.btnMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnMod.IconColor = System.Drawing.Color.White;
            this.btnMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMod.IconSize = 25;
            this.btnMod.Location = new System.Drawing.Point(213, 145);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(116, 31);
            this.btnMod.TabIndex = 223;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNueva.IconColor = System.Drawing.Color.White;
            this.btnNueva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNueva.IconSize = 25;
            this.btnNueva.Location = new System.Drawing.Point(213, 83);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(116, 31);
            this.btnNueva.TabIndex = 222;
            this.btnNueva.TabStop = false;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnElim
            // 
            this.btnElim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnElim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElim.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnElim.ForeColor = System.Drawing.Color.White;
            this.btnElim.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnElim.IconColor = System.Drawing.Color.White;
            this.btnElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnElim.IconSize = 25;
            this.btnElim.Location = new System.Drawing.Point(213, 208);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(116, 31);
            this.btnElim.TabIndex = 224;
            this.btnElim.TabStop = false;
            this.btnElim.Text = "ELIMINAR";
            this.btnElim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // FormSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(367, 483);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnRegistrarSucursal);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbNuevaSucursal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSucursales";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbNuevaSucursal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRegistrarSucursal;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lblSubtitulo;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMod;
        private FontAwesome.Sharp.IconButton btnNueva;
        private FontAwesome.Sharp.IconButton btnElim;
    }
}