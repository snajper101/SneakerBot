using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot
{ 
    public class HandleVersion
    {
        static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");
        public static string QueryVersion()
        {
            connection.Open();
            string query = $"SELECT version FROM Global_Values WHERE ID='1';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string ver = reader.GetString(0);
                reader.Close();
                connection.Close();
                return ver;
            }
            else
            {
                MessageBox.Show("Failed to get version");
                Application.Exit();
                connection.Close();
                reader.Close();
                return "";
            }
        }
    }
}
