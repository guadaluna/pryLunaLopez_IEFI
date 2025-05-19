namespace pryLunaLopez_IEFI
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.auditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoTrabajadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incicioToolStripMenuItem
            // 
            this.incicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.auditarToolStripMenuItem,
            this.userToolStripMenuItem,
            this.fechaToolStripMenuItem,
            this.tiempoTrabajadoToolStripMenuItem});
            this.incicioToolStripMenuItem.Name = "incicioToolStripMenuItem";
            this.incicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.incicioToolStripMenuItem.Text = "Inicio";
            this.incicioToolStripMenuItem.Click += new System.EventHandler(this.incicioToolStripMenuItem_Click);
            // 
            // trabajoToolStripMenuItem
            // 
            this.trabajoToolStripMenuItem.Name = "trabajoToolStripMenuItem";
            this.trabajoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trabajoToolStripMenuItem.Text = "Trabajo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // auditarToolStripMenuItem
            // 
            this.auditarToolStripMenuItem.Name = "auditarToolStripMenuItem";
            this.auditarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auditarToolStripMenuItem.Text = "Auditar";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // tiempoTrabajadoToolStripMenuItem
            // 
            this.tiempoTrabajadoToolStripMenuItem.Name = "tiempoTrabajadoToolStripMenuItem";
            this.tiempoTrabajadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiempoTrabajadoToolStripMenuItem.Text = "Tiempo trabajado";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem auditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoTrabajadoToolStripMenuItem;
    }
}