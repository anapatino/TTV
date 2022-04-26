
namespace InterfazGrafica4._7
{
    partial class FrmCargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargando));
            this.pcImagenLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Progress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenLogin)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcImagenLogin
            // 
            this.pcImagenLogin.Image = global::InterfazGrafica4._7.Properties.Resources.Clémence_Thune_on_Behance;
            this.pcImagenLogin.Location = new System.Drawing.Point(-44, -10);
            this.pcImagenLogin.Name = "pcImagenLogin";
            this.pcImagenLogin.ShadowDecoration.Parent = this.pcImagenLogin;
            this.pcImagenLogin.Size = new System.Drawing.Size(523, 550);
            this.pcImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagenLogin.TabIndex = 2;
            this.pcImagenLogin.TabStop = false;
            // 
            // Progress
            // 
            this.Progress.Animated = false;
            this.Progress.AnimationInterval = 1;
            this.Progress.AnimationSpeed = 1;
            this.Progress.BackColor = System.Drawing.Color.Transparent;
            this.Progress.CircleMargin = 10;
            this.Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Progress.IsPercentage = true;
            this.Progress.LineProgressThickness = 10;
            this.Progress.LineThickness = 10;
            this.Progress.Location = new System.Drawing.Point(77, 141);
            this.Progress.Name = "Progress";
            this.Progress.ProgressAnimationSpeed = 200;
            this.Progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.Progress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.Progress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.Progress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.Progress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.Progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Progress.Size = new System.Drawing.Size(184, 184);
            this.Progress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Progress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.Progress.SubScriptText = ".00";
            this.Progress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Progress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.Progress.SuperScriptText = "%";
            this.Progress.TabIndex = 16;
            this.Progress.Text = "30";
            this.Progress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Progress.Value = 30;
            this.Progress.ValueByTransition = 30;
            this.Progress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ingresando...";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Controls.Add(this.Progress);
            this.pnPrincipal.Location = new System.Drawing.Point(498, 12);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(347, 443);
            this.pnPrincipal.TabIndex = 18;
            // 
            // FrmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(857, 527);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pcImagenLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCargando";
            this.Load += new System.EventHandler(this.FrmCargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenLogin)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcImagenLogin;
        private Bunifu.UI.WinForms.BunifuCircleProgress Progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnPrincipal;
    }
}