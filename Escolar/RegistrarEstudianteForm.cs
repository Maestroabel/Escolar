
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records;

namespace Escolar {
    public partial class RegistrarEstudianteForm : Form {
        public RegistrarEstudianteForm() {
            InitializeComponent();
        }

        private void btnRegistrarEst_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text)||String.IsNullOrEmpty(txtCarrera.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                Estudiante estudiante = new Estudiante(txtID.Text, txtNombre.Text, txtApellido.Text, txtCarrera.Text, txtPassword.Text);
                ControlDB con = new ControlDB();

                if(ControlDB.AddEstudiante(estudiante)) {
                    Close();
                    MessageBox.Show("El estudiante fue registrado satisfactoriamente.", "Éxito");
                }
                else {
                    MessageBox.Show("El estudiante no fue registrado.", "Error");
                } 
            }

        }

    }
}
