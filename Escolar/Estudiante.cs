namespace Escolar {
    public class Estudiante {

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public double Indice { get; set; }
        public string Honor { get; set; }
        public string Password { get; set; }


        public Estudiante(string ID, string Password) {
            this.ID = ID;
            this.Password = Password;
        }
        public Estudiante(string ID, string Nombre, string Apellido, string Carrera, string Password) {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Carrera = Carrera;
            this.Password = Password;
        }

        
    }
}
