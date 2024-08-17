
namespace WindowsFormsApp1
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.cashCbx = new System.Windows.Forms.CheckBox();
            this.checksCbx = new System.Windows.Forms.CheckBox();
            this.paymentSlipCbx = new System.Windows.Forms.CheckBox();
            this.cardCbx = new System.Windows.Forms.CheckBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.card = new System.Windows.Forms.TextBox();
            this.paymentSlip = new System.Windows.Forms.TextBox();
            this.checks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.exchangeValue = new System.Windows.Forms.TextBox();
            this.PaymentType = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Način plaćanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznos za uplatu:";
            // 
            // cashCbx
            // 
            this.cashCbx.AutoSize = true;
            this.cashCbx.Location = new System.Drawing.Point(20, 42);
            this.cashCbx.Name = "cashCbx";
            this.cashCbx.Size = new System.Drawing.Size(91, 21);
            this.cashCbx.TabIndex = 6;
            this.cashCbx.Text = "Gotovina:";
            this.cashCbx.UseVisualStyleBackColor = true;
            // 
            // checksCbx
            // 
            this.checksCbx.AutoSize = true;
            this.checksCbx.Location = new System.Drawing.Point(20, 124);
            this.checksCbx.Name = "checksCbx";
            this.checksCbx.Size = new System.Drawing.Size(76, 21);
            this.checksCbx.TabIndex = 7;
            this.checksCbx.Text = "Čekovi:";
            this.checksCbx.UseVisualStyleBackColor = true;
            // 
            // paymentSlipCbx
            // 
            this.paymentSlipCbx.AutoSize = true;
            this.paymentSlipCbx.Location = new System.Drawing.Point(20, 97);
            this.paymentSlipCbx.Name = "paymentSlipCbx";
            this.paymentSlipCbx.Size = new System.Drawing.Size(93, 21);
            this.paymentSlipCbx.TabIndex = 8;
            this.paymentSlipCbx.Text = "Uplatnica:";
            this.paymentSlipCbx.UseVisualStyleBackColor = true;
            // 
            // cardCbx
            // 
            this.cardCbx.AutoSize = true;
            this.cardCbx.Location = new System.Drawing.Point(20, 70);
            this.cardCbx.Name = "cardCbx";
            this.cardCbx.Size = new System.Drawing.Size(78, 21);
            this.cardCbx.TabIndex = 9;
            this.cardCbx.Text = "Kartica:";
            this.cardCbx.UseVisualStyleBackColor = true;
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(175, 42);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(100, 22);
            this.cash.TabIndex = 10;
            this.cash.Text = "0";
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(175, 70);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 22);
            this.card.TabIndex = 11;
            this.card.Text = "0";
            // 
            // paymentSlip
            // 
            this.paymentSlip.Location = new System.Drawing.Point(175, 97);
            this.paymentSlip.Name = "paymentSlip";
            this.paymentSlip.Size = new System.Drawing.Size(100, 22);
            this.paymentSlip.TabIndex = 12;
            this.paymentSlip.Text = "0";
            // 
            // checks
            // 
            this.checks.Location = new System.Drawing.Point(175, 124);
            this.checks.Name = "checks";
            this.checks.Size = new System.Drawing.Size(100, 22);
            this.checks.TabIndex = 13;
            this.checks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kusur:";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(175, 192);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(100, 25);
            this.payBtn.TabIndex = 16;
            this.payBtn.Text = "Naplati";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.EnabledChanged += new System.EventHandler(this.payBtn_EnabledChanged);
            // 
            // exchangeValue
            // 
            this.exchangeValue.Location = new System.Drawing.Point(175, 155);
            this.exchangeValue.Name = "exchangeValue";
            this.exchangeValue.ReadOnly = true;
            this.exchangeValue.Size = new System.Drawing.Size(100, 22);
            this.exchangeValue.TabIndex = 17;
            // 
            // PaymentType
            // 
            this.PaymentType.FormattingEnabled = true;
            this.PaymentType.Items.AddRange(new object[] {
            "Gotovina",
            "Kartica",
            "Uplatnica",
            "Čekovi"});
            this.PaymentType.Location = new System.Drawing.Point(16, 178);
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Size = new System.Drawing.Size(120, 72);
            this.PaymentType.TabIndex = 18;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 239);
            this.Controls.Add(this.PaymentType);
            this.Controls.Add(this.exchangeValue);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checks);
            this.Controls.Add(this.paymentSlip);
            this.Controls.Add(this.card);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.cardCbx);
            this.Controls.Add(this.paymentSlipCbx);
            this.Controls.Add(this.checksCbx);
            this.Controls.Add(this.cashCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cashCbx;
        private System.Windows.Forms.CheckBox checksCbx;
        private System.Windows.Forms.CheckBox paymentSlipCbx;
        private System.Windows.Forms.CheckBox cardCbx;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.TextBox paymentSlip;
        private System.Windows.Forms.TextBox checks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.TextBox exchangeValue;
        private System.Windows.Forms.CheckedListBox PaymentType;
    }
}