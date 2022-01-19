
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Escolar {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnRegistrarEst_Click(object sender, EventArgs e) {
            RegistrarEstudianteForm form = new RegistrarEstudianteForm();
            form.Show();
        }

        private void btnRegistrarProf_Click(object sender, EventArgs e)
        {
            RegistrarProfesorForm form = new RegistrarProfesorForm();
            form.Show();
        }

        private void btnLoginEst_Click(object sender, EventArgs e) {
            LoginEstudianteForm form = new LoginEstudianteForm();
            form.Show();
            Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) {
            if(new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
                return;
            Application.Exit();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e) {
            LoginAdminForm form = new LoginAdminForm();
            form.Show();
            Close();
        }

        private void btnLoginProf_Click(object sender, EventArgs e) {
            LoginProfesorForm form = new LoginProfesorForm();
            form.Show();
            Close();
        }
    }
}