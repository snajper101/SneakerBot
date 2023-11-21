using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            gui1.SettingsBtn.Enabled = false;
            gui1.parentForm = this;
        }

        private void gui1_Load(object sender, EventArgs e)
        {
            WelcomeLbl.Text = WelcomeLbl.Text.Replace("---", Program.profile.Username);
            AccountTypeLbl.ForeColor = Program.profile.Permission == 0 ? Color.FromArgb(62, 154, 112) : Color.FromArgb(195, 65, 66);
            AccountTypeLbl.Text = AccountTypeLbl.Text.Replace("---", Program.profile.Permission == 0 ? "Normal User" : "Admin");
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Token = "";
            Program.profile = new Profile();
            Program.accounts = new List<Account>();
            Program.BillingProfiles = new List<BillingProfile>();
            Program.proxies = new List<Proxy>();
            Program.tasks = new List<AuthLib.Types.Task>();
            Login login = new Login();
            login.Show();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < numericUpDown1.Value + 1; i++)
            {
                HandleAdmin.GenerateLicence();
            }
        }
    }
}
