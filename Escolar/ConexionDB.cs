using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Escolar {
    public class ConexionDB {
        private static string server ;
        private static string user ;
        private static string password ;
        private static string port ;
        private static string database;


        private static string connStr;
        public MySqlConnection connection ;


        public ConexionDB(string server_address = "localhost", string db_user = "root", string db_password = "Maestroarco7", string db_port = "3306", string db_name="escolar") {
            server = server_address;
            user = db_user;
            password = db_password;
            port = db_port;
            database = db_name;

            connStr = $"server={server};user={user};database={database};port={port};password={password}";
            connect();
        }

         public void connect()
        {
            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't connect to database");
            }
            
        }


        
    }
}
