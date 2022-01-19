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
    public partial class RetiroAsigForm : Form {

        public string ID { get; set; }
        public RetiroAsigForm() {
            InitializeComponent();
        }

        private void RetiroAsigForm_Load(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerAsignaturasEstudiante(ID).Fill(record);
            dataGridView1.DataSource = record;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            ControlDB con = new ControlDB();
            if(ControlDB.DeleteInscripcion(ID, Convert.ToString(selectedRow.Cells["Clave"].Value))) {
                MessageBox.Show($"Se ha retirado satisfactoriamente la asignatura: {Convert.ToString(selectedRow.Cells["Nombre"].Value)}", "Éxito");
                Close();
            }
            else {
                MessageBox.Show($"No se ha podido retirar la asignatura: {Convert.ToString(selectedRow.Cells["Nombre"].Value)}. ", "Fracaso");
            }
        }
    }
}
