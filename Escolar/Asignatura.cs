namespace Escolar
{
    public class Asignatura
    {

        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
      
        public Asignatura(string Clave, string Nombre, int Creditos)
        {
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Creditos = Creditos;
        }
    }
}