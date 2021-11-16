
namespace InterfazGrafica4._7
{
    partial class FrmRegistroMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroMulta));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbMulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmTipoVehiculo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.bnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.cmDescripcion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.errorTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPlaca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripcion";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.BackColor = System.Drawing.Color.Transparent;
            this.lbMulta.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.lbMulta.Location = new System.Drawing.Point(235, 40);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(127, 41);
            this.lbMulta.TabIndex = 27;
            this.lbMulta.Text = "MULTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "REGISTRAR";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlaca.BorderRadius = 15;
            this.txtPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaca.DefaultText = "";
            this.txtPlaca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaca.DisabledState.Parent = this.txtPlaca;
            this.txtPlaca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaca.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlaca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaca.FocusedState.Parent = this.txtPlaca;
            this.txtPlaca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.txtPlaca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaca.HoverState.Parent = this.txtPlaca;
            this.txtPlaca.Location = new System.Drawing.Point(172, 194);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlaca.PlaceholderText = "";
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.ShadowDecoration.Parent = this.txtPlaca;
            this.txtPlaca.Size = new System.Drawing.Size(221, 36);
            this.txtPlaca.TabIndex = 34;
            this.txtPlaca.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlaca_Validating);
            // 
            // txtValor
            // 
            this.txtValor.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.BorderRadius = 15;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.Parent = this.txtValor;
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.Enabled = false;
            this.txtValor.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedState.Parent = this.txtValor;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.HoverState.Parent = this.txtValor;
            this.txtValor.Location = new System.Drawing.Point(172, 314);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.ShadowDecoration.Parent = this.txtValor;
            this.txtValor.Size = new System.Drawing.Size(221, 36);
            this.txtValor.TabIndex = 36;
            // 
            // cmTipoVehiculo
            // 
            this.cmTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.cmTipoVehiculo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmTipoVehiculo.BorderRadius = 15;
            this.cmTipoVehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTipoVehiculo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmTipoVehiculo.FocusedColor = System.Drawing.Color.Empty;
            this.cmTipoVehiculo.FocusedState.Parent = this.cmTipoVehiculo;
            this.cmTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmTipoVehiculo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmTipoVehiculo.FormattingEnabled = true;
            this.cmTipoVehiculo.HoverState.Parent = this.cmTipoVehiculo;
            this.cmTipoVehiculo.ItemHeight = 30;
            this.cmTipoVehiculo.Items.AddRange(new object[] {
            "Ninguno"});
            this.cmTipoVehiculo.ItemsAppearance.Parent = this.cmTipoVehiculo;
            this.cmTipoVehiculo.Location = new System.Drawing.Point(175, 138);
            this.cmTipoVehiculo.Name = "cmTipoVehiculo";
            this.cmTipoVehiculo.ShadowDecoration.Parent = this.cmTipoVehiculo;
            this.cmTipoVehiculo.Size = new System.Drawing.Size(218, 36);
            this.cmTipoVehiculo.TabIndex = 37;
            this.cmTipoVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cmTipoVehiculo_Validating);
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
            this.bnLimpiar.Location = new System.Drawing.Point(397, 516);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 39;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
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
            this.bnRegistrar.Location = new System.Drawing.Point(225, 516);
            this.bnRegistrar.Name = "bnRegistrar";
            this.bnRegistrar.ShadowDecoration.Parent = this.bnRegistrar;
            this.bnRegistrar.Size = new System.Drawing.Size(114, 30);
            this.bnRegistrar.TabIndex = 38;
            this.bnRegistrar.Text = "Registrar";
            this.bnRegistrar.Click += new System.EventHandler(this.bnRegistrar_Click);
            // 
            // cmDescripcion
            // 
            this.cmDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.cmDescripcion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmDescripcion.BorderRadius = 15;
            this.cmDescripcion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDescripcion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmDescripcion.FocusedColor = System.Drawing.Color.Empty;
            this.cmDescripcion.FocusedState.Parent = this.cmDescripcion;
            this.cmDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmDescripcion.FormattingEnabled = true;
            this.cmDescripcion.HoverState.Parent = this.cmDescripcion;
            this.cmDescripcion.ItemHeight = 30;
            this.cmDescripcion.Items.AddRange(new object[] {
            "Ninguno"});
            this.cmDescripcion.ItemsAppearance.Parent = this.cmDescripcion;
            this.cmDescripcion.Location = new System.Drawing.Point(172, 256);
            this.cmDescripcion.Name = "cmDescripcion";
            this.cmDescripcion.ShadowDecoration.Parent = this.cmDescripcion;
            this.cmDescripcion.Size = new System.Drawing.Size(218, 36);
            this.cmDescripcion.TabIndex = 40;
            this.cmDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.cmDescripcion_Validating);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderRadius = 15;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(425, 256);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(221, 36);
            this.txtBusqueda.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Fecha Expedicion";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(172, 380);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(221, 36);
            this.guna2DateTimePicker1.TabIndex = 47;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 11, 14, 21, 54, 38, 545);
            // 
            // errorTipo
            // 
            this.errorTipo.ContainerControl = this;
            this.errorTipo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTipo.Icon")));
            // 
            // errorPlaca
            // 
            this.errorPlaca.ContainerControl = this;
            this.errorPlaca.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPlaca.Icon")));
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            this.errorDescripcion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDescripcion.Icon")));
            // 
            // FrmRegistroMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmDescripcion);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnRegistrar);
            this.Controls.Add(this.cmTipoVehiculo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lbMulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroMulta";
            this.Text = "FrmRegistroMulta";
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbMulta;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaca;
        private Guna.UI2.WinForms.Guna2ComboBox cmTipoVehiculo;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private Guna.UI2.WinForms.Guna2Button bnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox cmDescripcion;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorTipo;
        private System.Windows.Forms.ErrorProvider errorPlaca;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
    }
}