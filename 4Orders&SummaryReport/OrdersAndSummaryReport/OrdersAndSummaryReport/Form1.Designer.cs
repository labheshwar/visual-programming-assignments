namespace OrdersAndSummaryReport
{
    partial class OrderAndSummaryReportForm
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
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.noCourseRadioButton = new System.Windows.Forms.RadioButton();
            this.mlRadioButton = new System.Windows.Forms.RadioButton();
            this.appDevRadioButton = new System.Windows.Forms.RadioButton();
            this.webDevRadioButton = new System.Windows.Forms.RadioButton();
            this.extrasGroupBox = new System.Windows.Forms.GroupBox();
            this.jobPlacementCheckBox = new System.Windows.Forms.CheckBox();
            this.mentorshipCheckBox = new System.Windows.Forms.CheckBox();
            this.codingResourcesCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.selectCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.flutterDevRadioButton = new System.Windows.Forms.RadioButton();
            this.iosDevRadioButton = new System.Windows.Forms.RadioButton();
            this.androidDevRadioButton = new System.Windows.Forms.RadioButton();
            this.appDevLabel = new System.Windows.Forms.Label();
            this.angularRadioButton = new System.Windows.Forms.RadioButton();
            this.reactJsRadioButton = new System.Windows.Forms.RadioButton();
            this.webDevLabel = new System.Windows.Forms.Label();
            this.enrollButton = new System.Windows.Forms.Button();
            this.enrollmentCompleteButton = new System.Windows.Forms.Button();
            this.summaryReportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.coursesGroupBox.SuspendLayout();
            this.extrasGroupBox.SuspendLayout();
            this.selectCourseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.Controls.Add(this.noCourseRadioButton);
            this.coursesGroupBox.Controls.Add(this.mlRadioButton);
            this.coursesGroupBox.Controls.Add(this.appDevRadioButton);
            this.coursesGroupBox.Controls.Add(this.webDevRadioButton);
            this.coursesGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesGroupBox.Location = new System.Drawing.Point(33, 47);
            this.coursesGroupBox.Name = "coursesGroupBox";
            this.coursesGroupBox.Size = new System.Drawing.Size(391, 217);
            this.coursesGroupBox.TabIndex = 0;
            this.coursesGroupBox.TabStop = false;
            this.coursesGroupBox.Text = "Courses";
            // 
            // noCourseRadioButton
            // 
            this.noCourseRadioButton.AutoSize = true;
            this.noCourseRadioButton.Checked = true;
            this.noCourseRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCourseRadioButton.Location = new System.Drawing.Point(257, 173);
            this.noCourseRadioButton.Name = "noCourseRadioButton";
            this.noCourseRadioButton.Size = new System.Drawing.Size(104, 28);
            this.noCourseRadioButton.TabIndex = 3;
            this.noCourseRadioButton.TabStop = true;
            this.noCourseRadioButton.Text = "invisible";
            this.noCourseRadioButton.UseVisualStyleBackColor = true;
            this.noCourseRadioButton.Visible = false;
            // 
            // mlRadioButton
            // 
            this.mlRadioButton.AutoSize = true;
            this.mlRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlRadioButton.Location = new System.Drawing.Point(17, 137);
            this.mlRadioButton.Name = "mlRadioButton";
            this.mlRadioButton.Size = new System.Drawing.Size(235, 28);
            this.mlRadioButton.TabIndex = 2;
            this.mlRadioButton.Text = "Machine Learning 99.99";
            this.mlRadioButton.UseVisualStyleBackColor = true;
            // 
            // appDevRadioButton
            // 
            this.appDevRadioButton.AutoSize = true;
            this.appDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDevRadioButton.Location = new System.Drawing.Point(17, 94);
            this.appDevRadioButton.Name = "appDevRadioButton";
            this.appDevRadioButton.Size = new System.Drawing.Size(237, 28);
            this.appDevRadioButton.TabIndex = 1;
            this.appDevRadioButton.Text = "App Development 89.99";
            this.appDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // webDevRadioButton
            // 
            this.webDevRadioButton.AutoSize = true;
            this.webDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDevRadioButton.Location = new System.Drawing.Point(17, 47);
            this.webDevRadioButton.Name = "webDevRadioButton";
            this.webDevRadioButton.Size = new System.Drawing.Size(239, 28);
            this.webDevRadioButton.TabIndex = 0;
            this.webDevRadioButton.Text = "Web Development 79.99";
            this.webDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // extrasGroupBox
            // 
            this.extrasGroupBox.Controls.Add(this.jobPlacementCheckBox);
            this.extrasGroupBox.Controls.Add(this.mentorshipCheckBox);
            this.extrasGroupBox.Controls.Add(this.codingResourcesCheckBox);
            this.extrasGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasGroupBox.Location = new System.Drawing.Point(33, 292);
            this.extrasGroupBox.Name = "extrasGroupBox";
            this.extrasGroupBox.Size = new System.Drawing.Size(391, 194);
            this.extrasGroupBox.TabIndex = 4;
            this.extrasGroupBox.TabStop = false;
            this.extrasGroupBox.Text = "Extras - $9.99 each ";
            // 
            // jobPlacementCheckBox
            // 
            this.jobPlacementCheckBox.AutoSize = true;
            this.jobPlacementCheckBox.Location = new System.Drawing.Point(17, 124);
            this.jobPlacementCheckBox.Name = "jobPlacementCheckBox";
            this.jobPlacementCheckBox.Size = new System.Drawing.Size(303, 33);
            this.jobPlacementCheckBox.TabIndex = 2;
            this.jobPlacementCheckBox.Text = "Job Placement Assistance ";
            this.jobPlacementCheckBox.UseVisualStyleBackColor = true;
            // 
            // mentorshipCheckBox
            // 
            this.mentorshipCheckBox.AutoSize = true;
            this.mentorshipCheckBox.Location = new System.Drawing.Point(17, 85);
            this.mentorshipCheckBox.Name = "mentorshipCheckBox";
            this.mentorshipCheckBox.Size = new System.Drawing.Size(247, 33);
            this.mentorshipCheckBox.TabIndex = 1;
            this.mentorshipCheckBox.Text = "Personal Mentorship";
            this.mentorshipCheckBox.UseVisualStyleBackColor = true;
            // 
            // codingResourcesCheckBox
            // 
            this.codingResourcesCheckBox.AutoSize = true;
            this.codingResourcesCheckBox.Location = new System.Drawing.Point(17, 46);
            this.codingResourcesCheckBox.Name = "codingResourcesCheckBox";
            this.codingResourcesCheckBox.Size = new System.Drawing.Size(318, 33);
            this.codingResourcesCheckBox.TabIndex = 0;
            this.codingResourcesCheckBox.Text = "Access To Coding Resources";
            this.codingResourcesCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(45, 512);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(205, 29);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Number of Persons";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(256, 514);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(59, 30);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.Text = "0";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(256, 563);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.ReadOnly = true;
            this.itemPriceTextBox.Size = new System.Drawing.Size(112, 32);
            this.itemPriceTextBox.TabIndex = 8;
            this.itemPriceTextBox.TabStop = false;
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLabel.Location = new System.Drawing.Point(45, 559);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(115, 29);
            this.itemPriceLabel.TabIndex = 7;
            this.itemPriceLabel.Text = "Item Price";
            // 
            // selectCourseGroupBox
            // 
            this.selectCourseGroupBox.Controls.Add(this.flutterDevRadioButton);
            this.selectCourseGroupBox.Controls.Add(this.iosDevRadioButton);
            this.selectCourseGroupBox.Controls.Add(this.androidDevRadioButton);
            this.selectCourseGroupBox.Controls.Add(this.appDevLabel);
            this.selectCourseGroupBox.Controls.Add(this.angularRadioButton);
            this.selectCourseGroupBox.Controls.Add(this.reactJsRadioButton);
            this.selectCourseGroupBox.Controls.Add(this.webDevLabel);
            this.selectCourseGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCourseGroupBox.Location = new System.Drawing.Point(480, 64);
            this.selectCourseGroupBox.Name = "selectCourseGroupBox";
            this.selectCourseGroupBox.Size = new System.Drawing.Size(353, 307);
            this.selectCourseGroupBox.TabIndex = 9;
            this.selectCourseGroupBox.TabStop = false;
            this.selectCourseGroupBox.Text = "Select the course type";
            // 
            // flutterDevRadioButton
            // 
            this.flutterDevRadioButton.AutoSize = true;
            this.flutterDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flutterDevRadioButton.Location = new System.Drawing.Point(37, 263);
            this.flutterDevRadioButton.Name = "flutterDevRadioButton";
            this.flutterDevRadioButton.Size = new System.Drawing.Size(209, 28);
            this.flutterDevRadioButton.TabIndex = 6;
            this.flutterDevRadioButton.TabStop = true;
            this.flutterDevRadioButton.Text = "Flutter Development";
            this.flutterDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // iosDevRadioButton
            // 
            this.iosDevRadioButton.AutoSize = true;
            this.iosDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iosDevRadioButton.Location = new System.Drawing.Point(37, 229);
            this.iosDevRadioButton.Name = "iosDevRadioButton";
            this.iosDevRadioButton.Size = new System.Drawing.Size(184, 28);
            this.iosDevRadioButton.TabIndex = 5;
            this.iosDevRadioButton.TabStop = true;
            this.iosDevRadioButton.Text = "iOS Development";
            this.iosDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // androidDevRadioButton
            // 
            this.androidDevRadioButton.AutoSize = true;
            this.androidDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.androidDevRadioButton.Location = new System.Drawing.Point(37, 195);
            this.androidDevRadioButton.Name = "androidDevRadioButton";
            this.androidDevRadioButton.Size = new System.Drawing.Size(215, 28);
            this.androidDevRadioButton.TabIndex = 4;
            this.androidDevRadioButton.TabStop = true;
            this.androidDevRadioButton.Text = "Andoid Development";
            this.androidDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // appDevLabel
            // 
            this.appDevLabel.AutoSize = true;
            this.appDevLabel.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDevLabel.Location = new System.Drawing.Point(6, 157);
            this.appDevLabel.Name = "appDevLabel";
            this.appDevLabel.Size = new System.Drawing.Size(179, 27);
            this.appDevLabel.TabIndex = 3;
            this.appDevLabel.Text = "App Development";
            // 
            // angularRadioButton
            // 
            this.angularRadioButton.AutoSize = true;
            this.angularRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angularRadioButton.Location = new System.Drawing.Point(37, 111);
            this.angularRadioButton.Name = "angularRadioButton";
            this.angularRadioButton.Size = new System.Drawing.Size(119, 28);
            this.angularRadioButton.TabIndex = 2;
            this.angularRadioButton.TabStop = true;
            this.angularRadioButton.Text = "Angular.js";
            this.angularRadioButton.UseVisualStyleBackColor = true;
            // 
            // reactJsRadioButton
            // 
            this.reactJsRadioButton.AutoSize = true;
            this.reactJsRadioButton.Checked = true;
            this.reactJsRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactJsRadioButton.Location = new System.Drawing.Point(37, 77);
            this.reactJsRadioButton.Name = "reactJsRadioButton";
            this.reactJsRadioButton.Size = new System.Drawing.Size(101, 28);
            this.reactJsRadioButton.TabIndex = 1;
            this.reactJsRadioButton.TabStop = true;
            this.reactJsRadioButton.Text = "React.js";
            this.reactJsRadioButton.UseVisualStyleBackColor = true;
            // 
            // webDevLabel
            // 
            this.webDevLabel.AutoSize = true;
            this.webDevLabel.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDevLabel.Location = new System.Drawing.Point(6, 43);
            this.webDevLabel.Name = "webDevLabel";
            this.webDevLabel.Size = new System.Drawing.Size(182, 27);
            this.webDevLabel.TabIndex = 0;
            this.webDevLabel.Text = "Web Development";
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButton.Location = new System.Drawing.Point(594, 385);
            this.enrollButton.Margin = new System.Windows.Forms.Padding(10);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(239, 50);
            this.enrollButton.TabIndex = 10;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // enrollmentCompleteButton
            // 
            this.enrollmentCompleteButton.Enabled = false;
            this.enrollmentCompleteButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentCompleteButton.Location = new System.Drawing.Point(594, 443);
            this.enrollmentCompleteButton.Margin = new System.Windows.Forms.Padding(10);
            this.enrollmentCompleteButton.Name = "enrollmentCompleteButton";
            this.enrollmentCompleteButton.Size = new System.Drawing.Size(239, 50);
            this.enrollmentCompleteButton.TabIndex = 11;
            this.enrollmentCompleteButton.Text = "Enrollment Complete";
            this.enrollmentCompleteButton.UseVisualStyleBackColor = true;
            this.enrollmentCompleteButton.Click += new System.EventHandler(this.enrollmentCompleteButton_Click);
            // 
            // summaryReportButton
            // 
            this.summaryReportButton.Enabled = false;
            this.summaryReportButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryReportButton.Location = new System.Drawing.Point(594, 503);
            this.summaryReportButton.Margin = new System.Windows.Forms.Padding(10);
            this.summaryReportButton.Name = "summaryReportButton";
            this.summaryReportButton.Size = new System.Drawing.Size(239, 50);
            this.summaryReportButton.TabIndex = 12;
            this.summaryReportButton.Text = "Summary Report";
            this.summaryReportButton.UseVisualStyleBackColor = true;
            this.summaryReportButton.Click += new System.EventHandler(this.summaryReportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(594, 563);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(239, 50);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrderAndSummaryReportForm
            // 
            this.AcceptButton = this.enrollButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(852, 625);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryReportButton);
            this.Controls.Add(this.enrollmentCompleteButton);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.selectCourseGroupBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.extrasGroupBox);
            this.Controls.Add(this.coursesGroupBox);
            this.Name = "OrderAndSummaryReportForm";
            this.Text = "Order and Summary Report";
            this.coursesGroupBox.ResumeLayout(false);
            this.coursesGroupBox.PerformLayout();
            this.extrasGroupBox.ResumeLayout(false);
            this.extrasGroupBox.PerformLayout();
            this.selectCourseGroupBox.ResumeLayout(false);
            this.selectCourseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.RadioButton webDevRadioButton;
        private System.Windows.Forms.RadioButton noCourseRadioButton;
        private System.Windows.Forms.RadioButton mlRadioButton;
        private System.Windows.Forms.RadioButton appDevRadioButton;
        private System.Windows.Forms.GroupBox extrasGroupBox;
        private System.Windows.Forms.CheckBox codingResourcesCheckBox;
        private System.Windows.Forms.CheckBox jobPlacementCheckBox;
        private System.Windows.Forms.CheckBox mentorshipCheckBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.GroupBox selectCourseGroupBox;
        private System.Windows.Forms.RadioButton flutterDevRadioButton;
        private System.Windows.Forms.RadioButton iosDevRadioButton;
        private System.Windows.Forms.RadioButton androidDevRadioButton;
        private System.Windows.Forms.Label appDevLabel;
        private System.Windows.Forms.RadioButton reactJsRadioButton;
        private System.Windows.Forms.Label webDevLabel;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button enrollmentCompleteButton;
        private System.Windows.Forms.Button summaryReportButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton angularRadioButton;
    }
}

