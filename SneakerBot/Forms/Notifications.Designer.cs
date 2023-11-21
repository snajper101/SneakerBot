namespace SneakerBot
{
    partial class Notifications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NotificationsList = new System.Windows.Forms.ListBox();
            this.Notification_Message = new System.Windows.Forms.RichTextBox();
            this.ShowReaded = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 64);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(548, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 40);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sneaker Bot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double Click To Mark As Read";
            // 
            // NotificationsList
            // 
            this.NotificationsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.NotificationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NotificationsList.ForeColor = System.Drawing.Color.White;
            this.NotificationsList.FormattingEnabled = true;
            this.NotificationsList.ItemHeight = 21;
            this.NotificationsList.Location = new System.Drawing.Point(5, 70);
            this.NotificationsList.Name = "NotificationsList";
            this.NotificationsList.Size = new System.Drawing.Size(251, 315);
            this.NotificationsList.TabIndex = 3;
            this.NotificationsList.SelectedIndexChanged += new System.EventHandler(this.NotificationsList_SelectedIndexChanged);
            this.NotificationsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationsList_MouseDoubleClick);
            // 
            // Notification_Message
            // 
            this.Notification_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Notification_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notification_Message.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Notification_Message.ForeColor = System.Drawing.Color.White;
            this.Notification_Message.Location = new System.Drawing.Point(275, 70);
            this.Notification_Message.Name = "Notification_Message";
            this.Notification_Message.ReadOnly = true;
            this.Notification_Message.Size = new System.Drawing.Size(317, 315);
            this.Notification_Message.TabIndex = 24;
            this.Notification_Message.Text = "";
            // 
            // ShowReaded
            // 
            this.ShowReaded.AutoSize = true;
            this.ShowReaded.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ShowReaded.ForeColor = System.Drawing.Color.White;
            this.ShowReaded.Location = new System.Drawing.Point(474, 388);
            this.ShowReaded.Name = "ShowReaded";
            this.ShowReaded.Size = new System.Drawing.Size(118, 21);
            this.ShowReaded.TabIndex = 25;
            this.ShowReaded.Text = "Show Readed";
            this.ShowReaded.UseVisualStyleBackColor = true;
            this.ShowReaded.CheckedChanged += new System.EventHandler(this.ShowReaded_CheckedChanged);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.ShowReaded);
            this.Controls.Add(this.Notification_Message);
            this.Controls.Add(this.NotificationsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox NotificationsList;
        private System.Windows.Forms.RichTextBox Notification_Message;
        private System.Windows.Forms.CheckBox ShowReaded;
    }
}