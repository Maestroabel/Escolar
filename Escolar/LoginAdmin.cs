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

namespace Escolar
{
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }
       
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                ControlDB con = new ControlDB();
                if(ControlDB.LoginAdmin(txtUsuario.Text, txtPassword.Text)) {
                    AdminForm AdminForm = new AdminForm();
                    AdminForm.Show();
                    Close();
                }
                else {
                    MessageBox.Show("No se pudo autenticar.", "Error");
                } 
            }
        }
        private void LoginAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                return;
            }
            MainForm login = new MainForm();
            login.Show();
        }
    }
}
