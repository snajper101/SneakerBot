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
    public partial class Proxy_List : Form
    {
        List<Button> select_btn = new List<Button>();
        List<Label> id_label = new List<Label>();
        List<Label> ip_label = new List<Label>();
        List<Label> port_Label = new List<Label>();
        List<Button> delete_btn = new List<Button>();
        public Proxy_List()
        {
            InitializeComponent();
            gui1.parentForm = this;
            gui1.button4.Enabled = false;
            Reaload_UI();
        }

        private void Reaload_UI()
        {
            select_btn.Clear();
            id_label.Clear();
            delete_btn.Clear();
            ProxyPanel.Controls.Clear();

            int i = 0;
            foreach(Proxy proxy in Program.proxies)
            {
                if (i == 18)
                {
                    ProxyPanel.AutoScroll = true;
                }
                Button button = new Button();
                this.ProxyPanel.Controls.Add(button);
                button.Text = "";
                button.Top = i * 30;
                button.BackColor = Color.FromArgb(54, 57, 63);
                button.Size = new System.Drawing.Size(1129, 30);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.Click += Select_Proxy;
                select_btn.Add(button);

                Label label = new Label();
                this.ProxyPanel.Controls.Add(label);
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.AutoSize = true;
                label.Left = 15;
                label.CausesValidation = false;
                label.BackColor = Color.Transparent;
                label.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                label.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label.Top = i * 30;
                label.Text = i.ToString();
                label.BringToFront();

                id_label.Add(label);

                Label label1 = new Label();
                this.ProxyPanel.Controls.Add(label1);
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.AutoSize = true;
                label1.Left = 73;
                label1.CausesValidation = false;
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Top = i * 30;
                label1.Text = Program.proxies[i].IP;
                label1.BringToFront();

                ip_label.Add(label1);

                Label label2 = new Label();
                this.ProxyPanel.Controls.Add(label2);
                label2.TextAlign = ContentAlignment.MiddleLeft;
                label2.AutoSize = true;
                label2.Left = 401;
                label2.BackColor = Color.Transparent;
                label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                label2.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label2.Top = i * 30;
                label2.Text = Program.proxies[i].Port.ToString();
                label2.BringToFront();
                port_Label.Add(label2);

                Button button1 = new Button();
                this.ProxyPanel.Controls.Add(button1);
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.Image = SneakerBot.Properties.Resources.delete_20px;
                button1.Top = i * 30;
                button1.Left = 1080;
                button1.BackColor = Color.FromArgb(54, 57, 63);
                button1.ImageAlign = ContentAlignment.MiddleCenter;
                button1.Size = new System.Drawing.Size(30, 30);
                button1.Click += Delete_Btn_Click;
                button1.BringToFront();
                delete_btn.Add(button1);

                i++;
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            int i = delete_btn.IndexOf((Button)sender);

            Program.proxies.RemoveAt(i);

            Reaload_UI();
        }

        private void Select_Proxy(object sender, EventArgs e)
        {
            for (int local = 0; local < Program.proxies.Count; local++)
            {
                select_btn[local].BackColor = Color.FromArgb(54, 57, 63);
                select_btn[local].FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 57, 63);
                select_btn[local].FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 57, 63);

                delete_btn[local].BackColor = Color.FromArgb(54, 57, 63);
                id_label[local].BackColor = Color.FromArgb(54, 57, 63);
                ip_label[local].BackColor = Color.FromArgb(54, 57, 63);
                port_Label[local].BackColor = Color.FromArgb(54, 57, 63);         
            }

            int i = select_btn.IndexOf((Button)sender);

            select_btn[i].BackColor = Color.FromArgb(32, 34, 37);
            select_btn[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 34, 37);
            select_btn[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 34, 37);

            delete_btn[i].BackColor = Color.FromArgb(32, 34, 37);
            id_label[i].BackColor = Color.FromArgb(32, 34, 37);
            ip_label[i].BackColor = Color.FromArgb(32, 34, 37);
            port_Label[i].BackColor = Color.FromArgb(32, 34, 37);
        }

        public void AddProxy(Proxy proxy)
        {
            Program.proxies.Add(proxy);

            HandleProxy.InsertTask(proxy);

            Reaload_UI();
        }

        private void Add_Proxy_Click(object sender, EventArgs e)
        {
            Add_Proxy add_Proxy = new Add_Proxy(this);
            add_Proxy.Show();
        }
    }
}
