using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SneakerBot.Forms;

namespace SneakerBot
{
    public partial class GUI : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form parentForm;
        public GUI()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeHour.Text = DateTime.Now.ToString("HH:mm : ss");
            Date.Text = DateTime.Now.ToString("dd MMM yyyy");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.calendar.Show();
            Program.calendar.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void GUI_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void GUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                parentForm.Location = new Point(
                    (parentForm.Location.X - lastLocation.X) + e.X, (parentForm.Location.Y - lastLocation.Y) + e.Y);

                parentForm.Update();
            }
        }

        private void GUI_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Show();
            task.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Support support = new Support();
            support.Show();
            support.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Show();
            accounts.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            Billings billings = new Billings();
            billings.Show();
            billings.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Proxy_List proxy = new Proxy_List();
            proxy.Show();
            proxy.Location = parentForm.Location;
            parentForm.Hide();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            settings.Location = parentForm.Location;
            parentForm.Hide();
        }
    }
}
