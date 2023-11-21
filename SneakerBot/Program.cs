using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SneakerBot.Api;

namespace SneakerBot
{
    static class Program
    {
        internal static Form1 calendar = new Form1();
        internal static string Token;
        internal static Profile profile = new Profile();
        internal static string version = "0.1";
        internal static List<Account> accounts = new List<Account>();
        internal static List<BillingProfile> BillingProfiles = new List<BillingProfile>();
        internal static List<Proxy> proxies = new List<Proxy>();
        internal static List<SneakerBot.AuthLib.Types.Task> tasks = new List<AuthLib.Types.Task>();
        internal static List<SupportTicket> supportTickets = new List<SupportTicket>();
        internal static List<Notification> notifications = new List<Notification>();

        [STAThread]
        static void Main()
        {
            API.Remove_ChromeDriver();
            Application.EnableVisualStyles();
            Application.Run(new Login());
        }

        public static void loadAccounts()
        {
            accounts = HandleAccounts.QueryAccount();
        }

    }
}
