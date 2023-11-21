using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleAccounts
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");

        public static List<Account> QueryAccount()
        {
            List<Account> temp = new List<Account>();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand("SELECT Store, Email,Password FROM websites_accounts WHERE User='" + Program.profile.Username + "';");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(new Account {Store = reader.GetString(0), Email = reader.GetString(1), Password = API.Decrypt(reader.GetString(2), Program.Token) });
            }
            connection.Close();
            return temp;
        }

        public static void Add_Account(Account account)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"INSERT INTO `websites_accounts` (`ID`, `Store`, `Email`, `Password`, `User`) VALUES (NULL, '" + account.Store + "', '" + account.Email + "', '" + API.Encrypt(account.Password, Program.Token) + "', '" + Program.profile.Username + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static int Int_Account(Account account)
        {
            int temp = -1;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            if (account != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT ID FROM websites_accounts WHERE Store='" + account.Store + "' AND User='" + Program.profile.Username + "' AND Email='" + account.Email + "';");
                command.Connection = connection;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    temp = reader.GetInt32(0);

                }
                connection.Close();
            }
            return temp;
        }

        public static Account Select_Account(int id)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            Account account = null;
            MySqlCommand command = new MySqlCommand("SELECT Store, Email,Password FROM websites_accounts WHERE User='" + Program.profile.Username + "';");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                account = new Account(reader.GetString(0), reader.GetString(1), API.Decrypt(reader.GetString(2), Program.Token));

            }
            connection.Close();
            return account;
        }
    }
}
