
namespace InterfazGrafica4._7
{
    partial class FrmHistorialPagoMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialPagoMulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbTexto2 = new System.Windows.Forms.Label();
            this.lbTexto = new System.Windows.Forms.Label();
            this.pcImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnBusqueda = new Guna.UI2.WinForms.Guna2Panel();
            this.cmFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.pnCentral = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmCodigoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmIdentificacionU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmApellidoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCodigoMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescripcionMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmEstadoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.pnSuperior.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.pnBusqueda.SuspendLayout();
            this.pnCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.bunifuPanel1);
            this.pnSuperior.Controls.Add(this.pnBusqueda);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.ShadowDecoration.Parent = this.pnSuperior;
            this.pnSuperior.Size = new System.Drawing.Size(780, 240);
            this.pnSuperior.TabIndex = 1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbTexto2);
            this.bunifuPanel1.Controls.Add(this.lbTexto);
            this.bunifuPanel1.Controls.Add(this.pcImage);
            this.bunifuPanel1.Location = new System.Drawing.Point(36, 24);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(510, 127);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // lbTexto2
            // 
            this.lbTexto2.AutoSize = true;
            this.lbTexto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.lbTexto2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTexto2.Location = new System.Drawing.Point(373, 60);
            this.lbTexto2.Name = "lbTexto2";
            this.lbTexto2.Size = new System.Drawing.Size(111, 41);
            this.lbTexto2.TabIndex = 4;
            this.lbTexto2.Text = "Multa";
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.lbTexto.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTexto.Location = new System.Drawing.Point(208, 18);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(248, 42);
            this.lbTexto.TabIndex = 3;
            this.lbTexto.Text = "Historial Pago";
            // 
            // pcImage
            // 
            this.pcImage.BackColor = System.Drawing.Color.Transparent;
            this.pcImage.Image = global::InterfazGrafica4._7.Properties.Resources.Creative_team_pana1;
            this.pcImage.Location = new System.Drawing.Point(-82, -23);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Parent = this.pcImage;
            this.pcImage.Size = new System.Drawing.Size(373, 199);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 4;
            this.pcImage.TabStop = false;
            // 
            // pnBusqueda
            // 
            this.pnBusqueda.Controls.Add(this.cmFiltro);
            this.pnBusqueda.Controls.Add(this.lbFiltro);
            this.pnBusqueda.Controls.Add(this.txtFiltro);
            this.pnBusqueda.Controls.Add(this.btnBuscar);
            this.pnBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBusqueda.Location = new System.Drawing.Point(0, 205);
            this.pnBusqueda.Name = "pnBusqueda";
            this.pnBusqueda.ShadowDecoration.Parent = this.pnBusqueda;
            this.pnBusqueda.Size = new System.Drawing.Size(780, 35);
            this.pnBusqueda.TabIndex = 0;
            // 
            // cmFiltro
            // 
            this.cmFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmFiltro.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmFiltro.BorderRadius = 15;
            this.cmFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFiltro.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmFiltro.FocusedColor = System.Drawing.Color.Empty;
            this.cmFiltro.FocusedState.Parent = this.cmFiltro;
            this.cmFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFiltro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmFiltro.FormattingEnabled = true;
            this.cmFiltro.HoverState.Parent = this.cmFiltro;
            this.cmFiltro.ItemHeight = 30;
            this.cmFiltro.Items.AddRange(new object[] {
            "TODOS",
            "IDENTIFICACION",
            "NOMBRE",
            "DESCRIPCION",
            "ESTADO",
            "ANIO"});
            this.cmFiltro.ItemsAppearance.Parent = this.cmFiltro;
            this.cmFiltro.Location = new System.Drawing.Point(162, -1);
            this.cmFiltro.Name = "cmFiltro";
            this.cmFiltro.ShadowDecoration.Parent = this.cmFiltro;
            this.cmFiltro.Size = new System.Drawing.Size(174, 36);
            this.cmFiltro.TabIndex = 45;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbFiltro.Location = new System.Drawing.Point(110, 6);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(46, 21);
            this.lbFiltro.TabIndex = 44;
            this.lbFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtFiltro.BorderRadius = 15;
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.DefaultText = "";
            this.txtFiltro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltro.DisabledState.Parent = this.txtFiltro;
            this.txtFiltro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltro.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltro.FocusedState.Parent = this.txtFiltro;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltro.HoverState.Parent = this.txtFiltro;
            this.txtFiltro.Location = new System.Drawing.Point(343, 0);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PlaceholderText = "";
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.ShadowDecoration.Parent = this.txtFiltro;
            this.txtFiltro.Size = new System.Drawing.Size(270, 35);
            this.txtFiltro.TabIndex = 43;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Animated = true;
            this.btnBuscar.BorderRadius = 15;
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuscar.Location = new System.Drawing.Point(625, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(45, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnCentral
            // 
            this.pnCentral.Controls.Add(this.dgvTabla);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCentral.Location = new System.Drawing.Point(0, 240);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.ShadowDecoration.Parent = this.pnCentral;
            this.pnCentral.Size = new System.Drawing.Size(780, 299);
            this.pnCentral.TabIndex = 2;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabla.ColumnHeadersHeight = 38;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmCodigoHistorial,
            this.cmIdentificacionU,
            this.cmNombreU,
            this.cmApellidoU,
            this.cmCodigoMulta,
            this.cmDescripcionMulta,
            this.cnValor,
            this.cnPlaca,
            this.cnMarca,
            this.cmEstadoM,
            this.cmFecha});
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.dgvTabla.Location = new System.Drawing.Point(47, 31);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabla.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabla.Size = new System.Drawing.Size(678, 250);
            this.dgvTabla.TabIndex = 5;
            this.dgvTabla.Visible = false;
            // 
            // cmCodigoHistorial
            // 
            this.cmCodigoHistorial.HeaderText = "Codigo Historial";
            this.cmCodigoHistorial.Name = "cmCodigoHistorial";
            this.cmCodigoHistorial.ReadOnly = true;
            // 
            // cmIdentificacionU
            // 
            this.cmIdentificacionU.HeaderText = "Identificacion";
            this.cmIdentificacionU.Name = "cmIdentificacionU";
            this.cmIdentificacionU.ReadOnly = true;
            // 
            // cmNombreU
            // 
            this.cmNombreU.HeaderText = "Nombre";
            this.cmNombreU.Name = "cmNombreU";
            this.cmNombreU.ReadOnly = true;
            // 
            // cmApellidoU
            // 
            this.cmApellidoU.HeaderText = "Apellido";
            this.cmApellidoU.Name = "cmApellidoU";
            this.cmApellidoU.ReadOnly = true;
            // 
            // cmCodigoMulta
            // 
            this.cmCodigoMulta.HeaderText = "Codigo Multa";
            this.cmCodigoMulta.Name = "cmCodigoMulta";
            this.cmCodigoMulta.ReadOnly = true;
            // 
            // cmDescripcionMulta
            // 
            this.cmDescripcionMulta.HeaderText = "Descripcion";
            this.cmDescripcionMulta.Name = "cmDescripcionMulta";
            this.cmDescripcionMulta.ReadOnly = true;
            // 
            // cnValor
            // 
            this.cnValor.HeaderText = "Valor";
            this.cnValor.Name = "cnValor";
            this.cnValor.ReadOnly = true;
            // 
            // cnPlaca
            // 
            this.cnPlaca.HeaderText = "Placa";
            this.cnPlaca.Name = "cnPlaca";
            this.cnPlaca.ReadOnly = true;
            // 
            // cnMarca
            // 
            this.cnMarca.HeaderText = "Marca";
            this.cnMarca.Name = "cnMarca";
            this.cnMarca.ReadOnly = true;
            // 
            // cmEstadoM
            // 
            this.cmEstadoM.HeaderText = "Estado";
            this.cmEstadoM.Name = "cmEstadoM";
            this.cmEstadoM.ReadOnly = true;
            // 
            // cmFecha
            // 
            this.cmFecha.HeaderText = "Fecha Pago";
            this.cmFecha.Name = "cmFecha";
            this.cmFecha.ReadOnly = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 23;
            this.bunifuElipse2.TargetControl = this.dgvTabla;
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Animated = true;
            this.bnLimpiar.BorderRadius = 15;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bnLimpiar.Location = new System.Drawing.Point(584, 553);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 21;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Visible = false;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // FrmHistorialPagoMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialPagoMulta";
            this.Text = "FrmHistorialPagoMulta";
            this.pnSuperior.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.pnBusqueda.ResumeLayout(false);
            this.pnBusqueda.PerformLayout();
            this.pnCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel pnSuperior;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lbTexto2;
        private System.Windows.Forms.Label lbTexto;
        private Guna.UI2.WinForms.Guna2PictureBox pcImage;
        private Guna.UI2.WinForms.Guna2Panel pnBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox cmFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Panel pnCentral;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridView dgvTabla;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCodigoHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIdentificacionU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmApellidoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCodigoMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescripcionMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmEstadoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmFecha;
    }
}