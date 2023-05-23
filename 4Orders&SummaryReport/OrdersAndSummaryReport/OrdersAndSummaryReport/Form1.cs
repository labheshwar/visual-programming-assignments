using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersAndSummaryReport
{
    public partial class OrderAndSummaryReportForm : Form
    {
        // Declare Class Variables
        private decimal itemPriceDecimal, totalOrderDecimal, totalSalesDecimal;
        private int coursesInteger, ordersInteger;

        public OrderAndSummaryReportForm()
        {
            InitializeComponent();
        }

        private double totalItemPrice() {
            double itemPrice=0;
            if (webDevRadioButton.Checked)
            {
                itemPrice = 79.99;
            }
            else if (appDevRadioButton.Checked)
            {
                itemPrice = 89.99;
            }
            else if (mlRadioButton.Checked)
            {
                itemPrice = 99.99;
            }
            if (mentorshipCheckBox.Checked)
            {
                itemPrice += 9.99;
            }
            if (jobPlacementCheckBox.Checked)
            {
                itemPrice += 9.99;
            }
            if (codingResourcesCheckBox.Checked)
            {
                itemPrice += 9.99;
            }
            return itemPrice;
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.
            if (noCourseRadioButton.Checked)
            {
                MessageBox.Show("You must select a course.", "Missing Required Entry");
            }
            else {
                try
                {
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger != 0)
                    {
                        coursesInteger += quantityInteger;
                        itemPriceDecimal = (decimal)totalItemPrice();
                        totalOrderDecimal += itemPriceDecimal * quantityInteger;
                        enrollmentCompleteButton.Enabled = true;

                        // Reset Default for next item.
                        noCourseRadioButton.Checked = true;
                        reactJsRadioButton.Checked = true;
                        codingResourcesCheckBox.Checked = false;
                        jobPlacementCheckBox.Checked = false;
                        mentorshipCheckBox.Checked = false;
                        itemPriceTextBox.Clear();
                        quantityTextBox.Text = "1";

                    }
                    else {
                        MessageBox.Show("Please enter a quantity.", "Missing Required Entry");
                    }
                } catch (FormatException) {
                    MessageBox.Show("Invalid Quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
            }
        }

        private void enrollmentCompleteButton_Click(object sender, EventArgs e)
        {
            // Enrollment is complete, add to summay and clear order.
            // Check if the last enrollment was added to the total
            if (itemPriceTextBox.Text != "") {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Enroll first!";
                responseDialogResult = MessageBox.Show(messageString, "Verify Last Enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes) {
                    enrollButton_Click(sender, e);
                }
            }
            
            // Display amound due
            string dueString = "Amount Due " + totalOrderDecimal.ToString("C");
            MessageBox.Show(dueString, "Enrollment Complete");

            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;

            // Reset buttons and total for new order.
            summaryReportButton.Enabled = true;
            enrollmentCompleteButton.Enabled = false;
            totalOrderDecimal = 0m;
        }

        private void summaryReportButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.

            string summaryString = "Courses sold:   "
                    + coursesInteger.ToString()
                    + "\n\n" + "Number of Orders:   "
                    + ordersInteger.ToString()
                    + "\n\n" + "Total Sales:    "
                    + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, "CodeLab Courses Sold Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
