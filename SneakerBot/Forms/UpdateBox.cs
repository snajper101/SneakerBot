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
    public partial class UpdateBox : Form
    {
        public UpdateBox(string sever_version)
        {
            InitializeComponent();
            label2.Text = label2.Text.Replace("--", Program.version).Replace("==", sever_version);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
