using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace assment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
         
        }


        private void calculate_Click(object sender, EventArgs e)
        {
      
           
            string guestName = txtGN.Text;

           
            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }

          
            if (!int.TryParse(textGA.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            // Validate Number of Nights
            if (!int.TryParse(textNOFN.Text, out int nights))
            {
                MessageBox.Show("Please enter a valid number of nights.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }

            // Validate Number of Guests
            if (!int.TryParse(textNOFG.Text, out int guests))
            {
                MessageBox.Show("Please enter a valid number of guests.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            // Room type and guest limits
            string roomType = "";
            double rate = 0;

            if (rstandard.Checked)
            {
                roomType = "Standard";
                rate = 50;

                if (guests > 2)
                {
                    MessageBox.Show("Standard room can accommodate a maximum of 2 guests.");
                    return;
                }
            }
            else if (rnormal.Checked)
            {
                roomType = "Normal";
                rate = 80;

                if (guests > 4)
                {
                    MessageBox.Show("Normal room can accommodate a maximum of 4 guests.");
                    return;
                }
            }
            else if (rhight.Checked)
            {
                roomType = "High";
                rate = 130;

                if (guests > 6)
                {
                    MessageBox.Show("High room can accommodate a maximum of 6 guests.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

        
            double basicRoomCost = rate * nights;

            // Stay discount
            double stayDiscount = 0;

            if (nights >= 5 && nights <= 9)
            {
                stayDiscount = basicRoomCost * 0.05;
            }
            else if (nights >= 10)
            {
                stayDiscount = basicRoomCost * 0.12;
            }

            // Breakfast
            double breakfastCost = 0;

            if (checkedBfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // Service surcharge
            double serviceSurcharge = 0;

            if (guests > 4)
            {
                serviceSurcharge = basicRoomCost * 0.10;
            }

            // Senior discount
            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = basicRoomCost * 0.05;
            }

            // Final cost
            double finalCost =
                basicRoomCost
                - stayDiscount
                - seniorDiscount
                + breakfastCost
                + serviceSurcharge;

            // Booking status
            string bookingStatus = "APPROVED";

            // Clear old ListBox data
            listoutput.Items.Clear();

            // Add information to ListBox
            listoutput.Items.Add("===== BOOKING DETAILS =====");
            listoutput.Items.Add("Guest Name: " + guestName);
            listoutput.Items.Add("Guest Age: " + age);
            listoutput.Items.Add("Number of Guests: " + guests);
            listoutput.Items.Add("Number of Nights: " + nights);
            listoutput.Items.Add("Room Type: " + roomType);
            listoutput.Items.Add("Rate Per Night: $" + rate.ToString("0.00"));
            listoutput.Items.Add("Basic Room Cost: $" + basicRoomCost.ToString("0.00"));
            listoutput.Items.Add("Stay Discount: $" + stayDiscount.ToString("0.00"));
            listoutput.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
            listoutput.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0.00"));
            listoutput.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("0.00"));
            listoutput.Items.Add("----------------------------");
            listoutput.Items.Add("Final Cost: $" + finalCost.ToString("0.00"));
            listoutput.Items.Add("Booking Status: " + bookingStatus);

            // MessageBox
            MessageBox.Show(
                "Booking Approved!\n\n" +
                "Guest Name: " + guestName + "\n" +
                "Room Type: " + roomType + "\n" +
                "Final Cost: $" + finalCost.ToString("0.00"),
                "Hotel Booking System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


        }
        
        private void bclear_Click(object sender, EventArgs e)
        {
            txtGN.Clear();
            textGA.Clear();
            textNOFN.Clear();
             textNOFG.Clear();

           rstandard.Checked = false;
           rnormal.Checked = false;
            rhight.Checked = false;

            checkedBfast.Checked = false;

            listoutput.Items.Clear();

            txtGN.Focus();
        }
    }
}
