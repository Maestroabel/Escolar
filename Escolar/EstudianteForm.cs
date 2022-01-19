
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar {
    public partial class EstudianteForm : Form {

        public string ID  { get; set; }
        public EstudianteForm() {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            ID = "";
            MainForm login = new MainForm();
            login.Show();
            Close();
        }

        private void EstudianteForm_Load(object sender, EventArgs e) {
            lblBienvenido.Text += ID;
        }

        private void btnInscripcion_Click(object sender, EventArgs e) {
            InscripcionAsigForm form = new InscripcionAsigForm();
            form.ID = ID;
            form.Show();
        }

        private void btnVerAsignaturas_Click(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerAsignaturasEstudiante(ID).Fill(record);
            dataGridView1.DataSource = record;
        }

        private void btnRetirarAsignatura_Click(object sender, EventArgs e) {
            RetiroAsigForm form = new RetiroAsigForm();
            form.ID = ID;
            form.Show();
        }

        private void btnBorrarEst_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar su cuenta?", "Confirmación", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) {
                ControlDB con = new ControlDB();
                if(ControlDB.BorrarEstudiante(ID)) {
                    MessageBox.Show("Se eliminó la cuenta satisfactoriamente.", "Éxito");
                    btnCerrarSesion.PerformClick();
                }
                else {
                    MessageBox.Show("No se pudo eliminar la cuenta.", "Fracaso");
                }
            }
        }

        private void btnModificarEst_Click(object sender, EventArgs e) {
            ModEstudianteForm form = new ModEstudianteForm();
            form.ID = ID;
            form.Show();
            Close();
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e) {
            ControlDB con = new ControlDB();
            DataTable record = new DataTable();
            ControlDB.VerCalificacionesEstudiante(ID).Fill(record);
            dataGridView1.DataSource = record;
        }
    }
}
