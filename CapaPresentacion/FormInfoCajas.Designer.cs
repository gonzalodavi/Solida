﻿
namespace CapaPresentacion
{
    partial class FormInfoCajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoCajas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDebe = new System.Windows.Forms.TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHaber = new System.Windows.Forms.TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.label28 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFecha1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarReg = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbDebe);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbHaber);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.tbSaldo);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFecha2);
            this.panel1.Controls.Add(this.dtpFecha1);
            this.panel1.Controls.Add(this.btnBuscarReg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFecha1);
            this.panel1.Controls.Add(this.lblFecha2);
            this.panel1.Controls.Add(this.dgvCaja);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 749);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(217, 667);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 237;
            this.label13.Text = "TOTALES:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(334, 670);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 236;
            this.label11.Text = "$";
            // 
            // tbDebe
            // 
            this.tbDebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDebe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDebe.ForeColor = System.Drawing.Color.Yellow;
            this.tbDebe.Location = new System.Drawing.Point(351, 667);
            this.tbDebe.Name = "tbDebe";
            this.tbDebe.ReadOnly = true;
            this.tbDebe.Size = new System.Drawing.Size(116, 25);
            this.tbDebe.TabIndex = 235;
            this.tbDebe.TabStop = false;
            this.tbDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(388, 645);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(40, 17);
            this.gunaLabel4.TabIndex = 234;
            this.gunaLabel4.Text = "DEBE";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(495, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 233;
            this.label8.Text = "$";
            // 
            // tbHaber
            // 
            this.tbHaber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHaber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHaber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbHaber.ForeColor = System.Drawing.Color.Yellow;
            this.tbHaber.Location = new System.Drawing.Point(512, 667);
            this.tbHaber.Name = "tbHaber";
            this.tbHaber.ReadOnly = true;
            this.tbHaber.Size = new System.Drawing.Size(116, 25);
            this.tbHaber.TabIndex = 232;
            this.tbHaber.TabStop = false;
            this.tbHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(544, 645);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 17);
            this.gunaLabel3.TabIndex = 231;
            this.gunaLabel3.Text = "HABER";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoEllipsis = true;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Gold;
            this.label28.Location = new System.Drawing.Point(655, 670);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 21);
            this.label28.TabIndex = 230;
            this.label28.Text = "$";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.tbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.ForeColor = System.Drawing.Color.Yellow;
            this.tbSaldo.Location = new System.Drawing.Point(675, 666);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(116, 29);
            this.tbSaldo.TabIndex = 229;
            this.tbSaldo.TabStop = false;
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(701, 642);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel2.TabIndex = 228;
            this.gunaLabel2.Text = "SALDO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(682, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 219;
            this.label2.Text = "SALDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(583, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 227;
            this.label5.Text = "HABER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha2.BaseColor = System.Drawing.Color.White;
            this.dtpFecha2.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha2.CustomFormat = null;
            this.dtpFecha2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha2.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(858, 338);
            this.dtpFecha2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha2.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha2.Radius = 10;
            this.dtpFecha2.Size = new System.Drawing.Size(116, 30);
            this.dtpFecha2.TabIndex = 225;
            this.dtpFecha2.Text = "22/10/2021";
            this.dtpFecha2.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            this.dtpFecha2.Visible = false;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha1.BaseColor = System.Drawing.Color.White;
            this.dtpFecha1.BorderColor = System.Drawing.Color.Silver;
            this.dtpFecha1.CustomFormat = null;
            this.dtpFecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFecha1.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(858, 252);
            this.dtpFecha1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFecha1.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFecha1.Radius = 10;
            this.dtpFecha1.Size = new System.Drawing.Size(116, 30);
            this.dtpFecha1.TabIndex = 226;
            this.dtpFecha1.Text = "22/10/2021";
            this.dtpFecha1.Value = new System.DateTime(2021, 10, 22, 23, 29, 56, 942);
            this.dtpFecha1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(894, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 223;
            this.label4.Text = "Hasta:";
            this.label4.Visible = false;
            // 
            // lblFecha1
            // 
            this.lblFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha1.AutoEllipsis = true;
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha1.Location = new System.Drawing.Point(890, 232);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(50, 17);
            this.lblFecha1.TabIndex = 222;
            this.lblFecha1.Text = "Desde:";
            this.lblFecha1.Visible = false;
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha2.AutoEllipsis = true;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFecha2.Location = new System.Drawing.Point(36, 67);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(259, 21);
            this.lblFecha2.TabIndex = 221;
            this.lblFecha2.Text = "Informe de Movimientos de Caja";
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.AllowUserToDeleteRows = false;
            this.dgvCaja.AllowUserToResizeColumns = false;
            this.dgvCaja.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaja.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaja.EnableHeadersVisualStyles = false;
            this.dgvCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.dgvCaja.Location = new System.Drawing.Point(40, 143);
            this.dgvCaja.MaximumSize = new System.Drawing.Size(900, 800);
            this.dgvCaja.MultiSelect = false;
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.ReadOnly = true;
            this.dgvCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCaja.RowHeadersVisible = false;
            this.dgvCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCaja.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaja.Size = new System.Drawing.Size(751, 469);
            this.dgvCaja.TabIndex = 213;
            this.dgvCaja.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(39, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 474);
            this.label10.TabIndex = 220;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(484, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 218;
            this.label1.Text = "DEBE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoEllipsis = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(310, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 215;
            this.label7.Text = "CLIENTE / PROVEEDOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(39, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 216;
            this.label6.Text = "FECHA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(127, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 217;
            this.label3.Text = "CONCEPTO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(440, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 208;
            this.label12.Text = "LIBRO DE CAJA";
            // 
            // btnBuscarReg
            // 
            this.btnBuscarReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBuscarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarReg.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarReg.IconColor = System.Drawing.Color.White;
            this.btnBuscarReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReg.IconSize = 25;
            this.btnBuscarReg.Location = new System.Drawing.Point(858, 393);
            this.btnBuscarReg.Name = "btnBuscarReg";
            this.btnBuscarReg.Size = new System.Drawing.Size(116, 31);
            this.btnBuscarReg.TabIndex = 224;
            this.btnBuscarReg.TabStop = false;
            this.btnBuscarReg.Text = "BUSCAR";
            this.btnBuscarReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReg.UseVisualStyleBackColor = false;
            this.btnBuscarReg.Visible = false;
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
            this.btnImprimir.Location = new System.Drawing.Point(858, 545);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 31);
            this.btnImprimir.TabIndex = 212;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
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
            this.btnRegresar.Location = new System.Drawing.Point(858, 64);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 31);
            this.btnRegresar.TabIndex = 211;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormInfoCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoCajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoCajas";
            this.Load += new System.EventHandler(this.FormInfoCajas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDebe;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHaber;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbSaldo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha2;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFecha1;
        private FontAwesome.Sharp.IconButton btnBuscarReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label label12;
    }
}