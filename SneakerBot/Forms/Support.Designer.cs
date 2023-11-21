namespace SneakerBot.Forms
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            this.Support_Topics = new System.Windows.Forms.ListBox();
            this.CreateTicketBtn = new System.Windows.Forms.Button();
            this.SupportReplies = new System.Windows.Forms.ListBox();
            this.MessageTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMessage_btn = new System.Windows.Forms.Button();
            this.AddMessagePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gui1 = new SneakerBot.GUI();
            this.AddMessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Support_Topics
            // 
            this.Support_Topics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Support_Topics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Support_Topics.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.Support_Topics.ForeColor = System.Drawing.SystemColors.Window;
            this.Support_Topics.FormattingEnabled = true;
            this.Support_Topics.IntegralHeight = false;
            this.Support_Topics.ItemHeight = 250;
            this.Support_Topics.Location = new System.Drawing.Point(33, 140);
            this.Support_Topics.Margin = new System.Windows.Forms.Padding(0);
            this.Support_Topics.Name = "Support_Topics";
            this.Support_Topics.Size = new System.Drawing.Size(396, 546);
            this.Support_Topics.TabIndex = 1;
            this.Support_Topics.SelectedIndexChanged += new System.EventHandler(this.Support_Topics_SelectedIndexChanged);
            // 
            // CreateTicketBtn
            // 
            this.CreateTicketBtn.FlatAppearance.BorderSize = 0;
            this.CreateTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTicketBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateTicketBtn.ForeColor = System.Drawing.Color.Gray;
            this.CreateTicketBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateTicketBtn.Image")));
            this.CreateTicketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTicketBtn.Location = new System.Drawing.Point(140, 723);
            this.CreateTicketBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.CreateTicketBtn.Name = "CreateTicketBtn";
            this.CreateTicketBtn.Size = new System.Drawing.Size(151, 50);
            this.CreateTicketBtn.TabIndex = 5;
            this.CreateTicketBtn.Text = "Create Ticket";
            this.CreateTicketBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateTicketBtn.UseVisualStyleBackColor = true;
            this.CreateTicketBtn.Click += new System.EventHandler(this.CreateTicketBtn_Click);
            // 
            // SupportReplies
            // 
            this.SupportReplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.SupportReplies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SupportReplies.Font = new System.Drawing.Font("Arial", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SupportReplies.ForeColor = System.Drawing.SystemColors.Window;
            this.SupportReplies.FormattingEnabled = true;
            this.SupportReplies.IntegralHeight = false;
            this.SupportReplies.ItemHeight = 250;
            this.SupportReplies.Location = new System.Drawing.Point(499, 140);
            this.SupportReplies.Margin = new System.Windows.Forms.Padding(0);
            this.SupportReplies.Name = "SupportReplies";
            this.SupportReplies.Size = new System.Drawing.Size(664, 546);
            this.SupportReplies.TabIndex = 6;
            // 
            // MessageTxt
            // 
            this.MessageTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MessageTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageTxt.ForeColor = System.Drawing.Color.White;
            this.MessageTxt.Location = new System.Drawing.Point(14, 25);
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(597, 54);
            this.MessageTxt.TabIndex = 7;
            this.MessageTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 736);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // AddMessage_btn
            // 
            this.AddMessage_btn.FlatAppearance.BorderSize = 0;
            this.AddMessage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMessage_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddMessage_btn.ForeColor = System.Drawing.Color.Gray;
            this.AddMessage_btn.Image = ((System.Drawing.Image)(resources.GetObject("AddMessage_btn.Image")));
            this.AddMessage_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMessage_btn.Location = new System.Drawing.Point(619, 25);
            this.AddMessage_btn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.AddMessage_btn.Name = "AddMessage_btn";
            this.AddMessage_btn.Size = new System.Drawing.Size(41, 50);
            this.AddMessage_btn.TabIndex = 9;
            this.AddMessage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddMessage_btn.UseVisualStyleBackColor = true;
            this.AddMessage_btn.Click += new System.EventHandler(this.AddMessage_btn_Click);
            // 
            // AddMessagePanel
            // 
            this.AddMessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.AddMessagePanel.Controls.Add(this.label2);
            this.AddMessagePanel.Controls.Add(this.AddMessage_btn);
            this.AddMessagePanel.Controls.Add(this.MessageTxt);
            this.AddMessagePanel.Enabled = false;
            this.AddMessagePanel.Location = new System.Drawing.Point(499, 698);
            this.AddMessagePanel.Name = "AddMessagePanel";
            this.AddMessagePanel.Size = new System.Drawing.Size(664, 90);
            this.AddMessagePanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type a message...";
            // 
            // gui1
            // 
            this.gui1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gui1.Location = new System.Drawing.Point(0, 0);
            this.gui1.Name = "gui1";
            this.gui1.Size = new System.Drawing.Size(1200, 800);
            this.gui1.TabIndex = 0;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.AddMessagePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupportReplies);
            this.Controls.Add(this.CreateTicketBtn);
            this.Controls.Add(this.Support_Topics);
            this.Controls.Add(this.gui1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Support";
            this.Text = "Support";
            this.Load += new System.EventHandler(this.Support_Load);
            this.AddMessagePanel.ResumeLayout(false);
            this.AddMessagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI gui1;
        private System.Windows.Forms.ListBox Support_Topics;
        private System.Windows.Forms.Button CreateTicketBtn;
        private System.Windows.Forms.ListBox SupportReplies;
        private System.Windows.Forms.RichTextBox MessageTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMessage_btn;
        private System.Windows.Forms.Panel AddMessagePanel;
        private System.Windows.Forms.Label label2;
    }
}