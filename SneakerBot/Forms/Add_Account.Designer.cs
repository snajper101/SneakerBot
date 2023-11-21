namespace SneakerBot.Forms
{
    partial class Add_Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LocalAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Accounts = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Accounts";
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StoreComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(30, 47);
            this.StoreComboBox.MaxDropDownItems = 10;
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(358, 28);
            this.StoreComboBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 500);
            this.panel2.TabIndex = 4;
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancleBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(232, 452);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(156, 37);
            this.CancleBtn.TabIndex = 5;
            this.CancleBtn.Text = "Cancel";
            this.CancleBtn.UseVisualStyleBackColor = false;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // EmailTXT
            // 
            this.EmailTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.EmailTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmailTXT.ForeColor = System.Drawing.Color.White;
            this.EmailTXT.Location = new System.Drawing.Point(30, 107);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(358, 27);
            this.EmailTXT.TabIndex = 6;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PasswordTxt.ForeColor = System.Drawing.Color.White;
            this.PasswordTxt.Location = new System.Drawing.Point(30, 175);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(358, 27);
            this.PasswordTxt.TabIndex = 7;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // LocalAdd
            // 
            this.LocalAdd.BackColor = System.Drawing.Color.Transparent;
            this.LocalAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LocalAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LocalAdd.ForeColor = System.Drawing.Color.White;
            this.LocalAdd.Location = new System.Drawing.Point(30, 208);
            this.LocalAdd.Name = "LocalAdd";
            this.LocalAdd.Size = new System.Drawing.Size(111, 39);
            this.LocalAdd.TabIndex = 8;
            this.LocalAdd.Text = "Add";
            this.LocalAdd.UseVisualStyleBackColor = false;
            this.LocalAdd.Click += new System.EventHandler(this.LocalAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-MAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "PASSWORD";
            // 
            // Accounts
            // 
            this.Accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Accounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Accounts.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.Accounts.ForeColor = System.Drawing.SystemColors.Window;
            this.Accounts.FormattingEnabled = true;
            this.Accounts.ItemHeight = 19;
            this.Accounts.Location = new System.Drawing.Point(30, 253);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(358, 190);
            this.Accounts.TabIndex = 11;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(30, 452);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(196, 37);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add 0 Accounts";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Accounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalAdd);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.CancleBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StoreComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Account";
            this.Text = "Add_Account";
            this.Load += new System.EventHandler(this.Add_Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StoreComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancleBtn;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LocalAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Accounts;
        private System.Windows.Forms.Button AddBtn;
    }
}