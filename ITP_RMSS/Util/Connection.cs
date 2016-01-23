using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ITP_RMSS.Util
{
    class Connection
    {
        private static MySqlConnection conn;
        private static String server = "localhost;";
        private static String database = "itp_rmss;";
        private static String username = "root;";
        private static String password = "1234;";

        public static MySqlConnection getConnection()
        {
            String connectionString = "Server=" + server + "Database=" + database + "Username=" + username + "Password=" + password;

            conn = new MySqlConnection(connectionString);
            conn.Open();

            if (conn.State.ToString() == "Open")
            {
                return conn;
            }
            else
            {
                return null;
            }
        }

    }
}
