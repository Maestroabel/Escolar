
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

namespace Escolar
{
    public partial class RegistrarProfesorForm : Form
    {
        public RegistrarProfesorForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarProf_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                Profesor profesor = new Profesor(txtID.Text, txtNombre.Text, txtApellido.Text, txtPassword.Text);
                ControlDB con = new ControlDB();
                if(ControlDB.AddProfesor(profesor)) {
                    this.Close();
                    MessageBox.Show("El profesor fue registrado satisfactoriamente.", "Éxito");
                }
                else {
                    MessageBox.Show("El profesor no fue registrado.", "Error");
                } 
            }
        }


    }
}
