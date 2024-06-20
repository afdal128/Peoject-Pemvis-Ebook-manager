using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace E_Book_Manager.Class
{
    internal class koneksi
    {
        public MySqlConnection Getconn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = book_manager; user = root; password='';";
            return conn;
        }
    }
}
