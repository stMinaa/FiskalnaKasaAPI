
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pages = new System.Windows.Forms.TabControl();
            this.clinicPage = new System.Windows.Forms.TabPage();
            this.PayBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicLbx = new System.Windows.Forms.ListBox();
            this.patientCmb = new System.Windows.Forms.ComboBox();
            this.departmentCmb = new System.Windows.Forms.ComboBox();
            this.marketPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.userCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Osoblje = new System.Windows.Forms.Label();
            this.pages.SuspendLayout();
            this.clinicPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.clinicPage);
            this.pages.Controls.Add(this.marketPage);
            this.pages.Location = new System.Drawing.Point(0, 0);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(802, 453);
            this.pages.TabIndex = 0;
            // 
            // clinicPage
            // 
            this.clinicPage.Controls.Add(this.Osoblje);
            this.clinicPage.Controls.Add(this.label3);
            this.clinicPage.Controls.Add(this.userCmb);
            this.clinicPage.Controls.Add(this.label2);
            this.clinicPage.Controls.Add(this.PayBtn);
            this.clinicPage.Controls.Add(this.textBox2);
            this.clinicPage.Controls.Add(this.label1);
            this.clinicPage.Controls.Add(this.clinicLbx);
            this.clinicPage.Controls.Add(this.patientCmb);
            this.clinicPage.Controls.Add(this.departmentCmb);
            this.clinicPage.Location = new System.Drawing.Point(4, 25);
            this.clinicPage.Name = "clinicPage";
            this.clinicPage.Padding = new System.Windows.Forms.Padding(3);
            this.clinicPage.Size = new System.Drawing.Size(794, 424);
            this.clinicPage.TabIndex = 0;
            this.clinicPage.Text = "Clinic";
            this.clinicPage.UseVisualStyleBackColor = true;
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(258, 382);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(100, 23);
            this.PayBtn.TabIndex = 6;
            this.PayBtn.Text = "Naplati";
            this.PayBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PayBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clinicLbx
            // 
            this.clinicLbx.FormattingEnabled = true;
            this.clinicLbx.ItemHeight = 16;
            this.clinicLbx.Location = new System.Drawing.Point(8, 59);
            this.clinicLbx.Name = "clinicLbx";
            this.clinicLbx.Size = new System.Drawing.Size(350, 292);
            this.clinicLbx.TabIndex = 3;
            // 
            // patientCmb
            // 
            this.patientCmb.FormattingEnabled = true;
            this.patientCmb.Location = new System.Drawing.Point(8, 29);
            this.patientCmb.Name = "patientCmb";
            this.patientCmb.Size = new System.Drawing.Size(350, 24);
            this.patientCmb.Sorted = true;
            this.patientCmb.TabIndex = 1;
            // 
            // departmentCmb
            // 
            this.departmentCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCmb.FormattingEnabled = true;
            this.departmentCmb.Location = new System.Drawing.Point(403, 79);
            this.departmentCmb.Name = "departmentCmb";
            this.departmentCmb.Size = new System.Drawing.Size(121, 24);
            this.departmentCmb.TabIndex = 0;
            // 
            // marketPage
            // 
            this.marketPage.Location = new System.Drawing.Point(4, 25);
            this.marketPage.Name = "marketPage";
            this.marketPage.Padding = new System.Windows.Forms.Padding(3);
            this.marketPage.Size = new System.Drawing.Size(794, 424);
            this.marketPage.TabIndex = 1;
            this.marketPage.Text = "Market";
            this.marketPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraga po pacijentima:";
            // 
            // userCmb
            // 
            this.userCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCmb.FormattingEnabled = true;
            this.userCmb.Location = new System.Drawing.Point(403, 29);
            this.userCmb.Name = "userCmb";
            this.userCmb.Size = new System.Drawing.Size(121, 24);
            this.userCmb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Departman:";
            // 
            // Osoblje
            // 
            this.Osoblje.AutoSize = true;
            this.Osoblje.Location = new System.Drawing.Point(400, 9);
            this.Osoblje.Name = "Osoblje";
            this.Osoblje.Size = new System.Drawing.Size(60, 17);
            this.Osoblje.TabIndex = 10;
            this.Osoblje.Text = "Osoblje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.pages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pages.ResumeLayout(false);
            this.clinicPage.ResumeLayout(false);
            this.clinicPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage clinicPage;
        private System.Windows.Forms.TabPage marketPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox clinicLbx;
        private System.Windows.Forms.ComboBox patientCmb;
        private System.Windows.Forms.ComboBox departmentCmb;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Osoblje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userCmb;
        private System.Windows.Forms.Label label2;
    }
}

