using FiskalnaKasaAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaFiskalnaKasa
{
    public partial class Payment : Form
    {

        private decimal _totalAmount;
        public Payment(decimal totalAmount)
        {
            InitializeComponent();
            _totalAmount = totalAmount;
        }


        //POMOCNA
        public (bool Success, decimal Change, string Message) ProcessPayment(decimal totalAmount, Dictionary<PaymentType, decimal> payments)
        {
            // Celo uplaceno
            decimal totalPaid = payments.Values.Sum();

            // Check if the payment covers the total amount
            if (totalPaid < totalAmount)
            {
                return (false, 0, $"Nedovoljno uplaćeno. Fali još {totalAmount - totalPaid:C}.");
            }

            // Calculate change if there was an overpayment
            decimal change = totalPaid - totalAmount;

            return (true, change, change > 0 ? $"Uplata uspešna. Kusur je {change:C}." : "Uplata uspešna. Nema kusura.");
        }

        private void paymentSlipCbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            //decimal totalAmount = 100.00m; 

            // Dictionary to store payment types and amounts
            var payments = new Dictionary<PaymentType, decimal>();

            //Gotovina
            if (cashCbx.Checked && decimal.TryParse(textBox1.Text, out decimal cashAmount) && cashAmount > 0)
            {
                payments[PaymentType.Gotovina] = cashAmount;
            }
            //kartica
            if (cardCbx.Checked && decimal.TryParse(textBox2.Text, out decimal creditCardAmount) && creditCardAmount > 0)
            {
                payments[PaymentType.KreditnaKartica] = creditCardAmount;
            }
            //cekovi
            if (checksCbx.Checked && decimal.TryParse(textBox4.Text, out decimal checkAmount) && checkAmount > 0)
            {
                payments[PaymentType.Cekovi] = checkAmount;
            }
            //uplatnica
            if (paymentSlipCbx.Checked && decimal.TryParse(textBox3.Text, out decimal paymentSlipAmount) && paymentSlipAmount > 0)
            {
                payments[PaymentType.Virman] = paymentSlipAmount;
            }

            // Call the payment processing logic
            var result = ProcessPayment(_totalAmount, payments);
            exchangeValue.Text = result.Change.ToString();
            // Display the result message
            MessageBox.Show(result.Message);
        }
    }
}
