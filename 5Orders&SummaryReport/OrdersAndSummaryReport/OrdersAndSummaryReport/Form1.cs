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
        decimal coursePriceDecimal, totalOrderDecimal, totalSalesDecimal, courseDecimal;
        int coursesInteger, ordersInteger;

        public OrderAndSummaryReportForm()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            enroll();
        }

        private void enrollmentCompleteButton_Click(object sender, EventArgs e)
        {
            enrollmentComplete(sender, e);
        }

        private void summaryReportButton_Click(object sender, EventArgs e)
        {
            summaryReport();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enroll();
        }

        private void enrollmentCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enrollmentComplete(sender, e);
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            summaryReport();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display information in a message box.

            string aboutString = "Programmed by Labheshwar\nVersion 1.1";
            string captionString =
            "About CodeLab By Labesh Courses Enrollment";
            MessageBox.Show(aboutString, captionString);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the label’s font.

            // Initialize the dialog box.
            fontDialog1.Font = headerLabel.Font;

            // Display the dialog box.
            fontDialog1.ShowDialog();

            // Assign the new font.
            headerLabel.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the form’s ForeColor.

            // Applies to all controls on the form that haven’t had their
            // ForeColor explicitly modified.

            // Initialize the dialog box.
            colorDialog1.Color = this.ForeColor;

            // Display the dialog box.
            colorDialog1.ShowDialog();

            // Assign the new color.
            this.ForeColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webDevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            findAndUpdateTextBox(sender);
        }

        private void appDevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            findAndUpdateTextBox(sender);
        }

        private void mlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            findAndUpdateTextBox(sender);
        }

        private void codingResourcesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateItemTextPrice();
        }

        private void mentorshipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateItemTextPrice();
        }

        private void jobPlacementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateItemTextPrice();
        }

        private void enroll()
        {
            // Add the current item price and quantity to the order.
            if (noCourseRadioButton.Checked)
            {
                MessageBox.Show("You must select a course.", "Missing Required Entry");
            }
            else
            {
                try
                {
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger > 0)
                    {
                        coursesInteger += quantityInteger;
                        totalOrderDecimal += courseDecimal * quantityInteger;
                        clearForNextItem();
                        enrollmentCompleteButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.", "Missing Required Entry");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
            }
        }

        private void enrollmentComplete(object sender, EventArgs e)
        {
            // Enrollment is complete, add to summay and clear order.
            // Check if the last enrollment was added to the total
            if (itemPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Enroll first!";
                responseDialogResult = MessageBox.Show(messageString, "Verify Last Enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
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
            summaryToolStripMenuItem.Enabled = true;
            enrollmentCompleteButton.Enabled = false;
            enrollmentCompleteToolStripMenuItem.Enabled = false;
            totalOrderDecimal = 0m;
        }

        private void summaryReport()
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

        private void clearForNextItem()
        {
            // Clear radio buttons, check boxes, text boxes.

            noCourseRadioButton.Checked = true;
            reactJsRadioButton.Checked = true;
            codingResourcesCheckBox.Checked = false;
            jobPlacementCheckBox.Checked = false;
            mentorshipCheckBox.Checked = false;
            itemPriceTextBox.Clear();
            quantityTextBox.Text = "1";
        }

        private decimal findExtrasPrice()
        {
            // Find price for additives.
            decimal extrasDecimal = 0;
            if (jobPlacementCheckBox.Checked)
            {
                extrasDecimal += 9.99m;
            }
            if (mentorshipCheckBox.Checked)
            {
                extrasDecimal += 9.99m;
            }
            if (jobPlacementCheckBox.Checked)
            {
                extrasDecimal += 9.99m;
            }
            return extrasDecimal;
        }

        private void findAndUpdateTextBox(object sender)
        {
            // Calculate and display the price for the selected item.
            // Handles all check boxes and radio buttons.

            // Cast the sender to a RadioButton type.
            RadioButton selectedCourseRadioBUtton = (RadioButton)sender;
            switch (selectedCourseRadioBUtton.Name)
            {
                case "webDevRadioButton":
                    coursePriceDecimal = 79.99m;
                    break;
                case "appDevRadioButton":
                    coursePriceDecimal = 89.99m;
                    break;
                case "mlRadioButton":
                    coursePriceDecimal = 99.99m;
                    break;
            }
            courseDecimal = coursePriceDecimal + findExtrasPrice();
            itemPriceTextBox.Text = courseDecimal.ToString("C");
        }

        private void updateItemTextPrice()
        {
            // Check price of additives and display current price.
            // Handles all three check boxes.

            courseDecimal = courseDecimal + 9.99m;
            itemPriceTextBox.Text = courseDecimal.ToString("C");
        }
    }
}
