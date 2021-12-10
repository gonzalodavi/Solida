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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheques));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.cbEstadoCheques = new System.Windows.Forms.ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblChekAnul = new Guna.UI.WinForms.GunaLabel();
            this.chekCLASIFICA = new Guna.UI.WinForms.GunaSwitch();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVencido = new System.Windows.Forms.Label();
            this.lblVencer = new System.Windows.Forms.Label();
            this.lblCobrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.tbTotalCheques = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tbCantidadCheques = new System.Windows.Forms.TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.cbEstadoCheques);
            this.panelContenedor.Controls.Add(this.gunaLabel3);
            this.panelContenedor.Controls.Add(this.lblChekAnul);
            this.panelContenedor.Controls.Add(this.chekCLASIFICA);
            this.panelContenedor.Controls.Add(this.lblSubtitulo);
            this.panelContenedor.Controls.Add(this.dgvCheques);
            this.panelContenedor.Controls.Add(this.label10);
            this.panelContenedor.Controls.Add(this.lblVencido);
            this.panelContenedor.Controls.Add(this.lblVencer);
            this.panelContenedor.Controls.Add(this.lblCobrar);
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
            // cbEstadoCheques
            // 
            this.cbEstadoCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstadoCheques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoCheques.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbEstadoCheques.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbEstadoCheques.FormattingEnabled = true;
            this.cbEstadoCheques.ItemHeight = 17;
            this.cbEstadoCheques.Items.AddRange(new object[] {
            "ACTIVO",
            "PAGADO"});
            this.cbEstadoCheques.Location = new System.Drawing.Point(855, 217);
            this.cbEstadoCheques.Name = "cbEstadoCheques";
            this.cbEstadoCheques.Size = new System.Drawing.Size(116, 25);
            this.cbEstadoCheques.TabIndex = 189;
            this.cbEstadoCheques.SelectedIndexChanged += new System.EventHandler(this.cbEstadoCheques_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(887, 199);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel3.TabIndex = 187;
            this.gunaLabel3.Text = "ESTADO";
            // 
            // lblChekAnul
            // 
            this.lblChekAnul.AutoSize = true;
            this.lblChekAnul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChekAnul.ForeColor = System.Drawing.Color.White;
            this.lblChekAnul.Location = new System.Drawing.Point(642, 669);
            this.lblChekAnul.Name = "lblChekAnul";
            this.lblChekAnul.Size = new System.Drawing.Size(128, 15);
            this.lblChekAnul.TabIndex = 185;
            this.lblChekAnul.Text = "CLASIFICAR CHEQUES";
            // 
            // chekCLASIFICA
            // 
            this.chekCLASIFICA.BaseColor = System.Drawing.SystemColors.Control;
            this.chekCLASIFICA.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chekCLASIFICA.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chekCLASIFICA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekCLASIFICA.FillColor = System.Drawing.Color.White;
            this.chekCLASIFICA.Location = new System.Drawing.Point(776, 666);
            this.chekCLASIFICA.Name = "chekCLASIFICA";
            this.chekCLASIFICA.Size = new System.Drawing.Size(28, 20);
            this.chekCLASIFICA.TabIndex = 184;
            this.chekCLASIFICA.CheckedChanged += new System.EventHandler(this.chekCLASIFICA_CheckedChanged);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitulo.AutoEllipsis = true;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(50, 107);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(242, 21);
            this.lblSubtitulo.TabIndex = 183;
            this.lblSubtitulo.Text = "Valores en Cartera Disponibles";
            // 
            // dgvCheques
            // 
            this.dgvCheques.AllowUserToAddRows = false;
            this.dgvCheques.AllowUserToDeleteRows = false;
            this.dgvCheques.AllowUserToResizeColumns = false;
            this.dgvCheques.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvCheques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheques.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCheques.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheques.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheques.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheques.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheques.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheques.EnableHeadersVisualStyles = false;
            this.dgvCheques.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCheques.Location = new System.Drawing.Point(53, 175);
            this.dgvCheques.MaximumSize = new System.Drawing.Size(900, 800);
            this.dgvCheques.MultiSelect = false;
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheques.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCheques.RowHeadersVisible = false;
            this.dgvCheques.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCheques.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.Size = new System.Drawing.Size(751, 469);
            this.dgvCheques.TabIndex = 134;
            this.dgvCheques.TabStop = false;
            this.dgvCheques.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCheques_CellFormatting);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(52, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 474);
            this.label10.TabIndex = 182;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVencido
            // 
            this.lblVencido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVencido.AutoSize = true;
            this.lblVencido.BackColor = System.Drawing.Color.Orange;
            this.lblVencido.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblVencido.ForeColor = System.Drawing.Color.Brown;
            this.lblVencido.Location = new System.Drawing.Point(538, 112);
            this.lblVencido.Name = "lblVencido";
            this.lblVencido.Size = new System.Drawing.Size(66, 17);
            this.lblVencido.TabIndex = 181;
            this.lblVencido.Text = "VENCIDO";
            this.lblVencido.Visible = false;
            // 
            // lblVencer
            // 
            this.lblVencer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVencer.AutoSize = true;
            this.lblVencer.BackColor = System.Drawing.Color.Gold;
            this.lblVencer.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblVencer.ForeColor = System.Drawing.Color.Maroon;
            this.lblVencer.Location = new System.Drawing.Point(421, 112);
            this.lblVencer.Name = "lblVencer";
            this.lblVencer.Size = new System.Drawing.Size(87, 17);
            this.lblVencer.TabIndex = 181;
            this.lblVencer.Text = "POR VENCER";
            this.lblVencer.Visible = false;
            // 
            // lblCobrar
            // 
            this.lblCobrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCobrar.AutoSize = true;
            this.lblCobrar.BackColor = System.Drawing.Color.Green;
            this.lblCobrar.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCobrar.ForeColor = System.Drawing.Color.Gold;
            this.lblCobrar.Location = new System.Drawing.Point(319, 112);
            this.lblCobrar.Name = "lblCobrar";
            this.lblCobrar.Size = new System.Drawing.Size(72, 17);
            this.lblCobrar.TabIndex = 181;
            this.lblCobrar.Text = "A COBRAR";
            this.lblCobrar.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(707, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 180;
            this.label2.Text = "IMPORTE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoEllipsis = true;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Gold;
            this.label28.Location = new System.Drawing.Point(838, 455);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 17);
            this.label28.TabIndex = 179;
            this.label28.Text = "$";
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
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(855, 573);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 178;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tbTotalCheques
            // 
            this.tbTotalCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalCheques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbTotalCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalCheques.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbTotalCheques.ForeColor = System.Drawing.Color.Yellow;
            this.tbTotalCheques.Location = new System.Drawing.Point(855, 452);
            this.tbTotalCheques.Name = "tbTotalCheques";
            this.tbTotalCheques.ReadOnly = true;
            this.tbTotalCheques.Size = new System.Drawing.Size(116, 25);
            this.tbTotalCheques.TabIndex = 177;
            this.tbTotalCheques.TabStop = false;
            this.tbTotalCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(891, 430);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(48, 17);
            this.gunaLabel2.TabIndex = 176;
            this.gunaLabel2.Text = "TOTAL";
            // 
            // tbCantidadCheques
            // 
            this.tbCantidadCheques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantidadCheques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbCantidadCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCantidadCheques.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCantidadCheques.ForeColor = System.Drawing.Color.Yellow;
            this.tbCantidadCheques.Location = new System.Drawing.Point(855, 346);
            this.tbCantidadCheques.Name = "tbCantidadCheques";
            this.tbCantidadCheques.ReadOnly = true;
            this.tbCantidadCheques.Size = new System.Drawing.Size(116, 25);
            this.tbCantidadCheques.TabIndex = 175;
            this.tbCantidadCheques.TabStop = false;
            this.tbCantidadCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(876, 324);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 17);
            this.gunaLabel1.TabIndex = 162;
            this.gunaLabel1.Text = "CANTIDAD";
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
            this.btnRegresar.Location = new System.Drawing.Point(855, 26);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(547, 154);
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
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(292, 154);
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
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(415, 154);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(52, 154);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(170, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 138;
            this.label3.Text = "FECHA EMIS.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(381, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 25);
            this.label12.TabIndex = 82;
            this.label12.Text = "CARTERA DE VALORES";
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
        private System.Windows.Forms.Label lblVencido;
        private System.Windows.Forms.Label lblVencer;
        private System.Windows.Forms.Label lblCobrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI.WinForms.GunaLabel lblChekAnul;
        private Guna.UI.WinForms.GunaSwitch chekCLASIFICA;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ComboBox cbEstadoCheques;
    }
}