using Microsoft.VisualStudio.TestTools.UnitTesting;
using Escolar;

namespace EscolarTests
{
    [TestClass]
    public class ControlDBTest
    {
        [TestMethod]
        public void AddEstudiante_Test_1()
        {
            Estudiante estudiante = new Estudiante("123456", "Ejemplo", "Ejemplo", "IDS", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddEstudiante(estudiante);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void AddProfesor_Test_2()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddProfesor(profesor);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginAdmin_Test_3()
        {
            bool Result = ControlDB.LoginAdmin("Admin", "Admin");
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginEstudiante_Test_4()
        {
            Estudiante estudiante = new Estudiante("123456", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.LoginEstudiante(estudiante);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void LoginProfesor_Test_5()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            bool Result = ControlDB.LoginProfesor(profesor);
            Assert.IsTrue(Result);

        }
        [TestMethod]
        public void GetProfesor_Test_ParametroVacío_6()
        {
            Profesor profesor = new Profesor("", "", "", "");
            ControlDB con = new ControlDB();
            Profesor Result = ControlDB.GetProfesor("");
            Assert.AreEqual(profesor.ID, Result.ID);
        }
        [TestMethod]
        public void GetProfesor_Test_ID_ParametroValido_7()
        {
            Profesor profesor = new Profesor("123456", "Ejemplo", "Ejemplo", "1234567");
            ControlDB con = new ControlDB();
            Profesor Result = ControlDB.GetProfesor("123456");
            Assert.AreEqual(profesor.ID, Result.ID);
        }
        [TestMethod]
        public void GetEstudiante_Test_ParametroVacío_8()
        {
            Estudiante estudiante = new Estudiante("", "", "", "","");
            ControlDB con = new ControlDB();
            Estudiante Result = ControlDB.GetEstudiante("");
            Assert.AreEqual(estudiante.ID, Result.ID);
        }
        [TestMethod]
        public void GetEstudiante_Test_ID_ParametroValido_9()
        {
            Estudiante estudiante = new Estudiante("123456", "Ejemplo", "Ejemplo", "IDS", "1234567");
            ControlDB con = new ControlDB();
            Estudiante Result = ControlDB.GetEstudiante("123456");
            Assert.AreEqual(estudiante.ID, Result.ID);
        }
        [TestMethod]
        public void AddAsignatura_Test_10()
        {
            Asignatura asignatura = new Asignatura("IDS500", "Ejemplo", 4);
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddAsignatura(asignatura);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void AddAsignatura_Test_11()
        {
            Asignatura asignatura = new Asignatura("IDS555", "Ejemplo", 50);
            ControlDB con = new ControlDB();
            bool Result = ControlDB.AddAsignatura(asignatura);
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void ModAsignatura_Test_12()
        {
            Asignatura asignatura = new Asignatura("IDS555", "Ejemplo", 5);
            ControlDB con = new ControlDB();
            bool Result = ControlDB.ModAsignatura(asignatura, "IDS555");
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void ModAsignatura_Test_13()
        {
            Asignatura asignatura = new Asignatura("IDS555", "Ejemplo", -1);
            ControlDB con = new ControlDB();
            bool Result = ControlDB.ModAsignatura(asignatura,"IDS555");
            Assert.IsFalse(Result);
        }

        /*
            select * from profesor;
            select * from estudiante;
            select * from asignatura;
            delete from estudiante where ID = 123456;
            delete from profesor where ID = 123456;
            delete from asignatura where Clave = "IDS500";
        */

        /*
         if (asignatura.Creditos < 0 || asignatura.Creditos > 5)
                {
                    return false;
                }
        */
    }
}
