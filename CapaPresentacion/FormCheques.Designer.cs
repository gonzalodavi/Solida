namespace CapaPresentacion
{
    partial class FormCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheques));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbCantidadCheques = new System.Windows.Forms.TextBox();
            this.tbTotalCheques = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lblFecha2);
            this.panelContenedor.Controls.Add(this.dgvCheques);
            this.panelContenedor.Controls.Add(this.label10);
            this.panelContenedor.Controls.Add(this.label8);
            this.panelContenedor.Controls.Add(this.label5);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label28);
            this.panelContenedor.Controls.Add(this.btnImprimir);
            this.panelContenedor.Controls.Add(this.tbTotalCheques);
            this.panelContenedor.Controls.Add(this.gunaLabel2);
            this.panelContenedor.Controls.Add(this.tbCantidadCheques);
            this.panelContenedor.Controls.Add(this.gunaLabel1);
            this.panelContenedor.Controls.Add(this.btnRegresar);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.label9);
            this.panelContenedor.Controls.Add(this.label7);
            this.panelContenedor.Controls.Add(this.label6);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.label12);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1026, 749);
            this.panelContenedor.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(493, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 82;
            this.label12.Text = "Cheques";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(547, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 139;
            this.label1.Text = "TITULAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(292, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 135;
            this.label9.Text = "FECHA CRED.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(415, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 136;
            this.label7.Text = "BANCO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(52, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 137;
            this.label6.Text = "Nº CHEQUE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(170, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 138;
            this.label3.Text = "FECHA EMIS.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvCheques
            // 
            this.dgvCheques.AllowUserToAddRows = false;
            this.dgvCheques.AllowUserToDeleteRows = false;
            this.dgvCheques.AllowUserToResizeColumns = false;
            this.dgvCheques.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvCheques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheques.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCheques.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheques.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheques.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheques.ColumnHeadersVisible = false;
            this.dgvCheques.EnableHeadersVisualStyles = false;
            this.dgvCheques.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCheques.Location = new System.Drawing.Point(53, 154);
            this.dgvCheques.MaximumSize = new System.Drawing.Size(900, 800);
            this.dgvCheques.MultiSelect = false;
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheques.RowHeadersVisible = false;
            this.dgvCheques.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCheques.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.Size = new System.Drawing.Size(751, 469);
            this.dgvCheques.TabIndex = 134;
            this.dgvCheques.TabStop = false;
            this.dgvCheques.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCheques_CellFormatting);
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
            this.btnRegresar.Location = new System.Drawing.Point(855, 80);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 161;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(878, 203);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel1.TabIndex = 162;
            this.gunaLabel1.Text = "CANTIDAD";
            // 
            // tbCantidadCheques
            // 
            this.tbCantidadCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantidadCheques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbCantidadCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCantidadCheques.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadCheques.ForeColor = System.Drawing.Color.Yellow;
            this.tbCantidadCheques.Location = new System.Drawing.Point(855, 221);
            this.tbCantidadCheques.Name = "tbCantidadCheques";
            this.tbCantidadCheques.ReadOnly = true;
            this.tbCantidadCheques.Size = new System.Drawing.Size(116, 22);
            this.tbCantidadCheques.TabIndex = 175;
            this.tbCantidadCheques.TabStop = false;
            this.tbCantidadCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTotalCheques
            // 
            this.tbTotalCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalCheques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbTotalCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalCheques.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCheques.ForeColor = System.Drawing.Color.Yellow;
            this.tbTotalCheques.Location = new System.Drawing.Point(855, 327);
            this.tbTotalCheques.Name = "tbTotalCheques";
            this.tbTotalCheques.ReadOnly = true;
            this.tbTotalCheques.Size = new System.Drawing.Size(116, 22);
            this.tbTotalCheques.TabIndex = 177;
            this.tbTotalCheques.TabStop = false;
            this.tbTotalCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(892, 309);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel2.TabIndex = 176;
            this.gunaLabel2.Text = "TOTAL";
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
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(855, 535);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 178;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoEllipsis = true;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Gold;
            this.label28.Location = new System.Drawing.Point(838, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 16);
            this.label28.TabIndex = 179;
            this.label28.Text = "$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(707, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 180;
            this.label2.Text = "IMPORTE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(90, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 181;
            this.label4.Text = "A COBRAR";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(217, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 181;
            this.label5.Text = "POR VENCER";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(360, 668);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 181;
            this.label8.Text = "VENCIDO";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(52, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 474);
            this.label10.TabIndex = 182;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha2.AutoEllipsis = true;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(50, 95);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(231, 16);
            this.lblFecha2.TabIndex = 183;
            this.lblFecha2.Text = "Valores en Cartera Disponibles";
            // 
            // FormCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheques";
            this.Text = "FormCheques";
            this.Load += new System.EventHandler(this.FormCheques_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCheques;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TextBox tbTotalCheques;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.TextBox tbCantidadCheques;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFecha2;
    }
}