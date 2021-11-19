
namespace InterfazGrafica4._7
{
    partial class FrmConsultaMulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMulta));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmCodigoMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescripcionMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmIdentificacionU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmApellidoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnValorMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmEstadoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnCentral = new Bunifu.UI.WinForms.BunifuPanel();
            this.cmFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.pnSuperior = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnCentral.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 23;
            this.bunifuElipse1.TargetControl = this.dgvTabla;
            // 
            // dgvTabla
            // 
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
            this.cmCodigoMulta,
            this.cmDescripcionMulta,
            this.cmIdentificacionU,
            this.cmNombreU,
            this.cmApellidoU,
            this.cnValorMulta,
            this.cmFecha,
            this.cmEstadoM});
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(46)))));
            this.dgvTabla.Location = new System.Drawing.Point(51, 75);
            this.dgvTabla.Name = "dgvTabla";
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
            this.dgvTabla.TabIndex = 46;
            // 
            // cmCodigoMulta
            // 
            this.cmCodigoMulta.HeaderText = "Codigo Multa";
            this.cmCodigoMulta.Name = "cmCodigoMulta";
            // 
            // cmDescripcionMulta
            // 
            this.cmDescripcionMulta.HeaderText = "Descripcion";
            this.cmDescripcionMulta.Name = "cmDescripcionMulta";
            // 
            // cmIdentificacionU
            // 
            this.cmIdentificacionU.HeaderText = "Identificacion";
            this.cmIdentificacionU.Name = "cmIdentificacionU";
            // 
            // cmNombreU
            // 
            this.cmNombreU.HeaderText = "Nombre";
            this.cmNombreU.Name = "cmNombreU";
            // 
            // cmApellidoU
            // 
            this.cmApellidoU.HeaderText = "Apellido";
            this.cmApellidoU.Name = "cmApellidoU";
            // 
            // cnValorMulta
            // 
            this.cnValorMulta.HeaderText = "Valor";
            this.cnValorMulta.Name = "cnValorMulta";
            // 
            // cmFecha
            // 
            this.cmFecha.HeaderText = "Fecha";
            this.cmFecha.Name = "cmFecha";
            // 
            // cmEstadoM
            // 
            this.cmEstadoM.HeaderText = "Estado";
            this.cmEstadoM.Name = "cmEstadoM";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pnCentral
            // 
            this.pnCentral.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCentral.BackgroundImage")));
            this.pnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnCentral.BorderColor = System.Drawing.Color.Transparent;
            this.pnCentral.BorderRadius = 3;
            this.pnCentral.BorderThickness = 1;
            this.pnCentral.Controls.Add(this.dgvTabla);
            this.pnCentral.Controls.Add(this.cmFiltro);
            this.pnCentral.Controls.Add(this.lbFiltro);
            this.pnCentral.Controls.Add(this.txtFiltro);
            this.pnCentral.Controls.Add(this.btnBuscar);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCentral.Location = new System.Drawing.Point(0, 180);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.ShowBorders = true;
            this.pnCentral.Size = new System.Drawing.Size(780, 357);
            this.pnCentral.TabIndex = 2;
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
            this.cmFiltro.ItemsAppearance.Parent = this.cmFiltro;
            this.cmFiltro.Location = new System.Drawing.Point(135, 15);
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
            this.lbFiltro.Location = new System.Drawing.Point(83, 22);
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
            this.txtFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.txtFiltro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltro.HoverState.Parent = this.txtFiltro;
            this.txtFiltro.Location = new System.Drawing.Point(316, 16);
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
            this.btnBuscar.Location = new System.Drawing.Point(598, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(45, 35);
            this.btnBuscar.TabIndex = 42;
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSuperior.BackgroundImage")));
            this.pnSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnSuperior.BorderColor = System.Drawing.Color.Transparent;
            this.pnSuperior.BorderRadius = 45;
            this.pnSuperior.BorderThickness = 1;
            this.pnSuperior.Controls.Add(this.bunifuPanel1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.ShowBorders = true;
            this.pnSuperior.Size = new System.Drawing.Size(780, 180);
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
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.pcImage);
            this.bunifuPanel1.Location = new System.Drawing.Point(45, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(510, 127);
            this.bunifuPanel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar";
            // 
            // pcImage
            // 
            this.pcImage.BackColor = System.Drawing.Color.Transparent;
            this.pcImage.Image = global::InterfazGrafica4._7.Properties.Resources.Blog_post_bro;
            this.pcImage.Location = new System.Drawing.Point(-82, -23);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Parent = this.pcImage;
            this.pcImage.Size = new System.Drawing.Size(373, 199);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 4;
            this.pcImage.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.BorderColor = System.Drawing.Color.LightGray;
            this.txtValor.BorderRadius = 15;
            this.txtValor.BorderThickness = 2;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.Parent = this.txtValor;
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FillColor = System.Drawing.Color.LightGray;
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedState.Parent = this.txtValor;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.HoverState.Parent = this.txtValor;
            this.txtValor.Location = new System.Drawing.Point(534, 557);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.ShadowDecoration.Parent = this.txtValor;
            this.txtValor.Size = new System.Drawing.Size(205, 34);
            this.txtValor.TabIndex = 50;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.DimGray;
            this.lbValor.Location = new System.Drawing.Point(435, 566);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(95, 17);
            this.lbValor.TabIndex = 49;
            this.lbValor.Text = "Total a Pagar";
            // 
            // FrmConsultaMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 614);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaMulta";
            this.Text = "FrmConsultaMulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnCentral.ResumeLayout(false);
            this.pnCentral.PerformLayout();
            this.pnSuperior.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnSuperior;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pcImage;
        private Bunifu.UI.WinForms.BunifuPanel pnCentral;
        private Guna.UI2.WinForms.Guna2ComboBox cmFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCodigoMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescripcionMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIdentificacionU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmApellidoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnValorMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmEstadoM;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private System.Windows.Forms.Label lbValor;
    }
}