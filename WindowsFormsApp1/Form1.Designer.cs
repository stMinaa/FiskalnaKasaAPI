
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
            this.ErrorClinic = new System.Windows.Forms.Label();
            this.Osoblje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.totalClinic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicLbx = new System.Windows.Forms.ListBox();
            this.patientCmb = new System.Windows.Forms.ComboBox();
            this.departmentCmb = new System.Windows.Forms.ComboBox();
            this.marketPage = new System.Windows.Forms.TabPage();
            this.ErrorMarket = new System.Windows.Forms.Label();
            this.bagLbx = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userCmx2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymetntBtn2 = new System.Windows.Forms.Button();
            this.totalMarket = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productLbx = new System.Windows.Forms.ListBox();
            this.departmentCbx2 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pages.SuspendLayout();
            this.clinicPage.SuspendLayout();
            this.marketPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.clinicPage);
            this.pages.Controls.Add(this.marketPage);
            this.pages.Location = new System.Drawing.Point(0, 0);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(559, 453);
            this.pages.TabIndex = 0;
            // 
            // clinicPage
            // 
            this.clinicPage.Controls.Add(this.ErrorClinic);
            this.clinicPage.Controls.Add(this.Osoblje);
            this.clinicPage.Controls.Add(this.label3);
            this.clinicPage.Controls.Add(this.userCmb);
            this.clinicPage.Controls.Add(this.label2);
            this.clinicPage.Controls.Add(this.PayBtn);
            this.clinicPage.Controls.Add(this.totalClinic);
            this.clinicPage.Controls.Add(this.label1);
            this.clinicPage.Controls.Add(this.clinicLbx);
            this.clinicPage.Controls.Add(this.patientCmb);
            this.clinicPage.Controls.Add(this.departmentCmb);
            this.clinicPage.Location = new System.Drawing.Point(4, 25);
            this.clinicPage.Name = "clinicPage";
            this.clinicPage.Padding = new System.Windows.Forms.Padding(3);
            this.clinicPage.Size = new System.Drawing.Size(551, 424);
            this.clinicPage.TabIndex = 0;
            this.clinicPage.Text = "Klinika";
            this.clinicPage.UseVisualStyleBackColor = true;
            // 
            // ErrorClinic
            // 
            this.ErrorClinic.AutoSize = true;
            this.ErrorClinic.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ErrorClinic.Location = new System.Drawing.Point(8, 354);
            this.ErrorClinic.Name = "ErrorClinic";
            this.ErrorClinic.Size = new System.Drawing.Size(0, 17);
            this.ErrorClinic.TabIndex = 11;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Departman:";
            // 
            // userCmb
            // 
            this.userCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCmb.FormattingEnabled = true;
            this.userCmb.Location = new System.Drawing.Point(403, 29);
            this.userCmb.Name = "userCmb";
            this.userCmb.Size = new System.Drawing.Size(121, 24);
            this.userCmb.TabIndex = 8;
            this.userCmb.SelectedIndexChanged += new System.EventHandler(this.userCmb_SelectedIndexChanged);
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
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(424, 328);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(100, 23);
            this.PayBtn.TabIndex = 6;
            this.PayBtn.Text = "Naplati";
            this.PayBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // totalClinic
            // 
            this.totalClinic.Location = new System.Drawing.Point(424, 300);
            this.totalClinic.Name = "totalClinic";
            this.totalClinic.ReadOnly = true;
            this.totalClinic.Size = new System.Drawing.Size(100, 22);
            this.totalClinic.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
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
            this.patientCmb.SelectedIndexChanged += new System.EventHandler(this.patientCmb_SelectedIndexChanged);
            this.patientCmb.TextChanged += new System.EventHandler(this.patientCmb_TextChanged);
            // 
            // departmentCmb
            // 
            this.departmentCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCmb.FormattingEnabled = true;
            this.departmentCmb.Location = new System.Drawing.Point(403, 79);
            this.departmentCmb.Name = "departmentCmb";
            this.departmentCmb.Size = new System.Drawing.Size(121, 24);
            this.departmentCmb.TabIndex = 0;
            this.departmentCmb.SelectedIndexChanged += new System.EventHandler(this.departmentCmb_SelectedIndexChanged);
            // 
            // marketPage
            // 
            this.marketPage.Controls.Add(this.searchBox);
            this.marketPage.Controls.Add(this.ErrorMarket);
            this.marketPage.Controls.Add(this.bagLbx);
            this.marketPage.Controls.Add(this.label4);
            this.marketPage.Controls.Add(this.label5);
            this.marketPage.Controls.Add(this.userCmx2);
            this.marketPage.Controls.Add(this.label6);
            this.marketPage.Controls.Add(this.paymetntBtn2);
            this.marketPage.Controls.Add(this.totalMarket);
            this.marketPage.Controls.Add(this.label7);
            this.marketPage.Controls.Add(this.productLbx);
            this.marketPage.Controls.Add(this.departmentCbx2);
            this.marketPage.Location = new System.Drawing.Point(4, 25);
            this.marketPage.Name = "marketPage";
            this.marketPage.Padding = new System.Windows.Forms.Padding(3);
            this.marketPage.Size = new System.Drawing.Size(551, 424);
            this.marketPage.TabIndex = 1;
            this.marketPage.Text = "Market";
            this.marketPage.UseVisualStyleBackColor = true;
            // 
            // ErrorMarket
            // 
            this.ErrorMarket.AutoSize = true;
            this.ErrorMarket.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ErrorMarket.Location = new System.Drawing.Point(294, 356);
            this.ErrorMarket.Name = "ErrorMarket";
            this.ErrorMarket.Size = new System.Drawing.Size(0, 17);
            this.ErrorMarket.TabIndex = 22;
            // 
            // bagLbx
            // 
            this.bagLbx.FormattingEnabled = true;
            this.bagLbx.ItemHeight = 16;
            this.bagLbx.Location = new System.Drawing.Point(297, 121);
            this.bagLbx.Name = "bagLbx";
            this.bagLbx.Size = new System.Drawing.Size(227, 164);
            this.bagLbx.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Osoblje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Departman:";
            // 
            // userCmx2
            // 
            this.userCmx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCmx2.FormattingEnabled = true;
            this.userCmx2.Location = new System.Drawing.Point(297, 34);
            this.userCmx2.Name = "userCmx2";
            this.userCmx2.Size = new System.Drawing.Size(121, 24);
            this.userCmx2.TabIndex = 18;
            this.userCmx2.SelectedIndexChanged += new System.EventHandler(this.userCmx2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pretraga po proizvodima:";
            // 
            // paymetntBtn2
            // 
            this.paymetntBtn2.Location = new System.Drawing.Point(424, 333);
            this.paymetntBtn2.Name = "paymetntBtn2";
            this.paymetntBtn2.Size = new System.Drawing.Size(100, 23);
            this.paymetntBtn2.TabIndex = 16;
            this.paymetntBtn2.Text = "Naplati";
            this.paymetntBtn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paymetntBtn2.UseVisualStyleBackColor = true;
            this.paymetntBtn2.Click += new System.EventHandler(this.paymetntBtn2_Click);
            // 
            // totalMarket
            // 
            this.totalMarket.Location = new System.Drawing.Point(424, 305);
            this.totalMarket.Name = "totalMarket";
            this.totalMarket.ReadOnly = true;
            this.totalMarket.Size = new System.Drawing.Size(100, 22);
            this.totalMarket.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // productLbx
            // 
            this.productLbx.FormattingEnabled = true;
            this.productLbx.ItemHeight = 16;
            this.productLbx.Location = new System.Drawing.Point(17, 64);
            this.productLbx.Name = "productLbx";
            this.productLbx.Size = new System.Drawing.Size(244, 292);
            this.productLbx.TabIndex = 13;
            this.productLbx.DoubleClick += new System.EventHandler(this.productLbx_DoubleClick);
            // 
            // departmentCbx2
            // 
            this.departmentCbx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCbx2.FormattingEnabled = true;
            this.departmentCbx2.Location = new System.Drawing.Point(297, 84);
            this.departmentCbx2.Name = "departmentCbx2";
            this.departmentCbx2.Size = new System.Drawing.Size(121, 24);
            this.departmentCbx2.TabIndex = 11;
            this.departmentCbx2.SelectedIndexChanged += new System.EventHandler(this.departmentCbx2_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(17, 36);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(244, 22);
            this.searchBox.TabIndex = 23;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
            this.marketPage.ResumeLayout(false);
            this.marketPage.PerformLayout();
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
        private System.Windows.Forms.TextBox totalClinic;
        private System.Windows.Forms.Label Osoblje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox bagLbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userCmx2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button paymetntBtn2;
        private System.Windows.Forms.TextBox totalMarket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox productLbx;
        private System.Windows.Forms.ComboBox departmentCbx2;
        private System.Windows.Forms.Label ErrorMarket;
        private System.Windows.Forms.Label ErrorClinic;
        private System.Windows.Forms.TextBox searchBox;
    }
}

