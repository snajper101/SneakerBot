namespace SneakerBot.UI
{
    partial class Bilings_General
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneTxT = new System.Windows.Forms.TextBox();
            this.Seperate_CB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "PROFILE NAME";
            // 
            // NameTXT
            // 
            this.NameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.NameTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.NameTXT.ForeColor = System.Drawing.Color.White;
            this.NameTXT.Location = new System.Drawing.Point(11, 27);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(358, 27);
            this.NameTXT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "EMAIL ADDRESS";
            // 
            // EmailTXT
            // 
            this.EmailTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.EmailTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmailTXT.ForeColor = System.Drawing.Color.White;
            this.EmailTXT.Location = new System.Drawing.Point(11, 91);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(358, 27);
            this.EmailTXT.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "PHONE NUMBER";
            // 
            // PhoneTxT
            // 
            this.PhoneTxT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PhoneTxT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTxT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PhoneTxT.ForeColor = System.Drawing.Color.White;
            this.PhoneTxT.Location = new System.Drawing.Point(11, 153);
            this.PhoneTxT.Name = "PhoneTxT";
            this.PhoneTxT.Size = new System.Drawing.Size(358, 27);
            this.PhoneTxT.TabIndex = 14;
            this.PhoneTxT.TextChanged += new System.EventHandler(this.PhoneTXT_TextChanged);
            this.PhoneTxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTXT_KeyPress);
            // 
            // Seperate_CB
            // 
            this.Seperate_CB.AutoSize = true;
            this.Seperate_CB.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.Seperate_CB.ForeColor = System.Drawing.Color.White;
            this.Seperate_CB.Location = new System.Drawing.Point(12, 197);
            this.Seperate_CB.Name = "Seperate_CB";
            this.Seperate_CB.Size = new System.Drawing.Size(226, 23);
            this.Seperate_CB.TabIndex = 16;
            this.Seperate_CB.Text = "Separete Billing And Delivery";
            this.Seperate_CB.UseVisualStyleBackColor = true;
            // 
            // Bilings_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.Seperate_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneTxT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTXT);
            this.Name = "Bilings_General";
            this.Size = new System.Drawing.Size(595, 250);
            this.Load += new System.EventHandler(this.Bilings_General_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NameTXT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PhoneTxT;
        public System.Windows.Forms.CheckBox Seperate_CB;
    }
}
