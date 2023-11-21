namespace SneakerBot.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RenewLicence = new System.Windows.Forms.Button();
            this.LicenceExpireLbl = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.AccountTypeLbl = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.gui1 = new SneakerBot.GUI();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.admin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.RenewLicence);
            this.panel1.Controls.Add(this.LicenceExpireLbl);
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.AccountTypeLbl);
            this.panel1.Controls.Add(this.WelcomeLbl);
            this.panel1.Location = new System.Drawing.Point(38, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 90);
            this.panel1.TabIndex = 1;
            // 
            // RenewLicence
            // 
            this.RenewLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.RenewLicence.FlatAppearance.BorderSize = 0;
            this.RenewLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenewLicence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RenewLicence.ForeColor = System.Drawing.Color.White;
            this.RenewLicence.Image = ((System.Drawing.Image)(resources.GetObject("RenewLicence.Image")));
            this.RenewLicence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenewLicence.Location = new System.Drawing.Point(793, 26);
            this.RenewLicence.Name = "RenewLicence";
            this.RenewLicence.Size = new System.Drawing.Size(110, 40);
            this.RenewLicence.TabIndex = 11;
            this.RenewLicence.Text = "Renew";
            this.RenewLicence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RenewLicence.UseVisualStyleBackColor = false;
            // 
            // LicenceExpireLbl
            // 
            this.LicenceExpireLbl.AutoSize = true;
            this.LicenceExpireLbl.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.LicenceExpireLbl.ForeColor = System.Drawing.Color.White;
            this.LicenceExpireLbl.Location = new System.Drawing.Point(10, 57);
            this.LicenceExpireLbl.Name = "LicenceExpireLbl";
            this.LicenceExpireLbl.Size = new System.Drawing.Size(129, 15);
            this.LicenceExpireLbl.TabIndex = 10;
            this.LicenceExpireLbl.Text = "Licence Expire In: ---";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(947, 26);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(126, 40);
            this.LogOutBtn.TabIndex = 9;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // AccountTypeLbl
            // 
            this.AccountTypeLbl.AutoSize = true;
            this.AccountTypeLbl.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.AccountTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.AccountTypeLbl.Location = new System.Drawing.Point(10, 33);
            this.AccountTypeLbl.Name = "AccountTypeLbl";
            this.AccountTypeLbl.Size = new System.Drawing.Size(73, 15);
            this.AccountTypeLbl.TabIndex = 1;
            this.AccountTypeLbl.Text = "You Are ---";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WelcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLbl.Location = new System.Drawing.Point(8, 3);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(148, 30);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome: ---";
            // 
            // gui1
            // 
            this.gui1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gui1.Location = new System.Drawing.Point(0, 0);
            this.gui1.Name = "gui1";
            this.gui1.Size = new System.Drawing.Size(1200, 800);
            this.gui1.TabIndex = 0;
            this.gui1.Load += new System.EventHandler(this.gui1_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.admin_panel);
            this.panel2.Location = new System.Drawing.Point(38, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 496);
            this.panel2.TabIndex = 2;
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.label1);
            this.admin_panel.Controls.Add(this.GenerateBtn);
            this.admin_panel.Controls.Add(this.numericUpDown1);
            this.admin_panel.Location = new System.Drawing.Point(0, 311);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(1119, 183);
            this.admin_panel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(35, 60);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Generate Licence";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gui1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.admin_panel.ResumeLayout(false);
            this.admin_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI gui1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label AccountTypeLbl;
        public System.Windows.Forms.Button LogOutBtn;
        public System.Windows.Forms.Button RenewLicence;
        private System.Windows.Forms.Label LicenceExpireLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}