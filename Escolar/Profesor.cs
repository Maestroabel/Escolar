namespace Escolar {
    public class Profesor {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }       
        public string Password { get; set; }

        public Profesor(string ID, string Password) {
            this.ID = ID;
            this.Password = Password;
        }
        public Profesor(string ID, string Nombre, string Apellido, string Password) {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Password = Password;
        }
    }
}

