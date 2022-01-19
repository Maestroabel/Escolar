using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar {
    public class Publicacion {
        public string Calificacion { get; set; }
        public int Creditos { get; set; }

        public Publicacion(string Calificacion, int Creditos) {
            this.Calificacion = Calificacion;
            this.Creditos = Creditos;
        }
    }
}
