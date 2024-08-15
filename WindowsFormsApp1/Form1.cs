using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> values = new List<string>()
        {
            "Apple", "Banana", "Cherry", "Date", "Elderberry",
            "Fig", "Grape", "Honeydew", "Kiwi", "Lemon"
        };


        public Form1()
        {
            InitializeComponent();
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //userCmb.Items.Add("Osoblje");
            foreach (string element in values)
            {
                patientCmb.Items.Add(element);

            }

            //departmentCmb.Items.Add("Department");
            foreach (string element in values)
            {
                departmentCmb.Items.Add(element);

            }

            clinicLbx.DataSource = values; // Povezuje listu sa ListBox-om

        }
    }
}
