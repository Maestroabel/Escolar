using Microsoft.VisualStudio.TestTools.UnitTesting;
using Escolar;

namespace EscolarTests
{
    [TestClass]
    public class ControlDBTest
    {
        [TestMethod]
        public void AddEstudiante_Test()
        {
            Estudiante estudiante = new Estudiante("123456","Ejemplo","Ejemplo","IDS","1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddEstudiante(estudiante);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void AddProfesor_Test()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddProfesor(profesor);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginAdmin_Test()
        {
            bool Result = ControlDB.LoginAdmin("Admin","Admin");
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginEstudiante_Test()
        {
            Estudiante estudiante = new Estudiante("123456","1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.LoginEstudiante(estudiante);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginProfesor_Test()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.LoginProfesor(profesor);
            Assert.IsTrue(Result);
            
        }
        [TestMethod]
        public void GetProfesor_Test_ParametroVacío()
        {
            Profesor profesor = new Profesor("", "", "", "");
            ControlDB con = new ControlDB();
            Profesor Result = ControlDB.GetProfesor("");
            Assert.AreEqual(profesor.ID, Result.ID); 
        }
        [TestMethod]
        public void GetProfesor_Test_ID_Profesor_Valido()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            Profesor Result = ControlDB.GetProfesor("123456");
            Assert.AreEqual(profesor.ID, Result.ID);
        }
        public void GetProfesor_Test_ID_Profesor_Invalido()
        {
            Profesor profesor = new Profesor("", "", "", "");
            ControlDB con = new ControlDB();
            Profesor Result = ControlDB.GetProfesor("1099998");
            Assert.AreEqual(profesor.ID, Result.ID);
        }
    }
}
