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
    public partial class Accounts : Form
    {
        
        public Accounts()
        {
            InitializeComponent();

            gui1.parentForm = this;
            gui1.AccountsBtn.Enabled = false;

            IdListBox.Items.Clear();
            StoreListBox.Items.Clear();
            EmailListBox.Items.Clear();
            PasswordListBox.Items.Clear();
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            Add_Account add_Account = new Add_Account(this);
            add_Account.Show();
        }

        public void Add_Account(Account account)
        {
            IdListBox.Items.Add(IdListBox.Items.Count);
            StoreListBox.Items.Add(account.Store);
            EmailListBox.Items.Add(account.Email);
            PasswordListBox.Items.Add(account.Password);
            HandleAccounts.Add_Account(account);
            Program.accounts.Add(account);
        }

        private void IdListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreListBox.SelectedIndex = IdListBox.SelectedIndex;
            EmailListBox.SelectedIndex = IdListBox.SelectedIndex;
            PasswordListBox.SelectedIndex = IdListBox.SelectedIndex;
        }

        private void StoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdListBox.SelectedIndex = StoreListBox.SelectedIndex;
            EmailListBox.SelectedIndex = StoreListBox.SelectedIndex;
            PasswordListBox.SelectedIndex = StoreListBox.SelectedIndex;
        }

        private void EmailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdListBox.SelectedIndex = EmailListBox.SelectedIndex;
            StoreListBox.SelectedIndex = EmailListBox.SelectedIndex;
            PasswordListBox.SelectedIndex = EmailListBox.SelectedIndex;
        }

        private void PasswordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdListBox.SelectedIndex = PasswordListBox.SelectedIndex;
            StoreListBox.SelectedIndex = PasswordListBox.SelectedIndex;
            EmailListBox.SelectedIndex = PasswordListBox.SelectedIndex;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            foreach (Account account in Program.accounts)
            {
                IdListBox.Items.Add(IdListBox.Items.Count);
                StoreListBox.Items.Add(account.Store);
                EmailListBox.Items.Add(account.Email);
                string password = "";
                foreach (char i in account.Password)
                {
                    password += '*';
                }
                PasswordListBox.Items.Add(password);
            }
        }
    }
}
