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
    public partial class veh_reg : Form
    {
        public veh_reg()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string manufacturer = manufacturerTextBox1.Text;
            string vehicle = vehicleTextBox2.Text;
            string model = modelTextBox3.Text;
            string vin = vinTextBox4.Text;
            string mileage = mileageTextBox5.Text;
            string numberPlate = numberPlateTextBox6.Text;
            string color = colorTextBox7.Text;
            string engineType = engineTypeTextBox8.Text;
            string combo1Value = comboBox1.Text;
            string combo2Value = comboBox2.Text;
            string combo3Value = comboBox3.Text;
            string combo4Value = comboBox4.Text;

            // Validate the input data
            if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrEmpty(vehicle) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(vin) || string.IsNullOrEmpty(mileage)
                || string.IsNullOrEmpty(numberPlate) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(engineType))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Format the data and send it to the backend system
            string formattedData = string.Format("Manufacturer: {0}, Vehicle: {1}, Model: {2}, VIN: {3}, Mileage: {4}, Number Plate: {5}, Color: {6}, Engine Type: {7}, Combo Box 1 Value: {8}, Combo Box 2 Value: {9}, Combo Box 3 Value: {10}, Combo Box 4 Value: {11}",
                manufacturer, vehicle, model, vin, mileage, numberPlate, color, engineType, combo1Value, combo2Value, combo3Value, combo4Value);
            // ... code to send the data to the backend system

            // Display a success message to the user
            MessageBox.Show("Thank you for submitting your information!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            manufacturerTextBox1.Text = "";
            vehicleTextBox2.Text = "";
            modelTextBox3.Text = "";
            vinTextBox4.Text = "";
            mileageTextBox5.Text = "";
            numberPlateTextBox6.Text = "";
            colorTextBox7.Text = "";
            engineTypeTextBox8.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the bill_pay form
            bill_pay billPayForm = new bill_pay();

            // Show the bill_pay form
            billPayForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the cus_reg form
            cus_reg cusRegForm = new cus_reg();

            // Show the cus_reg form
            cusRegForm.Show();


        }
    }
}