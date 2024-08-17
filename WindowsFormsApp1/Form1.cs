using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private List<string> bag = new List<string>()
        {
          
        };
        //public Department department;


        public Form1()
        {
            InitializeComponent();
        }








        private void Form1_Load(object sender, EventArgs e)
        {
            //KLINIKA
            //get patients
            patientCmb.Items.AddRange(values.ToArray());
            //get user
            userCmb.Items.AddRange(values.ToArray());
            //get department
            departmentCmb.Items.AddRange(values.ToArray());
            //u startu prazna?
            //clinicLbx.DataSource = values; // Povezuje listu sa ListBox-om



            //MARKET
            //get user
            userCmx2.Items.AddRange(values.ToArray());
            //get department
            departmentCbx2.Items.AddRange(values.ToArray());
            //get services--product
            productLbx.Items.AddRange(values.ToArray());
            //bag inicijalno prazna
            bagLbx.Items.AddRange(bag.ToArray());


        }

        //KLINIKA
        //patient cmb item selected -- popuni se cliniclbx i total polje
        private void patientCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalClinic.Text = 15.ToString();
        }
        //departmant cmb selected item
        //user cmb selected item
        private void userCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //departmant cmb selected item
        private void departmentCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void patientCmb_TextChanged(object sender, EventArgs e)
        {

            string filter = patientCmb.Text.ToLower();
            List<string> filteredItems = values.Where(item => item.ToLower().StartsWith(filter)).ToList();

            patientCmb.Items.Clear();
            patientCmb.Items.AddRange(filteredItems.ToArray());

            // Set the cursor at the end of the text
            patientCmb.SelectionStart = patientCmb.Text.Length;
            patientCmb.DroppedDown = true;
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (totalClinic.Text == "0" || totalClinic.Text == "" || userCmb.SelectedIndex==-1 || departmentCmb.SelectedIndex==-1)
            {
                ErrorClinic.Text = "Nisu definisane usluge za naplatu!!";
            }
            else
            {
                Payment payment = new Payment(); // Kreiraj instancu nove forme
                payment.Show(); // Otvori novu formu

            }
        }


        //MARKET


        private void paymetntBtn2_Click(object sender, EventArgs e)
        {
            if (totalMarket.Text == "0" || totalMarket.Text == "" || userCmx2.SelectedIndex == -1 || departmentCbx2.SelectedIndex == -1)
            {
                ErrorMarket.Text = "Nisu definisane usluge za naplatu!!";
            }
            else
            {
                Payment payment = new Payment(); // Kreiraj instancu nove forme
                payment.Show(); // Otvori novu formu
                
            }
        }

        private void userCmx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentCbx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchBox.Text.ToLower();
            var filtriranaLista = values
                                  .Where(item => item.ToLower().StartsWith(filter))
                                  .ToList();

            productLbx.DataSource = filtriranaLista;
        }

        private void productLbx_DoubleClick(object sender, EventArgs e)
        {
            if (productLbx.SelectedItem != null)
            {
                // Dodaj selektovanu stavku u listBox2
                
                bag.Add(productLbx.SelectedItem.ToString());
                //bagLbx.Items.Clear();
                bagLbx.Items.Add(productLbx.SelectedItem.ToString());
                totalMarket.Text = "15";
            }
        }
    }



   // private void label1_Click(object sender, EventArgs e)
   // {
   //
   // }

}
