using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string customername = txtcustomer.Text;
                double previousReading = double.Parse(txtprevious.Text);
                double currentReading = double.Parse(txtcurrent.Text);
                double unitperprice = double.Parse(txtunitprice.Text);

                double usge = currentReading - previousReading;
                double Subtotal = usge * unitperprice;
                double Tax = Subtotal * 0.07;
                double TotalBill = Subtotal + Tax;


                lblUsage.Text = usge.ToString();
                lblTax.Text = "$" + Tax.ToString("0,00");
                lblTotal.Text = "$" + TotalBill.ToString("0.00");
            }
            catch (Exception ex) {

                MessageBox.Show("PLEASE ENTER VALID NUMBERS.");
            }
        }

        private void TAX_Click(object sender, EventArgs e)
        {

        }
    }
}
