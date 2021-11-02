﻿namespace Presentacion
{
    partial class FormEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConfirmaClave = new System.Windows.Forms.Label();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBClaveNueva = new System.Windows.Forms.TextBox();
            this.tBClaveConfirma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBClaveActual = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblClaveNueva = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnGuardaClave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelaClave = new System.Windows.Forms.Button();
            this.tBRol = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // lblConfirmaClave
            // 
            this.lblConfirmaClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmaClave.AutoSize = true;
            this.lblConfirmaClave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaClave.ForeColor = System.Drawing.Color.White;
            this.lblConfirmaClave.Location = new System.Drawing.Point(82, 372);
            this.lblConfirmaClave.Name = "lblConfirmaClave";
            this.lblConfirmaClave.Size = new System.Drawing.Size(173, 16);
            this.lblConfirmaClave.TabIndex = 0;
            this.lblConfirmaClave.Text = "Confirmar Contraseña:";
            this.lblConfirmaClave.Visible = false;
            // 
            // tBUsuario
            // 
            this.tBUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBUsuario.Location = new System.Drawing.Point(30, 55);
            this.tBUsuario.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(271, 15);
            this.tBUsuario.TabIndex = 1;
            this.tBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBNombre
            // 
            this.tBNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBNombre.Location = new System.Drawing.Point(30, 101);
            this.tBNombre.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(271, 15);
            this.tBNombre.TabIndex = 2;
            this.tBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBApellido
            // 
            this.tBApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBApellido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBApellido.Location = new System.Drawing.Point(30, 147);
            this.tBApellido.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(271, 15);
            this.tBApellido.TabIndex = 3;
            this.tBApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBEmail
            // 
            this.tBEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBEmail.Location = new System.Drawing.Point(30, 194);
            this.tBEmail.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(271, 15);
            this.tBEmail.TabIndex = 4;
            this.tBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBClaveNueva
            // 
            this.tBClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBClaveNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBClaveNueva.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBClaveNueva.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBClaveNueva.Location = new System.Drawing.Point(30, 349);
            this.tBClaveNueva.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBClaveNueva.Name = "tBClaveNueva";
            this.tBClaveNueva.Size = new System.Drawing.Size(271, 15);
            this.tBClaveNueva.TabIndex = 0;
            this.tBClaveNueva.TabStop = false;
            this.tBClaveNueva.UseSystemPasswordChar = true;
            this.tBClaveNueva.Visible = false;
            // 
            // tBClaveConfirma
            // 
            this.tBClaveConfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBClaveConfirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBClaveConfirma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBClaveConfirma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBClaveConfirma.Location = new System.Drawing.Point(30, 391);
            this.tBClaveConfirma.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBClaveConfirma.Name = "tBClaveConfirma";
            this.tBClaveConfirma.Size = new System.Drawing.Size(271, 15);
            this.tBClaveConfirma.TabIndex = 0;
            this.tBClaveConfirma.TabStop = false;
            this.tBClaveConfirma.UseSystemPasswordChar = true;
            this.tBClaveConfirma.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(109, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "EDITAR PERFIL";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rol:";
            // 
            // tBClaveActual
            // 
            this.tBClaveActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBClaveActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBClaveActual.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBClaveActual.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBClaveActual.Location = new System.Drawing.Point(30, 306);
            this.tBClaveActual.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBClaveActual.Name = "tBClaveActual";
            this.tBClaveActual.Size = new System.Drawing.Size(271, 15);
            this.tBClaveActual.TabIndex = 5;
            this.tBClaveActual.UseSystemPasswordChar = true;
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
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(30, 469);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 40);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblClaveNueva
            // 
            this.lblClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClaveNueva.AutoSize = true;
            this.lblClaveNueva.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveNueva.ForeColor = System.Drawing.Color.White;
            this.lblClaveNueva.Location = new System.Drawing.Point(96, 330);
            this.lblClaveNueva.Name = "lblClaveNueva";
            this.lblClaveNueva.Size = new System.Drawing.Size(147, 16);
            this.lblClaveNueva.TabIndex = 0;
            this.lblClaveNueva.Text = "Contraseña Nueva:";
            this.lblClaveNueva.Visible = false;
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
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(179, 469);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarClave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.ForeColor = System.Drawing.Color.White;
            this.btnCambiarClave.Location = new System.Drawing.Point(64, 360);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(201, 40);
            this.btnCambiarClave.TabIndex = 0;
            this.btnCambiarClave.TabStop = false;
            this.btnCambiarClave.Text = "MODIFICAR CLAVE";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // btnGuardaClave
            // 
            this.btnGuardaClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGuardaClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardaClave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardaClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardaClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardaClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaClave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaClave.ForeColor = System.Drawing.Color.White;
            this.btnGuardaClave.Location = new System.Drawing.Point(179, 417);
            this.btnGuardaClave.Name = "btnGuardaClave";
            this.btnGuardaClave.Size = new System.Drawing.Size(122, 39);
            this.btnGuardaClave.TabIndex = 0;
            this.btnGuardaClave.TabStop = false;
            this.btnGuardaClave.Text = "GUARDAR CLAVE";
            this.btnGuardaClave.UseVisualStyleBackColor = false;
            this.btnGuardaClave.Visible = false;
            this.btnGuardaClave.Click += new System.EventHandler(this.btnGuardaClave_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(96, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contraseña Actual:";
            // 
            // btnCancelaClave
            // 
            this.btnCancelaClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancelaClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaClave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelaClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelaClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCancelaClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaClave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaClave.ForeColor = System.Drawing.Color.White;
            this.btnCancelaClave.Location = new System.Drawing.Point(30, 417);
            this.btnCancelaClave.Name = "btnCancelaClave";
            this.btnCancelaClave.Size = new System.Drawing.Size(122, 39);
            this.btnCancelaClave.TabIndex = 0;
            this.btnCancelaClave.TabStop = false;
            this.btnCancelaClave.Text = "CANCELAR ";
            this.btnCancelaClave.UseVisualStyleBackColor = false;
            this.btnCancelaClave.Visible = false;
            this.btnCancelaClave.Click += new System.EventHandler(this.btnCancelaClave_Click);
            // 
            // tBRol
            // 
            this.tBRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBRol.Enabled = false;
            this.tBRol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBRol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tBRol.Location = new System.Drawing.Point(30, 242);
            this.tBRol.MaximumSize = new System.Drawing.Size(271, 20);
            this.tBRol.Name = "tBRol";
            this.tBRol.Size = new System.Drawing.Size(271, 15);
            this.tBRol.TabIndex = 0;
            this.tBRol.TabStop = false;
            this.tBRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.tBRol);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCambiarClave);
            this.panel1.Controls.Add(this.lblClaveNueva);
            this.panel1.Controls.Add(this.tBClaveActual);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBClaveConfirma);
            this.panel1.Controls.Add(this.tBClaveNueva);
            this.panel1.Controls.Add(this.tBEmail);
            this.panel1.Controls.Add(this.tBApellido);
            this.panel1.Controls.Add(this.tBNombre);
            this.panel1.Controls.Add(this.tBUsuario);
            this.panel1.Controls.Add(this.lblConfirmaClave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelaClave);
            this.panel1.Controls.Add(this.btnGuardaClave);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 537);
            this.panel1.TabIndex = 0;
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
            this.btnSalir.Location = new System.Drawing.Point(325, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 26);
            this.btnSalir.TabIndex = 155;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(350, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarUsuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConfirmaClave;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBApellido;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBClaveNueva;
        private System.Windows.Forms.TextBox tBClaveConfirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBClaveActual;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblClaveNueva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnGuardaClave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelaClave;
        private System.Windows.Forms.TextBox tBRol;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
    }
}