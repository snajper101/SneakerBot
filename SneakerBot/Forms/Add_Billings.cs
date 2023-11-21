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
    public partial class Add_Billings : Form
    {
        public Billings Billings;
        public Add_Billings(Billings Billings)
        {
            InitializeComponent();
            this.Billings = Billings;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bilings_General1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bilings_Delivery1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            billings_Payment1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            billings_Billing1.BringToFront();
        }

        public void Seperate_CB_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible = bilings_General1.Seperate_CB.Checked;
        }

        private void Add_Billings_Load(object sender, EventArgs e)
        {
            bilings_General1.add_Billings = this;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (bilings_General1.Seperate_CB.Checked == true)
            {
                Billings.Add_Profile(new BillingProfile(bilings_General1.NameTXT.Text, bilings_General1.EmailTXT.Text, bilings_General1.PhoneTxT.Text, billings_Payment1.CardHolderTxt.Text, billings_Payment1.CardNumberTxt.Text, billings_Payment1.Expiry_Month_CB.SelectedItem.ToString(), Convert.ToInt32(billings_Payment1.Expir_Year_CB.SelectedItem), billings_Payment1.CVV_Value.Value.ToString(), bilings_Delivery1.First_Name_Txt.Text, bilings_Delivery1.Last_Name_Txt.Text, bilings_Delivery1.AddressTxt.Text, bilings_Delivery1.CityTxt.Text, bilings_Delivery1.ZipCodeTxt.Text, bilings_Delivery1.CountryTxt.Text, billings_Billing1.First_Name_Txt.Text, billings_Billing1.Last_Name_Txt.Text, billings_Billing1.AddressTxt.Text, billings_Billing1.CityTxt.Text, billings_Billing1.ZipCodeTxt.Text, billings_Billing1.CountryTxt.Text));
            }
            else
            {
                Billings.Add_Profile(new BillingProfile(bilings_General1.NameTXT.Text, bilings_General1.EmailTXT.Text, bilings_General1.PhoneTxT.Text, billings_Payment1.CardHolderTxt.Text, billings_Payment1.CardNumberTxt.Text, billings_Payment1.Expiry_Month_CB.SelectedItem.ToString(), Convert.ToInt32(billings_Payment1.Expir_Year_CB.SelectedItem), billings_Payment1.CVV_Value.Value.ToString(), bilings_Delivery1.First_Name_Txt.Text, bilings_Delivery1.Last_Name_Txt.Text, bilings_Delivery1.AddressTxt.Text, bilings_Delivery1.CityTxt.Text, bilings_Delivery1.ZipCodeTxt.Text, bilings_Delivery1.CountryTxt.Text, bilings_Delivery1.First_Name_Txt.Text, bilings_Delivery1.Last_Name_Txt.Text, bilings_Delivery1.AddressTxt.Text, bilings_Delivery1.CityTxt.Text, bilings_Delivery1.ZipCodeTxt.Text, bilings_Delivery1.CountryTxt.Text));
            }
            this.Hide();
        }
    }
}
