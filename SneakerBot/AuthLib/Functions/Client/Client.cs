using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot.AuthLib.Functions.Client
{
    public class Client
    {
        public Client(out MySqlConnection mySqlConnection)
        {
            mySqlConnection = new MySqlConnection("CONNECTION_STRING_HERE");
            try
            {
                mySqlConnection.Open();
            }
            catch
            {
                MessageBox.Show("Our servers seams to be offline now! Please try again leater");
                Application.Exit();
            }
        }

        public int Status(MySqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand cmd;
            MySqlDataReader reader;
            string query = $"SELECT `Status` FROM `Global_Values` WHERE ID = '1'";
            int temp = 0;
            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    temp = reader.GetInt32(0);
                    reader.Close();
                }
            }
            catch
            {
                return temp;
            }
            return temp;
        }

        public void Update_Licence_User(MySqlConnection connection, string new_user,string licence)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"UPDATE `licence` SET `User` = '"+ new_user+"' WHERE `licence`.`Licence` = '" + licence + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = $"UPDATE `accounts` SET `LICENCE` = '" + licence + "' WHERE `USERNAME` = '" + new_user + "';";
            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public string ValidLicence(MySqlConnection connection, string licence)
        {
            string query = $"SELECT * FROM licence WHERE licence='" + licence + "';";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    {
                    }
                }
                query = $"SELECT User FROM licence WHERE licence='" + licence + "';";
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string resp = reader.GetString(0);
                    if (resp == "")
                    {
                        reader.Close();
                        connection.Close();
                        return "true";
                    }
                    else
                    {
                        reader.Close();
                        return "false";
                    }
                }
                return "false";

            }
            catch
            {
                return "false";
            }
        }

        public string Register(MySqlConnection connection, string login, string password)
        {
            MySqlCommand cmd;
            MySqlDataReader reader;
            string query = $"SELECT PASSWORD FROM accounts WHERE USERNAME='" + login + "';";
            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string resp = reader.GetString(0);
                    if (resp != "")
                    {
                        reader.Close();
                        return "false";
                    }
                    reader.Close();
                }
                reader.Close();
                Program.Token = API.RandomLicence(32);
                query = $"INSERT INTO accounts (`ID`, `USERNAME`, `PASSWORD`, `HWDI`, `TOKEN`, `LICENCE`, `PERMISSION`, `STATUS`) VALUES (NULL, '" + login + "', '" + API.Encrypt(password,Program.Token) + "', '', '" + Program.Token + "', '', '0', '0');";
                MySqlCommand _cmd = new MySqlCommand(query, connection);
                _cmd.ExecuteNonQuery();
                return "true";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "false1";
            }
        }


        public string Token(MySqlConnection connection, string login)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand cmd;
            MySqlDataReader reader;
            string token = "error";
            string query = $"SELECT TOKEN FROM accounts WHERE USERNAME='" + login + "';";

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    token = reader.GetString(0);
                    reader.Close();
                }
            }
            catch
            {
                return token;
            }
            return token;
        }

        public string login(MySqlConnection connection, string login, string password, out string token, out int perm)
        {
            MySqlCommand cmd;
            MySqlDataReader reader;
            string query = $"SELECT TOKEN FROM accounts WHERE USERNAME='" + login +"';";

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Program.Token = reader.GetString(0);
                    reader.Close();
                }

                token = Program.Token;

                query = $"SELECT ID FROM accounts WHERE USERNAME='" + login + "' AND PASSWORD='" + API.Encrypt(password,token) + "';";
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                }

                query = $"SELECT LICENCE,PERMISSION FROM accounts WHERE USERNAME='" + login + "';";

                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string resp = reader.GetString(0);
                    if (resp != "")
                    {
                        perm = reader.GetInt32(1);
                        reader.Close();
                        connection.Close();
                        return "true";
                    }
                    else
                    {
                        reader.Close();
                        perm = 0;
                        return "licence_#01";
                    }
                }
                perm = -1;
                return "false";
            }
            catch (Exception ex)
            {
                token = "null";
                perm = -1;
                MessageBox.Show(ex.ToString());
                return "false1";
            }
        }
    }
}
