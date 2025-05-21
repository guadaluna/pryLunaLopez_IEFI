namespace pryLunaLopez_IEFI
{
    partial class frmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panelIniciarSesion = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.picVerContraseña = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.imgCandado = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new ReaLTaiizor.Controls.Button();
            this.lblContraseña = new ReaLTaiizor.Controls.DungeonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panelIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIniciarSesion
            // 
            this.panelIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(188)))), ((int)(((byte)(177)))));
            this.panelIniciarSesion.Controls.Add(this.lblError);
            this.panelIniciarSesion.Controls.Add(this.dungeonLabel1);
            this.panelIniciarSesion.Controls.Add(this.picVerContraseña);
            this.panelIniciarSesion.Controls.Add(this.txtContraseña);
            this.panelIniciarSesion.Controls.Add(this.txtUsuario);
            this.panelIniciarSesion.Controls.Add(this.imgCandado);
            this.panelIniciarSesion.Controls.Add(this.imgUser);
            this.panelIniciarSesion.Controls.Add(this.btnLogIn);
            this.panelIniciarSesion.Controls.Add(this.lblContraseña);
            this.panelIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIniciarSesion.Location = new System.Drawing.Point(237, 0);
            this.panelIniciarSesion.Name = "panelIniciarSesion";
            this.panelIniciarSesion.Size = new System.Drawing.Size(442, 305);
            this.panelIniciarSesion.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(147, 160);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(105, 15);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Mensaje de error";
            this.lblError.Visible = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(147, 52);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(53, 17);
            this.dungeonLabel1.TabIndex = 19;
            this.dungeonLabel1.Text = "Usuario";
            // 
            // picVerContraseña
            // 
            this.picVerContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.picVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVerContraseña.ErrorImage = null;
            this.picVerContraseña.Image = global::pryLunaLopez_IEFI.Properties.Resources.icons8_closed_eye_15;
            this.picVerContraseña.InitialImage = global::pryLunaLopez_IEFI.Properties.Resources.icons8_closed_eye_15;
            this.picVerContraseña.Location = new System.Drawing.Point(285, 134);
            this.picVerContraseña.Name = "picVerContraseña";
            this.picVerContraseña.Size = new System.Drawing.Size(25, 22);
            this.picVerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVerContraseña.TabIndex = 18;
            this.picVerContraseña.TabStop = false;
            this.picVerContraseña.Click += new System.EventHandler(this.picVerContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(150, 133);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(161, 24);
            this.txtContraseña.TabIndex = 17;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(150, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 27);
            this.txtUsuario.TabIndex = 16;
            // 
            // imgCandado
            // 
            this.imgCandado.Image = ((System.Drawing.Image)(resources.GetObject("imgCandado.Image")));
            this.imgCandado.Location = new System.Drawing.Point(124, 133);
            this.imgCandado.Name = "imgCandado";
            this.imgCandado.Size = new System.Drawing.Size(20, 20);
            this.imgCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCandado.TabIndex = 14;
            this.imgCandado.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(124, 76);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(20, 20);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 13;
            this.imgUser.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogIn.Image = null;
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogIn.Location = new System.Drawing.Point(150, 206);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogIn.Size = new System.Drawing.Size(161, 40);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Iniciar sesión";
            this.btnLogIn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblContraseña.Location = new System.Drawing.Point(147, 113);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(74, 17);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(27, 160);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(185, 46);
            this.bigLabel1.TabIndex = 6;
            this.bigLabel1.Text = "Bienvenido";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pryLunaLopez_IEFI.Properties.Resources.Ondas_terrosas_y_detalles_geométricos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 305);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelIniciarSesion);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.panelIniciarSesion.ResumeLayout(false);
            this.panelIniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIniciarSesion;
        private System.Windows.Forms.PictureBox picVerContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox imgCandado;
        private System.Windows.Forms.PictureBox imgUser;
        private ReaLTaiizor.Controls.Button btnLogIn;
        private ReaLTaiizor.Controls.DungeonLabel lblContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private System.Windows.Forms.Label lblError;
    }
}

