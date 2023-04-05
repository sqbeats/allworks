using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace session1
{
    class db
    {
        MySqlConnection con = new MySqlConnection("server=localhost; port=8889; username=root; password=root; database=session; SSL Mode = None");

        public void conOpen()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void conClose()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public MySqlConnection getC()
        {
            return con;
        }
    }
}
