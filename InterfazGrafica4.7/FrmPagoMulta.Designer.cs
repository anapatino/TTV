
namespace InterfazGrafica4._7
{
    partial class FrmPagoMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagoMulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnBusqueda = new Guna.UI2.WinForms.Guna2Panel();
            this.cmFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.pnCentral = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmCodigoMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescripcionMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmIdentificacionU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmApellidoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnValorMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmEstadoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnInferior = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagar = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigoMultaPagar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCodigoMultaPagar = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbPlca = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSuperior.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.pnBusqueda.SuspendLayout();
            this.pnCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnInferior.SuspendLayout();
            this.SuspendLayout();
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
            this.pnSuperior.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.pcImage);
            this.bunifuPanel1.Location = new System.Drawing.Point(36, 24);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(510, 127);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(297, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pago";
            // 
            // pcImage
            // 
            this.pcImage.BackColor = System.Drawing.Color.Transparent;
            this.pcImage.Image = global::InterfazGrafica4._7.Properties.Resources.Taking_notes_pana;
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
            this.pnBusqueda.Location = new System.Drawing.Point(0, 194);
            this.pnBusqueda.Name = "pnBusqueda";
            this.pnBusqueda.ShadowDecoration.Parent = this.pnBusqueda;
            this.pnBusqueda.Size = new System.Drawing.Size(780, 46);
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
            "CODIGO MULTA",
            "NOMBRE",
            "DESCRIPCION",
            "ESTADO",
            "ANIO",
            "PLACA",
            "MARCA"});
            this.cmFiltro.ItemsAppearance.Parent = this.cmFiltro;
            this.cmFiltro.Location = new System.Drawing.Point(114, -1);
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
            this.lbFiltro.Location = new System.Drawing.Point(62, 0);
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
            this.txtFiltro.Location = new System.Drawing.Point(295, 0);
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
            this.btnBuscar.Location = new System.Drawing.Point(572, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(45, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.bnLimpiar.Location = new System.Drawing.Point(615, 21);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 46;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Visible = false;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // pnCentral
            // 
            this.pnCentral.Controls.Add(this.dgvTabla);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCentral.Location = new System.Drawing.Point(0, 240);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.ShadowDecoration.Parent = this.pnCentral;
            this.pnCentral.Size = new System.Drawing.Size(780, 294);
            this.pnCentral.TabIndex = 1;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeight = 38;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmCodigoMulta,
            this.cmDescripcionMulta,
            this.cnPlaca,
            this.cnMarca,
            this.cmIdentificacionU,
            this.cmNombreU,
            this.cmApellidoU,
            this.cnValorMulta,
            this.cmFecha,
            this.cmEstadoM});
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.dgvTabla.Location = new System.Drawing.Point(51, 22);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabla.Size = new System.Drawing.Size(678, 250);
            this.dgvTabla.TabIndex = 47;
            this.dgvTabla.Visible = false;
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
            // cnValorMulta
            // 
            this.cnValorMulta.HeaderText = "Valor";
            this.cnValorMulta.Name = "cnValorMulta";
            this.cnValorMulta.ReadOnly = true;
            // 
            // cmFecha
            // 
            this.cmFecha.HeaderText = "Fecha";
            this.cmFecha.Name = "cmFecha";
            this.cmFecha.ReadOnly = true;
            // 
            // cmEstadoM
            // 
            this.cmEstadoM.HeaderText = "Estado";
            this.cmEstadoM.Name = "cmEstadoM";
            this.cmEstadoM.ReadOnly = true;
            // 
            // pnInferior
            // 
            this.pnInferior.Controls.Add(this.bnLimpiar);
            this.pnInferior.Controls.Add(this.btnLimpiar);
            this.pnInferior.Controls.Add(this.btnPagar);
            this.pnInferior.Controls.Add(this.txtCodigoMultaPagar);
            this.pnInferior.Controls.Add(this.lbCodigoMultaPagar);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInferior.Location = new System.Drawing.Point(0, 534);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.ShadowDecoration.Parent = this.pnInferior;
            this.pnInferior.Size = new System.Drawing.Size(780, 247);
            this.pnInferior.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Animated = true;
            this.btnLimpiar.BorderRadius = 15;
            this.btnLimpiar.CheckedState.Parent = this.btnLimpiar;
            this.btnLimpiar.CustomImages.Parent = this.btnLimpiar;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.HoverState.Parent = this.btnLimpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(333, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.Parent = this.btnLimpiar;
            this.btnLimpiar.Size = new System.Drawing.Size(114, 34);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Pagar";
            this.btnLimpiar.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Animated = true;
            this.btnPagar.BorderRadius = 15;
            this.btnPagar.CheckedState.Parent = this.btnPagar;
            this.btnPagar.CustomImages.Parent = this.btnPagar;
            this.btnPagar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.HoverState.Parent = this.btnPagar;
            this.btnPagar.Location = new System.Drawing.Point(495, 21);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.ShadowDecoration.Parent = this.btnPagar;
            this.btnPagar.Size = new System.Drawing.Size(114, 30);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtCodigoMultaPagar
            // 
            this.txtCodigoMultaPagar.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoMultaPagar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoMultaPagar.BorderRadius = 15;
            this.txtCodigoMultaPagar.BorderThickness = 2;
            this.txtCodigoMultaPagar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoMultaPagar.DefaultText = "";
            this.txtCodigoMultaPagar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoMultaPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoMultaPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMultaPagar.DisabledState.Parent = this.txtCodigoMultaPagar;
            this.txtCodigoMultaPagar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMultaPagar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoMultaPagar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMultaPagar.FocusedState.Parent = this.txtCodigoMultaPagar;
            this.txtCodigoMultaPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMultaPagar.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoMultaPagar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMultaPagar.HoverState.Parent = this.txtCodigoMultaPagar;
            this.txtCodigoMultaPagar.Location = new System.Drawing.Point(295, 21);
            this.txtCodigoMultaPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoMultaPagar.Name = "txtCodigoMultaPagar";
            this.txtCodigoMultaPagar.PasswordChar = '\0';
            this.txtCodigoMultaPagar.PlaceholderText = "";
            this.txtCodigoMultaPagar.SelectedText = "";
            this.txtCodigoMultaPagar.ShadowDecoration.Parent = this.txtCodigoMultaPagar;
            this.txtCodigoMultaPagar.Size = new System.Drawing.Size(174, 36);
            this.txtCodigoMultaPagar.TabIndex = 48;
            this.txtCodigoMultaPagar.Visible = false;
            // 
            // lbCodigoMultaPagar
            // 
            this.lbCodigoMultaPagar.AutoSize = true;
            this.lbCodigoMultaPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoMultaPagar.ForeColor = System.Drawing.Color.DimGray;
            this.lbCodigoMultaPagar.Location = new System.Drawing.Point(130, 30);
            this.lbCodigoMultaPagar.Name = "lbCodigoMultaPagar";
            this.lbCodigoMultaPagar.Size = new System.Drawing.Size(158, 17);
            this.lbCodigoMultaPagar.TabIndex = 47;
            this.lbCodigoMultaPagar.Text = "Codigo Multa  A Pagar";
            this.lbCodigoMultaPagar.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel3.TabIndex = 0;
            // 
            // lbPlca
            // 
            this.lbPlca.AutoSize = true;
            this.lbPlca.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbPlca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlca.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPlca.Location = new System.Drawing.Point(84, 0);
            this.lbPlca.Name = "lbPlca";
            this.lbPlca.Size = new System.Drawing.Size(64, 23);
            this.lbPlca.TabIndex = 1;
            this.lbPlca.Text = "Placa";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 23;
            this.bunifuElipse1.TargetControl = this.dgvTabla;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // FrmPagoMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagoMulta";
            this.Text = "FrmPagoMulta";
            this.pnSuperior.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.pnBusqueda.ResumeLayout(false);
            this.pnBusqueda.PerformLayout();
            this.pnCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnInferior.ResumeLayout(false);
            this.pnInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSuperior;
        private Guna.UI2.WinForms.Guna2Panel pnCentral;
        private Guna.UI2.WinForms.Guna2Panel pnInferior;
        private Guna.UI2.WinForms.Guna2Panel pnBusqueda;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbPlca;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnPagar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pcImage;
        private Guna.UI2.WinForms.Guna2ComboBox cmFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoMultaPagar;
        private System.Windows.Forms.Label lbCodigoMultaPagar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCodigoMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescripcionMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIdentificacionU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmApellidoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnValorMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmEstadoM;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
    }
}