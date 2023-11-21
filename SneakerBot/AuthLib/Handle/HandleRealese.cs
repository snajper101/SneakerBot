using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot.AuthLib.Functions.Realeses
{
    public class HandleRealese
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;DATABASE=mEKYOdkxsP;UID=mEKYOdkxsP;PASSWORD=V8UD0BReg1");

        public static string RealeseInDataBase(string model, string website)
        {
            string resp = "error";
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand cmd;
            MySqlDataReader reader;

            string query = $"SELECT ID FROM UpcomingRealeses WHERE Model='" + model + "' AND Website='" + website + "';";

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetInt32(0) != 0)
                    {
                        reader.Close();
                        resp = "true";
                        return resp;
                    }
                    else
                    {
                        reader.Close();
                        resp = "false";
                        return resp;
                    }
                }
                else
                {
                    resp = "false";
                    reader.Close();
                    return resp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return resp;
            }
        }

        public static bool InsertIntoDataBase(string model, string color, string realese_day,string realese_month, string website)
        {
            string query = $"INSERT INTO `UpcomingRealeses` (`ID`, `Model`, `Color`, `Realese Day`, `Realese Month`, `Website`, `CopVotes`, `DropVotes`) VALUES (NULL, '" + model + "', '" + color + "', '" + realese_day+"', '" + realese_month + "', '" + website + "', '1', '1');";
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void AddCop(string model, string website)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = 0;

            MySqlCommand cmd;
            MySqlDataReader reader;

            string query = $"SELECT ID FROM UpcomingRealeses WHERE Model='" + model + "' AND Website='" + website + "';";

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    reader.Close();
                }


                query = $"SELECT CopVotes FROM UpcomingRealeses WHERE ID='" + id + "';";

                int copvotes = 0;

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    copvotes = reader.GetInt32(0);
                    reader.Close();
                }

                copvotes++;

                query = $"UPDATE `UpcomingRealeses` SET `CopVotes`=" + copvotes.ToString() +" WHERE ID=" + id.ToString() + ";";

                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        public static void AddDrop(string model, string website)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = 0;

            MySqlCommand cmd;
            MySqlDataReader reader;

            string query = $"SELECT ID FROM UpcomingRealeses WHERE Model='" + model + "' AND Website='" + website + "';";

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    reader.Close();
                }


                query = $"SELECT DropVotes FROM UpcomingRealeses WHERE ID='" + id + "';";

                int DropVotes = 0;

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DropVotes = reader.GetInt32(0);
                    reader.Close();
                }

                DropVotes++;

                query = $"UPDATE `UpcomingRealeses` SET `DropVotes`=" + DropVotes.ToString() + " WHERE ID=" + id.ToString() + ";";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        public static int GetCopVotes(string model, string website,out string resp)
        {
            resp = "error";

            int id = 0;
            MySqlCommand cmd;
            MySqlDataReader reader;
            string query;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            try
            {
                query = $"SELECT ID FROM UpcomingRealeses WHERE Model='" + model + "' AND Website='" + website + "';";

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    reader.Close();
                }


                query = $"SELECT CopVotes FROM UpcomingRealeses WHERE ID='" + id + "';";

                int copvotes = 0;

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    copvotes = reader.GetInt32(0);
                    reader.Close();
                }
                resp = "true";
                return copvotes;
            }
            catch
            {
                return 0;
            }
        }

        public static int GetDropVotes(string model, string website, out string resp)
        {
            resp = "error";

            int id = 0;
            MySqlCommand cmd;
            MySqlDataReader reader;
            string query;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            try
            {
                query = $"SELECT ID FROM UpcomingRealeses WHERE Model='" + model + "' AND Website='" + website + "';";

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    reader.Close();
                }


                query = $"SELECT DropVotes FROM UpcomingRealeses WHERE ID='" + id + "';";

                int DropVotes = 0;

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DropVotes = reader.GetInt32(0);
                    reader.Close();
                }
                resp = "true";
                return DropVotes;
            }
            catch
            {
                return 0;
            }
        }
    }
}
