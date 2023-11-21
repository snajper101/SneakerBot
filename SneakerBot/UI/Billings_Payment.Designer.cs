namespace SneakerBot.UI
{
    partial class Billings_Payment
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
            this.CardNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Expiry_Month_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Expir_Year_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CVV_Value = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CardHolderTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CVV_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "CARD NUMBER";
            // 
            // CardNumberTxt
            // 
            this.CardNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CardNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNumberTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CardNumberTxt.ForeColor = System.Drawing.Color.White;
            this.CardNumberTxt.Location = new System.Drawing.Point(11, 31);
            this.CardNumberTxt.Name = "CardNumberTxt";
            this.CardNumberTxt.Size = new System.Drawing.Size(358, 27);
            this.CardNumberTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "EXPIRY";
            // 
            // Expiry_Month_CB
            // 
            this.Expiry_Month_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Expiry_Month_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Expiry_Month_CB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Expiry_Month_CB.FormattingEnabled = true;
            this.Expiry_Month_CB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.Expiry_Month_CB.Location = new System.Drawing.Point(66, 85);
            this.Expiry_Month_CB.Name = "Expiry_Month_CB";
            this.Expiry_Month_CB.Size = new System.Drawing.Size(106, 28);
            this.Expiry_Month_CB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Month";
            // 
            // Expir_Year_CB
            // 
            this.Expir_Year_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Expir_Year_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Expir_Year_CB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Expir_Year_CB.FormattingEnabled = true;
            this.Expir_Year_CB.Location = new System.Drawing.Point(223, 85);
            this.Expir_Year_CB.Name = "Expir_Year_CB";
            this.Expir_Year_CB.Size = new System.Drawing.Size(146, 28);
            this.Expir_Year_CB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(178, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "CVV";
            // 
            // CVV_Value
            // 
            this.CVV_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CVV_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CVV_Value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CVV_Value.Location = new System.Drawing.Point(11, 147);
            this.CVV_Value.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CVV_Value.Name = "CVV_Value";
            this.CVV_Value.Size = new System.Drawing.Size(129, 26);
            this.CVV_Value.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "CARD HOLDER";
            // 
            // CardHolderTxt
            // 
            this.CardHolderTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CardHolderTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardHolderTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CardHolderTxt.ForeColor = System.Drawing.Color.White;
            this.CardHolderTxt.Location = new System.Drawing.Point(11, 199);
            this.CardHolderTxt.Name = "CardHolderTxt";
            this.CardHolderTxt.Size = new System.Drawing.Size(358, 27);
            this.CardHolderTxt.TabIndex = 21;
            // 
            // Billings_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardHolderTxt);
            this.Controls.Add(this.CVV_Value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Expir_Year_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Expiry_Month_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardNumberTxt);
            this.Name = "Billings_Payment";
            this.Size = new System.Drawing.Size(595, 250);
            ((System.ComponentModel.ISupportInitialize)(this.CVV_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox CardNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CardHolderTxt;
        public System.Windows.Forms.ComboBox Expiry_Month_CB;
        public System.Windows.Forms.ComboBox Expir_Year_CB;
        public System.Windows.Forms.NumericUpDown CVV_Value;
    }
}
