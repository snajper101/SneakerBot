using MySql.Data.MySqlClient;
using SneakerBot.AuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class HandleSupport
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");

        public static List<SupportTicket> SupportTickets()
        {
            if (connection.State != System.Data.ConnectionState.Open) { connection.Open(); }

            List<SupportTicket> temp = new List<SupportTicket>();

            string query = (Program.profile.Permission == 0 ? "SELECT Title,Status,TicketID FROM Support_Topics WHERE Username='" + Program.profile.Username + "';" : "SELECT Title,Status,TicketID FROM Support_Topics WHERE 1;");

            MySqlCommand command = new MySqlCommand(query);

            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(new SupportTicket {Topic = reader.GetString(0), Status = reader.GetInt32(1), TicketID = reader.GetInt32(2), supportReply = SupportReplies(reader.GetInt32(2)) });
            }
            connection.Close();
            return temp;
        }

        private static List<SupportReply> SupportReplies(int tickedID)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");
            if (mySqlConnection.State != System.Data.ConnectionState.Open) { mySqlConnection.Open(); }

            List<SupportReply> temp = new List<SupportReply>();

            MySqlCommand command = new MySqlCommand("SELECT Username,UserPermission,Content,DateTime,LocalID FROM Support_Replies WHERE TicketId='" + tickedID + "';");
            command.Connection = mySqlConnection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(new SupportReply {profile = new Profile("",reader.GetString(0), reader.GetInt32(1)), content = reader.GetString(2), DateTime = reader.GetDateTime(3), ID = reader.GetInt32(4) });
            }
            mySqlConnection.Close();
            return temp;
        }

        public static void Create_Ticket(string title, string start_message)
        {
            int local_ticket_id = 0;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"SELECT MAX(TicketID) FROM Support_Topics";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                local_ticket_id = reader.GetInt32(0) + 1;
            }
            reader.Close();
            query = "INSERT INTO `Support_Topics` (`ID`, `Title`, `Status`, `Username`, `TicketID`) VALUES (NULL, '" + title + "', '0', '" + Program.profile.Username + "', '" + local_ticket_id + "');";

            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            command.Dispose();

            query = "INSERT INTO `Support_Replies` (`ID`, `TicketID`, `Username`, `Content`, `LocalID`,`UserPermission`) VALUES (NULL,'" + local_ticket_id + "','" + Program.profile.Username + "','" + start_message + "','1','" + Program.profile.Permission + "');";

            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        public static void Reply(int TicketID, string Message)
        {
            int max_id = 0;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"SELECT MAX(LocalID) FROM Support_Replies";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                max_id = reader.GetInt32(0) + 1;
            }
            reader.Close();

            query = "INSERT INTO `Support_Replies` (`ID`, `TicketID`, `Username`, `Content`,`UserPermission`,`LocalID`) VALUES (NULL,'" + TicketID + "','" + Program.profile.Username + "','" + Message + "','" + Program.profile.Permission + "','"+max_id+"');";

            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
