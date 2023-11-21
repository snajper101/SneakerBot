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
    public partial class Add_Task : Form
    {
        Task task;
        List<string> tags_name = new List<string>();
        List<Tag> Tags = new List<Tag>();
        List<Account> local_accounts = new List<Account>();
        public Add_Task(Task _task)
        {
            InitializeComponent();

            task = _task;

            foreach (string Webiste in Enum.GetNames(typeof(API.Websites)))
            {
                StoreCB.Items.Add(Webiste);
            }
            StoreCB.SelectedIndex = 0;

            foreach (BillingProfile Account in Program.BillingProfiles)
            {
                Billings_CB.Items.Add(Account.Name);
            }

            foreach (Proxy Account in Program.proxies)
            {
                ProxiesCB.Items.Add(Account.IP.ToString());
            }

            ProxiesCB.SelectedIndex = 0;

            SizeTextBox.AutoCompleteCustomSource.Add("Random");
            SizeTextBox.AutoCompleteCustomSource.Add("36.5");
            SizeTextBox.AutoCompleteCustomSource.Add("37.5");
            SizeTextBox.AutoCompleteCustomSource.Add("38");
            SizeTextBox.AutoCompleteCustomSource.Add("38.5");
            SizeTextBox.AutoCompleteCustomSource.Add("39");
            SizeTextBox.AutoCompleteCustomSource.Add("40");
            SizeTextBox.AutoCompleteCustomSource.Add("40.5");
            SizeTextBox.AutoCompleteCustomSource.Add("41");
            SizeTextBox.AutoCompleteCustomSource.Add("42");
            SizeTextBox.AutoCompleteCustomSource.Add("42.5");
            SizeTextBox.AutoCompleteCustomSource.Add("43");
            SizeTextBox.AutoCompleteCustomSource.Add("44");
            SizeTextBox.AutoCompleteCustomSource.Add("44.5");
            SizeTextBox.AutoCompleteCustomSource.Add("45");
            SizeTextBox.AutoCompleteCustomSource.Add("45.5");
            SizeTextBox.AutoCompleteCustomSource.Add("46");
            SizeTextBox.AutoCompleteCustomSource.Add("47");
            SizeTextBox.AutoCompleteCustomSource.Add("47.5");
            SizeTextBox.AutoCompleteCustomSource.Add("48.5");
            SizeTextBox.AutoCompleteCustomSource.Add("49.5");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Remove_Tag(int i)
        {
            tags_name.RemoveAt(i);
            Load_Tags();
        }

        public void Load_Tags()
        {
            TagsPanel.Controls.Clear();

            int[] left_bonds = { 0, 160, 320, 0, 160, 320};
            int[] top_bonds = { 0, 0, 0, 35, 35, 35 };

            Tags.Clear();
            foreach (string name in tags_name)
            {
                int i = tags_name.IndexOf(name);
                Tag tag = new Tag(this, name, name.Contains('+') ? Color.FromArgb(45, 183, 45) : Color.FromArgb(189, 41, 41), i);
                TagsPanel.Controls.Add(tag);
                tag.Left = left_bonds[i];
                tag.Top = top_bonds[i];
                tag.Visible = true;
                Tags.Add(tag);
            }
        }

        private void StoreTxtBox_TextChanged(object sender, EventArgs e)
        {
            SelectedAccount.Items.Clear();
            SelectedAccount.Items.Add("Guest");
            local_accounts.Clear();
            foreach (Account account in Program.accounts)
            {
                if (account.Store == StoreCB.SelectedItem.ToString())
                {
                    SelectedAccount.Items.Add(account.Email);
                    local_accounts.Add(account);
                }
            }
            if (StoreCB.SelectedItem.ToString() == "Nike")
            {
                label4.Text = "Link";
                SelectedAccount.SelectedIndex = 0;
                SelectedAccount.Enabled = true;
                Billings_CB.Enabled = false;
                Billings_CB.SelectedIndex = -1;
            }
            else if (StoreCB.SelectedItem.ToString() == "Supreme")
            {
                label4.Text = "Tags";
                SelectedAccount.SelectedIndex = 0;
                SelectedAccount.Enabled = false;
                Billings_CB.Enabled = true;
            }
            tags_name.Clear();
            Load_Tags();
        }

        private void ProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StoreCB.Text == API.Websites.Nike.ToString() && ProductTxt.Text.Contains("https://www.nike.com") == false)
            {
                Link_Status.Text = "Nike Product Link Need To Contain: https://www.nike.com";
                Link_Status.Visible = true;
            }
            else if (StoreCB.Text == API.Websites.Supreme.ToString())
            {
                if (ProductTxt.Text.Contains(" "))
                {
                    if ((ProductTxt.Text[0] == '+' || ProductTxt.Text[0] == '-') && tags_name.Count < 6)
                    {
                        tags_name.Add(ProductTxt.Text.Replace(" ",""));
                        Load_Tags();
                        ProductTxt.Text = "";
                        Link_Status.Visible = false;
                    }
                    else if (tags_name.Count > 5)
                    {
                        Link_Status.Text = "Can't have more than 6 tags";
                        Link_Status.Visible = true;
                    }
                    else
                    {
                        Link_Status.Text = "Tags Need To Have + Or - At Start Of Tag Name";
                        Link_Status.Visible = true;
                    }
                }
            }
            else
            {
                Link_Status.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Link_Status.Visible)
            {
                MessageBox.Show("Product Link Is Invalid");
            }
            else
            {
                Account selected_Accout = null;
                foreach (Account account in local_accounts)
                {
                    if (account.Email == SelectedAccount.Text && account.Store.ToLower() == StoreCB.Text.ToLower())
                        selected_Accout = account;
                }

                task.Add_New_Task(Task_Name.Text, StoreCB.Text, ProductTxt.Text, SizeTextBox.Text, ConfirmCB.Checked, SelectedAccount.SelectedIndex == 0 ? null : selected_Accout, tags_name, Billings_CB.SelectedIndex == -1 ? new BillingProfile() : Program.BillingProfiles[Billings_CB.SelectedIndex], ProxiesCB.SelectedIndex == 0 ? new Proxy(0, "",0) : Program.proxies[ProxiesCB.SelectedIndex-1]);
                this.Hide();
            }
        }

        private void Add_Task_Load(object sender, EventArgs e)
        {

        }

        private void SelectedAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedAccount.SelectedIndex == 0)
            {
                Billings_CB.Enabled = true;
            }
        }
    }
}
