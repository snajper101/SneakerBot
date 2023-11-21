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
    public partial class Add_Account : Form
    {
        List<Account> account = new List<Account>();
        Accounts accounts_form;
        public Add_Account(Accounts accounts)
        {
            InitializeComponent();
            accounts_form = accounts;
        }

        private void Add_Account_Load(object sender, EventArgs e)
        {

            foreach (string Webiste in Enum.GetNames(typeof(API.Websites)))
            {
                StoreComboBox.Items.Add(Webiste);
            }
            StoreComboBox.SelectedIndex = 0;
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LocalAdd_Click(object sender, EventArgs e)
        {
            if (EmailTXT.Text != "" && PasswordTxt.Text != "" && StoreComboBox.SelectedItem.ToString() != "")
            {
                string password = "";
                foreach(char i in PasswordTxt.Text)
                {
                    password += '*';
                }

                account.Add(new Account(StoreComboBox.Text, EmailTXT.Text, PasswordTxt.Text));
                Accounts.Items.Add(EmailTXT.Text + ":" + password);
                StoreComboBox.Enabled = false;
                AddBtn.Text = "Add " + Accounts.Items.Count + " Accounts";
                PasswordTxt.Text = "";
                EmailTXT.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            foreach (Account account1 in account)
            {
                accounts_form.Add_Account(account1);
            }

            this.Hide();


        }
    }
}
