namespace SalesForm
{
    partial class CodeLabSalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.extendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.extendedPriceLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numberTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.numberTransactionsLabel = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(184, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(449, 59);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "CodeLab Sales Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Location = new System.Drawing.Point(57, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(279, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(250, 32);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(43, 104);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(64, 29);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(279, 43);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(250, 32);
            this.quantityTextBox.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(43, 42);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(204, 29);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Number of Courses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amountDueTextBox);
            this.groupBox2.Controls.Add(this.amountDueLabel);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.discountLabel);
            this.groupBox2.Controls.Add(this.extendedPriceTextBox);
            this.groupBox2.Controls.Add(this.extendedPriceLabel);
            this.groupBox2.Location = new System.Drawing.Point(57, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Enabled = false;
            this.amountDueTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueTextBox.Location = new System.Drawing.Point(367, 174);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.Size = new System.Drawing.Size(250, 32);
            this.amountDueTextBox.TabIndex = 5;
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(138, 173);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(139, 29);
            this.amountDueLabel.TabIndex = 4;
            this.amountDueLabel.Text = "Amount Due";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Enabled = false;
            this.discountTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(367, 112);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(250, 32);
            this.discountTextBox.TabIndex = 3;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(138, 111);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(149, 29);
            this.discountLabel.TabIndex = 2;
            this.discountLabel.Text = "30% Discount";
            // 
            // extendedPriceTextBox
            // 
            this.extendedPriceTextBox.Enabled = false;
            this.extendedPriceTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedPriceTextBox.Location = new System.Drawing.Point(367, 50);
            this.extendedPriceTextBox.Name = "extendedPriceTextBox";
            this.extendedPriceTextBox.Size = new System.Drawing.Size(250, 32);
            this.extendedPriceTextBox.TabIndex = 1;
            // 
            // extendedPriceLabel
            // 
            this.extendedPriceLabel.AutoSize = true;
            this.extendedPriceLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedPriceLabel.Location = new System.Drawing.Point(138, 49);
            this.extendedPriceLabel.Name = "extendedPriceLabel";
            this.extendedPriceLabel.Size = new System.Drawing.Size(164, 29);
            this.extendedPriceLabel.TabIndex = 0;
            this.extendedPriceLabel.Text = "Extended Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numberTransactionsTextBox);
            this.groupBox3.Controls.Add(this.numberTransactionsLabel);
            this.groupBox3.Controls.Add(this.totalAmountTextBox);
            this.groupBox3.Controls.Add(this.totalAmountLabel);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(57, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 196);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary Information";
            // 
            // numberTransactionsTextBox
            // 
            this.numberTransactionsTextBox.Enabled = false;
            this.numberTransactionsTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTransactionsTextBox.Location = new System.Drawing.Point(367, 120);
            this.numberTransactionsTextBox.Name = "numberTransactionsTextBox";
            this.numberTransactionsTextBox.Size = new System.Drawing.Size(250, 32);
            this.numberTransactionsTextBox.TabIndex = 3;
            // 
            // numberTransactionsLabel
            // 
            this.numberTransactionsLabel.AutoSize = true;
            this.numberTransactionsLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTransactionsLabel.Location = new System.Drawing.Point(46, 119);
            this.numberTransactionsLabel.Name = "numberTransactionsLabel";
            this.numberTransactionsLabel.Size = new System.Drawing.Size(251, 29);
            this.numberTransactionsLabel.TabIndex = 2;
            this.numberTransactionsLabel.Text = "Number of Transactions";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Enabled = false;
            this.totalAmountTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(367, 58);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(250, 32);
            this.totalAmountTextBox.TabIndex = 1;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(46, 57);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(120, 29);
            this.totalAmountLabel.TabIndex = 0;
            this.totalAmountLabel.Text = "Total Sales";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(56, 824);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 39);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(251, 824);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(162, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(446, 824);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(162, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CodeLabSalesForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(793, 885);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headerLabel);
            this.Name = "CodeLabSalesForm";
            this.Text = "CodeLab By Labhesh Sales Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox extendedPriceTextBox;
        private System.Windows.Forms.Label extendedPriceLabel;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox numberTransactionsTextBox;
        private System.Windows.Forms.Label numberTransactionsLabel;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

