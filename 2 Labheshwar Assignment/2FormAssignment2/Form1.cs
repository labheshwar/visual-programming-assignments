using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FormAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headerLabel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, headerLabel.DisplayRectangle, Color.Lime, ButtonBorderStyle.Solid);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextBox.Text != "" && nameTextBox.Text != "")
            {
                welcomeRichTextBox.Visible = true;
                welcomeRichTextBox.Text = "Welcome Student #"
                    + studentIdTextBox.Text
                    + Environment.NewLine + nameTextBox.Text;

                webDesRadioButton.Enabled = true;
                webDevRadioButton.Enabled = true;
                dotNetRadioButton.Enabled = true;
                winFormRadioButton.Enabled = true;
                javaDevRadioButton.Enabled = true;                
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webDesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageVisibleCheckBox.Checked)
            {
                coursesPictureBox.Image = _2FormAssignment2.Properties.Resources.webdes;
                promotionsTextBox.Text = "Learn essential tech skills like HTML, CSS + Bootstrap and JS) at the cheapest price";
            }
        }

        private void webDevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageVisibleCheckBox.Checked)
            {
                coursesPictureBox.Image = _2FormAssignment2.Properties.Resources.mern;
                promotionsTextBox.Text = "Learn advance full stack web development at cheapest";
            }
        }

        private void winFormRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageVisibleCheckBox.Checked)
            {
                coursesPictureBox.Image = _2FormAssignment2.Properties.Resources.winform;
                promotionsTextBox.Text = "Learn Visual Programming in C# and become a windows developer";
            }
        }

        private void dotNetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageVisibleCheckBox.Checked)
            {
                coursesPictureBox.Image = _2FormAssignment2.Properties.Resources.dotnet;
                promotionsTextBox.Text = "Learn the most demanding skill in the market at absolute cheap price";
            }
        }

        private void javaDevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageVisibleCheckBox.Checked)
            {
                coursesPictureBox.Image = _2FormAssignment2.Properties.Resources.javadev;
                promotionsTextBox.Text = "Learn the most high paid skill at the cheapest price";
            }
        }
    }
}
