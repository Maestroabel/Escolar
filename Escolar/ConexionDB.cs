using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Escolar {
    public class ConexionDB {
        private static string server = "localhost";
        private static string user = "root";
        private static string password = "Maestroarco7";
        private static string port = "3306";
        private static string database = "escolar";

        public MySqlConnection connection;

        private string connStr = $"server={server};user={user};database={database};port={port};password={password}";

        public ConexionDB() {
            connection = new MySqlConnection(connStr);
            connection.Open();
        }
    }
}
