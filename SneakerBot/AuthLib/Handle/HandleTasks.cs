using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleTasks
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");
        public static List<SneakerBot.AuthLib.Types.Task> QueryTasks()
        {
            List<SneakerBot.AuthLib.Types.Task> temp = new List<SneakerBot.AuthLib.Types.Task>();
            List<int> temp1 = new List<int>();
            int Proxy_Id = -1;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand("SELECT `BillingProfile`,`Name`, `Webiste`, `Link`, `Product`, `Status`, `Size`,`ID`,`ProfileID` FROM `Tasks` WHERE `User`= '" + Program.profile.Username + "';");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BillingProfile billingProfile1 = null;
                string data_profile = reader.GetString(0);
                if (data_profile != "null")
                {
                    foreach (BillingProfile billingProfile in Program.BillingProfiles)
                    {
                        if (billingProfile.Name == data_profile)
                            billingProfile1 = billingProfile;
                    }
                }
                temp.Add(new SneakerBot.AuthLib.Types.Task(reader.GetString(1), reader.GetString(2), reader.GetString(3), null, reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), billingProfile1, null));
                temp1.Add(reader.GetInt32(8));
            }
            connection.Close();

            for (int i = 0; i < temp.Count; i++)
            {
                temp[i].Account = HandleAccounts.Select_Account(temp1[i]);

                if (Proxy_Id != 0)
                    temp[i].proxy = HandleProxy.Select_Proxy(Proxy_Id);
            }

            return temp;
        }

        public static void InsertTask(SneakerBot.AuthLib.Types.Task task)
        {
            string query = $"INSERT INTO `Tasks` (`ID`, `Name`, `Webiste`, `Link`, `ProfileID`, `Product`, `Size`, `Status`, `User`, `BillingProfile`,`ProxyID`) VALUES (NULL,'" + task.Name + "','" + task.Website + "','" + task.Link + "','" + HandleAccounts.Int_Account(task.Account) + "','" + task.Product + "','" + task.Size + "','" + task.Status + "','" + Program.profile.Username + "','" + (task.BillingProfile == null ? "null" : task.BillingProfile.Name) + "','" + task.proxy.ID + "');";
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditStatus(string new_status, SneakerBot.AuthLib.Types.Task task, int id)
        {
            string query = $"UPDATE `Tasks` SET `Status` = '" + new_status + "' WHERE ID='" + id + "';";

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteTask(int id)
        {
            string query = $"DELETE FROM `Tasks` WHERE `ID`='" + id + "';";

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static int MaxId()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"SELECT MAX(ID) FROM Tasks";
            int temp = -1;

            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    temp = reader.GetInt32(0);
                }
                catch
                {
                    temp = 0;
                }
            }
            connection.Close();
            return temp;
        }
    }
}
