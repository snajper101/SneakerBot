using MySql.Data.MySqlClient;
using SneakerBot.AuthLib.Functions.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot
{
    public partial class Register : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        static MySqlConnection connection;
        public static Client client = new Client(out connection);
        public Register()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
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
            if (Password1Txt.Text == Password2Txt.Text)
            {
                string resp = client.Register(connection,UsernameTxt.Text, Password1Txt.Text);
                if (resp == "false")
                {
                    LoginStatus.Text = "Username was used!";
                    LoginStatus.Visible = true;
                    API.Wait(5000);
                    LoginStatus.Visible = false;
                }
                else if (resp == "true")
                {
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    LoginStatus.Text = "Failed To register!";
                    LoginStatus.Visible = true;
                    API.Wait(5000);
                    LoginStatus.Visible = false;
                }
            }
            else
            {
                LoginStatus.Text = "Passwords aren't equal!";
                LoginStatus.Visible = true;
                API.Wait(5000);
                LoginStatus.Visible = false;
            }
        }
    }
}
