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
    public partial class Add_Proxy : Form
    {
        Proxy_List proxy_List;
        public Add_Proxy(Proxy_List proxy_List)
        {
            InitializeComponent();
            this.proxy_List = proxy_List;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IpTXT.Text != "" && PortTxt.Text != "")
            {
                proxy_List.AddProxy(new Proxy(HandleProxy.Get_Max_Id() + 1, IpTXT.Text, Convert.ToInt32(PortTxt.Text)));
                this.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
