using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar {
    public class ControlDB
    {
        public static ConexionDB con;

        public ControlDB()
        {
            con = new ConexionDB(db_password: "@Hotmail.com1");
        }

       public static MySqlDataReader rdr { get; set; }


        public static Boolean EstudianteExists(Estudiante estudiante)
        {
            string check = "SELECT ID FROM Estudiante WHERE ID=@ID";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters["@ID"].Value = estudiante.ID;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;       
        }
        public static Boolean ProfesorExists(Profesor profesor)
        {
            string check = "SELECT ID FROM Profesor WHERE ID=@ID";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters["@ID"].Value = profesor.ID;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static Boolean AddEstudiante(Estudiante newEstudiante)
        {
            try
            {
                string insert = "INSERT INTO Estudiante (ID, Nombre, Apellido, Carrera, Password) VALUES (@ID,@Nombre, @Apellido, @Carrera, @Password)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Apellido", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Carrera", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
                InsertCmd.Parameters["@ID"].Value = newEstudiante.ID;
                InsertCmd.Parameters["@Nombre"].Value = newEstudiante.Nombre;
                InsertCmd.Parameters["@Apellido"].Value = newEstudiante.Apellido;
                InsertCmd.Parameters["@Carrera"].Value = newEstudiante.Carrera;
                InsertCmd.Parameters["@Password"].Value = newEstudiante.Password;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public static Boolean AddProfesor(Profesor newProfesor)
        {
            try
            {
                string insert = "INSERT INTO Profesor (ID, Nombre, Apellido, Password) VALUES (@ID,@Nombre, @Apellido, @Password)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Apellido", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
                InsertCmd.Parameters["@ID"].Value = newProfesor.ID;
                InsertCmd.Parameters["@Nombre"].Value = newProfesor.Nombre;
                InsertCmd.Parameters["@Apellido"].Value = newProfesor.Apellido;
                InsertCmd.Parameters["@Password"].Value = newProfesor.Password;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public static Boolean LoginAdmin(string Usuario,String Password)
        {
            if (Usuario == "Admin" && Password == "Admin")
                return true;
            else
                return false;
            
        }
        public static Boolean LoginEstudiante(Estudiante estudiante) {
            string check = "SELECT ID FROM Estudiante WHERE ID=@ID AND Password=@Password";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
            CheckCmd.Parameters["@ID"].Value = estudiante.ID;
            CheckCmd.Parameters["@Password"].Value = estudiante.Password;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static Boolean LoginProfesor(Profesor profesor) {
            string check = "SELECT ID FROM Profesor WHERE ID=@ID AND Password=@Password";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
            CheckCmd.Parameters["@ID"].Value = profesor.ID;
            CheckCmd.Parameters["@Password"].Value = profesor.Password;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static MySqlDataAdapter VerEstudiantes() {
            string watch = "SELECT ID, Nombre, Apellido, Carrera, Indice, Honor FROM Estudiante ORDER BY Indice DESC";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            return new MySqlDataAdapter(WatchCmd);
        }

        
        public static MySqlDataAdapter VerEstudiantesAsigProf(string ID) {
            string watch = "SELECT Estudiante.ID, Estudiante.Nombre, Estudiante.Apellido, Estudiante.Carrera, Estudiante.Indice, Estudiante.Honor, Asignatura.Nombre AS 'Nombre Asignatura' FROM Estudiante INNER JOIN CursoAsignatura ON Estudiante.ID=CursoAsignatura.IDEstudiante INNER JOIN Asignatura ON CursoAsignatura.ClaveAsignatura=Asignatura.Clave INNER JOIN ImparticionAsignatura ON Asignatura.Clave=ImparticionAsignatura.ClaveAsignatura INNER JOIN Profesor ON ImparticionAsignatura.IDProfesor=Profesor.ID WHERE Profesor.ID=@ID";
            
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static MySqlDataAdapter VerEstudiantesAsigCalProf(string ID) {
            string watch = "SELECT Estudiante.ID, Estudiante.Nombre, Estudiante.Apellido, Asignatura.Clave, Asignatura.Nombre AS 'Nombre Asignatura' FROM Estudiante INNER JOIN CursoAsignatura ON Estudiante.ID=CursoAsignatura.IDEstudiante INNER JOIN Asignatura ON CursoAsignatura.ClaveAsignatura=Asignatura.Clave INNER JOIN ImparticionAsignatura ON Asignatura.Clave=ImparticionAsignatura.ClaveAsignatura INNER JOIN Profesor ON ImparticionAsignatura.IDProfesor=Profesor.ID WHERE Profesor.ID=@ID";

            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static MySqlDataAdapter VerProfesores() {
            string watch = "SELECT ID, Nombre, Apellido FROM Profesor";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            return new MySqlDataAdapter(WatchCmd);
        }

        public static Profesor GetProfesor(string ID) {
            string watch = "SELECT * FROM Profesor WHERE ID=@ID";
            MySqlCommand GetCmd = new MySqlCommand(watch, con.connection);
            GetCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            GetCmd.Parameters["@ID"].Value = ID;
            rdr = GetCmd.ExecuteReader();
            
            if(rdr.Read()) {
                return new Profesor(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)); 
            }
            return new Profesor("", "", "", "");
        }

        public static List<Publicacion> GetCalificacionesEst(string ID) {
            string watch = "SELECT Calificacion.Letra, Asignatura.Creditos FROM Calificacion JOIN Asignatura ON Calificacion.ClaveAsignatura=Asignatura.Clave WHERE Calificacion.IDEstudiante=@ID";
            MySqlCommand GetCmd = new MySqlCommand(watch, con.connection);
            GetCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            GetCmd.Parameters["@ID"].Value = ID;
            rdr = GetCmd.ExecuteReader();
            List<Publicacion> calificaciones = new List<Publicacion>();
            while(rdr.Read()) {
                calificaciones.Add(new Publicacion(rdr.GetString(0),rdr.GetInt32(1)));
            }

            return calificaciones;
            
        }

        public static Boolean CheckCalificacion(string IDEstudiante, string IDProfesor, string ClaveAsignatura) {
            string check = "SELECT * FROM Calificacion WHERE IDEstudiante=@IDEstudiante AND IDProfesor=@IDProfesor AND ClaveAsignatura=@ClaveAsignatura";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@IDEstudiante", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters.Add("@IDProfesor", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters["@IDEstudiante"].Value = IDEstudiante;
            CheckCmd.Parameters["@IDProfesor"].Value = IDProfesor;
            CheckCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static Estudiante GetEstudiante(string ID) {
            string watch = "SELECT ID, Nombre, Apellido, Carrera,Password FROM Estudiante WHERE ID=@ID";
            MySqlCommand GetCmd = new MySqlCommand(watch, con.connection);
            GetCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            GetCmd.Parameters["@ID"].Value = ID;
            rdr = GetCmd.ExecuteReader();
            
            if(rdr.Read()) {
                return new Estudiante(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4)); 
            }

            return new Estudiante("", "", "", "", "");
        }

        public static MySqlDataAdapter VerAsignaturas() {
            string watch = "SELECT Clave, Nombre, Creditos FROM Asignatura";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            return new MySqlDataAdapter(WatchCmd);
        }
        public static MySqlDataAdapter VerCalificacionesProf(string ID) {
            string watch = "SELECT Calificacion.IDEstudiante, Calificacion.ClaveAsignatura, Calificacion.IDProfesor, Calificacion.Numero, Estudiante.Nombre, Estudiante.Apellido, Asignatura.Nombre AS 'Nombre Asignatura' FROM Calificacion INNER JOIN Estudiante ON Calificacion.IDEstudiante=Estudiante.ID INNER JOIN Asignatura ON Calificacion.ClaveAsignatura=Asignatura.Clave WHERE Calificacion.IDProfesor=@ID";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }
        public static MySqlDataAdapter VerAsignaturasProfesor(string ID) {
            string watch = "SELECT Asignatura.Clave, Asignatura.Nombre, Asignatura.Creditos FROM Asignatura INNER JOIN ImparticionAsignatura ON Asignatura.Clave = ImparticionAsignatura.ClaveAsignatura INNER JOIN Profesor ON ImparticionAsignatura.IDProfesor = Profesor.ID WHERE Profesor.ID = @ID";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static MySqlDataAdapter VerAsignaturasEstudiante(string ID) {
            string watch = "SELECT Asignatura.Clave, Asignatura.Nombre, Asignatura.Creditos FROM Asignatura INNER JOIN CursoAsignatura ON Asignatura.Clave = CursoAsignatura.ClaveAsignatura INNER JOIN Estudiante ON CursoAsignatura.IDEstudiante = Estudiante.ID WHERE Estudiante.ID = @ID";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static MySqlDataAdapter VerCalificacionesEstudiante(string ID) {
            string watch = "SELECT Calificacion.Numero AS 'Calificacion', Calificacion.Letra, Asignatura.Clave, Asignatura.Nombre FROM Calificacion INNER JOIN Asignatura ON Calificacion.ClaveAsignatura = Asignatura.Clave WHERE Calificacion.IDEstudiante = @ID";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static MySqlDataAdapter VerCalificacionesProfesor(string ID) {
            string watch = "SELECT Calificacion.Numero AS 'Calificacion', Calificacion.Letra, Asignatura.Clave, Asignatura.Nombre, Calificacion.IDEstudiante, Estudiante.Nombre AS 'Nombre Estudiante', Estudiante.Apellido FROM Calificacion INNER JOIN Asignatura ON Calificacion.ClaveAsignatura = Asignatura.Clave INNER JOIN Estudiante ON Calificacion.IDEstudiante = Estudiante.ID WHERE Calificacion.IDProfesor = @ID";
            MySqlCommand WatchCmd = new MySqlCommand(watch, con.connection);
            WatchCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
            WatchCmd.Parameters["@ID"].Value = ID;
            return new MySqlDataAdapter(WatchCmd);
        }

        public static Boolean ModAsignatura(Asignatura asignatura, string OldClave) {
            try {
                string update = "UPDATE Asignatura SET Clave=@Clave, Nombre=@Nombre, Creditos=@Creditos WHERE Clave=@OldClave";
                MySqlCommand UpdateCmd = new MySqlCommand(update, con.connection);
                UpdateCmd.Parameters.Add("@Clave", MySqlDbType.VarChar, 9);
                UpdateCmd.Parameters.Add("@OldClave", MySqlDbType.VarChar, 9);
                UpdateCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters.Add("@Creditos", MySqlDbType.Int32);
                UpdateCmd.Parameters["@Clave"].Value = asignatura.Clave;
                UpdateCmd.Parameters["@OldClave"].Value = OldClave;
                UpdateCmd.Parameters["@Nombre"].Value = asignatura.Nombre;
                UpdateCmd.Parameters["@Creditos"].Value = asignatura.Creditos;
                UpdateCmd.Prepare();
                UpdateCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean ModProfesor(Profesor profesor, string OldID) {
            try {
                string update = "UPDATE Profesor SET ID=@ID, Nombre=@Nombre, Apellido=@Apellido, Password=@Password WHERE ID=@OldID";
                MySqlCommand UpdateCmd = new MySqlCommand(update, con.connection);
                UpdateCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                UpdateCmd.Parameters.Add("@OldID", MySqlDbType.VarChar, 7);
                UpdateCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters.Add("@Apellido", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
                UpdateCmd.Parameters["@ID"].Value = profesor.ID;
                UpdateCmd.Parameters["@OldID"].Value = OldID;
                UpdateCmd.Parameters["@Nombre"].Value = profesor.Nombre;
                UpdateCmd.Parameters["@Apellido"].Value = profesor.Apellido;
                UpdateCmd.Parameters["@Password"].Value = profesor.Password;
                UpdateCmd.Prepare();
                UpdateCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean ModEstudiante(Estudiante estudiante, string OldID) {
            try {
                string update = "UPDATE Estudiante SET ID=@ID, Nombre=@Nombre, Apellido=@Apellido, Password=@Password, Carrera=@Carrera WHERE ID=@OldID";
                MySqlCommand UpdateCmd = new MySqlCommand(update, con.connection);
                UpdateCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                UpdateCmd.Parameters.Add("@OldID", MySqlDbType.VarChar, 7);
                UpdateCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters.Add("@Apellido", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters.Add("@Password", MySqlDbType.VarChar, 40);
                UpdateCmd.Parameters.Add("@Carrera", MySqlDbType.VarChar, 30);
                UpdateCmd.Parameters["@ID"].Value = estudiante.ID;
                UpdateCmd.Parameters["@OldID"].Value = OldID;
                UpdateCmd.Parameters["@Nombre"].Value = estudiante.Nombre;
                UpdateCmd.Parameters["@Apellido"].Value = estudiante.Apellido;
                UpdateCmd.Parameters["@Password"].Value = estudiante.Password;
                UpdateCmd.Parameters["@Carrera"].Value = estudiante.Carrera;
                UpdateCmd.Prepare();
                UpdateCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean ModEstudianteIndice(double indice, string honor, string ID) {
            try {
                string update = "UPDATE Estudiante SET Indice=@Indice, Honor=@Honor WHERE ID=@ID";
                MySqlCommand UpdateCmd = new MySqlCommand(update, con.connection);
                UpdateCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                MySqlParameter param = new MySqlParameter("@Indice", MySqlDbType.Decimal);
                param.Precision = 3;
                param.Scale = 2;
                UpdateCmd.Parameters.Add(param);
                UpdateCmd.Parameters.Add("@Honor", MySqlDbType.VarChar, 15);
                UpdateCmd.Parameters["@ID"].Value = ID;
                UpdateCmd.Parameters["@Indice"].Value = indice;
                UpdateCmd.Parameters["@Honor"].Value = honor;

                UpdateCmd.Prepare();
                UpdateCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static Boolean CheckInscripcion(string IDEstudiante, string ClaveAsignatura) {
            string check = "SELECT IDEstudiante FROM CursoAsignatura WHERE IDEstudiante=@IDEstudiante AND ClaveAsignatura=@ClaveAsignatura";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@IDEstudiante", MySqlDbType.VarChar, 7);
            CheckCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
            CheckCmd.Parameters["@IDEstudiante"].Value = IDEstudiante;
            CheckCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static Boolean CheckImparticion(string IDProfesor, string ClaveAsignatura) {
            string check = "SELECT IDProfesor FROM ImparticionAsignatura WHERE  ClaveAsignatura=@ClaveAsignatura";
            MySqlCommand CheckCmd = new MySqlCommand(check, con.connection);
            CheckCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
            CheckCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
            CheckCmd.Prepare();

            rdr = CheckCmd.ExecuteReader();

            return rdr.HasRows;
        }

        public static Boolean ImparticionAsignatura(string IDProfesor, string ClaveAsignatura) {
            try {
                string insert = "INSERT INTO ImparticionAsignatura (ClaveAsignatura, IDProfesor) VALUES (@ClaveAsignatura, @IDProfesor)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
                InsertCmd.Parameters.Add("@IDProfesor", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
                InsertCmd.Parameters["@IDProfesor"].Value = IDProfesor;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean BorrarProfesor(string ID) {
            try {
                string delete = "DELETE FROM Profesor WHERE ID=@ID";
                MySqlCommand DeleteCmd = new MySqlCommand(delete, con.connection);
                DeleteCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                DeleteCmd.Parameters["@ID"].Value = ID;
                DeleteCmd.Prepare();
                DeleteCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }



        public static Boolean BorrarEstudiante(string ID) {
            try {
                string delete = "DELETE FROM Estudiante WHERE ID=@ID";
                MySqlCommand DeleteCmd = new MySqlCommand(delete, con.connection);
                DeleteCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                DeleteCmd.Parameters["@ID"].Value = ID;
                DeleteCmd.Prepare();
                DeleteCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }



        public static Boolean InscripcionAsignatura(string IDEstudiante, string ClaveAsignatura) {
            try {
                string insert = "INSERT INTO CursoAsignatura (ClaveAsignatura, IDEstudiante) VALUES (@ClaveAsignatura, @IDEstudiante)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
                InsertCmd.Parameters.Add("@IDEstudiante", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
                InsertCmd.Parameters["@IDEstudiante"].Value = IDEstudiante;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean DeleteInscripcion(string IDEstudiante, string ClaveAsignatura) {
            try {
                string delete = "DELETE FROM CursoAsignatura WHERE IDEstudiante=@ID AND ClaveAsignatura=@ClaveAsignatura";
                MySqlCommand DeleteCmd = new MySqlCommand(delete, con.connection);
                DeleteCmd.Parameters.Add("@ID", MySqlDbType.VarChar, 7);
                DeleteCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
                DeleteCmd.Parameters["@ID"].Value = IDEstudiante;
                DeleteCmd.Parameters["@ClaveAsignatura"].Value = ClaveAsignatura;
                DeleteCmd.Prepare();
                DeleteCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }



        public static Boolean AddCalificacion(Calificacion calificacion) {
            try {
                string insert = "INSERT INTO Calificacion (Numero, Letra, IDEstudiante, IDProfesor, ClaveAsignatura) VALUES (@Numero, @Letra, @IDEstudiante, @IDProfesor, @ClaveAsignatura)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@Numero", MySqlDbType.Int32);
                InsertCmd.Parameters.Add("@Letra", MySqlDbType.VarChar, 2);
                InsertCmd.Parameters.Add("@IDEstudiante", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@IDProfesor", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
                InsertCmd.Parameters["@Numero"].Value = calificacion.Nota_Numero;
                InsertCmd.Parameters["@Letra"].Value = calificacion.Nota_Letra;
                InsertCmd.Parameters["@IDEstudiante"].Value = calificacion.IDEstudiante;
                InsertCmd.Parameters["@IDProfesor"].Value = calificacion.IDProfesor;
                InsertCmd.Parameters["@ClaveAsignatura"].Value = calificacion.ClaveAsignatura;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean ModCalificacion(Calificacion calificacion) {
            try {
                string insert = "UPDATE Calificacion SET Numero=@Numero, Letra=@Letra WHERE IDEstudiante=@IDEstudiante AND IDProfesor=@IDProfesor AND ClaveAsignatura=@ClaveAsignatura";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@Numero", MySqlDbType.Int32);
                InsertCmd.Parameters.Add("@Letra", MySqlDbType.VarChar, 2);
                InsertCmd.Parameters.Add("@IDEstudiante", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@IDProfesor", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@ClaveAsignatura", MySqlDbType.VarChar, 9);
                InsertCmd.Parameters["@Numero"].Value = calificacion.Nota_Numero;
                InsertCmd.Parameters["@Letra"].Value = calificacion.Nota_Letra;
                InsertCmd.Parameters["@IDEstudiante"].Value = calificacion.IDEstudiante;
                InsertCmd.Parameters["@IDProfesor"].Value = calificacion.IDProfesor;
                InsertCmd.Parameters["@ClaveAsignatura"].Value = calificacion.ClaveAsignatura;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex) {
                return false;
            }
        }

        public static Boolean AddAsignatura(Asignatura asignatura){
            try
            {              
                string insert = "INSERT INTO Asignatura (Clave, Nombre, Creditos) VALUES (@Clave, @Nombre, @Creditos)";
                MySqlCommand InsertCmd = new MySqlCommand(insert, con.connection);
                InsertCmd.Parameters.Add("@Clave", MySqlDbType.VarChar, 7);
                InsertCmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30);
                InsertCmd.Parameters.Add("@Creditos", MySqlDbType.Int32);
                InsertCmd.Parameters["@Clave"].Value = asignatura.Clave;
                InsertCmd.Parameters["@Nombre"].Value = asignatura.Nombre;               
                InsertCmd.Parameters["@Creditos"].Value = asignatura.Creditos;
                InsertCmd.Prepare();
                InsertCmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
    }
}

