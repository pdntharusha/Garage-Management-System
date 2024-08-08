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
    public partial class customer_details : Form
    {
        public customer_details()
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
    }
}
