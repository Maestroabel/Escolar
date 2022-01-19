using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar {
    public class ProcesoIndice {
        public static double IndiceCalc(List<Publicacion> calificaciones) {
            double indice = 0;
            double puntos = 0;
            double totalCreditos = 0;
            foreach(Publicacion calificacion in calificaciones) {
                puntos += CaliNumCalc(calificacion.Calificacion) * calificacion.Creditos;
                totalCreditos += calificacion.Creditos;
            }
            indice = puntos / totalCreditos;
            return indice;
        }
        public static string HonorCalc(double indice) {
            if(indice < 3.1) {
                return "Sin Honor";
            }
            else if(indice >= 3.1 && indice < 3.4) {
                return "Cum Laude";
            }

            else if(indice >= 3.4 && indice < 3.7) {
                return "Magna Cum Laude";
            }
            else {
                return "Summa Cum Laude";
            }
        }

        public static int CaliNumCalc(string letra) {
            switch(letra) {
                case "A": return 4;
                case "B": return 3;
                case "C": return 2;
                case "D": return 1;
                case "F": return 0;
                default: return -1;
            }
        }
    }
}
