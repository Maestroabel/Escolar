using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Escolar;
using MySql.Data.MySqlClient;



namespace EscolarTests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Couldn't connect to database")]
        public void Test_Database_Connection_Wrong_Credentials()
        {
            //ConexionDB already has the corresponding default credentials
            //string server_address = "localhost",
            //string db_user = "root",
            //string db_password = "Maestroarco7",
            //string db_port = "3306",
            //string db_name="escolar"

            ConexionDB connection = new ConexionDB();
            connection.connect();



        }

        [TestMethod]
        public void Test_Database_Connection_Right_Credentials()
        {
            

            ConexionDB connection = new ConexionDB(db_password: "@Hotmail.com1");
            connection.connect();


        }
    }
}
