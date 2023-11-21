using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleAdmin
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");

        public static void GenerateLicence()
        {
            string query = $"INSERT INTO `licence` (`ID`, `Licence`, `User`) VALUES (NULL,'" + API.RandomLicence(8) + "','');";
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
