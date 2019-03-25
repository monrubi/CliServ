namespace CliServ {
  partial class FrmGestorBD {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.cboAlum = new System.Windows.Forms.ComboBox();
      this.cboMater = new System.Windows.Forms.ComboBox();
      this.btnAltaCalif = new System.Windows.Forms.Button();
      this.btnBajaCalif = new System.Windows.Forms.Button();
      this.btnCambia = new System.Windows.Forms.Button();
      this.cboCalif = new System.Windows.Forms.ComboBox();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.btnRegistrarAlta = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(97, 40);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.RowTemplate.Height = 24;
      this.dtgGeneral.Size = new System.Drawing.Size(620, 230);
      this.dtgGeneral.TabIndex = 0;
      this.dtgGeneral.Click += new System.EventHandler(this.dtgGeneral_Click);
      // 
      // cboAlum
      // 
      this.cboAlum.FormattingEnabled = true;
      this.cboAlum.Location = new System.Drawing.Point(98, 312);
      this.cboAlum.Name = "cboAlum";
      this.cboAlum.Size = new System.Drawing.Size(138, 24);
      this.cboAlum.TabIndex = 1;
      this.cboAlum.Text = "Alumnos:";
      this.cboAlum.SelectedIndexChanged += new System.EventHandler(this.cboAlum_SelectedIndexChanged);
      // 
      // cboMater
      // 
      this.cboMater.FormattingEnabled = true;
      this.cboMater.Location = new System.Drawing.Point(102, 437);
      this.cboMater.Name = "cboMater";
      this.cboMater.Size = new System.Drawing.Size(134, 24);
      this.cboMater.TabIndex = 2;
      this.cboMater.Text = "Materias:";
      this.cboMater.Visible = false;
      // 
      // btnAltaCalif
      // 
      this.btnAltaCalif.Enabled = false;
      this.btnAltaCalif.Location = new System.Drawing.Point(99, 373);
      this.btnAltaCalif.Name = "btnAltaCalif";
      this.btnAltaCalif.Size = new System.Drawing.Size(137, 34);
      this.btnAltaCalif.TabIndex = 3;
      this.btnAltaCalif.Text = "Alta calif.";
      this.btnAltaCalif.UseVisualStyleBackColor = true;
      this.btnAltaCalif.Click += new System.EventHandler(this.btnAltaCalif_Click);
      // 
      // btnBajaCalif
      // 
      this.btnBajaCalif.Enabled = false;
      this.btnBajaCalif.Location = new System.Drawing.Point(314, 373);
      this.btnBajaCalif.Name = "btnBajaCalif";
      this.btnBajaCalif.Size = new System.Drawing.Size(159, 34);
      this.btnBajaCalif.TabIndex = 4;
      this.btnBajaCalif.Text = "Baja calif.";
      this.btnBajaCalif.UseVisualStyleBackColor = true;
      this.btnBajaCalif.Click += new System.EventHandler(this.btnBajaCalif_Click);
      // 
      // btnCambia
      // 
      this.btnCambia.Enabled = false;
      this.btnCambia.Location = new System.Drawing.Point(524, 369);
      this.btnCambia.Name = "btnCambia";
      this.btnCambia.Size = new System.Drawing.Size(164, 38);
      this.btnCambia.TabIndex = 5;
      this.btnCambia.Text = "Cambiar";
      this.btnCambia.UseVisualStyleBackColor = true;
      // 
      // cboCalif
      // 
      this.cboCalif.FormattingEnabled = true;
      this.cboCalif.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5"});
      this.cboCalif.Location = new System.Drawing.Point(327, 437);
      this.cboCalif.Name = "cboCalif";
      this.cboCalif.Size = new System.Drawing.Size(121, 24);
      this.cboCalif.TabIndex = 6;
      this.cboCalif.Text = "Calificación:";
      this.cboCalif.Visible = false;
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(524, 437);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(164, 22);
      this.dtpFecha.TabIndex = 7;
      this.dtpFecha.Visible = false;
      // 
      // btnRegistrarAlta
      // 
      this.btnRegistrarAlta.Location = new System.Drawing.Point(102, 503);
      this.btnRegistrarAlta.Name = "btnRegistrarAlta";
      this.btnRegistrarAlta.Size = new System.Drawing.Size(134, 32);
      this.btnRegistrarAlta.TabIndex = 8;
      this.btnRegistrarAlta.Text = "Registrar alta";
      this.btnRegistrarAlta.UseVisualStyleBackColor = true;
      this.btnRegistrarAlta.Visible = false;
      this.btnRegistrarAlta.Click += new System.EventHandler(this.btnRegistrarAlta_Click);
      // 
      // FrmGestorBD
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(809, 577);
      this.Controls.Add(this.btnRegistrarAlta);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.cboCalif);
      this.Controls.Add(this.btnCambia);
      this.Controls.Add(this.btnBajaCalif);
      this.Controls.Add(this.btnAltaCalif);
      this.Controls.Add(this.cboMater);
      this.Controls.Add(this.cboAlum);
      this.Controls.Add(this.dtgGeneral);
      this.Name = "FrmGestorBD";
      this.Text = "Manejo de la BD usando a GestorBD";
      this.Load += new System.EventHandler(this.FrmGestorBD_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.ComboBox cboAlum;
    private System.Windows.Forms.ComboBox cboMater;
    private System.Windows.Forms.Button btnAltaCalif;
    private System.Windows.Forms.Button btnBajaCalif;
    private System.Windows.Forms.Button btnCambia;
    private System.Windows.Forms.ComboBox cboCalif;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnRegistrarAlta;
  }
}