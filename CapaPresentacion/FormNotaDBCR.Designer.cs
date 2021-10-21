namespace CapaPresentacion
{
    partial class FormNotaDBCR
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
            this.tabNotasDBCR = new System.Windows.Forms.TabControl();
            this.tabListaNotas = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chekVerAnulados = new System.Windows.Forms.CheckBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.dgvNotasDBCR = new System.Windows.Forms.DataGridView();
            this.tabNuevaNotasDBCR = new System.Windows.Forms.TabPage();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbDetalleNota = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.gpDetinatario = new System.Windows.Forms.GroupBox();
            this.tbNumNota = new System.Windows.Forms.TextBox();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNota = new System.Windows.Forms.DateTimePicker();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarReg = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.tabNotasDBCR.SuspendLayout();
            this.tabListaNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDBCR)).BeginInit();
            this.tabNuevaNotasDBCR.SuspendLayout();
            this.gpDetinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNotasDBCR
            // 
            this.tabNotasDBCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabNotasDBCR.Controls.Add(this.tabListaNotas);
            this.tabNotasDBCR.Controls.Add(this.tabNuevaNotasDBCR);
            this.tabNotasDBCR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNotasDBCR.HotTrack = true;
            this.tabNotasDBCR.Location = new System.Drawing.Point(34, 51);
            this.tabNotasDBCR.Multiline = true;
            this.tabNotasDBCR.Name = "tabNotasDBCR";
            this.tabNotasDBCR.SelectedIndex = 0;
            this.tabNotasDBCR.Size = new System.Drawing.Size(632, 470);
            this.tabNotasDBCR.TabIndex = 86;
            // 
            // tabListaNotas
            // 
            this.tabListaNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabListaNotas.Controls.Add(this.label9);
            this.tabListaNotas.Controls.Add(this.label8);
            this.tabListaNotas.Controls.Add(this.label7);
            this.tabListaNotas.Controls.Add(this.label6);
            this.tabListaNotas.Controls.Add(this.label3);
            this.tabListaNotas.Controls.Add(this.chekVerAnulados);
            this.tabListaNotas.Controls.Add(this.btnActualizar);
            this.tabListaNotas.Controls.Add(this.btnBuscarReg);
            this.tabListaNotas.Controls.Add(this.btnNuevo);
            this.tabListaNotas.Controls.Add(this.btnAnular);
            this.tabListaNotas.Controls.Add(this.btnImprimir);
            this.tabListaNotas.Controls.Add(this.dtpFecha2);
            this.tabListaNotas.Controls.Add(this.dtpFecha1);
            this.tabListaNotas.Controls.Add(this.lblFecha2);
            this.tabListaNotas.Controls.Add(this.lblFecha1);
            this.tabListaNotas.Controls.Add(this.dgvNotasDBCR);
            this.tabListaNotas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListaNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabListaNotas.Location = new System.Drawing.Point(4, 25);
            this.tabListaNotas.Name = "tabListaNotas";
            this.tabListaNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaNotas.Size = new System.Drawing.Size(624, 441);
            this.tabListaNotas.TabIndex = 0;
            this.tabListaNotas.Text = "Consulta";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoEllipsis = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(534, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 103;
            this.label9.Text = "TIPO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(440, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 103;
            this.label8.Text = "IMPORTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(203, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "CLIENTE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(126, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nº";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "FECHA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chekVerAnulados
            // 
            this.chekVerAnulados.AutoSize = true;
            this.chekVerAnulados.ForeColor = System.Drawing.SystemColors.Control;
            this.chekVerAnulados.Location = new System.Drawing.Point(270, 408);
            this.chekVerAnulados.Name = "chekVerAnulados";
            this.chekVerAnulados.Size = new System.Drawing.Size(95, 17);
            this.chekVerAnulados.TabIndex = 102;
            this.chekVerAnulados.Text = "ANULADOS";
            this.chekVerAnulados.UseVisualStyleBackColor = true;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(144, 32);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(109, 22);
            this.dtpFecha2.TabIndex = 96;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(12, 32);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(109, 22);
            this.dtpFecha1.TabIndex = 95;
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha2.AutoEllipsis = true;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(153, 13);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(91, 16);
            this.lblFecha2.TabIndex = 94;
            this.lblFecha2.Text = "Fecha Final";
            // 
            // lblFecha1
            // 
            this.lblFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha1.AutoEllipsis = true;
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha1.Location = new System.Drawing.Point(17, 13);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(100, 16);
            this.lblFecha1.TabIndex = 93;
            this.lblFecha1.Text = "Fecha Inicial";
            // 
            // dgvNotasDBCR
            // 
            this.dgvNotasDBCR.AllowUserToAddRows = false;
            this.dgvNotasDBCR.AllowUserToDeleteRows = false;
            this.dgvNotasDBCR.AllowUserToResizeColumns = false;
            this.dgvNotasDBCR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.dgvNotasDBCR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotasDBCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNotasDBCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotasDBCR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvNotasDBCR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotasDBCR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotasDBCR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasDBCR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotasDBCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotasDBCR.EnableHeadersVisualStyles = false;
            this.dgvNotasDBCR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvNotasDBCR.Location = new System.Drawing.Point(12, 69);
            this.dgvNotasDBCR.MaximumSize = new System.Drawing.Size(650, 650);
            this.dgvNotasDBCR.Name = "dgvNotasDBCR";
            this.dgvNotasDBCR.ReadOnly = true;
            this.dgvNotasDBCR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNotasDBCR.RowHeadersVisible = false;
            this.dgvNotasDBCR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotasDBCR.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotasDBCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasDBCR.Size = new System.Drawing.Size(599, 320);
            this.dgvNotasDBCR.TabIndex = 92;
            this.dgvNotasDBCR.TabStop = false;
            // 
            // tabNuevaNotasDBCR
            // 
            this.tabNuevaNotasDBCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tabNuevaNotasDBCR.Controls.Add(this.tbImporte);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl5);
            this.tabNuevaNotasDBCR.Controls.Add(this.tbDetalleNota);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl4);
            this.tabNuevaNotasDBCR.Controls.Add(this.cbCliente);
            this.tabNuevaNotasDBCR.Controls.Add(this.gpDetinatario);
            this.tabNuevaNotasDBCR.Controls.Add(this.lbl1);
            this.tabNuevaNotasDBCR.Controls.Add(this.btnGuardar);
            this.tabNuevaNotasDBCR.Location = new System.Drawing.Point(4, 25);
            this.tabNuevaNotasDBCR.Name = "tabNuevaNotasDBCR";
            this.tabNuevaNotasDBCR.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevaNotasDBCR.Size = new System.Drawing.Size(624, 441);
            this.tabNuevaNotasDBCR.TabIndex = 1;
            this.tabNuevaNotasDBCR.Text = "Nuevo";
            // 
            // tbImporte
            // 
            this.tbImporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbImporte.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbImporte.Location = new System.Drawing.Point(480, 243);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(111, 15);
            this.tbImporte.TabIndex = 136;
            this.tbImporte.TabStop = false;
            this.tbImporte.Text = "0,00";
            this.tbImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoEllipsis = true;
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl5.Location = new System.Drawing.Point(398, 242);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(85, 16);
            this.lbl5.TabIndex = 135;
            this.lbl5.Text = "Importe: $";
            // 
            // tbDetalleNota
            // 
            this.tbDetalleNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetalleNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetalleNota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalleNota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDetalleNota.Location = new System.Drawing.Point(55, 261);
            this.tbDetalleNota.Multiline = true;
            this.tbDetalleNota.Name = "tbDetalleNota";
            this.tbDetalleNota.Size = new System.Drawing.Size(249, 76);
            this.tbDetalleNota.TabIndex = 134;
            this.tbDetalleNota.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoEllipsis = true;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl4.Location = new System.Drawing.Point(64, 242);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(64, 16);
            this.lbl4.TabIndex = 133;
            this.lbl4.Text = "Detalle:";
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 14;
            this.cbCliente.Location = new System.Drawing.Point(55, 201);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(249, 22);
            this.cbCliente.TabIndex = 132;
            // 
            // gpDetinatario
            // 
            this.gpDetinatario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpDetinatario.Controls.Add(this.tbNumNota);
            this.gpDetinatario.Controls.Add(this.rbCredito);
            this.gpDetinatario.Controls.Add(this.label1);
            this.gpDetinatario.Controls.Add(this.dtpFechaNota);
            this.gpDetinatario.Controls.Add(this.rbDebito);
            this.gpDetinatario.Controls.Add(this.lbl2);
            this.gpDetinatario.Controls.Add(this.lbl3);
            this.gpDetinatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpDetinatario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpDetinatario.Location = new System.Drawing.Point(20, 19);
            this.gpDetinatario.Name = "gpDetinatario";
            this.gpDetinatario.Size = new System.Drawing.Size(580, 116);
            this.gpDetinatario.TabIndex = 88;
            this.gpDetinatario.TabStop = false;
            // 
            // tbNumNota
            // 
            this.tbNumNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumNota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumNota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbNumNota.Location = new System.Drawing.Point(35, 59);
            this.tbNumNota.Name = "tbNumNota";
            this.tbNumNota.Size = new System.Drawing.Size(94, 20);
            this.tbNumNota.TabIndex = 135;
            this.tbNumNota.TabStop = false;
            this.tbNumNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbCredito
            // 
            this.rbCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCredito.Location = new System.Drawing.Point(460, 61);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(81, 17);
            this.rbCredito.TabIndex = 51;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "CRÉDITO";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(354, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo de Nota:";
            // 
            // dtpFechaNota
            // 
            this.dtpFechaNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNota.Location = new System.Drawing.Point(177, 58);
            this.dtpFechaNota.Name = "dtpFechaNota";
            this.dtpFechaNota.Size = new System.Drawing.Size(107, 22);
            this.dtpFechaNota.TabIndex = 134;
            // 
            // rbDebito
            // 
            this.rbDebito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDebito.Location = new System.Drawing.Point(460, 39);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(73, 17);
            this.rbDebito.TabIndex = 51;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "DÉBITO";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoEllipsis = true;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl2.Location = new System.Drawing.Point(44, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 16);
            this.lbl2.TabIndex = 133;
            this.lbl2.Text = "Número:";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoEllipsis = true;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl3.Location = new System.Drawing.Point(199, 40);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 16);
            this.lbl3.TabIndex = 132;
            this.lbl3.Text = "Fecha:";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoEllipsis = true;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl1.Location = new System.Drawing.Point(64, 182);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 16);
            this.lbl1.TabIndex = 131;
            this.lbl1.Text = "Cliente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(192, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 18);
            this.lblTitulo.TabIndex = 87;
            this.lblTitulo.Text = "Débito/Crédito a Cuenta Corriente";
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
            this.btnRegresar.Location = new System.Drawing.Point(518, 529);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(111, 32);
            this.btnRegresar.TabIndex = 88;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 25;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(480, 27);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 97;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarReg
            // 
            this.btnBuscarReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReg.FlatAppearance.BorderSize = 0;
            this.btnBuscarReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReg.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReg.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarReg.IconColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReg.IconSize = 25;
            this.btnBuscarReg.Location = new System.Drawing.Point(259, 27);
            this.btnBuscarReg.Name = "btnBuscarReg";
            this.btnBuscarReg.Size = new System.Drawing.Size(106, 32);
            this.btnBuscarReg.TabIndex = 98;
            this.btnBuscarReg.TabStop = false;
            this.btnBuscarReg.Text = "BUSCAR";
            this.btnBuscarReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReg.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.Location = new System.Drawing.Point(15, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 32);
            this.btnNuevo.TabIndex = 99;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "NUEVO DEB/CRED";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnAnular.IconColor = System.Drawing.Color.White;
            this.btnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnular.IconSize = 25;
            this.btnAnular.Location = new System.Drawing.Point(147, 400);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(106, 32);
            this.btnAnular.TabIndex = 100;
            this.btnAnular.TabStop = false;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.Location = new System.Drawing.Point(480, 400);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 32);
            this.btnImprimir.TabIndex = 101;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(480, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 32);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormNotaDBCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabNotasDBCR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotaDBCR";
            this.Text = "FormNotaDBCR";
            this.Load += new System.EventHandler(this.FormNotaDBCR_Load);
            this.tabNotasDBCR.ResumeLayout(false);
            this.tabListaNotas.ResumeLayout(false);
            this.tabListaNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDBCR)).EndInit();
            this.tabNuevaNotasDBCR.ResumeLayout(false);
            this.tabNuevaNotasDBCR.PerformLayout();
            this.gpDetinatario.ResumeLayout(false);
            this.gpDetinatario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabNotasDBCR;
        private System.Windows.Forms.TabPage tabListaNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chekVerAnulados;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnBuscarReg;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnAnular;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.DataGridView dgvNotasDBCR;
        private System.Windows.Forms.TabPage tabNuevaNotasDBCR;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.GroupBox gpDetinatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbNumNota;
        private System.Windows.Forms.DateTimePicker dtpFechaNota;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbl1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TextBox tbDetalleNota;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label lbl5;
    }
}