using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliServ {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    //Cierra la aplicación.
    private void MnuCerrar_Click(object sender, EventArgs e) {

      Application.Exit();
    }

    //Abre la forma del GestorBD.
    private void MnuGestorBD_Click(object sender, EventArgs e) {

      FrmGestorBD fg = new FrmGestorBD();
      fg.ShowDialog();
    }

    //Abre la forma de los subprogramas almacenados.
    private void MnuSubprogsAlm_Click(object sender, EventArgs e) {

      FrmSubprogsAlm fs = new FrmSubprogsAlm();
      fs.ShowDialog();
    }
  }
}
