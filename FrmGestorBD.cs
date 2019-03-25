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
  public partial class FrmGestorBD : Form {
    //Atributos de la clase.
    private GestorBD.GestorBD GestorBD;
    private DataSet dsAlum = new DataSet(), dsMater = new DataSet();
    private DataSet dsCalifs= new DataSet();
    private string cadSql;
    private const int OK= 1;
    Varios.Comunes comunes = new Varios.Comunes();

    public FrmGestorBD() {
      InitializeComponent();
    }

    private void FrmGestorBD_Load(object sender, EventArgs e) {

      //1- Hace la conexìón a la BD de Oracle.
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bdalumno", "alumno", "oracle");

      //2- Obtiene y muestra los datos de los alumnos.
      cadSql = "select * from Alum";
      GestorBD.consBD(cadSql, dsAlum, "Alum");
      dtgGeneral.DataSource = dsAlum.Tables["Alum"];
      comunes.cargaCombo(cboAlum, dsAlum, "Alum", "NomAl");

      //3- Obtiene y muestra los datos de las materias.
      cadSql = "select * from Mater";
      GestorBD.consBD(cadSql, dsMater, "Mater");
      //dtgGeneral.DataSource = dsMater.Tables["Mater"];
      comunes.cargaCombo(cboMater, dsMater, "Mater", "NomMat");
    }

    //Muestra en el grid las calificaciones del alumno elegido
    //en el combo.
    private void cboAlum_SelectedIndexChanged(object sender, EventArgs e) {

      alumCalifs();
      btnAltaCalif.Enabled = true; btnBajaCalif.Enabled = true;
      btnCambia.Enabled = true;
    }

    //Muestra en el grid las calificaciones del alumno elegido en el combo.
    public void alumCalifs() {

      cadSql = "select Folio, NomAl, Calif, Fecha, NomMat " +
        "from Alum a, Historial h, Mater m " +
        "where NomAl='" + cboAlum.Text + "' and a.cu=h.cu " +
        "and h.clavem=m.clavem";
      GestorBD.consBD(cadSql, dsCalifs, "Califs");
      dtgGeneral.DataSource = dsCalifs.Tables["Califs"];
    }


    //Agrega una nueva calificación: el alumno y la materia se seleccionan
    //de sus combo box, calificación y fecha de las cajas correspondientes.
    private void btnAltaCalif_Click(object sender, EventArgs e) {

      //Habilita/deshabilita controles (de esta manera se puede guiar lo que el usuario
      //debe hacer).
      cboMater.Visible = true; cboCalif.Visible = true; dtpFecha.Visible = true;
      btnRegistrarAlta.Visible = true; btnAltaCalif.Enabled = false;
      btnBajaCalif.Enabled = false; btnCambia.Enabled = false;
    }

    //Hace el alta de la calificación del alumno elegido y materia
    //elegidos en los combos respectivos.
    private void btnRegistrarAlta_Click(object sender, EventArgs e) {
      DataSet dsTemp = new DataSet();
      DataRow[] filasAlum, filasMater;
      DataRow fila;
      int folio, cu, claveM;
      string fecha;

      //Obtiene el nuevo folio.
      cadSql = "select max(folio) as maxFolio from historial";
      GestorBD.consBD(cadSql, dsTemp, "Temp");
      fila = dsTemp.Tables["Temp"].Rows[0];
      folio = Convert.ToInt16(fila["maxFolio"]) + 1;

      //Las siguientes alternativas tienen como ventaja la búsqueda inmediata
      //de los datos y como desventaja el tener, potencialmente, desactualizados
      //los datos.
      //Obtiene la clave única del alumno.
      filasAlum = dsAlum.Tables["Alum"].Select("NomAl='" + cboAlum.Text + "'");
      cu = Convert.ToInt16(filasAlum[0]["CU"]);

      //Obtiene la clave de la materia.
      filasMater = dsMater.Tables["Mater"].Select("NomMat='" + cboMater.Text + "'");
      claveM = Convert.ToInt16(filasMater[0]["ClaveM"]);

      //Construir la fecha en el formato requerido por Oracle.
      fecha = "date'" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month +
              "-" + dtpFecha.Value.Day + "'";

      //Construye la cadena de inserción.
      cadSql = "insert into Historial values(" + folio + "," + cboCalif.Text + "," +
              fecha + "," + cu + "," + claveM + ")";
      MessageBox.Show(cadSql);

      //Ejecuta la inserción.
      if (GestorBD.altaBD(cadSql) == OK) {
        MessageBox.Show("Alta exitosa");
        alumCalifs();
      }
      else
        MessageBox.Show("No se pudo hacer el alta");

      //Habilita/deshabilita controles.
      cboMater.Visible = false; cboMater.Text = "Materias:";
      cboCalif.Visible = false; cboCalif.Text = "Calificación:";
      dtpFecha.Visible = false;
      btnRegistrarAlta.Visible = false; btnAltaCalif.Enabled = true;
      btnBajaCalif.Enabled = true; btnCambia.Enabled = true;
    }

    //Para obtener el valor de la celda seleccionada al darle clic en el DataGrid
    //existen tres maneras (necesariamente hay que dar clic en la celda elegida):
    //1) nombreDataGrid.CurrentCell.Value;
    //2) nombreDataGrid[ÍndiceColumna, ÍndiceFila].Value;
    //3) nombreDataGrid[NombreColumna, ÍndiceFila].Value
    private void dtgGeneral_Click(object sender, EventArgs e) {
      //int fila, col; Object valor;

      ////Obtiene fila, columna y valor de la celda elegida.
      //fila = dtgGeneral.CurrentCell.RowIndex; col = dtgGeneral.CurrentCell.ColumnIndex;
      //valor = dtgGeneral.CurrentCell.Value;
      //MessageBox.Show("Fila: " + fila + " Columna: " + col + " Valor: " + valor);

      ////Obtiene sólo el valor.
      //MessageBox.Show("Valor: " + dtgGeneral[col, fila].Value.ToString());
    }

    //Realiza el proceso para eliminar una calificación de Historial.
    //Se usa el folio, de la fila elegida en el grid, para hacer la baja.
    private void btnBajaCalif_Click(object sender, EventArgs e) {
      int folio; String cadSql;
      DialogResult botón;

      //Toma el folio de la calificación seleccionada en el data grid.
      folio = Convert.ToInt16(dtgGeneral["Folio", dtgGeneral.CurrentRow.Index].Value);
      botón = MessageBox.Show("¿Se elimina el registro con folio= " + folio.ToString(),
        "Eliminación", MessageBoxButtons.YesNo);

      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (botón == DialogResult.Yes) {
        //Construye la cadena de eliminación y la envía para su ejecución.
        cadSql = "delete from Historial where Folio = " + folio;
        if (GestorBD.bajaBD(cadSql) == OK) {
          MessageBox.Show("Se eliminó la calificación del folio " + folio + " exitosamente");
          alumCalifs();
        }
        else
          MessageBox.Show("No se pudo eliminar la calificación");
      }
    }

  }
}








