using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class add_det : Form
    {
        public add_det()
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the bill_pay form
            bill_pay billPayForm = new bill_pay();

            // Show the bill_pay form
            billPayForm.Show();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the values from the form controls
            string serviceValue = serviceTextBox.Text;
            string insuranceValue = insuranceTextBox.Text;
            string employeeValue = employeeTextBox.Text;
            string statusValue = statusTextBox.Text;
            string checkValue = checkTextBox.Text;
            string notesValue = notesTextBox.Text;

            DateTime startDateValue = dateTimePicker1.Value;
            DateTime endDateValue = dateTimePicker2.Value;

            List<string> checkedListBoxValues = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedListBoxValues.Add(item.ToString());
            }

            // Validate the input data
            if (string.IsNullOrEmpty(serviceValue) || string.IsNullOrEmpty(insuranceValue) || string.IsNullOrEmpty(employeeValue) || string.IsNullOrEmpty(statusValue) || string.IsNullOrEmpty(checkValue) || string.IsNullOrEmpty(notesValue))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Format the data and send it to the backend system
            string formattedData = string.Format("Service: {0}, Insurance: {1}, Employee: {2}, Status: {3}, Check: {4}, Notes: {5}, Start Date: {6}, End Date: {7}, Checked List Box Values: {8}",
                serviceValue, insuranceValue, employeeValue, statusValue, checkValue, notesValue, startDateValue.ToString(), endDateValue.ToString(), string.Join(",", checkedListBoxValues));
            // ... code to send the data to the backend system

            // Display a success message to the user
            MessageBox.Show("Thank you for submitting your information!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the form controls
            serviceTextBox.Text = "";
            insuranceTextBox.Text = "";
            employeeTextBox.Text = "";
            statusTextBox.Text = "";
            checkTextBox.Text = "";
            notesTextBox.Text = "";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }
    }
}
