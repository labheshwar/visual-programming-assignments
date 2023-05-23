/*Project: Sales Form
 *Programmer: Labheshwar
 *Description: This project inputs sales information for CodeLab by Labesh.
 * It calculates the extended price and discount for
 * a sale.
 * Uses variables, constants, and calculations.
 * Includes error trapping and summary calculations.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesForm
{
    public partial class CodeLabSalesForm : Form
    {
        private const decimal DISCOUNT_RATE_Decimal = 0.3m;
        private decimal totalAmountDecimal;
        private int numberTransactionsInteger;

        public CodeLabSalesForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare the variables
            int quantityInteger;
            decimal priceDecimal, extendedPriceDecimal, discountDecimal, amoundDueDecimal;

            try
            {
                // Convert input values to numeric and assign to variables.
                quantityInteger = int.Parse(quantityTextBox.Text);

                try
                {
                    priceDecimal = decimal.Parse(priceTextBox.Text);

                    // Calculate Values
                    extendedPriceDecimal = quantityInteger * priceDecimal;
                    discountDecimal = Decimal.Round((extendedPriceDecimal * DISCOUNT_RATE_Decimal), 2);
                    amoundDueDecimal = extendedPriceDecimal - discountDecimal;
                    totalAmountDecimal += amoundDueDecimal;
                    numberTransactionsInteger++;

                    // Format and display answers
                    extendedPriceTextBox.Text = extendedPriceDecimal.ToString("C");
                    discountTextBox.Text = discountDecimal.ToString("N");
                    amountDueTextBox.Text = amoundDueDecimal.ToString("C");

                    // Format and display and summary information.
                    totalAmountTextBox.Text = totalAmountDecimal.ToString("C");
                    numberTransactionsTextBox.Text = numberTransactionsInteger.ToString();
                }
                catch { 
                    // Invalid price.
                    MessageBox.Show("Invalid price.", "Data Error");
                    priceTextBox.Focus();
                    priceTextBox.SelectAll();
                }
            }
            catch { 
                // Invalid quantity.
                MessageBox.Show("Invalid quantity.", "Data Error");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            quantityTextBox.Clear();
            priceTextBox.Clear();
            discountTextBox.Clear();
            extendedPriceTextBox.Clear();
            amountDueTextBox.Clear();
            quantityTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the program

            this.Close();
        }
    }
}
