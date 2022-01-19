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
    public partial class AgregarAsignaturaForm : Form {
        public AgregarAsignaturaForm() {
            InitializeComponent();
        }

        private void btnCrearAsig_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtClave.Text)|| String.IsNullOrEmpty(txtNombre.Text)|| String.IsNullOrEmpty(txtCreditos.Text)) {
                MessageBox.Show("Por favor, llene todos los espacios antes de continuar.", "Error");
            }
            else {
                if(Int32.TryParse(txtCreditos.Text, out int creditos)) {
                    Asignatura asignatura = new Asignatura(txtClave.Text, txtNombre.Text, creditos);
                    ControlDB con = new ControlDB();
                    if(ControlDB.AddAsignatura(asignatura)) {
                        Close();
                        MessageBox.Show("Asignatura creada satisfactoriamente", "Exito");
                    }
                    else {
                        MessageBox.Show("La asignatura no pudo ser creada", "Fracaso");
                    }
                }
                else {
                    MessageBox.Show("El número introducido en los créditos es inválido. Por favor, revise su número e intente de nuevo","Error");
                }
                
            }
        }
    }
}
