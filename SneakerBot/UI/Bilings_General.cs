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

namespace SneakerBot.UI
{
    public partial class Bilings_General : UserControl
    {
        public Add_Billings add_Billings;
        public Bilings_General()
        {
            InitializeComponent();
        }

        private void PhoneTXT_TextChanged(object sender, EventArgs e)
        {

            string x = PhoneTxT.Text;
            if (x.Length == 9)
            {
                double y = Double.Parse(x);
                PhoneTxT.Text = String.Format("{0:###-###-###}", y);
            }
        }

        private void PhoneTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Bilings_General_Load(object sender, EventArgs e)
        {
            /*if (add_Billings != null)
            {
                Seperate_CB.CheckedChanged += add_Billings.Seperate_CB_CheckedChanged;
            }
            Seperate_CB.CheckedChanged += add_Billings.Seperate_CB_CheckedChanged;*/
        }
    }
}
