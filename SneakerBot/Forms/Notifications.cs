using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SneakerBot.AuthLib;

namespace SneakerBot
{
    public partial class Notifications : Form
    {
        #region Variables
        List<Notification> notifications = HandleNotifications.QueryNotifications();

        private bool mouseDown;
        private Point lastLocation;
        #endregion
        public Notifications()
        {
            InitializeComponent();

            //Notification list drawing options
            NotificationsList.DrawMode = DrawMode.OwnerDrawVariable;
            NotificationsList.MeasureItem += new MeasureItemEventHandler(NotificationsList_MeasureItem);
            NotificationsList.DrawItem += new DrawItemEventHandler(NotificationsList_DrawItem);

            //Add notifications to list
            foreach (var i in HandleNotifications.QueryNotifications())
            {
                bool respone = HandleNotifications.ReadNotification(Program.profile.Username, i.ID);
                //Check if show all notifications
                if (ShowReaded.Checked)
                {
                    i.Read = respone;
                    NotificationsList.Items.Add(i.Title);
                }
                else
                {
                    if (respone == false)
                        NotificationsList.Items.Add(i.Title);
                }
            }

            //Select first notification as default
            if (NotificationsList.Items.Count > 0)
                NotificationsList.SelectedIndex = 0;
        }

        #region UI_Functions
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region CustomDrawing
        private void NotificationsList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.ItemHeight = (int)e.Graphics.MeasureString(NotificationsList.Items[e.Index].ToString(), NotificationsList.Font, NotificationsList.Width).Height > 50 ? (int)e.Graphics.MeasureString(NotificationsList.Items[e.Index].ToString(), NotificationsList.Font, NotificationsList.Width).Height + 5 : 50;
        }

        private void NotificationsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(35, 168, 109));

            //Draw Background
            e.DrawBackground();

            //Draw The content
            e.Graphics.DrawString((NotificationsList.Items[e.Index]).ToString(), e.Font, Brushes.White, e.Bounds.Left + 2, e.Bounds.Top + e.Bounds.Height / 2 - 25, StringFormat.GenericDefault);

            //Draw notification reader status
            e.Graphics.DrawString("Read: " + (notifications[e.Index].Read ? "Yes" : "No"), new Font(e.Font.FontFamily, 8, FontStyle.Bold), Brushes.White, e.Bounds.Left + 3, e.Bounds.Top + e.Bounds.Height / 2 - 5, StringFormat.GenericDefault);

            //Draw created time label
            e.Graphics.DrawString("Created: " + RelativeTime(Convert.ToDateTime(notifications[e.Index].CreationDate)), new Font(e.Font.FontFamily, 8, FontStyle.Bold), Brushes.White, e.Bounds.Left + 3, e.Bounds.Top + e.Bounds.Height / 2 + 5, StringFormat.GenericDefault);


            e.DrawFocusRectangle();
        }
        #endregion

        #region Notification List Functions
        private void NotificationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Notification_Message.Text = "";

            Notification_Message.Text = notifications[NotificationsList.SelectedIndex].Message;
        }

        private void ShowReaded_CheckedChanged(object sender, EventArgs e)
        {
            int selected_index = NotificationsList.SelectedIndex;
            Notification_Message.Text = "";
            NotificationsList.Items.Clear();

            foreach (var i in HandleNotifications.QueryNotifications())
            {
                bool respone = HandleNotifications.ReadNotification(Program.profile.Username, i.ID);
                //Check if show all notifications
                if (ShowReaded.Checked)
                {
                    i.Read = respone;
                    NotificationsList.Items.Add(i.Title);
                }
                else
                {
                    if (respone == false)
                        NotificationsList.Items.Add(i.Title);
                }
            }
            if (NotificationsList.Items.Count > 0)
            {
                NotificationsList.SelectedIndex = 0;
            }
        }
        private void NotificationsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HandleNotifications.UpdateNotificationStatus(Program.profile.Username, notifications[NotificationsList.SelectedIndex].ID);

            bool Respone = HandleNotifications.ReadNotification(Program.profile.Username, notifications[NotificationsList.SelectedIndex].ID);

            if (Respone == false)
            {
                notifications[NotificationsList.SelectedIndex].Read = false;
                NotificationsList.Update();
            }
            else if (Respone == true)
            {
                notifications[NotificationsList.SelectedIndex].Read = true;
                NotificationsList.Update();
            }
        }
        #endregion

        #region Other Functions

        public string RelativeTime(DateTime date)
        {
            TimeSpan ts = DateTime.Now - date;
            if (ts.TotalMinutes < 1)//seconds ago
                return "just now";
            if (ts.TotalHours < 1)//min ago
                return (int)ts.TotalMinutes == 1 ? "1 Minute ago" : (int)ts.TotalMinutes + " Minutes ago";
            if (ts.TotalDays < 1)//hours ago
                return (int)ts.TotalHours == 1 ? "1 Hour ago" : (int)ts.TotalHours + " Hours ago";
            if (ts.TotalDays < 7)//days ago
                return (int)ts.TotalDays == 1 ? "1 Day ago" : (int)ts.TotalDays + " Days ago";
            if (ts.TotalDays < 30.4368)//weeks ago
                return (int)(ts.TotalDays / 7) == 1 ? "1 Week ago" : (int)(ts.TotalDays / 7) + " Weeks ago";
            if (ts.TotalDays < 365.242)//months ago
                return (int)(ts.TotalDays / 30.4368) == 1 ? "1 Month ago" : (int)(ts.TotalDays / 30.4368) + " Months ago";
            //years ago
            return (int)(ts.TotalDays / 365.242) == 1 ? "1 Year ago" : (int)(ts.TotalDays / 365.242) + " Years ago";
        }

        #endregion

    }
}
