using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
namespace test2
{
  class Connect
{
        private string connectionString = "server=127.0.0.1;user=root;password=123456;database=valet;sslmode=none";
        // private string connectionString = "server=192.168.1.32;user=user50;password=26643;database=user50;sslmode=none";
        private MySqlConnection con;
        private MySqlDataAdapter adapter;
        private DataSet ds;

        public DataSet CO(string qwerty)
        {
            con = new MySqlConnection(connectionString);
            con.Open();
            adapter = new MySqlDataAdapter(qwerty, con);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void SIDU(string sql)
        {
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }
        }

    }
    }

