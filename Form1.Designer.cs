namespace CliServ {
  partial class Form1 {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
      this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuGestorBD = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuSubprogsAlm = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.procesosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(799, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCerrar});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
      this.archivoToolStripMenuItem.Text = "Archivo";
      // 
      // MnuCerrar
      // 
      this.MnuCerrar.Name = "MnuCerrar";
      this.MnuCerrar.Size = new System.Drawing.Size(124, 26);
      this.MnuCerrar.Text = "Cerrar";
      this.MnuCerrar.Click += new System.EventHandler(this.MnuCerrar_Click);
      // 
      // procesosToolStripMenuItem
      // 
      this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestorBD,
            this.MnuSubprogsAlm});
      this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
      this.procesosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
      this.procesosToolStripMenuItem.Text = "Procesos";
      // 
      // MnuGestorBD
      // 
      this.MnuGestorBD.Name = "MnuGestorBD";
      this.MnuGestorBD.Size = new System.Drawing.Size(182, 26);
      this.MnuGestorBD.Text = "GestorBD";
      this.MnuGestorBD.Click += new System.EventHandler(this.MnuGestorBD_Click);
      // 
      // MnuSubprogsAlm
      // 
      this.MnuSubprogsAlm.Name = "MnuSubprogsAlm";
      this.MnuSubprogsAlm.Size = new System.Drawing.Size(182, 26);
      this.MnuSubprogsAlm.Text = "Subprogs. alm.";
      this.MnuSubprogsAlm.Click += new System.EventHandler(this.MnuSubprogsAlm_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(799, 561);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Menú principal";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuCerrar;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuGestorBD;
    private System.Windows.Forms.ToolStripMenuItem MnuSubprogsAlm;
  }
}

