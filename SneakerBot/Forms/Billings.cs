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

namespace SneakerBot.Forms
{
    public partial class Billings : Form
    {

        public Billings()
        {
            InitializeComponent();

            gui1.parentForm = this;
            gui1.BillingBtn.Enabled = false;

            BillingsListBox.MeasureItem += new MeasureItemEventHandler(BillingsListBox_MeasureItem);
            BillingsListBox.DrawItem += new DrawItemEventHandler(BillingsListBox_DrawItem);

            BillingsListBox.HorizontalScrollbar = false;
        }

        private void BillingsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || DesignMode)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(40, 43, 48));

            e.DrawBackground();

            e.Graphics.DrawString(BillingsListBox.Items[e.Index].ToString(), e.Font, Brushes.White,e.Bounds.Left + 12 , e.Bounds.Top + 3, StringFormat.GenericDefault);

            e.Graphics.DrawString(Program.BillingProfiles[e.Index].Name, e.Font, Brushes.White, e.Bounds.Left + 70, e.Bounds.Top + 3, StringFormat.GenericDefault);

            e.Graphics.DrawString(Program.BillingProfiles[e.Index].Email, e.Font, Brushes.White, e.Bounds.Left + 170, e.Bounds.Top + 3, StringFormat.GenericDefault);

            e.Graphics.DrawString(Program.BillingProfiles[e.Index].CardHolder, e.Font, Brushes.White, e.Bounds.Left + 466, e.Bounds.Top + 3, StringFormat.GenericDefault);

            e.Graphics.DrawString("Ending with " + API.GetLast(Program.BillingProfiles[e.Index].CardNumber, 4), e.Font, Brushes.White, e.Bounds.Left + 748, e.Bounds.Top + 3, StringFormat.GenericDefault);
        }

        private void BillingsListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;

            if (e.Index < 0 || DesignMode)
                return;
        }

        private void BillingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveBtn.Text = "Remove " + Program.BillingProfiles[BillingsListBox.SelectedIndex].Name;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Program.BillingProfiles.RemoveAt(BillingsListBox.SelectedIndex);
            BillingsListBox.Items.RemoveAt(BillingsListBox.SelectedIndex);
        }

        public void Add_Profile(BillingProfile billing_profile)
        {
            List<string> temp = new List<string>();
            Program.BillingProfiles.Add(billing_profile);
            BillingsListBox.Items.Clear();
            int i = 0;
            foreach(BillingProfile billing in Program.BillingProfiles)
            {
                temp.Add(API.Encrypt(billing_profile.Name+","+ billing_profile.Email + "," + billing_profile.PhoneNumber + "," + billing_profile.CardHolder + "," + API.Encrypt(billing_profile.CardNumber, Program.Token) + "," + API.Encrypt(billing_profile.CVV, Program.Token) + "," + billing_profile.Expiry_Month  + "," + billing_profile.Expiry_Year + "," + billing_profile.Delivery_Addres + "," + billing_profile.Delivery_City + "," + billing_profile.Delivery_Country +"," + billing_profile.Delivery_First_Name + "," + billing_profile.Delivery_Last_Name + "," + billing_profile.Delivery_Zip_Code + "," + billing_profile.Billings_Addres + "," + billing_profile.Billings_City + "," + billing_profile.Billings_Country + "," + billing_profile.Billings_First_Name + "," + billing_profile.Billings_Last_Name + "," + billing_profile.Billings_Zip_Code, Program.Token));
                BillingsListBox.Items.Add(i.ToString());
                i++;
            }
            Directory.CreateDirectory(Application.StartupPath + "//Data");
            File.WriteAllLines(Application.StartupPath + "//Data//" + Program.profile.Username + "_data.data", temp);
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            Add_Billings add_Billings = new Add_Billings(this);
            add_Billings.Show();
        }

        private void Billings_Load(object sender, EventArgs e)
        {

                int i = 0;
                foreach (BillingProfile profile in Program.BillingProfiles)
                {
                    BillingsListBox.Items.Add(i.ToString());
                    i++;
                }
        }
    }
}
