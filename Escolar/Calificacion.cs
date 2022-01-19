namespace Escolar
{
    public class Calificacion
    {

        private int nota_numero;

        public int Nota_Numero {
            get {
                return nota_numero;
            } 
            set {
                if(value > 0 && value < 100) {
                    nota_numero = value;
                }
                else {
                    nota_numero = 0;
                }
            } 
        }

        
        public string Nota_Letra { get; set; }
        public string IDEstudiante { get; set; }
        public string IDProfesor { get; set; }
        public string ClaveAsignatura { get; set; }

        public Calificacion(int Nota_Numero, string IDEstudiante, string IDProfesor, string ClaveAsignatura)
        {
            this.Nota_Numero = Nota_Numero;
            this.IDEstudiante = IDEstudiante;
            this.IDProfesor = IDProfesor;
            this.ClaveAsignatura = ClaveAsignatura;
            Nota_Letra = Nota_LetraCalc(Nota_Numero);
        }

        public static string Nota_LetraCalc(int Nota_Numero)
        {
            if (Nota_Numero >= 90 && Nota_Numero <= 100)
            {
                return "A";
            }
            else if (Nota_Numero >= 80 && Nota_Numero <= 89)
            {
                return "B";
            }
            else if (Nota_Numero >= 70 && Nota_Numero <= 79)
            {
                return "C";
            }
            else if (Nota_Numero >= 60 && Nota_Numero <= 69)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
