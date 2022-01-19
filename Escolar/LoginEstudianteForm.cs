using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar {
    public partial class LoginEstudianteForm : Form {
        public LoginEstudianteForm() {
            InitializeComponent();
        }

        private void btnLoginEst_Click(object sender, EventArgs e) {

            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }

            else {
                Estudiante estudiante = new Estudiante(txtID.Text, txtPassword.Text);
                ControlDB con = new ControlDB();

                if(ControlDB.LoginEstudiante(estudiante)) {
                    EstudianteForm estudianteForm = new EstudianteForm();
                    estudianteForm.ID = txtID.Text;
                    estudianteForm.Show();
                    Close();
                }
                else {
                    MessageBox.Show("No se pudo autenticar", "Error");
                } 
            }
        }

        private void LoginEstudianteForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) {
                return;
            }
            MainForm login = new MainForm();
            login.Show();
        }

    }
}
