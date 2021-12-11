namespace CapaPresentacion
{
    partial class FormMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcas));
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptaMarca = new System.Windows.Forms.Button();
            this.btnCancelaMarca = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModMarca = new FontAwesome.Sharp.IconButton();
            this.btnNueva = new FontAwesome.Sharp.IconButton();
            this.btnEliminaMarca = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMarca.Enabled = false;
            this.tbMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbMarca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbMarca.Location = new System.Drawing.Point(32, 426);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(284, 25);
            this.tbMarca.TabIndex = 108;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarca.AutoEllipsis = true;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblMarca.Location = new System.Drawing.Point(28, 384);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 21);
            this.lblMarca.TabIndex = 107;
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.AllowUserToResizeColumns = false;
            this.dgvMarca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarca.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarca.EnableHeadersVisualStyles = false;
            this.dgvMarca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvMarca.Location = new System.Drawing.Point(32, 106);
            this.dgvMarca.MaximumSize = new System.Drawing.Size(650, 350);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMarca.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(284, 250);
            this.dgvMarca.TabIndex = 106;
            this.dgvMarca.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(31, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 168;
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
            this.label10.Location = new System.Drawing.Point(111, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 18);
            this.label10.TabIndex = 169;
            this.label10.Text = "NOMBRE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAceptaMarca
            // 
            this.btnAceptaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAceptaMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptaMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptaMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptaMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptaMarca.ForeColor = System.Drawing.Color.White;
            this.btnAceptaMarca.Location = new System.Drawing.Point(348, 422);
            this.btnAceptaMarca.Name = "btnAceptaMarca";
            this.btnAceptaMarca.Size = new System.Drawing.Size(116, 31);
            this.btnAceptaMarca.TabIndex = 172;
            this.btnAceptaMarca.TabStop = false;
            this.btnAceptaMarca.Text = "ACEPTAR";
            this.btnAceptaMarca.UseVisualStyleBackColor = false;
            this.btnAceptaMarca.Click += new System.EventHandler(this.btnAceptaMarca_Click);
            // 
            // btnCancelaMarca
            // 
            this.btnCancelaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancelaMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelaMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancelaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelaMarca.ForeColor = System.Drawing.Color.White;
            this.btnCancelaMarca.Location = new System.Drawing.Point(348, 480);
            this.btnCancelaMarca.Name = "btnCancelaMarca";
            this.btnCancelaMarca.Size = new System.Drawing.Size(116, 31);
            this.btnCancelaMarca.TabIndex = 173;
            this.btnCancelaMarca.TabStop = false;
            this.btnCancelaMarca.Text = "CANCELAR";
            this.btnCancelaMarca.UseVisualStyleBackColor = false;
            this.btnCancelaMarca.Click += new System.EventHandler(this.btnCancelaMarca_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(135, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 21);
            this.lblTitulo.TabIndex = 175;
            this.lblTitulo.Text = "Mantenimiento de Marcas";
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
            this.btnSalir.TabIndex = 176;
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
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 255);
            this.label1.TabIndex = 185;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModMarca
            // 
            this.btnModMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnModMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModMarca.ForeColor = System.Drawing.Color.White;
            this.btnModMarca.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnModMarca.IconColor = System.Drawing.Color.White;
            this.btnModMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModMarca.IconSize = 25;
            this.btnModMarca.Location = new System.Drawing.Point(348, 165);
            this.btnModMarca.Name = "btnModMarca";
            this.btnModMarca.Size = new System.Drawing.Size(116, 31);
            this.btnModMarca.TabIndex = 194;
            this.btnModMarca.TabStop = false;
            this.btnModMarca.Text = "MODIFICAR";
            this.btnModMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModMarca.UseVisualStyleBackColor = false;
            this.btnModMarca.Click += new System.EventHandler(this.btnModMarca_Click);
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
            this.btnNueva.Location = new System.Drawing.Point(348, 102);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(116, 31);
            this.btnNueva.TabIndex = 193;
            this.btnNueva.TabStop = false;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEliminaMarca
            // 
            this.btnEliminaMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEliminaMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminaMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminaMarca.ForeColor = System.Drawing.Color.White;
            this.btnEliminaMarca.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminaMarca.IconColor = System.Drawing.Color.White;
            this.btnEliminaMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminaMarca.IconSize = 25;
            this.btnEliminaMarca.Location = new System.Drawing.Point(348, 229);
            this.btnEliminaMarca.Name = "btnEliminaMarca";
            this.btnEliminaMarca.Size = new System.Drawing.Size(116, 31);
            this.btnEliminaMarca.TabIndex = 195;
            this.btnEliminaMarca.TabStop = false;
            this.btnEliminaMarca.Text = "ELIMINAR";
            this.btnEliminaMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminaMarca.UseVisualStyleBackColor = false;
            this.btnEliminaMarca.Click += new System.EventHandler(this.btnEliminaMarca_Click);
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(490, 539);
            this.Controls.Add(this.btnModMarca);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnEliminaMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAceptaMarca);
            this.Controls.Add(this.btnCancelaMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMarcas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAceptaMarca;
        private System.Windows.Forms.Button btnCancelaMarca;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnModMarca;
        private FontAwesome.Sharp.IconButton btnNueva;
        private FontAwesome.Sharp.IconButton btnEliminaMarca;
    }
}