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
    public partial class bill_pay : Form
    {
        public bill_pay()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Get Home form from the Application.OpenForms collection
            Home home = (Home)Application.OpenForms["Home"];

            // Show Home form
            home.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string customerName = customerNameTextBox.Text;
            string contact = contactTextBox.Text;
            string billing = billingTextBox.Text;
            string invoice = invoiceTextBox.Text;
            string email = emailTextBox.Text;
            string payment = paymentTextBox.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string comboValue = comboBox1.Text;

            // Validate the input data
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(billing) || string.IsNullOrEmpty(invoice) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(payment))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Format the data and send it to the backend system
            string formattedData = string.Format("Customer Name: {0}, Contact: {1}, Billing: {2}, Invoice: {3}, Email: {4}, Payment: {5}, Date Time: {6}, Combo Box Value: {7}",
                customerName, contact, billing, invoice, email, payment, dateTime.ToString(), comboValue);
            // ... code to send the data to the backend system

            // Display a success message to the user
            MessageBox.Show("Thank you for submitting your information!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            customerNameTextBox.Clear();
            contactTextBox.Clear();
            billingTextBox.Clear();
            invoiceTextBox.Clear();
            emailTextBox.Clear();
            paymentTextBox.Clear();

            // Reset the datetimepicker to the current date and time
            dateTimePicker1.Value = DateTime.Now;

            // Reset the combobox
            comboBox1.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the add_det form
            add_det addDetForm = new add_det();

            // Show the add_det form
            addDetForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the veh_reg form
            veh_reg vehRegForm = new veh_reg();

            // Show the veh_reg form
            vehRegForm.Show();


        }
    }
}
