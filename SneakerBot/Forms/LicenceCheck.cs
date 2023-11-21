using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SneakerBot.AuthLib.Functions.Client;
using SneakerBot.UI;

namespace SneakerBot
{
    public partial class LicenceCheck : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        MySqlConnection connection;
        Client client;
        string username;
        public LicenceCheck(MySqlConnection mySqlConnection, Client _client, string _username)
        {
            InitializeComponent();

            textBox1.Visible = true;

            connection = mySqlConnection;

            client = _client;

            username = _username;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text.Length == 8)
            {
                string resp = client.ValidLicence(connection, textBox1.Text);
                if (resp == "true")
                {
                    client.Update_Licence_User(connection, username, textBox1.Text);
                    this.Hide();
                    LoadData loadData = new LoadData();
                    loadData.Show();
                }
                else
                {
                    ValidLicenceLbl.Text = "LICENCE ISN'T VALID";
                    ValidLicenceLbl.Visible = true;
                    API.Wait(5000);
                    ValidLicenceLbl.Visible = false;
                }

            }
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

        private void LicenceCheck_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
