namespace CapaPresentacion
{
    partial class FormRubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRubros));
            this.dgvRubros = new System.Windows.Forms.DataGridView();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.btnEliminaRubro = new System.Windows.Forms.Button();
            this.btnModRubro = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.btnAceptaRubro = new System.Windows.Forms.Button();
            this.btnCancelaRubro = new System.Windows.Forms.Button();
            this.tbRubro = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRubros
            // 
            this.dgvRubros.AllowUserToAddRows = false;
            this.dgvRubros.AllowUserToDeleteRows = false;
            this.dgvRubros.AllowUserToResizeColumns = false;
            this.dgvRubros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvRubros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRubros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRubros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvRubros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRubros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRubros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRubros.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRubros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRubros.EnableHeadersVisualStyles = false;
            this.dgvRubros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvRubros.Location = new System.Drawing.Point(26, 97);
            this.dgvRubros.MaximumSize = new System.Drawing.Size(650, 250);
            this.dgvRubros.Name = "dgvRubros";
            this.dgvRubros.ReadOnly = true;
            this.dgvRubros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRubros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRubros.RowHeadersVisible = false;
            this.dgvRubros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRubros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRubros.Size = new System.Drawing.Size(284, 250);
            this.dgvRubros.TabIndex = 156;
            this.dgvRubros.TabStop = false;
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
            this.btnSalir.TabIndex = 155;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminaRubro
            // 
            this.btnEliminaRubro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminaRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminaRubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaRubro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminaRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminaRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminaRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaRubro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminaRubro.ForeColor = System.Drawing.Color.White;
            this.btnEliminaRubro.Location = new System.Drawing.Point(344, 223);
            this.btnEliminaRubro.Name = "btnEliminaRubro";
            this.btnEliminaRubro.Size = new System.Drawing.Size(116, 31);
            this.btnEliminaRubro.TabIndex = 157;
            this.btnEliminaRubro.TabStop = false;
            this.btnEliminaRubro.Text = "ELIMINAR";
            this.btnEliminaRubro.UseVisualStyleBackColor = false;
            this.btnEliminaRubro.Click += new System.EventHandler(this.btnEliminaRubro_Click);
            // 
            // btnModRubro
            // 
            this.btnModRubro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnModRubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModRubro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModRubro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModRubro.ForeColor = System.Drawing.Color.White;
            this.btnModRubro.Location = new System.Drawing.Point(344, 161);
            this.btnModRubro.Name = "btnModRubro";
            this.btnModRubro.Size = new System.Drawing.Size(116, 31);
            this.btnModRubro.TabIndex = 158;
            this.btnModRubro.TabStop = false;
            this.btnModRubro.Text = "MODIFICAR";
            this.btnModRubro.UseVisualStyleBackColor = false;
            this.btnModRubro.Click += new System.EventHandler(this.btnModRubro_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRubro.AutoEllipsis = true;
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRubro.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblRubro.Location = new System.Drawing.Point(22, 383);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(0, 21);
            this.lblRubro.TabIndex = 159;
            // 
            // btnAceptaRubro
            // 
            this.btnAceptaRubro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptaRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAceptaRubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptaRubro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptaRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptaRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptaRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptaRubro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptaRubro.ForeColor = System.Drawing.Color.White;
            this.btnAceptaRubro.Location = new System.Drawing.Point(344, 415);
            this.btnAceptaRubro.Name = "btnAceptaRubro";
            this.btnAceptaRubro.Size = new System.Drawing.Size(116, 31);
            this.btnAceptaRubro.TabIndex = 161;
            this.btnAceptaRubro.TabStop = false;
            this.btnAceptaRubro.Text = "ACEPTAR";
            this.btnAceptaRubro.UseVisualStyleBackColor = false;
            this.btnAceptaRubro.Click += new System.EventHandler(this.btnAceptaRubro_Click);
            // 
            // btnCancelaRubro
            // 
            this.btnCancelaRubro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelaRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancelaRubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaRubro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelaRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelaRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancelaRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaRubro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelaRubro.ForeColor = System.Drawing.Color.White;
            this.btnCancelaRubro.Location = new System.Drawing.Point(344, 478);
            this.btnCancelaRubro.Name = "btnCancelaRubro";
            this.btnCancelaRubro.Size = new System.Drawing.Size(116, 31);
            this.btnCancelaRubro.TabIndex = 162;
            this.btnCancelaRubro.TabStop = false;
            this.btnCancelaRubro.Text = "CANCELAR";
            this.btnCancelaRubro.UseVisualStyleBackColor = false;
            this.btnCancelaRubro.Click += new System.EventHandler(this.btnCancelaRubro_Click);
            // 
            // tbRubro
            // 
            this.tbRubro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRubro.Enabled = false;
            this.tbRubro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbRubro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbRubro.Location = new System.Drawing.Point(26, 421);
            this.tbRubro.Name = "tbRubro";
            this.tbRubro.Size = new System.Drawing.Size(284, 25);
            this.tbRubro.TabIndex = 160;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(344, 97);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 31);
            this.btnNuevo.TabIndex = 164;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(139, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 21);
            this.lblTitulo.TabIndex = 165;
            this.lblTitulo.Text = "Mantenimiento de Rubros";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(25, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 166;
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
            this.label10.Location = new System.Drawing.Point(105, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 18);
            this.label10.TabIndex = 167;
            this.label10.Text = "NOMBRE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 255);
            this.label1.TabIndex = 186;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(490, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptaRubro);
            this.Controls.Add(this.btnCancelaRubro);
            this.Controls.Add(this.tbRubro);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.btnEliminaRubro);
            this.Controls.Add(this.btnModRubro);
            this.Controls.Add(this.dgvRubros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRubros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormRubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.DataGridView dgvRubros;
        private System.Windows.Forms.Button btnEliminaRubro;
        private System.Windows.Forms.Button btnModRubro;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Button btnAceptaRubro;
        private System.Windows.Forms.Button btnCancelaRubro;
        private System.Windows.Forms.TextBox tbRubro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}