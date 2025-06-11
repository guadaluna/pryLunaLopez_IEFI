namespace pryLunaLopez_IEFI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripStatusLblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatusLblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatusLblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.picEscritorio = new System.Windows.Forms.PictureBox();
            this.btnTareas = new System.Windows.Forms.Button();
            this.panelTareasSubMenu = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnRegistrarTarea = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new Sunny.UI.UIButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscritorio)).BeginInit();
            this.panelTareasSubMenu.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatusLblUsuario,
            this.stripStatusLblFecha,
            this.stripStatusLblTiempo});
            this.statusStrip.Location = new System.Drawing.Point(250, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // stripStatusLblUsuario
            // 
            this.stripStatusLblUsuario.Name = "stripStatusLblUsuario";
            this.stripStatusLblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // stripStatusLblFecha
            // 
            this.stripStatusLblFecha.Name = "stripStatusLblFecha";
            this.stripStatusLblFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // stripStatusLblTiempo
            // 
            this.stripStatusLblTiempo.Name = "stripStatusLblTiempo";
            this.stripStatusLblTiempo.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.picEscritorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.MistyRose;
            this.lblBienvenido.Location = new System.Drawing.Point(65, 42);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(25, 24);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "   ";
            // 
            // picEscritorio
            // 
            this.picEscritorio.Image = global::pryLunaLopez_IEFI.Properties.Resources.OfficeBlack1;
            this.picEscritorio.Location = new System.Drawing.Point(0, 0);
            this.picEscritorio.Name = "picEscritorio";
            this.picEscritorio.Size = new System.Drawing.Size(63, 100);
            this.picEscritorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEscritorio.TabIndex = 0;
            this.picEscritorio.TabStop = false;
            // 
            // btnTareas
            // 
            this.btnTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.Linen;
            this.btnTareas.Location = new System.Drawing.Point(0, 100);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTareas.Size = new System.Drawing.Size(250, 45);
            this.btnTareas.TabIndex = 1;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // panelTareasSubMenu
            // 
            this.panelTareasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.panelTareasSubMenu.Controls.Add(this.btnHistorial);
            this.panelTareasSubMenu.Controls.Add(this.btnRegistrarTarea);
            this.panelTareasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTareasSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelTareasSubMenu.Name = "panelTareasSubMenu";
            this.panelTareasSubMenu.Size = new System.Drawing.Size(250, 81);
            this.panelTareasSubMenu.TabIndex = 2;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.ForeColor = System.Drawing.Color.Linen;
            this.btnHistorial.Image = global::pryLunaLopez_IEFI.Properties.Resources.Activity_History;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 40);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(250, 41);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "       Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarTarea.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarea.ForeColor = System.Drawing.Color.Linen;
            this.btnRegistrarTarea.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarTarea.Image")));
            this.btnRegistrarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarTarea.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarTarea.Size = new System.Drawing.Size(250, 40);
            this.btnRegistrarTarea.TabIndex = 3;
            this.btnRegistrarTarea.Text = "       Registrar tarea";
            this.btnRegistrarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarTarea.UseVisualStyleBackColor = true;
            this.btnRegistrarTarea.Click += new System.EventHandler(this.btnRegistrarTarea_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Linen;
            this.btnAdmin.Location = new System.Drawing.Point(0, 226);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(250, 45);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Administración";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.panelAdminSubMenu.Controls.Add(this.btnAuditoria);
            this.panelAdminSubMenu.Controls.Add(this.btnUsuarios);
            this.panelAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSubMenu.Location = new System.Drawing.Point(0, 271);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(250, 82);
            this.panelAdminSubMenu.TabIndex = 4;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoria.FlatAppearance.BorderSize = 0;
            this.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoria.ForeColor = System.Drawing.Color.Linen;
            this.btnAuditoria.Image = global::pryLunaLopez_IEFI.Properties.Resources.Analyze;
            this.btnAuditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.Location = new System.Drawing.Point(0, 40);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAuditoria.Size = new System.Drawing.Size(250, 40);
            this.btnAuditoria.TabIndex = 4;
            this.btnAuditoria.Text = "       Auditoria";
            this.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Linen;
            this.btnUsuarios.Image = global::pryLunaLopez_IEFI.Properties.Resources.Users;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "       Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.panelMenuLateral.Controls.Add(this.panelAdminSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnAdmin);
            this.panelMenuLateral.Controls.Add(this.panelTareasSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnTareas);
            this.panelMenuLateral.Controls.Add(this.panel1);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 749);
            this.panelMenuLateral.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnCerrarSesion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnCerrarSesion.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnCerrarSesion.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnCerrarSesion.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 714);
            this.btnCerrarSesion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(188)))), ((int)(((byte)(177)))));
            this.btnCerrarSesion.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnCerrarSesion.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnCerrarSesion.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 35);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormulario.AutoScroll = true;
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.panelFormulario.Location = new System.Drawing.Point(260, 10);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(992, 702);
            this.panelFormulario.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryLunaLopez_IEFI.Properties.Resources.Capas_onduladas_y_círculos_azules;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscritorio)).EndInit();
            this.panelTareasSubMenu.ResumeLayout(false);
            this.panelAdminSubMenu.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Panel panelTareasSubMenu;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnRegistrarTarea;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLblFecha;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLblTiempo;
        private System.Windows.Forms.Panel panelFormulario;
        private Sunny.UI.UIButton btnCerrarSesion;
        private System.Windows.Forms.PictureBox picEscritorio;
        private System.Windows.Forms.Label lblBienvenido;
    }
}