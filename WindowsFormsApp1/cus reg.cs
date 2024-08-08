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
    public partial class cus_reg : Form
    {
        public cus_reg()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input values from the form controls
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string idNumber = idNumberTextBox.Text;
            string address = addressTextBox.Text;
            DateTime date = dateTimePicker1.Value;
            string comboValue = comboBox1.Text;
            string checkedListValues = string.Join(",", checkedListBox1.CheckedItems.Cast<string>().ToArray());

            // Validate the input data
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Format the data and send it to the backend system
            string formattedData = string.Format("Name: {0}, Email: {1}, Phone: {2}, ID Number: {3}, Address: {4}, Date: {5}, Combo Box Value: {6}, Checked List Box Values: {7}",
                name, email, phone, idNumber, address, date.ToShortDateString(), comboValue, checkedListValues);
            // ... code to send the data to the backend system

            // Display a success message to the user
            MessageBox.Show("Thank you for submitting your information!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            idNumberTextBox.Text = "";
            addressTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            checkedListBox1.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veh_reg vehRegForm = new veh_reg();
            vehRegForm.Show();
            this.Hide();

        }
    }
}
