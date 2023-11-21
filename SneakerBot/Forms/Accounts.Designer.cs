namespace SneakerBot.Forms
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Task = new System.Windows.Forms.Button();
            this.IdListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.EmailListBox = new System.Windows.Forms.ListBox();
            this.PasswordListBox = new System.Windows.Forms.ListBox();
            this.gui1 = new SneakerBot.GUI();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 738);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(177)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.Add_Task);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 45);
            this.panel2.TabIndex = 7;
            // 
            // Add_Task
            // 
            this.Add_Task.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Task.FlatAppearance.BorderSize = 0;
            this.Add_Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Task.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Task.ForeColor = System.Drawing.Color.Gray;
            this.Add_Task.Image = ((System.Drawing.Image)(resources.GetObject("Add_Task.Image")));
            this.Add_Task.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Task.Location = new System.Drawing.Point(0, 0);
            this.Add_Task.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Add_Task.Name = "Add_Task";
            this.Add_Task.Size = new System.Drawing.Size(156, 40);
            this.Add_Task.TabIndex = 5;
            this.Add_Task.Text = "Add Account";
            this.Add_Task.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Task.UseVisualStyleBackColor = false;
            this.Add_Task.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // IdListBox
            // 
            this.IdListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.IdListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.IdListBox.ForeColor = System.Drawing.Color.White;
            this.IdListBox.FormattingEnabled = true;
            this.IdListBox.ItemHeight = 21;
            this.IdListBox.Items.AddRange(new object[] {
            "1"});
            this.IdListBox.Location = new System.Drawing.Point(42, 182);
            this.IdListBox.Name = "IdListBox";
            this.IdListBox.Size = new System.Drawing.Size(94, 525);
            this.IdListBox.TabIndex = 2;
            this.IdListBox.SelectedIndexChanged += new System.EventHandler(this.IdListBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 44);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(787, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "PASSWORD";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(417, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "EMAIL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "#";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(105, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StoreListBox
            // 
            this.StoreListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.StoreListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StoreListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StoreListBox.ForeColor = System.Drawing.Color.White;
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.ItemHeight = 21;
            this.StoreListBox.Items.AddRange(new object[] {
            "----------------------------------------------------------------"});
            this.StoreListBox.Location = new System.Drawing.Point(136, 182);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.Size = new System.Drawing.Size(312, 525);
            this.StoreListBox.TabIndex = 6;
            this.StoreListBox.SelectedIndexChanged += new System.EventHandler(this.StoreListBox_SelectedIndexChanged);
            // 
            // EmailListBox
            // 
            this.EmailListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.EmailListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EmailListBox.ForeColor = System.Drawing.Color.White;
            this.EmailListBox.FormattingEnabled = true;
            this.EmailListBox.ItemHeight = 21;
            this.EmailListBox.Items.AddRange(new object[] {
            "----------------------------------------------------------------"});
            this.EmailListBox.Location = new System.Drawing.Point(448, 182);
            this.EmailListBox.Name = "EmailListBox";
            this.EmailListBox.Size = new System.Drawing.Size(371, 525);
            this.EmailListBox.TabIndex = 7;
            this.EmailListBox.SelectedIndexChanged += new System.EventHandler(this.EmailListBox_SelectedIndexChanged);
            // 
            // PasswordListBox
            // 
            this.PasswordListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PasswordListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordListBox.ForeColor = System.Drawing.Color.White;
            this.PasswordListBox.FormattingEnabled = true;
            this.PasswordListBox.ItemHeight = 21;
            this.PasswordListBox.Items.AddRange(new object[] {
            "----------------------------------------------------------------"});
            this.PasswordListBox.Location = new System.Drawing.Point(818, 182);
            this.PasswordListBox.Name = "PasswordListBox";
            this.PasswordListBox.Size = new System.Drawing.Size(328, 525);
            this.PasswordListBox.TabIndex = 8;
            this.PasswordListBox.SelectedIndexChanged += new System.EventHandler(this.PasswordListBox_SelectedIndexChanged);
            // 
            // gui1
            // 
            this.gui1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gui1.Location = new System.Drawing.Point(0, 0);
            this.gui1.Name = "gui1";
            this.gui1.Size = new System.Drawing.Size(1200, 800);
            this.gui1.TabIndex = 0;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PasswordListBox);
            this.Controls.Add(this.EmailListBox);
            this.Controls.Add(this.StoreListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.IdListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gui1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI gui1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Add_Task;
        private System.Windows.Forms.ListBox IdListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StoreListBox;
        private System.Windows.Forms.ListBox EmailListBox;
        private System.Windows.Forms.ListBox PasswordListBox;
    }
}