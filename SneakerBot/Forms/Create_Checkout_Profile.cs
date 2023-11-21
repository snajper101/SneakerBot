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
    public partial class Create_Checkout_Profile : Form
    {
        public Create_Checkout_Profile()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ProfileName.Text == "" || ProfileName.Text.Length >= 5)
            {
                Errorlbl.Text = "Nickname is too short";
                Errorlbl.Visible = true;
                API.Wait(3000);
                Errorlbl.Visible = false;
            }
            else
            {
                this.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.png) | *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                Avatar.Image = File;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
