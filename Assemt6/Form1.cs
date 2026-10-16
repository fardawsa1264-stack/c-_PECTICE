using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assemt6
{
    public partial class Form1 : Form
    {
        // Ticket prices
        const double FIRST_CLASS_PRICE = 500;
        const double NORMAL_CLASS_PRICE = 300;
        const double BUSINESS_CLASS_PRICE = 700;

        // Stores whether the booking is valid
        bool bookingApproved = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bcalculate_Click(object sender, EventArgs e)
        {      
            // Get passenger name
            string passengerName = txtpassengerName.Text.Trim();

            // Check passenger name
            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            // TryParse for Age, Tickets and Baggage Weight
            if (!int.TryParse(txtpassengerAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                return;
            }

            if (!int.TryParse(txtnumberoftickets.Text, out int tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            if (!double.TryParse(txtBaggaggeweight.Text, out double baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            // Age must be between 1 and 100
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                return;
            }

            // Number of tickets must be between 1 and 5
            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            // Baggage cannot be negative
            if (baggageWeight < 0)
            {
                MessageBox.Show("Baggage weight cannot be negative.");
                return;
            }

            // Maximum baggage is 50 kg per passenger

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                bookingApproved = false;
                return;
            }

            // Check travel class
            if (!rfirtsclss.Checked &&
                !rnormalclass.Checked &&
                !rbussinclass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Passenger below 12 cannot book First Class
            if (age < 12 && rfirtsclss.Checked)
            {
                bookingApproved = false;

                MessageBox.Show(
                    "Booking rejected: Passengers below 12 years cannot book First Class."
                );

                return;
            }

            // Booking is approved
            bookingApproved = true;

            // Select ticket price
            double ticketPrice = 0;
            string travelClass = "";

            if (rfirtsclss.Checked)
            {
                ticketPrice = FIRST_CLASS_PRICE;
                travelClass = "First Class";
            }
            else if (rnormalclass.Checked)
            {
                ticketPrice = NORMAL_CLASS_PRICE;
                travelClass = "Normal Class";
            }
            else if (rbussinclass.Checked)
            {
                ticketPrice = BUSINESS_CLASS_PRICE;
                travelClass = "Business Class";
            }

            // Basic ticket cost
            double basicCost = ticketPrice * tickets;

            // Ticket discount
            double ticketDiscountRate = 0;

            if (tickets >= 5)
            {
                ticketDiscountRate = 0.10;
            }
            else if (tickets >= 3)
            {
                ticketDiscountRate = 0.05;
            }

            double ticketDiscount = basicCost * ticketDiscountRate;

            // Age discount
            double ageDiscountRate = 0;

            if (age < 12)
            {
                ageDiscountRate = 0.20;
            }
            else if (age >= 60)
            {
                ageDiscountRate = 0.10;
            }

            double ageDiscount = basicCost * ageDiscountRate;

            // Travel insurance
            double insuranceCost = 0;

            if (chekedaddTIN.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // Total cost
            double totalCost =
                basicCost
                - ticketDiscount
                - ageDiscount
                + insuranceCost;

            // Display booking details
            listBookingDetail.Items.Clear();

            listBookingDetail.Items.Add("AIRLINE BOOKING DETAILS");
            listBookingDetail.Items.Add("--------------------------------");
            listBookingDetail.Items.Add("Passenger Name: " + passengerName);
          listBookingDetail.Items.Add("Passenger Age: " + age);
         listBookingDetail.Items.Add("Number of Tickets: " + tickets);
           listBookingDetail.Items.Add("Baggage Weight: " + baggageWeight + " kg");
           listBookingDetail.Items.Add("Travel Class: " + travelClass);
        listBookingDetail.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("0.00"));
           listBookingDetail.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("0.00"));
           listBookingDetail.Items.Add("Age Discount: $" + ageDiscount.ToString("0.00"));
           listBookingDetail.Items.Add("Travel Insurance: $" + insuranceCost.ToString("0.00"));
        listBookingDetail.Items.Add("--------------------------------");
            listBookingDetail.Items.Add("Total Cost: $" + totalCost.ToString("0.00"));
          listBookingDetail.Items.Add("Booking Approved: " + bookingApproved);

            MessageBox.Show("Booking approved successfully!");
        }

        
        private void bclear_Click(object sender, EventArgs e)
        {
          txtpassengerName.Clear();
           txtpassengerAge.Clear();
            txtnumberoftickets.Clear();
            txtBaggaggeweight.Clear();

           rfirtsclss.Checked = false;
            rnormalclass.Checked = false;
           rbussinclass.Checked = false;

         chekedaddTIN.Checked = false;

          listBookingDetail.Items.Clear();

            bookingApproved = false;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

     

