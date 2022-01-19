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
    public partial class ModProfesorForm : Form {

        public string ID { get; set; }
        public ModProfesorForm() {
            InitializeComponent();
        }

        private void ModProfesorForm_Load(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            Profesor profesor = ControlDB.GetProfesor(ID);
            txtID.Text = profesor.ID;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtPassword.Text = profesor.Password;
        }

        private void btnModProf_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {

                Profesor profesor = new Profesor(txtID.Text, txtNombre.Text, txtApellido.Text, txtPassword.Text);
                ControlDB con = new ControlDB();
                if(ControlDB.ModProfesor(profesor, ID)) {
                    ID = txtID.Text;
                    MessageBox.Show("Campos modificados satisfactoriamente.", "Éxito");
                    Close();
                }
                else {
                    MessageBox.Show("Los campos no pudieron ser modificados.", "Fracaso");
                } 
            }
        }

        private void ModProfesorForm_FormClosed(object sender, FormClosedEventArgs e) {
            ProfesorForm form = new ProfesorForm();
            form.ID = ID;
            form.Show();
        }
    }
}
