
namespace InterfazGrafica4._7
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnIzquierdo = new Guna.UI2.WinForms.Guna2Panel();
            this.pcImagenLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.linkRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chxOcultarPassword = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.pnIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenLogin)).BeginInit();
            this.pnSuperior.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Animated = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FillColor = System.Drawing.Color.Transparent;
            this.btnSalir.HoverState.Parent = this.btnSalir;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnSalir.Location = new System.Drawing.Point(328, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ShadowDecoration.BorderRadius = 9;
            this.btnSalir.ShadowDecoration.Parent = this.btnSalir;
            this.btnSalir.Size = new System.Drawing.Size(50, 36);
            this.btnSalir.TabIndex = 0;
            // 
            // pnIzquierdo
            // 
            this.pnIzquierdo.Controls.Add(this.pcImagenLogin);
            this.pnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnIzquierdo.Name = "pnIzquierdo";
            this.pnIzquierdo.ShadowDecoration.Parent = this.pnIzquierdo;
            this.pnIzquierdo.Size = new System.Drawing.Size(479, 527);
            this.pnIzquierdo.TabIndex = 2;
            // 
            // pcImagenLogin
            // 
            this.pcImagenLogin.BackColor = System.Drawing.Color.Transparent;
            this.pcImagenLogin.Image = global::InterfazGrafica4._7.Properties.Resources.Clémence_Thune_on_Behance;
            this.pcImagenLogin.Location = new System.Drawing.Point(-44, -10);
            this.pcImagenLogin.Name = "pcImagenLogin";
            this.pcImagenLogin.ShadowDecoration.Parent = this.pcImagenLogin;
            this.pcImagenLogin.Size = new System.Drawing.Size(523, 550);
            this.pcImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagenLogin.TabIndex = 1;
            this.pcImagenLogin.TabStop = false;
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.btnSalir);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(479, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.ShadowDecoration.Parent = this.pnSuperior;
            this.pnSuperior.Size = new System.Drawing.Size(378, 36);
            this.pnSuperior.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 22;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(23)))));
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(95, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(142, 45);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Cornsilk;
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Cornsilk;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(31, 236);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(276, 38);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Cornsilk;
            this.txtUsername.BorderRadius = 18;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.Cornsilk;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(31, 143);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(276, 38);
            this.txtUsername.TabIndex = 13;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLogin.Location = new System.Drawing.Point(33, 71);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(151, 20);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "Login your account";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDescripcion.Location = new System.Drawing.Point(24, 30);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(273, 41);
            this.lbDescripcion.TabIndex = 10;
            this.lbDescripcion.Text = "Welcome Back";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 48;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.linkRecuperarContrasena);
            this.bunifuPanel1.Controls.Add(this.lbPassword);
            this.bunifuPanel1.Controls.Add(this.lbUsername);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.chxOcultarPassword);
            this.bunifuPanel1.Controls.Add(this.btnLogin);
            this.bunifuPanel1.Controls.Add(this.lbDescripcion);
            this.bunifuPanel1.Controls.Add(this.txtPassword);
            this.bunifuPanel1.Controls.Add(this.lbLogin);
            this.bunifuPanel1.Controls.Add(this.txtUsername);
            this.bunifuPanel1.Location = new System.Drawing.Point(495, 42);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(333, 448);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // linkRecuperarContrasena
            // 
            this.linkRecuperarContrasena.AutoSize = true;
            this.linkRecuperarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.linkRecuperarContrasena.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkRecuperarContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRecuperarContrasena.ForeColor = System.Drawing.Color.Transparent;
            this.linkRecuperarContrasena.LinkColor = System.Drawing.Color.White;
            this.linkRecuperarContrasena.Location = new System.Drawing.Point(64, 406);
            this.linkRecuperarContrasena.Name = "linkRecuperarContrasena";
            this.linkRecuperarContrasena.Size = new System.Drawing.Size(214, 17);
            this.linkRecuperarContrasena.TabIndex = 21;
            this.linkRecuperarContrasena.TabStop = true;
            this.linkRecuperarContrasena.Text = "¿Desea Recuperar Contraseña?";
            this.linkRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperarContrasena_LinkClicked);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPassword.Location = new System.Drawing.Point(28, 215);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(69, 17);
            this.lbPassword.TabIndex = 20;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUsername.Location = new System.Drawing.Point(28, 122);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(71, 17);
            this.lbUsername.TabIndex = 19;
            this.lbUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ocultar Password";
            // 
            // chxOcultarPassword
            // 
            this.chxOcultarPassword.AllowBindingControlAnimation = true;
            this.chxOcultarPassword.AllowBindingControlColorChanges = false;
            this.chxOcultarPassword.AllowBindingControlLocation = true;
            this.chxOcultarPassword.AllowCheckBoxAnimation = false;
            this.chxOcultarPassword.AllowCheckmarkAnimation = true;
            this.chxOcultarPassword.AllowOnHoverStates = true;
            this.chxOcultarPassword.AutoCheck = true;
            this.chxOcultarPassword.BackColor = System.Drawing.Color.Transparent;
            this.chxOcultarPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chxOcultarPassword.BackgroundImage")));
            this.chxOcultarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chxOcultarPassword.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chxOcultarPassword.BorderRadius = 12;
            this.chxOcultarPassword.Checked = true;
            this.chxOcultarPassword.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chxOcultarPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.chxOcultarPassword.CustomCheckmarkImage = null;
            this.chxOcultarPassword.Location = new System.Drawing.Point(37, 297);
            this.chxOcultarPassword.MinimumSize = new System.Drawing.Size(17, 17);
            this.chxOcultarPassword.Name = "chxOcultarPassword";
            this.chxOcultarPassword.OnCheck.BorderColor = System.Drawing.Color.Transparent;
            this.chxOcultarPassword.OnCheck.BorderRadius = 12;
            this.chxOcultarPassword.OnCheck.BorderThickness = 2;
            this.chxOcultarPassword.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(132)))), ((int)(((byte)(35)))));
            this.chxOcultarPassword.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chxOcultarPassword.OnCheck.CheckmarkThickness = 2;
            this.chxOcultarPassword.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chxOcultarPassword.OnDisable.BorderRadius = 12;
            this.chxOcultarPassword.OnDisable.BorderThickness = 2;
            this.chxOcultarPassword.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chxOcultarPassword.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chxOcultarPassword.OnDisable.CheckmarkThickness = 2;
            this.chxOcultarPassword.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chxOcultarPassword.OnHoverChecked.BorderRadius = 12;
            this.chxOcultarPassword.OnHoverChecked.BorderThickness = 2;
            this.chxOcultarPassword.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chxOcultarPassword.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chxOcultarPassword.OnHoverChecked.CheckmarkThickness = 2;
            this.chxOcultarPassword.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chxOcultarPassword.OnHoverUnchecked.BorderRadius = 12;
            this.chxOcultarPassword.OnHoverUnchecked.BorderThickness = 1;
            this.chxOcultarPassword.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chxOcultarPassword.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chxOcultarPassword.OnUncheck.BorderRadius = 12;
            this.chxOcultarPassword.OnUncheck.BorderThickness = 1;
            this.chxOcultarPassword.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chxOcultarPassword.Size = new System.Drawing.Size(21, 21);
            this.chxOcultarPassword.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chxOcultarPassword.TabIndex = 17;
            this.chxOcultarPassword.ThreeState = false;
            this.chxOcultarPassword.ToolTipText = null;
            this.chxOcultarPassword.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chxOcultarPassword_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(857, 527);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.pnIzquierdo);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngresar";
            this.pnIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenLogin)).EndInit();
            this.pnSuperior.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox btnSalir;
        private Guna.UI2.WinForms.Guna2Panel pnIzquierdo;
        private Guna.UI2.WinForms.Guna2Panel pnSuperior;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbDescripcion;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox pcImagenLogin;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox chxOcultarPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.LinkLabel linkRecuperarContrasena;
    }
}