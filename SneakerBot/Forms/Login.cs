using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SneakerBot.AuthLib.Functions.Client;
using SneakerBot.UI;

namespace SneakerBot
{
    public partial class Login : Form
    {
        static MySqlConnection connection;
        public static Client client = new Client(out connection);

        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string token;
            int perm;
            string resp = client.login(connection, UsernameTxt.Text, PasswordTxt.Text, out token, out perm);

            if (resp == "true")
            {
                this.Hide();
                AutoLogin(token);
                Program.profile = new Profile(token, UsernameTxt.Text, perm);
                Program.Token = client.Token(connection, UsernameTxt.Text);
                LoadData loadData = new LoadData();
                loadData.Show();
            }
            else if (resp == "false")
            {
                LoginStatus.Visible = true;
                API.Wait(5000);
                LoginStatus.Visible = false;
            }
            else if (resp == "licence_#01")
            {
                this.Hide();
                AutoLogin(token);
                LicenceCheck licence = new LicenceCheck(connection, client, UsernameTxt.Text);
                licence.Show();
                Program.Token = client.Token(connection, UsernameTxt.Text);
                Program.profile = new Profile(token, UsernameTxt.Text, perm);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (client.Status(connection) == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                RememberMeCB.Enabled = false;
                LoginStatus.Visible = true;
                LoginStatus.Text = "SERVER UNAVAIBLE";
                UsernameTxt.Enabled = false;
                PasswordTxt.Enabled = false;
            }
            else
            {
                if (File.Exists("autologin.data"))
                {
                    //Load Config
                    StreamReader sr = new StreamReader("autologin.data");
                    string useAutoLogin = sr.ReadLine();
                    string userHash = sr.ReadLine();
                    string pwHash = sr.ReadLine();

                    sr.Close();
                    sr.Dispose();

                    if (Convert.ToBoolean(useAutoLogin))
                    {
                        //Setup Decryption...etc
                        RememberMeCB.Checked = true;
                        pwHash = API.Decrypt(pwHash, client.Token(connection, userHash));
                        UsernameTxt.Text = userHash;
                        PasswordTxt.Text = pwHash;
                        Button1_Click(null, EventArgs.Empty);
                    }
                    else
                    {
                        RememberMeCB.Checked = true;
                        pwHash = API.Decrypt(pwHash, client.Token(connection, userHash));
                        UsernameTxt.Text = userHash;
                        PasswordTxt.Text = pwHash;
                    }
                }
            }
        }

        private void AutoLogin(string token)
        {
            if (RememberMeCB.Checked)
            {
                if (!File.Exists("autologin.data"))
                {
                    var file = File.Create("autologin.data");
                    file.Close();
                    StreamWriter sw = new StreamWriter("autologin.data");
                    sw.WriteLine("False");
                    sw.WriteLine(UsernameTxt.Text);
                    sw.WriteLine(API.Encrypt(PasswordTxt.Text, token));
                    sw.Close();
                }
                else
                {
                    try
                    {
                        File.Delete("autologin.data");
                        var file = File.Create("autologin.data");
                        file.Close();
                        StreamWriter sw = new StreamWriter("autologin.data");
                        sw.WriteLine("False");
                        sw.WriteLine(UsernameTxt.Text);
                        sw.WriteLine(API.Encrypt(PasswordTxt.Text, token));
                        sw.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Configuration File cannot be removed");
                    }
                }
            }
            else
            {
                if (File.Exists("autologin.data"))
                {
                    try
                    {
                        File.Delete("autologin.data");
                    }
                    catch
                    {
                        MessageBox.Show("Configuration File cannot be removed");
                    }
                }
            }
        }

        private void AutoLoginCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Auto_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
