﻿
namespace InterfazGrafica4._7
{
    partial class FrmRegistroLicenciaa
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelRegistro = new System.Windows.Forms.TabControl();
            this.DatosPersonales = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiudad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbGS = new System.Windows.Forms.Label();
            this.txtGS = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSegApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbApellidoSeg = new System.Windows.Forms.Label();
            this.lbApellidoPri = new System.Windows.Forms.Label();
            this.txtSegNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNombreSeg = new System.Windows.Forms.Label();
            this.lbNombrePri = new System.Windows.Forms.Label();
            this.DatosLicencia = new System.Windows.Forms.TabPage();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.bnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.PanelRegistro.SuspendLayout();
            this.DatosPersonales.SuspendLayout();
            this.DatosLicencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.Controls.Add(this.DatosPersonales);
            this.PanelRegistro.Controls.Add(this.DatosLicencia);
            this.PanelRegistro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistro.Location = new System.Drawing.Point(27, 109);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.SelectedIndex = 0;
            this.PanelRegistro.Size = new System.Drawing.Size(647, 343);
            this.PanelRegistro.TabIndex = 0;
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Controls.Add(this.label2);
            this.DatosPersonales.Controls.Add(this.txtCiudad);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Controls.Add(this.txtBarrio);
            this.DatosPersonales.Controls.Add(this.lbGS);
            this.DatosPersonales.Controls.Add(this.txtGS);
            this.DatosPersonales.Controls.Add(this.lbTelefono);
            this.DatosPersonales.Controls.Add(this.txtTelefono);
            this.DatosPersonales.Controls.Add(this.lbFechaNacimiento);
            this.DatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.DatosPersonales.Controls.Add(this.txtSegApellido);
            this.DatosPersonales.Controls.Add(this.txtPriApellido);
            this.DatosPersonales.Controls.Add(this.lbApellidoSeg);
            this.DatosPersonales.Controls.Add(this.lbApellidoPri);
            this.DatosPersonales.Controls.Add(this.txtSegNombre);
            this.DatosPersonales.Controls.Add(this.txtPriNombre);
            this.DatosPersonales.Controls.Add(this.lbCedula);
            this.DatosPersonales.Controls.Add(this.txtCedula);
            this.DatosPersonales.Controls.Add(this.lbNombreSeg);
            this.DatosPersonales.Controls.Add(this.lbNombrePri);
            this.DatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.DatosPersonales.Size = new System.Drawing.Size(639, 314);
            this.DatosPersonales.TabIndex = 0;
            this.DatosPersonales.Text = "Datos Personales";
            this.DatosPersonales.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudad.BorderRadius = 15;
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.DefaultText = "";
            this.txtCiudad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCiudad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCiudad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCiudad.DisabledState.Parent = this.txtCiudad;
            this.txtCiudad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCiudad.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCiudad.FocusedState.Parent = this.txtCiudad;
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCiudad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCiudad.HoverState.Parent = this.txtCiudad;
            this.txtCiudad.Location = new System.Drawing.Point(462, 230);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudad.PlaceholderText = "";
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.ShadowDecoration.Parent = this.txtCiudad;
            this.txtCiudad.Size = new System.Drawing.Size(142, 30);
            this.txtCiudad.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Barrio";
            // 
            // txtBarrio
            // 
            this.txtBarrio.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtBarrio.BorderRadius = 15;
            this.txtBarrio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarrio.DefaultText = "";
            this.txtBarrio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarrio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarrio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarrio.DisabledState.Parent = this.txtBarrio;
            this.txtBarrio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarrio.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBarrio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarrio.FocusedState.Parent = this.txtBarrio;
            this.txtBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.ForeColor = System.Drawing.Color.DimGray;
            this.txtBarrio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarrio.HoverState.Parent = this.txtBarrio;
            this.txtBarrio.Location = new System.Drawing.Point(154, 224);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.PasswordChar = '\0';
            this.txtBarrio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBarrio.PlaceholderText = "";
            this.txtBarrio.SelectedText = "";
            this.txtBarrio.ShadowDecoration.Parent = this.txtBarrio;
            this.txtBarrio.Size = new System.Drawing.Size(142, 30);
            this.txtBarrio.TabIndex = 49;
            // 
            // lbGS
            // 
            this.lbGS.AutoSize = true;
            this.lbGS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGS.Location = new System.Drawing.Point(334, 187);
            this.lbGS.Name = "lbGS";
            this.lbGS.Size = new System.Drawing.Size(121, 17);
            this.lbGS.TabIndex = 48;
            this.lbGS.Text = "Grupo Sanguineo";
            // 
            // txtGS
            // 
            this.txtGS.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtGS.BorderRadius = 15;
            this.txtGS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGS.DefaultText = "";
            this.txtGS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGS.DisabledState.Parent = this.txtGS;
            this.txtGS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGS.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtGS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGS.FocusedState.Parent = this.txtGS;
            this.txtGS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGS.ForeColor = System.Drawing.Color.DimGray;
            this.txtGS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGS.HoverState.Parent = this.txtGS;
            this.txtGS.Location = new System.Drawing.Point(462, 180);
            this.txtGS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGS.Name = "txtGS";
            this.txtGS.PasswordChar = '\0';
            this.txtGS.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtGS.PlaceholderText = "";
            this.txtGS.SelectedText = "";
            this.txtGS.ShadowDecoration.Parent = this.txtGS;
            this.txtGS.Size = new System.Drawing.Size(142, 30);
            this.txtGS.TabIndex = 47;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(85, 180);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(62, 17);
            this.lbTelefono.TabIndex = 46;
            this.lbTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.Location = new System.Drawing.Point(154, 174);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(142, 30);
            this.txtTelefono.TabIndex = 45;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(328, 135);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(127, 17);
            this.lbFechaNacimiento.TabIndex = 44;
            this.lbFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.BorderRadius = 15;
            this.dtpFechaNacimiento.CheckedState.Parent = this.dtpFechaNacimiento;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaNacimiento.HoverState.Parent = this.dtpFechaNacimiento;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(462, 128);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.ShadowDecoration.Parent = this.dtpFechaNacimiento;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(142, 30);
            this.dtpFechaNacimiento.TabIndex = 43;
            this.dtpFechaNacimiento.Value = new System.DateTime(2021, 11, 14, 21, 54, 38, 545);
            // 
            // txtSegApellido
            // 
            this.txtSegApellido.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegApellido.BorderRadius = 15;
            this.txtSegApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegApellido.DefaultText = "";
            this.txtSegApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSegApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSegApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegApellido.DisabledState.Parent = this.txtSegApellido;
            this.txtSegApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegApellido.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegApellido.FocusedState.Parent = this.txtSegApellido;
            this.txtSegApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegApellido.HoverState.Parent = this.txtSegApellido;
            this.txtSegApellido.Location = new System.Drawing.Point(154, 122);
            this.txtSegApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegApellido.Name = "txtSegApellido";
            this.txtSegApellido.PasswordChar = '\0';
            this.txtSegApellido.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegApellido.PlaceholderText = "";
            this.txtSegApellido.SelectedText = "";
            this.txtSegApellido.ShadowDecoration.Parent = this.txtSegApellido;
            this.txtSegApellido.Size = new System.Drawing.Size(142, 30);
            this.txtSegApellido.TabIndex = 42;
            // 
            // txtPriApellido
            // 
            this.txtPriApellido.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriApellido.BorderRadius = 15;
            this.txtPriApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriApellido.DefaultText = "";
            this.txtPriApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriApellido.DisabledState.Parent = this.txtPriApellido;
            this.txtPriApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriApellido.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriApellido.FocusedState.Parent = this.txtPriApellido;
            this.txtPriApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtPriApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriApellido.HoverState.Parent = this.txtPriApellido;
            this.txtPriApellido.Location = new System.Drawing.Point(462, 74);
            this.txtPriApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriApellido.Name = "txtPriApellido";
            this.txtPriApellido.PasswordChar = '\0';
            this.txtPriApellido.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriApellido.PlaceholderText = "";
            this.txtPriApellido.SelectedText = "";
            this.txtPriApellido.ShadowDecoration.Parent = this.txtPriApellido;
            this.txtPriApellido.Size = new System.Drawing.Size(142, 30);
            this.txtPriApellido.TabIndex = 41;
            // 
            // lbApellidoSeg
            // 
            this.lbApellidoSeg.AutoSize = true;
            this.lbApellidoSeg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoSeg.Location = new System.Drawing.Point(25, 128);
            this.lbApellidoSeg.Name = "lbApellidoSeg";
            this.lbApellidoSeg.Size = new System.Drawing.Size(122, 17);
            this.lbApellidoSeg.TabIndex = 40;
            this.lbApellidoSeg.Text = "Segundo Apellido";
            // 
            // lbApellidoPri
            // 
            this.lbApellidoPri.AutoSize = true;
            this.lbApellidoPri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoPri.Location = new System.Drawing.Point(350, 82);
            this.lbApellidoPri.Name = "lbApellidoPri";
            this.lbApellidoPri.Size = new System.Drawing.Size(105, 17);
            this.lbApellidoPri.TabIndex = 39;
            this.lbApellidoPri.Text = "Primer Apellido";
            // 
            // txtSegNombre
            // 
            this.txtSegNombre.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegNombre.BorderRadius = 15;
            this.txtSegNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegNombre.DefaultText = "";
            this.txtSegNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSegNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSegNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegNombre.DisabledState.Parent = this.txtSegNombre;
            this.txtSegNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegNombre.FocusedState.Parent = this.txtSegNombre;
            this.txtSegNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegNombre.HoverState.Parent = this.txtSegNombre;
            this.txtSegNombre.Location = new System.Drawing.Point(154, 69);
            this.txtSegNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegNombre.Name = "txtSegNombre";
            this.txtSegNombre.PasswordChar = '\0';
            this.txtSegNombre.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSegNombre.PlaceholderText = "";
            this.txtSegNombre.SelectedText = "";
            this.txtSegNombre.ShadowDecoration.Parent = this.txtSegNombre;
            this.txtSegNombre.Size = new System.Drawing.Size(142, 30);
            this.txtSegNombre.TabIndex = 38;
            // 
            // txtPriNombre
            // 
            this.txtPriNombre.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriNombre.BorderRadius = 15;
            this.txtPriNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriNombre.DefaultText = "";
            this.txtPriNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriNombre.DisabledState.Parent = this.txtPriNombre;
            this.txtPriNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriNombre.FocusedState.Parent = this.txtPriNombre;
            this.txtPriNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtPriNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriNombre.HoverState.Parent = this.txtPriNombre;
            this.txtPriNombre.Location = new System.Drawing.Point(462, 21);
            this.txtPriNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriNombre.Name = "txtPriNombre";
            this.txtPriNombre.PasswordChar = '\0';
            this.txtPriNombre.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriNombre.PlaceholderText = "";
            this.txtPriNombre.SelectedText = "";
            this.txtPriNombre.ShadowDecoration.Parent = this.txtPriNombre;
            this.txtPriNombre.Size = new System.Drawing.Size(142, 30);
            this.txtPriNombre.TabIndex = 37;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(91, 27);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(56, 17);
            this.lbCedula.TabIndex = 33;
            this.lbCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.BorderRadius = 15;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.Parent = this.txtCedula;
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.FocusedState.Parent = this.txtCedula;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.HoverState.Parent = this.txtCedula;
            this.txtCedula.Location = new System.Drawing.Point(154, 21);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.PlaceholderText = "";
            this.txtCedula.SelectedText = "";
            this.txtCedula.ShadowDecoration.Parent = this.txtCedula;
            this.txtCedula.Size = new System.Drawing.Size(142, 30);
            this.txtCedula.TabIndex = 32;
            // 
            // lbNombreSeg
            // 
            this.lbNombreSeg.AutoSize = true;
            this.lbNombreSeg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreSeg.Location = new System.Drawing.Point(25, 75);
            this.lbNombreSeg.Name = "lbNombreSeg";
            this.lbNombreSeg.Size = new System.Drawing.Size(122, 17);
            this.lbNombreSeg.TabIndex = 31;
            this.lbNombreSeg.Text = "Segundo Nombre";
            // 
            // lbNombrePri
            // 
            this.lbNombrePri.AutoSize = true;
            this.lbNombrePri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePri.Location = new System.Drawing.Point(350, 27);
            this.lbNombrePri.Name = "lbNombrePri";
            this.lbNombrePri.Size = new System.Drawing.Size(105, 17);
            this.lbNombrePri.TabIndex = 30;
            this.lbNombrePri.Text = "Primer Nombre";
            // 
            // DatosLicencia
            // 
            this.DatosLicencia.Controls.Add(this.guna2ComboBox1);
            this.DatosLicencia.Controls.Add(this.label4);
            this.DatosLicencia.Controls.Add(this.cmCategoria);
            this.DatosLicencia.Controls.Add(this.txtPrecio);
            this.DatosLicencia.Controls.Add(this.lbPrecio);
            this.DatosLicencia.Controls.Add(this.lbCategoria);
            this.DatosLicencia.Controls.Add(this.label6);
            this.DatosLicencia.Controls.Add(this.guna2DateTimePicker1);
            this.DatosLicencia.Controls.Add(this.guna2TextBox1);
            this.DatosLicencia.Controls.Add(this.label5);
            this.DatosLicencia.Location = new System.Drawing.Point(4, 25);
            this.DatosLicencia.Name = "DatosLicencia";
            this.DatosLicencia.Padding = new System.Windows.Forms.Padding(3);
            this.DatosLicencia.Size = new System.Drawing.Size(639, 314);
            this.DatosLicencia.TabIndex = 1;
            this.DatosLicencia.Text = "Datos Licencia";
            this.DatosLicencia.UseVisualStyleBackColor = true;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(162, 138);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(253, 36);
            this.guna2ComboBox1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Restriccion";
            // 
            // cmCategoria
            // 
            this.cmCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmCategoria.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmCategoria.BorderRadius = 15;
            this.cmCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCategoria.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cmCategoria.FocusedState.Parent = this.cmCategoria;
            this.cmCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmCategoria.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmCategoria.FormattingEnabled = true;
            this.cmCategoria.HoverState.Parent = this.cmCategoria;
            this.cmCategoria.ItemHeight = 30;
            this.cmCategoria.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3"});
            this.cmCategoria.ItemsAppearance.Parent = this.cmCategoria;
            this.cmCategoria.Location = new System.Drawing.Point(157, 28);
            this.cmCategoria.Name = "cmCategoria";
            this.cmCategoria.ShadowDecoration.Parent = this.cmCategoria;
            this.cmCategoria.Size = new System.Drawing.Size(258, 36);
            this.cmCategoria.TabIndex = 51;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.BorderRadius = 15;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPrecio.Location = new System.Drawing.Point(157, 87);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(258, 30);
            this.txtPrecio.TabIndex = 50;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(98, 91);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 48;
            this.lbPrecio.Text = "Precio";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(71, 38);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(75, 17);
            this.lbCategoria.TabIndex = 47;
            this.lbCategoria.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha Expedicion";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(162, 255);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(253, 30);
            this.guna2DateTimePicker1.TabIndex = 45;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 11, 14, 21, 54, 38, 545);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(162, 190);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(253, 30);
            this.guna2TextBox1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Organismo";
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.BackColor = System.Drawing.Color.Transparent;
            this.lbMulta.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.lbMulta.Location = new System.Drawing.Point(257, 18);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(177, 41);
            this.lbMulta.TabIndex = 27;
            this.lbMulta.Text = "LICENCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "REGISTRAR";
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.BorderRadius = 15;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(33)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.Location = new System.Drawing.Point(233, 491);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 29;
            this.bnLimpiar.Text = "Limpiar";
            // 
            // bnRegistrar
            // 
            this.bnRegistrar.BorderRadius = 15;
            this.bnRegistrar.CheckedState.Parent = this.bnRegistrar;
            this.bnRegistrar.CustomImages.Parent = this.bnRegistrar;
            this.bnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(33)))));
            this.bnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRegistrar.ForeColor = System.Drawing.Color.White;
            this.bnRegistrar.HoverState.Parent = this.bnRegistrar;
            this.bnRegistrar.Location = new System.Drawing.Point(382, 491);
            this.bnRegistrar.Name = "bnRegistrar";
            this.bnRegistrar.ShadowDecoration.Parent = this.bnRegistrar;
            this.bnRegistrar.Size = new System.Drawing.Size(114, 30);
            this.bnRegistrar.TabIndex = 28;
            this.bnRegistrar.Text = "Registrar";
            // 
            // FrmRegistroLicenciaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(764, 575);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnRegistrar);
            this.Controls.Add(this.lbMulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroLicenciaa";
            this.Text = "FrmRegistroLicenciaa";
            this.PanelRegistro.ResumeLayout(false);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosLicencia.ResumeLayout(false);
            this.DatosLicencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TabControl PanelRegistro;
        private System.Windows.Forms.TabPage DatosPersonales;
        private System.Windows.Forms.TabPage DatosLicencia;
        private Guna.UI2.WinForms.Guna2TextBox txtSegNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtPriNombre;
        private System.Windows.Forms.Label lbCedula;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        private System.Windows.Forms.Label lbNombreSeg;
        private System.Windows.Forms.Label lbNombrePri;
        private System.Windows.Forms.Label lbMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaNacimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtSegApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtPriApellido;
        private System.Windows.Forms.Label lbApellidoSeg;
        private System.Windows.Forms.Label lbApellidoPri;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCiudad;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBarrio;
        private System.Windows.Forms.Label lbGS;
        private Guna.UI2.WinForms.Guna2TextBox txtGS;
        private System.Windows.Forms.Label lbTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmCategoria;
        protected Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private Guna.UI2.WinForms.Guna2Button bnRegistrar;
    }
}