namespace SneakerBot
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Avaible_realeses_box = new System.Windows.Forms.ListBox();
            this.LoadItemsWork = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_Notifications = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.propabilyty_text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResellStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DropBtn = new System.Windows.Forms.Button();
            this.CopBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DetailLbl = new System.Windows.Forms.Label();
            this.waitForm1 = new SneakerBot.WaitForm();
            this.gui3 = new SneakerBot.GUI();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Avaible_realeses_box
            // 
            this.Avaible_realeses_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Avaible_realeses_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Avaible_realeses_box.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Avaible_realeses_box.ForeColor = System.Drawing.SystemColors.Window;
            this.Avaible_realeses_box.FormattingEnabled = true;
            this.Avaible_realeses_box.IntegralHeight = false;
            this.Avaible_realeses_box.ItemHeight = 250;
            this.Avaible_realeses_box.Location = new System.Drawing.Point(73, 163);
            this.Avaible_realeses_box.Name = "Avaible_realeses_box";
            this.Avaible_realeses_box.Size = new System.Drawing.Size(292, 582);
            this.Avaible_realeses_box.TabIndex = 0;
            this.Avaible_realeses_box.Visible = false;
            this.Avaible_realeses_box.SelectedIndexChanged += new System.EventHandler(this.Avaible_realeses_box_SelectedIndexChanged);
            // 
            // LoadItemsWork
            // 
            this.LoadItemsWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadItemsWork_DoWork);
            this.LoadItemsWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadItemsWork_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(86, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "UPCOMING REALESES";
            // 
            // Show_Notifications
            // 
            this.Show_Notifications.Location = new System.Drawing.Point(1015, 749);
            this.Show_Notifications.Name = "Show_Notifications";
            this.Show_Notifications.Size = new System.Drawing.Size(137, 41);
            this.Show_Notifications.TabIndex = 4;
            this.Show_Notifications.Text = "Show Notifications";
            this.Show_Notifications.UseVisualStyleBackColor = true;
            this.Show_Notifications.Click += new System.EventHandler(this.Show_Notifications_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(478, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "REALESE DETALIS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.propabilyty_text);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ResellStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DropBtn);
            this.panel1.Controls.Add(this.CopBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DetailLbl);
            this.panel1.Location = new System.Drawing.Point(462, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 582);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // propabilyty_text
            // 
            this.propabilyty_text.AutoSize = true;
            this.propabilyty_text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propabilyty_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propabilyty_text.Location = new System.Drawing.Point(41, 550);
            this.propabilyty_text.Name = "propabilyty_text";
            this.propabilyty_text.Size = new System.Drawing.Size(118, 20);
            this.propabilyty_text.TabIndex = 14;
            this.propabilyty_text.Text = "Propability: --%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(183, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 92);
            this.panel2.TabIndex = 13;
            // 
            // ResellStatus
            // 
            this.ResellStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResellStatus.ForeColor = System.Drawing.Color.Gray;
            this.ResellStatus.Location = new System.Drawing.Point(21, 506);
            this.ResellStatus.Name = "ResellStatus";
            this.ResellStatus.Size = new System.Drawing.Size(150, 37);
            this.ResellStatus.TabIndex = 12;
            this.ResellStatus.Text = "No Data";
            this.ResellStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(199, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vote For Resell";
            // 
            // DropBtn
            // 
            this.DropBtn.Enabled = false;
            this.DropBtn.FlatAppearance.BorderSize = 0;
            this.DropBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DropBtn.ForeColor = System.Drawing.Color.Gray;
            this.DropBtn.Image = ((System.Drawing.Image)(resources.GetObject("DropBtn.Image")));
            this.DropBtn.Location = new System.Drawing.Point(273, 506);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Size = new System.Drawing.Size(60, 50);
            this.DropBtn.TabIndex = 10;
            this.DropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DropBtn.UseVisualStyleBackColor = true;
            this.DropBtn.Click += new System.EventHandler(this.DropBtn_Click);
            // 
            // CopBtn
            // 
            this.CopBtn.Enabled = false;
            this.CopBtn.FlatAppearance.BorderSize = 0;
            this.CopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopBtn.ForeColor = System.Drawing.Color.Gray;
            this.CopBtn.Image = ((System.Drawing.Image)(resources.GetObject("CopBtn.Image")));
            this.CopBtn.Location = new System.Drawing.Point(194, 506);
            this.CopBtn.Name = "CopBtn";
            this.CopBtn.Size = new System.Drawing.Size(60, 50);
            this.CopBtn.TabIndex = 9;
            this.CopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopBtn.UseVisualStyleBackColor = true;
            this.CopBtn.Click += new System.EventHandler(this.CopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Realese Prediction";
            // 
            // DetailLbl
            // 
            this.DetailLbl.AutoSize = true;
            this.DetailLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DetailLbl.ForeColor = System.Drawing.Color.Gray;
            this.DetailLbl.Location = new System.Drawing.Point(3, 3);
            this.DetailLbl.Name = "DetailLbl";
            this.DetailLbl.Size = new System.Drawing.Size(109, 21);
            this.DetailLbl.TabIndex = 0;
            this.DetailLbl.Text = "Name : Color";
            this.DetailLbl.Visible = false;
            // 
            // waitForm1
            // 
            this.waitForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.waitForm1.Location = new System.Drawing.Point(28, 163);
            this.waitForm1.Name = "waitForm1";
            this.waitForm1.Size = new System.Drawing.Size(386, 193);
            this.waitForm1.TabIndex = 7;
            this.waitForm1.Visible = false;
            // 
            // gui3
            // 
            this.gui3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gui3.Location = new System.Drawing.Point(0, 0);
            this.gui3.Name = "gui3";
            this.gui3.Size = new System.Drawing.Size(1200, 800);
            this.gui3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.waitForm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Notifications);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Avaible_realeses_box);
            this.Controls.Add(this.gui3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker LoadItemsWork;
        private GUI gui1;
        private GUI gui2;
        private System.Windows.Forms.ListBox Avaible_realeses_box;
        private GUI gui3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Show_Notifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private WaitForm waitForm1;
        private System.Windows.Forms.Label DetailLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ResellStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DropBtn;
        private System.Windows.Forms.Button CopBtn;
        private System.Windows.Forms.Label propabilyty_text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

