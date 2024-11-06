namespace FormaFiskalnaKasa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ErrorClinic = new Label();
            PayBtn = new Button();
            totalClinic = new TextBox();
            departmentCmb = new ComboBox();
            userCmb = new ComboBox();
            patientCmb = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            ErrorMarket = new Label();
            bagLbx = new ListBox();
            paymetntBtn2 = new Button();
            totalMarket = new TextBox();
            departmentCbx2 = new ComboBox();
            userCmx2 = new ComboBox();
            productLbx = new ListBox();
            searchBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(567, 441);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(ErrorClinic);
            tabPage1.Controls.Add(PayBtn);
            tabPage1.Controls.Add(totalClinic);
            tabPage1.Controls.Add(departmentCmb);
            tabPage1.Controls.Add(userCmb);
            tabPage1.Controls.Add(patientCmb);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Klinika";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ErrorClinic
            // 
            ErrorClinic.AutoSize = true;
            ErrorClinic.ForeColor = Color.Red;
            ErrorClinic.Location = new Point(352, 339);
            ErrorClinic.Name = "ErrorClinic";
            ErrorClinic.Size = new Size(0, 20);
            ErrorClinic.TabIndex = 10;
            ErrorClinic.Visible = false;
            // 
            // PayBtn
            // 
            PayBtn.Location = new Point(352, 295);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(141, 29);
            PayBtn.TabIndex = 9;
            PayBtn.Text = "Naplati";
            PayBtn.UseVisualStyleBackColor = true;
            PayBtn.Click += PayBtn_Click;
            // 
            // totalClinic
            // 
            totalClinic.Location = new Point(352, 250);
            totalClinic.Name = "totalClinic";
            totalClinic.ReadOnly = true;
            totalClinic.Size = new Size(141, 27);
            totalClinic.TabIndex = 8;
            // 
            // departmentCmb
            // 
            departmentCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCmb.FormattingEnabled = true;
            departmentCmb.Location = new Point(352, 83);
            departmentCmb.Name = "departmentCmb";
            departmentCmb.Size = new Size(141, 28);
            departmentCmb.TabIndex = 7;
            departmentCmb.SelectedIndexChanged += departmentCmb_SelectedIndexChanged;
            // 
            // userCmb
            // 
            userCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            userCmb.FormattingEnabled = true;
            userCmb.Location = new Point(352, 26);
            userCmb.Name = "userCmb";
            userCmb.Size = new Size(141, 28);
            userCmb.TabIndex = 6;
            userCmb.SelectedIndexChanged += userCmb_SelectedIndexChanged;
            // 
            // patientCmb
            // 
            patientCmb.FormattingEnabled = true;
            patientCmb.Location = new Point(0, 26);
            patientCmb.Name = "patientCmb";
            patientCmb.Size = new Size(292, 28);
            patientCmb.TabIndex = 4;
            patientCmb.SelectedIndexChanged += patientCmb_SelectedIndexChanged;
            patientCmb.TextChanged += patientCmb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 227);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 3);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Osoblje:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 60);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Departman:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Pretraga po pacijentima:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ErrorMarket);
            tabPage2.Controls.Add(bagLbx);
            tabPage2.Controls.Add(paymetntBtn2);
            tabPage2.Controls.Add(totalMarket);
            tabPage2.Controls.Add(departmentCbx2);
            tabPage2.Controls.Add(userCmx2);
            tabPage2.Controls.Add(productLbx);
            tabPage2.Controls.Add(searchBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(559, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Market";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ErrorMarket
            // 
            ErrorMarket.AutoSize = true;
            ErrorMarket.Location = new Point(344, 342);
            ErrorMarket.Name = "ErrorMarket";
            ErrorMarket.Size = new Size(0, 20);
            ErrorMarket.TabIndex = 21;
            // 
            // bagLbx
            // 
            bagLbx.FormattingEnabled = true;
            bagLbx.ItemHeight = 20;
            bagLbx.Location = new Point(352, 131);
            bagLbx.Name = "bagLbx";
            bagLbx.SelectionMode = SelectionMode.None;
            bagLbx.Size = new Size(184, 104);
            bagLbx.TabIndex = 20;
            // 
            // paymetntBtn2
            // 
            paymetntBtn2.Location = new Point(395, 296);
            paymetntBtn2.Name = "paymetntBtn2";
            paymetntBtn2.Size = new Size(141, 29);
            paymetntBtn2.TabIndex = 19;
            paymetntBtn2.Text = "Naplati";
            paymetntBtn2.UseVisualStyleBackColor = true;
            paymetntBtn2.Click += paymetntBtn2_Click;
            // 
            // totalMarket
            // 
            totalMarket.Location = new Point(395, 263);
            totalMarket.Name = "totalMarket";
            totalMarket.ReadOnly = true;
            totalMarket.Size = new Size(141, 27);
            totalMarket.TabIndex = 18;
            // 
            // departmentCbx2
            // 
            departmentCbx2.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCbx2.FormattingEnabled = true;
            departmentCbx2.Location = new Point(352, 84);
            departmentCbx2.Name = "departmentCbx2";
            departmentCbx2.Size = new Size(141, 28);
            departmentCbx2.TabIndex = 17;
            departmentCbx2.SelectedIndexChanged += departmentCbx2_SelectedIndexChanged;
            // 
            // userCmx2
            // 
            userCmx2.DropDownStyle = ComboBoxStyle.DropDownList;
            userCmx2.FormattingEnabled = true;
            userCmx2.Location = new Point(352, 27);
            userCmx2.Name = "userCmx2";
            userCmx2.Size = new Size(141, 28);
            userCmx2.TabIndex = 16;
            userCmx2.SelectedIndexChanged += userCmx2_SelectedIndexChanged;
            // 
            // productLbx
            // 
            productLbx.FormattingEnabled = true;
            productLbx.ItemHeight = 20;
            productLbx.Location = new Point(0, 61);
            productLbx.Name = "productLbx";
            productLbx.Size = new Size(292, 264);
            productLbx.TabIndex = 15;
            productLbx.SelectedIndexChanged += productLbx_SelectedIndexChanged;
            productLbx.DoubleClick += productLbx_DoubleClick;
            productLbx.MouseDoubleClick += productLbx_MouseDoubleClick;
            // 
            // searchBox
            // 
            searchBox.FormattingEnabled = true;
            searchBox.Location = new Point(0, 27);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(292, 28);
            searchBox.TabIndex = 14;
            searchBox.SelectedIndexChanged += searchBox_SelectedIndexChanged;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 270);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 13;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 4);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 12;
            label6.Text = "Osoblje:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 61);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 11;
            label7.Text = "Departman:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 4);
            label8.Name = "label8";
            label8.Size = new Size(172, 20);
            label8.TabIndex = 10;
            label8.Text = "Pretraga po pacijentima:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 187);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 453);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox patientCmb;
        private ComboBox departmentCmb;
        private ComboBox userCmb;
        private TextBox totalClinic;
        private Button PayBtn;
        private Button paymetntBtn2;
        private TextBox totalMarket;
        private ComboBox departmentCbx2;
        private ComboBox userCmx2;
        private ListBox productLbx;
        private ComboBox searchBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox bagLbx;
        private Label ErrorClinic;
        private Label ErrorMarket;
        private DataGridView dataGridView1;
    }
}
