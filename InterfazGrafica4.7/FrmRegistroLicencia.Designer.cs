
namespace InterfazGrafica4._7
{
    partial class FrmRegistroLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroLicencia));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbFechaExpedicion = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.bnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.bnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.lbMulta = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnImage = new Bunifu.UI.WinForms.BunifuPanel();
            this.pcImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrupoSanguineo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFechaExpedicion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFechaNacimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRAR";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(266, 109);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(61, 17);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(505, 109);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(61, 17);
            this.lbApellido.TabIndex = 5;
            this.lbApellido.Text = "Apellido";
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
            this.txtCedula.Location = new System.Drawing.Point(41, 129);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.PlaceholderText = "";
            this.txtCedula.SelectedText = "";
            this.txtCedula.ShadowDecoration.Parent = this.txtCedula;
            this.txtCedula.Size = new System.Drawing.Size(185, 30);
            this.txtCedula.TabIndex = 6;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(31, 108);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(56, 17);
            this.lbCedula.TabIndex = 7;
            this.lbCedula.Text = "Cedula";
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(31, 186);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(127, 17);
            this.lbFechaNacimiento.TabIndex = 9;
            this.lbFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(264, 186);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(62, 17);
            this.lbTelefono.TabIndex = 11;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupo.Location = new System.Drawing.Point(507, 186);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(29, 17);
            this.lbGrupo.TabIndex = 13;
            this.lbGrupo.Text = "G.S";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(509, 266);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(69, 17);
            this.lbDireccion.TabIndex = 14;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbFechaExpedicion
            // 
            this.lbFechaExpedicion.AutoSize = true;
            this.lbFechaExpedicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaExpedicion.Location = new System.Drawing.Point(269, 266);
            this.lbFechaExpedicion.Name = "lbFechaExpedicion";
            this.lbFechaExpedicion.Size = new System.Drawing.Size(121, 17);
            this.lbFechaExpedicion.TabIndex = 16;
            this.lbFechaExpedicion.Text = "Fecha Expedicion";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(26, 266);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(75, 17);
            this.lbCategoria.TabIndex = 19;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(32, 349);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 20;
            this.lbPrecio.Text = "Precio";
            // 
            // bnCalcular
            // 
            this.bnCalcular.BorderRadius = 15;
            this.bnCalcular.CheckedState.Parent = this.bnCalcular;
            this.bnCalcular.CustomImages.Parent = this.bnCalcular;
            this.bnCalcular.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.bnCalcular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCalcular.ForeColor = System.Drawing.Color.White;
            this.bnCalcular.HoverState.Parent = this.bnCalcular;
            this.bnCalcular.Location = new System.Drawing.Point(242, 386);
            this.bnCalcular.Name = "bnCalcular";
            this.bnCalcular.ShadowDecoration.Parent = this.bnCalcular;
            this.bnCalcular.Size = new System.Drawing.Size(114, 30);
            this.bnCalcular.TabIndex = 22;
            this.bnCalcular.Text = "Calcular";
            this.bnCalcular.Click += new System.EventHandler(this.bnCalcular_Click);
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
            this.bnRegistrar.Location = new System.Drawing.Point(100, 470);
            this.bnRegistrar.Name = "bnRegistrar";
            this.bnRegistrar.ShadowDecoration.Parent = this.bnRegistrar;
            this.bnRegistrar.Size = new System.Drawing.Size(114, 30);
            this.bnRegistrar.TabIndex = 23;
            this.bnRegistrar.Text = "Registrar";
            this.bnRegistrar.Click += new System.EventHandler(this.bnRegistrar_Click);
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
            this.bnLimpiar.Location = new System.Drawing.Point(267, 470);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(114, 30);
            this.bnLimpiar.TabIndex = 24;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.BackColor = System.Drawing.Color.Transparent;
            this.lbMulta.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.lbMulta.Location = new System.Drawing.Point(235, 40);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(177, 41);
            this.lbMulta.TabIndex = 25;
            this.lbMulta.Text = "LICENCIA";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnImage
            // 
            this.pnImage.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnImage.BackgroundImage")));
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnImage.BorderColor = System.Drawing.Color.Transparent;
            this.pnImage.BorderRadius = 3;
            this.pnImage.BorderThickness = 1;
            this.pnImage.Controls.Add(this.pcImage);
            this.pnImage.Location = new System.Drawing.Point(480, 330);
            this.pnImage.Name = "pnImage";
            this.pnImage.ShowBorders = true;
            this.pnImage.Size = new System.Drawing.Size(300, 284);
            this.pnImage.TabIndex = 26;
            // 
            // pcImage
            // 
            this.pcImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcImage.Image = global::InterfazGrafica4._7.Properties.Resources.Creativity_amico1;
            this.pcImage.Location = new System.Drawing.Point(0, 0);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Parent = this.pcImage;
            this.pcImage.Size = new System.Drawing.Size(300, 284);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(270, 129);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(185, 30);
            this.txtNombre.TabIndex = 28;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderRadius = 15;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.DisabledState.Parent = this.txtApellido;
            this.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.FocusedState.Parent = this.txtApellido;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.HoverState.Parent = this.txtApellido;
            this.txtApellido.Location = new System.Drawing.Point(512, 129);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.SelectedText = "";
            this.txtApellido.ShadowDecoration.Parent = this.txtApellido;
            this.txtApellido.Size = new System.Drawing.Size(185, 30);
            this.txtApellido.TabIndex = 29;
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
            this.txtTelefono.Location = new System.Drawing.Point(269, 206);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(185, 30);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtGrupoSanguineo
            // 
            this.txtGrupoSanguineo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrupoSanguineo.BorderRadius = 15;
            this.txtGrupoSanguineo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrupoSanguineo.DefaultText = "";
            this.txtGrupoSanguineo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrupoSanguineo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrupoSanguineo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoSanguineo.DisabledState.Parent = this.txtGrupoSanguineo;
            this.txtGrupoSanguineo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoSanguineo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrupoSanguineo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrupoSanguineo.FocusedState.Parent = this.txtGrupoSanguineo;
            this.txtGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoSanguineo.ForeColor = System.Drawing.Color.DimGray;
            this.txtGrupoSanguineo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrupoSanguineo.HoverState.Parent = this.txtGrupoSanguineo;
            this.txtGrupoSanguineo.Location = new System.Drawing.Point(512, 207);
            this.txtGrupoSanguineo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrupoSanguineo.Name = "txtGrupoSanguineo";
            this.txtGrupoSanguineo.PasswordChar = '\0';
            this.txtGrupoSanguineo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrupoSanguineo.PlaceholderText = "";
            this.txtGrupoSanguineo.SelectedText = "";
            this.txtGrupoSanguineo.ShadowDecoration.Parent = this.txtGrupoSanguineo;
            this.txtGrupoSanguineo.Size = new System.Drawing.Size(185, 30);
            this.txtGrupoSanguineo.TabIndex = 31;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderRadius = 15;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.Parent = this.txtDireccion;
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.FocusedState.Parent = this.txtDireccion;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.HoverState.Parent = this.txtDireccion;
            this.txtDireccion.Location = new System.Drawing.Point(512, 293);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.ShadowDecoration.Parent = this.txtDireccion;
            this.txtDireccion.Size = new System.Drawing.Size(185, 30);
            this.txtDireccion.TabIndex = 33;
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
            this.txtPrecio.Location = new System.Drawing.Point(34, 386);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(181, 30);
            this.txtPrecio.TabIndex = 34;
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
            this.cmCategoria.Location = new System.Drawing.Point(34, 286);
            this.cmCategoria.Name = "cmCategoria";
            this.cmCategoria.ShadowDecoration.Parent = this.cmCategoria;
            this.cmCategoria.Size = new System.Drawing.Size(181, 36);
            this.cmCategoria.TabIndex = 35;
            // 
            // txtFechaExpedicion
            // 
            this.txtFechaExpedicion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaExpedicion.BorderRadius = 15;
            this.txtFechaExpedicion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaExpedicion.DefaultText = "";
            this.txtFechaExpedicion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFechaExpedicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFechaExpedicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaExpedicion.DisabledState.Parent = this.txtFechaExpedicion;
            this.txtFechaExpedicion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaExpedicion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaExpedicion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaExpedicion.FocusedState.Parent = this.txtFechaExpedicion;
            this.txtFechaExpedicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaExpedicion.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaExpedicion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaExpedicion.HoverState.Parent = this.txtFechaExpedicion;
            this.txtFechaExpedicion.Location = new System.Drawing.Point(269, 292);
            this.txtFechaExpedicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaExpedicion.Name = "txtFechaExpedicion";
            this.txtFechaExpedicion.PasswordChar = '\0';
            this.txtFechaExpedicion.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaExpedicion.PlaceholderText = "";
            this.txtFechaExpedicion.SelectedText = "";
            this.txtFechaExpedicion.ShadowDecoration.Parent = this.txtFechaExpedicion;
            this.txtFechaExpedicion.Size = new System.Drawing.Size(185, 30);
            this.txtFechaExpedicion.TabIndex = 36;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaNacimiento.BorderRadius = 15;
            this.txtFechaNacimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaNacimiento.DefaultText = "";
            this.txtFechaNacimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFechaNacimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFechaNacimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaNacimiento.DisabledState.Parent = this.txtFechaNacimiento;
            this.txtFechaNacimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaNacimiento.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaNacimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaNacimiento.FocusedState.Parent = this.txtFechaNacimiento;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaNacimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaNacimiento.HoverState.Parent = this.txtFechaNacimiento;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(41, 207);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PasswordChar = '\0';
            this.txtFechaNacimiento.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaNacimiento.PlaceholderText = "";
            this.txtFechaNacimiento.SelectedText = "";
            this.txtFechaNacimiento.ShadowDecoration.Parent = this.txtFechaNacimiento;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(185, 30);
            this.txtFechaNacimiento.TabIndex = 37;
            // 
            // FrmRegistroLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtFechaExpedicion);
            this.Controls.Add(this.cmCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtGrupoSanguineo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnImage);
            this.Controls.Add(this.lbMulta);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnRegistrar);
            this.Controls.Add(this.bnCalcular);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbFechaExpedicion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbGrupo);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroLicencia";
            this.Text = "FrmRegistroLicencia";
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbGrupo;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbFechaExpedicion;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbPrecio;
        private Guna.UI2.WinForms.Guna2Button bnCalcular;
        private Guna.UI2.WinForms.Guna2Button bnRegistrar;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private System.Windows.Forms.Label lbMulta;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel pnImage;
        private Guna.UI2.WinForms.Guna2PictureBox pcImage;
        private Guna.UI2.WinForms.Guna2ComboBox cmCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private Guna.UI2.WinForms.Guna2TextBox txtGrupoSanguineo;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        protected Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtFechaNacimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtFechaExpedicion;
    }
}