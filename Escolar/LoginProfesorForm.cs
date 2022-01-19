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
    public partial class LoginProfesorForm : Form {
        public LoginProfesorForm() {
            InitializeComponent();
        }

        private void LoginProfesorForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) {
                return;
            }
            MainForm login = new MainForm();
            login.Show();
        }

        private void btnLoginProf_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                Profesor profesor = new Profesor(txtID.Text, txtPassword.Text);

                ControlDB con = new ControlDB();
                if(ControlDB.LoginProfesor(profesor)) {
                    ProfesorForm profesorForm = new ProfesorForm();
                    profesorForm.ID = txtID.Text;
                    profesorForm.Show();
                    Close();
                }
                else {
                    MessageBox.Show("No se pudo autenticar", "Error");
                } 
            }
        }
    }
}
