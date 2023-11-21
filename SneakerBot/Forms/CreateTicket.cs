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
    public partial class CreateTicket : Form
    {
        Support support;
        public CreateTicket(Support support)
        {
            InitializeComponent();
            this.support = support;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TopicTxt.Text == "")
            {
                ErrorTxt.Text = "Topic cannot be empty";
                ErrorTxt.Visible = true;
                API.Wait(3000);
                ErrorTxt.Visible = false;
            }
            else if (MessageTxt.Text == "")
            {
                ErrorTxt.Text = "Message cannot be empty";
                ErrorTxt.Visible = true;
                API.Wait(3000);
                ErrorTxt.Visible = false;
            }
            else
            {
                HandleSupport.Create_Ticket(TopicTxt.Text, MessageTxt.Text);
                support.Update_Support();
                this.Hide();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
