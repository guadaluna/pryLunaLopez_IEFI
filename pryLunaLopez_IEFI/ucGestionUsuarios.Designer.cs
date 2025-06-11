namespace pryLunaLopez_IEFI
{
    partial class ucGestionUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new Sunny.UI.UIDataGridView();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.optNo = new Sunny.UI.UIRadioButton();
            this.optSi = new Sunny.UI.UIRadioButton();
            this.btnLimpiar = new ReaLTaiizor.Controls.AloneButton();
            this.btnModificar = new ReaLTaiizor.Controls.AloneButton();
            this.btnEliminar = new ReaLTaiizor.Controls.AloneButton();
            this.txtContraseña = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnAgregar = new ReaLTaiizor.Controls.AloneButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtMail = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtTelefono = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtDNI = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(225)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(214, 16);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.dgvUsuarios.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.dgvUsuarios.ScrollBarStyleInherited = false;
            this.dgvUsuarios.SelectedIndex = -1;
            this.dgvUsuarios.Size = new System.Drawing.Size(756, 666);
            this.dgvUsuarios.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(225)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.txtMail);
            this.grpUsuarios.Controls.Add(this.txtTelefono);
            this.grpUsuarios.Controls.Add(this.txtDNI);
            this.grpUsuarios.Controls.Add(this.lblTelefono);
            this.grpUsuarios.Controls.Add(this.lblDNI);
            this.grpUsuarios.Controls.Add(this.lblMail);
            this.grpUsuarios.Controls.Add(this.optNo);
            this.grpUsuarios.Controls.Add(this.optSi);
            this.grpUsuarios.Controls.Add(this.btnLimpiar);
            this.grpUsuarios.Controls.Add(this.btnModificar);
            this.grpUsuarios.Controls.Add(this.btnEliminar);
            this.grpUsuarios.Controls.Add(this.txtContraseña);
            this.grpUsuarios.Controls.Add(this.txtNombre);
            this.grpUsuarios.Controls.Add(this.txtUsuario);
            this.grpUsuarios.Controls.Add(this.btnAgregar);
            this.grpUsuarios.Controls.Add(this.lblNombre);
            this.grpUsuarios.Controls.Add(this.lblUsuario);
            this.grpUsuarios.Controls.Add(this.lblContraseña);
            this.grpUsuarios.Controls.Add(this.lblAdmin);
            this.grpUsuarios.Location = new System.Drawing.Point(28, 16);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(180, 592);
            this.grpUsuarios.TabIndex = 25;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Usuarios";
            // 
            // optNo
            // 
            this.optNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNo.Location = new System.Drawing.Point(20, 403);
            this.optNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.optNo.Name = "optNo";
            this.optNo.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.optNo.Size = new System.Drawing.Size(124, 27);
            this.optNo.TabIndex = 32;
            this.optNo.Text = "No";
            // 
            // optSi
            // 
            this.optSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSi.Location = new System.Drawing.Point(20, 379);
            this.optSi.MinimumSize = new System.Drawing.Size(1, 1);
            this.optSi.Name = "optSi";
            this.optSi.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.optSi.Size = new System.Drawing.Size(124, 27);
            this.optSi.TabIndex = 31;
            this.optSi.Text = "Si";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.EnabledCalc = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnLimpiar.Location = new System.Drawing.Point(20, 541);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 29);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.EnabledCalc = true;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnModificar.Location = new System.Drawing.Point(20, 506);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 29);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Editar";
            this.btnModificar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.EnabledCalc = true;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnEliminar.Location = new System.Drawing.Point(20, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 29);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnEliminar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtContraseña.EdgeColor = System.Drawing.Color.White;
            this.txtContraseña.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(20, 148);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.Size = new System.Drawing.Size(128, 28);
            this.txtContraseña.TabIndex = 23;
            this.txtContraseña.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNombre.EdgeColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(20, 43);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(128, 28);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUsuario.EdgeColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(20, 95);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(128, 28);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.EnabledCalc = true;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnAgregar.Location = new System.Drawing.Point(20, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 29);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(17, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(17, 363);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(96, 13);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "¿Es administrador?";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtMail.EdgeColor = System.Drawing.Color.White;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMail.ForeColor = System.Drawing.Color.DimGray;
            this.txtMail.Location = new System.Drawing.Point(20, 307);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = false;
            this.txtMail.Size = new System.Drawing.Size(128, 28);
            this.txtMail.TabIndex = 37;
            this.txtMail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtTelefono.EdgeColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(20, 202);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.Size = new System.Drawing.Size(128, 28);
            this.txtTelefono.TabIndex = 36;
            this.txtTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.Transparent;
            this.txtDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDNI.EdgeColor = System.Drawing.Color.White;
            this.txtDNI.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDNI.ForeColor = System.Drawing.Color.DimGray;
            this.txtDNI.Location = new System.Drawing.Point(20, 254);
            this.txtDNI.MaxLength = 32767;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = false;
            this.txtDNI.Size = new System.Drawing.Size(128, 28);
            this.txtDNI.TabIndex = 38;
            this.txtDNI.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDNI.UseSystemPasswordChar = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 186);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(17, 238);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 34;
            this.lblDNI.Text = "DNI";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(17, 291);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 35;
            this.lblMail.Text = "Mail";
            // 
            // ucGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "ucGestionUsuarios";
            this.Size = new System.Drawing.Size(991, 702);
            this.Load += new System.EventHandler(this.ucGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private ReaLTaiizor.Controls.AloneButton btnLimpiar;
        private ReaLTaiizor.Controls.AloneButton btnModificar;
        private ReaLTaiizor.Controls.AloneButton btnEliminar;
        private ReaLTaiizor.Controls.DungeonTextBox txtContraseña;
        private ReaLTaiizor.Controls.DungeonTextBox txtNombre;
        private ReaLTaiizor.Controls.DungeonTextBox txtUsuario;
        private ReaLTaiizor.Controls.AloneButton btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblAdmin;
        private Sunny.UI.UIRadioButton optNo;
        private Sunny.UI.UIRadioButton optSi;
        private ReaLTaiizor.Controls.DungeonTextBox txtMail;
        private ReaLTaiizor.Controls.DungeonTextBox txtTelefono;
        private ReaLTaiizor.Controls.DungeonTextBox txtDNI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblMail;
    }
}
