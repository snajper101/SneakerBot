using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot.UI
{
    public partial class LoadData : Form
    {
        public LoadData()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.accounts = HandleAccounts.QueryAccount();
            if (File.Exists(Application.StartupPath + "//Data//" + Program.profile.Username + "_data.data"))
            {
                string[] temp = File.ReadAllLines(Application.StartupPath + "//Data//" + Program.profile.Username + "_data.data");

                int i = 0;
                foreach (string line in temp)
                {
                    string[] temp2 = API.Decrypt(line, Program.Token).Split(',');

                    Program.BillingProfiles.Add(new BillingProfile(temp2[0], temp2[1], temp2[2], temp2[3], API.Decrypt(temp2[4], Program.Token), temp2[6], Convert.ToInt32(temp2[7]), API.Decrypt(temp2[5], Program.Token), temp2[11], temp2[12], temp2[8], temp2[9], temp2[13], temp2[10], temp2[17], temp2[18], temp2[14], temp2[15], temp2[19], temp2[16]));
                    i++;
                }
            }
            Program.tasks = HandleTasks.QueryTasks();
            Program.proxies = HandleProxy.QueryProxies();
            Program.supportTickets = HandleSupport.SupportTickets();
            Program.notifications = HandleNotifications.QueryNotifications();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Program.calendar.Show();
            this.Hide();
        }
    }
}
