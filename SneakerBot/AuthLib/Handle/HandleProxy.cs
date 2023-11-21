using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleProxy
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");
        public static int Get_Max_Id()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            int temp = -1;

            string query = $"SELECT MAX(`ID`) From `Proxy`";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    temp = reader.GetInt32(0);
                }
                catch { }
            }
            reader.Close();
            connection.Close();
            return temp;
        }

        public static Proxy Select_Proxy(int id)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            Proxy Proxy = null;
            MySqlCommand command = new MySqlCommand("SELECT ID, Address,Port FROM Proxy WHERE User='" + Program.profile.Username + "';");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Proxy = new Proxy(reader.GetInt32(0), API.Decrypt(reader.GetString(1), Program.Token), reader.GetInt32(2));

            }
            connection.Close();
            return Proxy;
        }

        public static void InsertTask(Proxy proxy)
        {
            string query = $"INSERT INTO `Proxy` (`ID`, `Address`, `Port`, `User`) VALUES (NULL, '" + API.Encrypt(proxy.IP, Program.Token) + "', '" + proxy.Port + "', '" + Program.profile.Username + "')";
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Proxy> QueryProxies()
        {
            List<Proxy> temp = new List<Proxy>();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand("SELECT ID, Address,Port FROM Proxy WHERE User='" + Program.profile.Username + "';");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(new Proxy { ID = reader.GetInt32(0), IP = API.Decrypt(reader.GetString(1),Program.Token), Port = Convert.ToInt32(reader.GetString(2))});
            }
            connection.Close();
            return temp;
        }
    }
}