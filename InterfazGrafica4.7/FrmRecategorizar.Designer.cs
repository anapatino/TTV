
namespace InterfazGrafica4._7
{
    partial class FrmRecategorizar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecategorizar));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmCodigoLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmOrganismo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnFechaExpedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pcImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.bnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigoLicencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 23;
            this.bunifuElipse2.TargetControl = this.dgvTabla;
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
            this.dgvTabla.ColumnHeadersHeight = 36;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmCodigoLicencia,
            this.cmCedula,
            this.cmNombre,
            this.cmApellido,
            this.cmGrupo,
            this.cmOrganismo,
            this.cmCategoria,
            this.cnFechaExpedicion});
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.dgvTabla.Location = new System.Drawing.Point(45, 247);
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
            this.dgvTabla.Size = new System.Drawing.Size(678, 212);
            this.dgvTabla.TabIndex = 55;
            this.dgvTabla.Visible = false;
            // 
            // cmCodigoLicencia
            // 
            this.cmCodigoLicencia.HeaderText = "Codigo Licencia";
            this.cmCodigoLicencia.Name = "cmCodigoLicencia";
            this.cmCodigoLicencia.ReadOnly = true;
            // 
            // cmCedula
            // 
            this.cmCedula.HeaderText = "Cedula";
            this.cmCedula.Name = "cmCedula";
            this.cmCedula.ReadOnly = true;
            // 
            // cmNombre
            // 
            this.cmNombre.HeaderText = "Nombre";
            this.cmNombre.Name = "cmNombre";
            this.cmNombre.ReadOnly = true;
            // 
            // cmApellido
            // 
            this.cmApellido.HeaderText = "Apellido";
            this.cmApellido.Name = "cmApellido";
            this.cmApellido.ReadOnly = true;
            // 
            // cmGrupo
            // 
            this.cmGrupo.HeaderText = "Grupo";
            this.cmGrupo.Name = "cmGrupo";
            this.cmGrupo.ReadOnly = true;
            // 
            // cmOrganismo
            // 
            this.cmOrganismo.HeaderText = "Organismo";
            this.cmOrganismo.Name = "cmOrganismo";
            this.cmOrganismo.ReadOnly = true;
            // 
            // cmCategoria
            // 
            this.cmCategoria.HeaderText = "Categoria";
            this.cmCategoria.Name = "cmCategoria";
            this.cmCategoria.ReadOnly = true;
            // 
            // cnFechaExpedicion
            // 
            this.cnFechaExpedicion.HeaderText = "Fecha Expedicion";
            this.cnFechaExpedicion.Name = "cnFechaExpedicion";
            this.cnFechaExpedicion.ReadOnly = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.pcImage);
            this.bunifuPanel1.Location = new System.Drawing.Point(45, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(510, 127);
            this.bunifuPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(348, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Licencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(200, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recategorizar";
            // 
            // pcImage
            // 
            this.pcImage.BackColor = System.Drawing.Color.Transparent;
            this.pcImage.Image = global::InterfazGrafica4._7.Properties.Resources.Notes_bro;
            this.pcImage.Location = new System.Drawing.Point(-84, -38);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Parent = this.pcImage;
            this.pcImage.Size = new System.Drawing.Size(373, 199);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 4;
            this.pcImage.TabStop = false;
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
            "TODO",
            "IDENTIFICACION",
            "NOMBRE",
            "CATEGORIA",
            "ORGANISMO",
            "ANIO"});
            this.cmFiltro.ItemsAppearance.Parent = this.cmFiltro;
            this.cmFiltro.Location = new System.Drawing.Point(144, 180);
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
            this.lbFiltro.Location = new System.Drawing.Point(92, 187);
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
            this.txtFiltro.Location = new System.Drawing.Point(325, 181);
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
            this.btnBuscar.Location = new System.Drawing.Point(607, 181);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(45, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategoria.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategoria.BorderRadius = 15;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategoria.FocusedState.Parent = this.cmbCategoria;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.HoverState.Parent = this.cmbCategoria;
            this.cmbCategoria.ItemHeight = 30;
            this.cmbCategoria.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3"});
            this.cmbCategoria.ItemsAppearance.Parent = this.cmbCategoria;
            this.cmbCategoria.Location = new System.Drawing.Point(144, 524);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.ShadowDecoration.Parent = this.cmbCategoria;
            this.cmbCategoria.Size = new System.Drawing.Size(174, 36);
            this.cmbCategoria.TabIndex = 53;
            this.cmbCategoria.Visible = false;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(63, 535);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(75, 17);
            this.lbCategoria.TabIndex = 52;
            this.lbCategoria.Text = "Categoria";
            this.lbCategoria.Visible = false;
            // 
            // bnGuardar
            // 
            this.bnGuardar.BorderRadius = 15;
            this.bnGuardar.CheckedState.Parent = this.bnGuardar;
            this.bnGuardar.CustomImages.Parent = this.bnGuardar;
            this.bnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(33)))));
            this.bnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnGuardar.ForeColor = System.Drawing.Color.White;
            this.bnGuardar.HoverState.Parent = this.bnGuardar;
            this.bnGuardar.Location = new System.Drawing.Point(454, 553);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.ShadowDecoration.Parent = this.bnGuardar;
            this.bnGuardar.Size = new System.Drawing.Size(114, 30);
            this.bnGuardar.TabIndex = 54;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.Visible = false;
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.BorderRadius = 15;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.Location = new System.Drawing.Point(584, 553);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 56;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Visible = false;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // txtCodigoLicencia
            // 
            this.txtCodigoLicencia.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoLicencia.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoLicencia.BorderRadius = 15;
            this.txtCodigoLicencia.BorderThickness = 2;
            this.txtCodigoLicencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoLicencia.DefaultText = "";
            this.txtCodigoLicencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoLicencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoLicencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoLicencia.DisabledState.Parent = this.txtCodigoLicencia;
            this.txtCodigoLicencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoLicencia.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoLicencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoLicencia.FocusedState.Parent = this.txtCodigoLicencia;
            this.txtCodigoLicencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLicencia.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoLicencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoLicencia.HoverState.Parent = this.txtCodigoLicencia;
            this.txtCodigoLicencia.Location = new System.Drawing.Point(144, 480);
            this.txtCodigoLicencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoLicencia.Name = "txtCodigoLicencia";
            this.txtCodigoLicencia.PasswordChar = '\0';
            this.txtCodigoLicencia.PlaceholderText = "";
            this.txtCodigoLicencia.SelectedText = "";
            this.txtCodigoLicencia.ShadowDecoration.Parent = this.txtCodigoLicencia;
            this.txtCodigoLicencia.Size = new System.Drawing.Size(174, 36);
            this.txtCodigoLicencia.TabIndex = 58;
            this.txtCodigoLicencia.Visible = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(58, 490);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(79, 17);
            this.lbCodigo.TabIndex = 59;
            this.lbCodigo.Text = "Codigo Lic";
            this.lbCodigo.Visible = false;
            // 
            // FrmRecategorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtCodigoLicencia);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmFiltro);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecategorizar";
            this.Text = "FrmRecategorizar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox pcImage;
        private Guna.UI2.WinForms.Guna2ComboBox cmFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2Button bnGuardar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCodigoLicencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmOrganismo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnFechaExpedicion;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private System.Windows.Forms.Label lbCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoLicencia;
    }
}