namespace FormaFiskalnaKasa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cashCbx = new CheckBox();
            cardCbx = new CheckBox();
            paymentSlipCbx = new CheckBox();
            checksCbx = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            exchangeValue = new TextBox();
            payBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Način plaćanja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Iznos za uplatu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Kusur:";
            // 
            // cashCbx
            // 
            cashCbx.AutoSize = true;
            cashCbx.Location = new Point(12, 35);
            cashCbx.Name = "cashCbx";
            cashCbx.Size = new Size(94, 24);
            cashCbx.TabIndex = 3;
            cashCbx.Text = "Gotovina:";
            cashCbx.UseVisualStyleBackColor = true;
            // 
            // cardCbx
            // 
            cardCbx.AutoSize = true;
            cardCbx.Location = new Point(12, 65);
            cardCbx.Name = "cardCbx";
            cardCbx.Size = new Size(80, 24);
            cardCbx.TabIndex = 4;
            cardCbx.Text = "Kartica:";
            cardCbx.UseVisualStyleBackColor = true;
            // 
            // paymentSlipCbx
            // 
            paymentSlipCbx.AutoSize = true;
            paymentSlipCbx.Location = new Point(12, 95);
            paymentSlipCbx.Name = "paymentSlipCbx";
            paymentSlipCbx.Size = new Size(97, 24);
            paymentSlipCbx.TabIndex = 5;
            paymentSlipCbx.Text = "Uplatnica:";
            paymentSlipCbx.UseVisualStyleBackColor = true;
            paymentSlipCbx.CheckedChanged += paymentSlipCbx_CheckedChanged;
            // 
            // checksCbx
            // 
            checksCbx.AutoSize = true;
            checksCbx.Location = new Point(12, 125);
            checksCbx.Name = "checksCbx";
            checksCbx.Size = new Size(78, 24);
            checksCbx.TabIndex = 6;
            checksCbx.Text = "Čekovi:";
            checksCbx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(215, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // exchangeValue
            // 
            exchangeValue.Location = new Point(215, 172);
            exchangeValue.Name = "exchangeValue";
            exchangeValue.ReadOnly = true;
            exchangeValue.Size = new Size(125, 27);
            exchangeValue.TabIndex = 11;
            // 
            // payBtn
            // 
            payBtn.Location = new Point(215, 216);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(125, 29);
            payBtn.TabIndex = 12;
            payBtn.Text = "Naplati";
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 275);
            Controls.Add(payBtn);
            Controls.Add(exchangeValue);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checksCbx);
            Controls.Add(paymentSlipCbx);
            Controls.Add(cardCbx);
            Controls.Add(cashCbx);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cashCbx;
        private CheckBox cardCbx;
        private CheckBox paymentSlipCbx;
        private CheckBox checksCbx;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox exchangeValue;
        private Button payBtn;
    }
}