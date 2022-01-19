using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar {
    public partial class ModAsignaturaForm : Form {

        public string oldClave { get; set; }

        public ModAsignaturaForm() {
            InitializeComponent();
        }

        private void ModAsignaturaForm_Load(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerAsignaturas().Fill(record);
            dataGridView1.DataSource = record;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            oldClave = Convert.ToString(selectedRow.Cells["Clave"].Value);
            txtClave.Text = Convert.ToString(selectedRow.Cells["Clave"].Value);
            txtNombre.Text = Convert.ToString(selectedRow.Cells["Nombre"].Value);
            txtCreditos.Text = Convert.ToString(selectedRow.Cells["Creditos"].Value);
        }

        private void btnModAsig_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtClave.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtCreditos.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {

                if(Int32.TryParse(txtCreditos.Text, out int creditos)) {
                    Asignatura asignatura = new Asignatura(txtClave.Text, txtNombre.Text, creditos);
                    ControlDB con = new ControlDB();
                    if(ControlDB.ModAsignatura(asignatura,oldClave)) {
                        Close();
                        MessageBox.Show("Asignatura modificada satisfactoriamente", "Exito");
                    }
                    else {
                        MessageBox.Show("La asignatura no pudo ser modificada", "Fracaso");
                    }
                }
                else {
                    MessageBox.Show("El número introducido en los créditos es inválido. Por favor, revise su número e intente de nuevo", "Error");
                }

            }
        }
    }
}
