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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();

            gui1.parentForm = this;
            gui1.ProxyBtn.Enabled = false;

            Support_Topics.DrawMode = DrawMode.OwnerDrawVariable;
            Support_Topics.MeasureItem += new MeasureItemEventHandler(Support_Topics_MeasureItem);
            Support_Topics.DrawItem += new DrawItemEventHandler(Support_Topics_DrawItem);

            SupportReplies.DrawMode = DrawMode.OwnerDrawVariable;
            SupportReplies.MeasureItem += new MeasureItemEventHandler(SupportReplies_MeasureItem);
            SupportReplies.DrawItem += new DrawItemEventHandler(SupportReplies_DrawItem);

        }

        private void Support_Load(object sender, EventArgs e)
        {
            foreach (SupportTicket ticket in Program.supportTickets)
            {
                Support_Topics.Items.Add(ticket.Topic);
            }
        }

        public void Update_Support()
        {
            Support_Topics.Items.Clear();
            Program.supportTickets = HandleSupport.SupportTickets();
            foreach (SupportTicket ticket in Program.supportTickets)
            {
                Support_Topics.Items.Add(ticket.Topic);
            }
        }

        #region Support Replies Drawing
        private void SupportReplies_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 85;

            if (e.Index < 0 || DesignMode)
                return;
        }

        private void SupportReplies_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || DesignMode)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(62, 114, 196));

            e.DrawBackground();

            Font username_font = new Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);


            Font perm_font = new Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(47, 158, 70)), new Rectangle(new Point(e.Bounds.Left, e.Bounds.Top), new Size(664, 25)));

            Brush color = new SolidBrush(Program.supportTickets[Support_Topics.SelectedIndex].supportReply[e.Index].profile.Permission == 0 ? Color.FromArgb(62, 154, 112) : Color.FromArgb(195, 65, 66));

            e.Graphics.DrawString(Program.supportTickets[Support_Topics.SelectedIndex].supportReply[e.Index].profile.Username + "    Sent Message At: " + Program.supportTickets[Support_Topics.SelectedIndex].supportReply[e.Index].DateTime.ToString(), username_font, Brushes.White, e.Bounds.Left + 12, e.Bounds.Top);

            e.Graphics.DrawString(Program.supportTickets[Support_Topics.SelectedIndex].supportReply[e.Index].content, e.Font, Brushes.White, e.Bounds.Left + 12, e.Bounds.Top + 30);

            e.Graphics.DrawString("By " + (Program.supportTickets[Support_Topics.SelectedIndex].supportReply[e.Index].profile.Permission == 0 ? "Normal User" : "Admin") , perm_font, color, e.Bounds.Left + 12, e.Bounds.Top + 65);

            e.Graphics.FillRectangle(Brushes.GreenYellow, new Rectangle(new Point(e.Bounds.Left, e.Bounds.Top + 82), new Size(664, 3)));

        }
        #endregion

        #region Support Topics Drawing
        private void Support_Topics_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 58;

            if (e.Index < 0 || DesignMode)
                return;
        }

        private void Support_Topics_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || DesignMode)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(62, 114, 196));

            e.DrawBackground();

            e.Graphics.DrawString(Support_Topics.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds.Left + 12, e.Bounds.Top + 6);

            Font status_font = new Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular);

            e.Graphics.DrawString("Status:", status_font, Brushes.White, e.Bounds.Left + 12, e.Bounds.Top + 30);

            if (Program.supportTickets.Count > e.Index)
            {
                if (Program.supportTickets[e.Index].Status == 0)
                {
                    e.Graphics.DrawString("Wait for an answer", status_font, Brushes.Red, e.Bounds.Left + 75, e.Bounds.Top + 30);

                }
                else if (Program.supportTickets[e.Index].Status == 1)
                {
                    e.Graphics.DrawString("Closed", status_font, Brushes.Green, e.Bounds.Left + 75, e.Bounds.Top + 30);
                }
            }
            else
            {
                e.Graphics.DrawString("Invalid Status", status_font, Brushes.Red, e.Bounds.Left + 75, e.Bounds.Top + 30);
            }

        }
        #endregion

        private void Support_Topics_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupportReplies.Items.Clear();

            foreach (SupportReply supportReply in Program.supportTickets[Support_Topics.SelectedIndex].supportReply)
            {
                SupportReplies.Items.Add(supportReply.content);
            }
            
            if (Program.supportTickets[Support_Topics.SelectedIndex].Status == 0)
            {
                AddMessagePanel.Enabled = true;
            }
            else if (Program.supportTickets[Support_Topics.SelectedIndex].Status == 1)
            {
                AddMessagePanel.Enabled = false;
            }
        }

        private void CreateTicketBtn_Click(object sender, EventArgs e)
        {
            CreateTicket create = new CreateTicket(this);
            create.Show();
        }

        private void AddMessage_btn_Click(object sender, EventArgs e)
        {
            HandleSupport.Reply(Program.supportTickets[Support_Topics.SelectedIndex].TicketID, MessageTxt.Text.Replace("'" , ""));
            MessageTxt.Text = "";
            Update_Support();
        }
    }
}
