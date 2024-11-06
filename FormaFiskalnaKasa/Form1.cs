using FiskalnaKasaAPI.Models;
using System.ComponentModel;
using System.Net.Http.Json;

namespace FormaFiskalnaKasa
{
    public partial class Form1 : Form
    {
        private List<string> bag = new List<string>()
        {

        };

        
        private readonly HttpClient _httpClient;

        private List<Customer> _patients = new List<Customer>();
        


        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            })
            {
                BaseAddress = new Uri("https://localhost:7041")
            };

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //pacijenti
                var patientsTask = GetPatients();
                Console.Write(patientsTask);
                //kasiri
                var usersTask = GetUsersCashiers();
                //departmani
                var departmentsTask = GetActiveDepartments();

                await Task.WhenAll(patientsTask, usersTask, departmentsTask);

                _patients = await patientsTask;
                patientCmb.DataSource = _patients;
                patientCmb.FormattingEnabled = true;
                patientCmb.DisplayMember = "Name";
                patientCmb.ValueMember = "Id";
                
                patientCmb.Refresh();



                var users = await usersTask;
                foreach (var user in users)
                {
                    userCmb.Items.Add(user.FirstName + " " + user.LastName);
                    userCmx2.Items.Add(user.FirstName + " " + user.LastName);
                }

                var departments = await departmentsTask;
                foreach (var department in departments)
                {
                    departmentCmb.Items.Add(department.DepartmentName);
                    departmentCbx2.Items.Add(department.DepartmentName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //departmentCmb.Items.AddRange(values.ToArray());

            //u startu prazna?
            //clinicLbx.DataSource = values; // Povezuje listu sa ListBox-om

            //MARKET
            //productLbx.Items.AddRange(values.ToArray());
            //bag inicijalno prazna
            bagLbx.Items.AddRange(bag.ToArray());


        }

        //POMOCNE
        private async Task<List<Department>> GetActiveDepartments()
        {
            var response = await _httpClient.GetAsync("api/Department");
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not 2xx
            return await response.Content.ReadFromJsonAsync<List<Department>>();
        }

        private async Task<List<User>> GetUsersCashiers()
        {
            var response = await _httpClient.GetAsync("api/User");
            response.EnsureSuccessStatusCode(); 
            return await response.Content.ReadFromJsonAsync<List<User>>();
        }

        private async Task<List<Customer>> GetPatients()
        {
            var response = await _httpClient.GetAsync("api/Customer");
            response.EnsureSuccessStatusCode(); 
            return await response.Content.ReadFromJsonAsync<List<Customer>>();
        }
        

        
        private void patientCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patientCmb_TextChanged(object sender, EventArgs e)
        {
            string filter = patientCmb.Text.ToLower();
            List<string> filteredItems = _patients
               .Where(p => $"{p.Name} {p.JMBG}".ToLower().StartsWith(filter))
               .Select(p => $"{p.Name} {p.JMBG}")
               .ToList();

            patientCmb.Items.Clear();
            patientCmb.Items.AddRange(filteredItems.ToArray());

            // Set the cursor at the end of the text
            patientCmb.SelectionStart = patientCmb.Text.Length;
            patientCmb.DroppedDown = true;
        }

        //KLINIKA
        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (totalClinic.Text == "0" || totalClinic.Text == "" || userCmb.SelectedIndex == -1 || departmentCmb.SelectedIndex == -1)
            {
                ErrorClinic.Text = "Nisu definisane usluge za naplatu!!";
                ErrorClinic.Visible = true;
            }
            else
            {
                if (decimal.TryParse(totalClinic.Text, out decimal totalAmount))
                {
                    Payment payment = new Payment(totalAmount); // Kreiraj instancu nove forme
                    payment.Show(); // Otvori novu formu
                }

            }
        }

        private void userCmx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentCbx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
           // string filter = searchBox.Text.ToLower();
            //var filtriranaLista = values
            //                      .Where(item => item.ToLower().StartsWith(filter))
            //                      .ToList();

           // productLbx.DataSource = filtriranaLista;
        }

        private void productLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {/*
            if (productLbx.SelectedItem != null)
            {
                // Dodaj selektovanu stavku u listBox2

                bag.Add(productLbx.SelectedItem.ToString());
                //bagLbx.Items.Clear();
                bagLbx.Items.Add(productLbx.SelectedItem.ToString());
                totalMarket.Text = "15";//IZMENIIII
            }*/
        }

        private void productLbx_DoubleClick(object sender, EventArgs e)
        {
            if (productLbx.SelectedItem != null)
            {
                // Dodaj selektovanu stavku u listBox2

                bag.Add(productLbx.SelectedItem.ToString());
                //bagLbx.Items.Clear();
                bagLbx.Items.Add(productLbx.SelectedItem.ToString());
                totalMarket.Text = "15";//IZMENIIII
            }
        }

        private void productLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paymetntBtn2_Click(object sender, EventArgs e)
        {
          /*  if (totalMarket.Text == "0" || totalMarket.Text == "" || userCmx2.SelectedIndex == -1 || departmentCbx2.SelectedIndex == -1)
            {
                ErrorMarket.Text = "Nisu definisane usluge za naplatu!!";
            }
            else
            {
                Payment payment = new Payment(); // Kreiraj instancu nove forme
                payment.Show(); // Otvori novu formu

            }*/
        }
    }
}
