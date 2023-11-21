using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleNotifications
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");

        public static List<Notification> QueryNotifications()
        {
            List<Notification> temp = new List<Notification>();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand("SELECT ID, Title,Message, DateTime FROM Notifications");
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(new Notification { ID = reader.GetInt32(0), Title = reader.GetString(1), Message = reader.GetString(2), CreationDate = reader.GetString(3),Read = ReadNotification(Program.profile.Username, reader.GetInt32(0)) });
            }
            connection.Close();
            return temp;
        }

        public static bool ReadNotification(string UserName, int NotificationID)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlDataAdapter adapter;

            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT `Username`, `NotificationID` FROM `Readed_Notifications` WHERE `Username`='" + UserName + "' AND `NotificationID`='" + NotificationID + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                table.Clear();
                return false;
            }
            else
            {
                table.Clear();
                return true;
            }
        }
        public static bool UpdateNotificationStatus(string UserName, int NotificationID)
        {

            MySqlDataAdapter adapter;

            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT `Username`, `NotificationID` FROM `Readed_Notifications` WHERE `Username`='" + UserName + "' AND `NotificationID`='" + NotificationID + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MySqlConnection conn = connection;
                MySqlCommand command = new MySqlCommand("INSERT INTO `Readed_Notifications` (`Username`,`NotificationID`) VALUES ('" + UserName + "', '" + NotificationID + "')", connection);
                command.Connection = conn;
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                command.Dispose();
                table.Clear();
                return true;
            }
            else
            {
                MySqlConnection conn = connection;
                MySqlCommand command1 = new MySqlCommand("DELETE FROM Readed_Notifications WHERE Username=@User AND NotificationID=@NotificationID", connection);
                command1.Parameters.AddWithValue("@User", UserName);
                command1.Parameters.AddWithValue("@NotificationID", NotificationID);
                command1.Connection = conn;
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                command1.ExecuteNonQuery();
                command1.Dispose();
                table.Clear();
            }
            return false;
        }

        public static int QueryNotificationsCount()
        {
            string queryString = "SELECT COUNT(*) FROM Notifications";

            using (MySqlConnection mySqlConnection = connection)
            {
                MySqlCommand command = new MySqlCommand(queryString, mySqlConnection);

                mySqlConnection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static int ReadedNotifications()
        {
            string queryString = "SELECT COUNT(*) FROM `Readed_Notifications` WHERE `Username`='" + Program.profile.Username + "'";

            using (MySqlConnection mySqlConnection = connection)
            {
                MySqlCommand command = new MySqlCommand(queryString, mySqlConnection);

                mySqlConnection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}
