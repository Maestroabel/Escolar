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
    public partial class ModEstudianteForm : Form {

        public string ID { get; set; }
        public ModEstudianteForm() {
            InitializeComponent();
        }

        private void ModEstudianteForm_Load(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            Estudiante estudiante = ControlDB.GetEstudiante(ID);
            txtID.Text = estudiante.ID;
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            txtPassword.Text = estudiante.Password;
            txtCarrera.Text = estudiante.Carrera;
        }

        private void btnModProf_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtCarrera.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                Estudiante estudiante = new Estudiante(txtID.Text, txtNombre.Text, txtApellido.Text, txtCarrera.Text, txtPassword.Text);
                ControlDB con = new ControlDB();
                if(ControlDB.ModEstudiante(estudiante, ID)) {
                    ID = txtID.Text;
                    MessageBox.Show("Campos modificados satisfactoriamente.", "Éxito");
                    Close();
                }
                else {
                    MessageBox.Show("Los campos no pudieron ser modificados.", "Fracaso");
                }
            }
        }

        private void ModEstudianteForm_FormClosed(object sender, FormClosedEventArgs e) {
            EstudianteForm form = new EstudianteForm();
            form.ID = ID;
            form.Show();
        }
    }
}
