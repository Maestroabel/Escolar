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
    public partial class AsignarCaliForm : Form {

        public string ID { get; set; }
        public AsignarCaliForm() {
            InitializeComponent();
        }

        private void AsignarCaliForm_Load(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerEstudiantesAsigCalProf(ID).Fill(record);
            dataGridView1.DataSource = record;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtIDEstudiante.Text = Convert.ToString(selectedRow.Cells["ID"].Value);
            txtClaveAsignatura.Text = Convert.ToString(selectedRow.Cells["Clave"].Value);
            txtIDProfesor.Text = ID;
        }

        private void btnAsignarCali_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtClaveAsignatura.Text) || String.IsNullOrEmpty(txtIDEstudiante.Text) || String.IsNullOrEmpty(txtIDProfesor.Text)|| String.IsNullOrEmpty(txtCalificacion.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                if(int.TryParse(txtCalificacion.Text, out int calificacionNumber)) {
                    Calificacion calificacion = new Calificacion(calificacionNumber,txtIDEstudiante.Text,txtIDProfesor.Text,txtClaveAsignatura.Text);
                    ControlDB con = new ControlDB();
                    if(!ControlDB.CheckCalificacion(txtIDEstudiante.Text,ID, txtClaveAsignatura.Text)) {
                        ControlDB.rdr.Close();
                        if(ControlDB.AddCalificacion(calificacion)) {
                            double indice = ProcesoIndice.IndiceCalc(ControlDB.GetCalificacionesEst(txtIDEstudiante.Text));
                            string honor = ProcesoIndice.HonorCalc(indice);
                            ControlDB.rdr.Close();
                            if(ControlDB.ModEstudianteIndice(indice, honor, txtIDEstudiante.Text)) {
                                MessageBox.Show("Calificación introducida y actualizado índice de estudiante", "Éxito");
                            }
                            else {
                                MessageBox.Show("No se pudo actualizar el índice académico del estudiante.", "Error");
                            }
                        }
                        else {
                            MessageBox.Show("No se pudo añadir la calificación.", "Error");
                        }
                    }
                    else {
                        MessageBox.Show("El estudiante ya tiene una calificación de esta asignatura", "Error");
                    }
                    
                }
                else {
                    MessageBox.Show("Conversión de la calificación fallida. Verifique que haya introducido un número válido e intente de nuevo", "Error");
                }
                
            }
        }
    }
}
