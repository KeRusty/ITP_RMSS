using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITP_RMSS.Util;
using MySql.Data.MySqlClient;   

namespace ITP_RMSS.Util
{
    class DBHandler
    {
        static MySqlConnection conn = Connection.getConnection();

        //This piece of code is for insert, Update and delete query

        public static bool ExecuteNonQuery(String query)
        {
            if (conn != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return false;
        }

        //This piece of code is for the select query
        public static MySqlDataReader ExecuteQuery(String query)
        {
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
            return null;
        }

    }
}
