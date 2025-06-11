namespace pryLunaLopez_IEFI
{
    partial class frmEditarItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarItems));
            this.lstItems = new Sunny.UI.UIListBox();
            this.txtItems = new Sunny.UI.UITextBox();
            this.btnAgregar = new Sunny.UI.UIButton();
            this.btnEditar = new Sunny.UI.UIButton();
            this.btnEliminar = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstItems.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lstItems.ItemSelectForeColor = System.Drawing.Color.White;
            this.lstItems.Location = new System.Drawing.Point(13, 14);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstItems.MinimumSize = new System.Drawing.Size(1, 1);
            this.lstItems.Name = "lstItems";
            this.lstItems.Padding = new System.Windows.Forms.Padding(2);
            this.lstItems.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.lstItems.ShowText = false;
            this.lstItems.Size = new System.Drawing.Size(456, 154);
            this.lstItems.TabIndex = 0;
            this.lstItems.Text = "uiListBox1";
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // txtItems
            // 
            this.txtItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtItems.Location = new System.Drawing.Point(477, 14);
            this.txtItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItems.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtItems.Name = "txtItems";
            this.txtItems.Padding = new System.Windows.Forms.Padding(5);
            this.txtItems.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.txtItems.ShowText = false;
            this.txtItems.Size = new System.Drawing.Size(150, 29);
            this.txtItems.TabIndex = 1;
            this.txtItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtItems.Watermark = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnAgregar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnAgregar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnAgregar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnAgregar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(476, 51);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(188)))), ((int)(((byte)(177)))));
            this.btnAgregar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnAgregar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnAgregar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnAgregar.Size = new System.Drawing.Size(151, 35);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnEditar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnEditar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnEditar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEditar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditar.Location = new System.Drawing.Point(476, 92);
            this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(188)))), ((int)(((byte)(177)))));
            this.btnEditar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnEditar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEditar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEditar.Size = new System.Drawing.Size(151, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(131)))), ((int)(((byte)(130)))));
            this.btnEliminar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnEliminar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEliminar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(476, 133);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(188)))), ((int)(((byte)(177)))));
            this.btnEliminar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(171)))), ((int)(((byte)(170)))));
            this.btnEliminar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEliminar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.btnEliminar.Size = new System.Drawing.Size(151, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmEditarItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(644, 180);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.lstItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Items";
            this.Load += new System.EventHandler(this.frmEditarItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox lstItems;
        private Sunny.UI.UITextBox txtItems;
        private Sunny.UI.UIButton btnAgregar;
        private Sunny.UI.UIButton btnEditar;
        private Sunny.UI.UIButton btnEliminar;
    }
}