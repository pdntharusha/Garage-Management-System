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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer_details form = new customer_details();
            form.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill_pay formBillPay = new bill_pay();
            formBillPay.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            veh_reg formVehReg = new veh_reg();
            formVehReg.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            cus_reg cusRegForm = new cus_reg();

            // Hide the current form
            this.Hide();

            // Show the new form
            cusRegForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_det formAddDet = new add_det();
            formAddDet.Show();
            this.Hide();

        }

        private void cutomer_det1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Get Form1 from the Application.OpenForms collection
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // Reset Form1
            form1.ResetForm();

            // Show Form1
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
