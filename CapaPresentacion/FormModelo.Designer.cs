namespace CapaPresentacion
{
    partial class FormModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptaModelo = new System.Windows.Forms.Button();
            this.btnCancelaModelo = new System.Windows.Forms.Button();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminaModelo = new FontAwesome.Sharp.IconButton();
            this.btnModModelo = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(125, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 21);
            this.lblTitulo.TabIndex = 177;
            this.lblTitulo.Text = "Mantenimiento de Modelos";
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
            this.btnSalir.Location = new System.Drawing.Point(467, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 26);
            this.btnSalir.TabIndex = 178;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvModelo
            // 
            this.dgvModelo.AllowUserToAddRows = false;
            this.dgvModelo.AllowUserToDeleteRows = false;
            this.dgvModelo.AllowUserToResizeColumns = false;
            this.dgvModelo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvModelo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvModelo.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModelo.EnableHeadersVisualStyles = false;
            this.dgvModelo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvModelo.Location = new System.Drawing.Point(38, 110);
            this.dgvModelo.MaximumSize = new System.Drawing.Size(650, 350);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.ReadOnly = true;
            this.dgvModelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvModelo.RowHeadersVisible = false;
            this.dgvModelo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvModelo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelo.Size = new System.Drawing.Size(284, 250);
            this.dgvModelo.TabIndex = 179;
            this.dgvModelo.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(37, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 180;
            this.label4.Text = "CODIGO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(117, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 18);
            this.label10.TabIndex = 181;
            this.label10.Text = "NOMBRE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAceptaModelo
            // 
            this.btnAceptaModelo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptaModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAceptaModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptaModelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptaModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptaModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptaModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptaModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptaModelo.ForeColor = System.Drawing.Color.White;
            this.btnAceptaModelo.Location = new System.Drawing.Point(352, 417);
            this.btnAceptaModelo.Name = "btnAceptaModelo";
            this.btnAceptaModelo.Size = new System.Drawing.Size(116, 31);
            this.btnAceptaModelo.TabIndex = 186;
            this.btnAceptaModelo.TabStop = false;
            this.btnAceptaModelo.Text = "ACEPTAR";
            this.btnAceptaModelo.UseVisualStyleBackColor = false;
            this.btnAceptaModelo.Click += new System.EventHandler(this.btnAceptaModelo_Click);
            // 
            // btnCancelaModelo
            // 
            this.btnCancelaModelo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelaModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancelaModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaModelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelaModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelaModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancelaModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelaModelo.ForeColor = System.Drawing.Color.White;
            this.btnCancelaModelo.Location = new System.Drawing.Point(352, 474);
            this.btnCancelaModelo.Name = "btnCancelaModelo";
            this.btnCancelaModelo.Size = new System.Drawing.Size(116, 31);
            this.btnCancelaModelo.TabIndex = 187;
            this.btnCancelaModelo.TabStop = false;
            this.btnCancelaModelo.Text = "CANCELAR";
            this.btnCancelaModelo.UseVisualStyleBackColor = false;
            this.btnCancelaModelo.Click += new System.EventHandler(this.btnCancelaModelo_Click);
            // 
            // tbModelo
            // 
            this.tbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModelo.Enabled = false;
            this.tbModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbModelo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbModelo.Location = new System.Drawing.Point(38, 421);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(284, 25);
            this.tbModelo.TabIndex = 185;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModelo.AutoEllipsis = true;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblModelo.Location = new System.Drawing.Point(33, 387);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 21);
            this.lblModelo.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 255);
            this.label1.TabIndex = 189;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminaModelo
            // 
            this.btnEliminaModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminaModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminaModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaModelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminaModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminaModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminaModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminaModelo.ForeColor = System.Drawing.Color.White;
            this.btnEliminaModelo.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminaModelo.IconColor = System.Drawing.Color.White;
            this.btnEliminaModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminaModelo.IconSize = 25;
            this.btnEliminaModelo.Location = new System.Drawing.Point(352, 223);
            this.btnEliminaModelo.Name = "btnEliminaModelo";
            this.btnEliminaModelo.Size = new System.Drawing.Size(116, 31);
            this.btnEliminaModelo.TabIndex = 192;
            this.btnEliminaModelo.TabStop = false;
            this.btnEliminaModelo.Text = "ELIMINAR";
            this.btnEliminaModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminaModelo.UseVisualStyleBackColor = false;
            this.btnEliminaModelo.Click += new System.EventHandler(this.btnElimiarDom_Click);
            // 
            // btnModModelo
            // 
            this.btnModModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnModModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModModelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModModelo.ForeColor = System.Drawing.Color.White;
            this.btnModModelo.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnModModelo.IconColor = System.Drawing.Color.White;
            this.btnModModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModModelo.IconSize = 25;
            this.btnModModelo.Location = new System.Drawing.Point(352, 161);
            this.btnModModelo.Name = "btnModModelo";
            this.btnModModelo.Size = new System.Drawing.Size(116, 31);
            this.btnModModelo.TabIndex = 191;
            this.btnModModelo.TabStop = false;
            this.btnModModelo.Text = "MODIFICAR";
            this.btnModModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModModelo.UseVisualStyleBackColor = false;
            this.btnModModelo.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.Location = new System.Drawing.Point(352, 100);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 31);
            this.btnNuevo.TabIndex = 190;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(490, 539);
            this.Controls.Add(this.btnModModelo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptaModelo);
            this.Controls.Add(this.btnCancelaModelo);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvModelo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminaModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModelo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAceptaModelo;
        private System.Windows.Forms.Button btnCancelaModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEliminaModelo;
        private FontAwesome.Sharp.IconButton btnModModelo;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}