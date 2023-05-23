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
            this.headerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.coursesGroupBox.SuspendLayout();
            this.extrasGroupBox.SuspendLayout();
            this.selectCourseGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.Controls.Add(this.noCourseRadioButton);
            this.coursesGroupBox.Controls.Add(this.mlRadioButton);
            this.coursesGroupBox.Controls.Add(this.appDevRadioButton);
            this.coursesGroupBox.Controls.Add(this.webDevRadioButton);
            this.coursesGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesGroupBox.Location = new System.Drawing.Point(32, 149);
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
            this.mlRadioButton.CheckedChanged += new System.EventHandler(this.mlRadioButton_CheckedChanged);
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
            this.appDevRadioButton.CheckedChanged += new System.EventHandler(this.appDevRadioButton_CheckedChanged);
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
            this.webDevRadioButton.CheckedChanged += new System.EventHandler(this.webDevRadioButton_CheckedChanged);
            // 
            // extrasGroupBox
            // 
            this.extrasGroupBox.Controls.Add(this.jobPlacementCheckBox);
            this.extrasGroupBox.Controls.Add(this.mentorshipCheckBox);
            this.extrasGroupBox.Controls.Add(this.codingResourcesCheckBox);
            this.extrasGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasGroupBox.Location = new System.Drawing.Point(32, 394);
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
            this.jobPlacementCheckBox.CheckedChanged += new System.EventHandler(this.jobPlacementCheckBox_CheckedChanged);
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
            this.mentorshipCheckBox.CheckedChanged += new System.EventHandler(this.mentorshipCheckBox_CheckedChanged);
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
            this.codingResourcesCheckBox.CheckedChanged += new System.EventHandler(this.codingResourcesCheckBox_CheckedChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(885, 188);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(205, 29);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Number of Persons";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(1096, 190);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(59, 30);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.Text = "0";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(1096, 239);
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
            this.itemPriceLabel.Location = new System.Drawing.Point(885, 235);
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
            this.selectCourseGroupBox.Location = new System.Drawing.Point(479, 166);
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
            this.enrollButton.Location = new System.Drawing.Point(1029, 322);
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
            this.enrollmentCompleteButton.Location = new System.Drawing.Point(1029, 380);
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
            this.summaryReportButton.Location = new System.Drawing.Point(1029, 440);
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
            this.exitButton.Location = new System.Drawing.Point(1029, 500);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(239, 50);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(440, 64);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(435, 59);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "CodeLab By Labesh";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Enabled = false;
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollToolStripMenuItem,
            this.enrollmentCompleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // enrollToolStripMenuItem
            // 
            this.enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            this.enrollToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.enrollToolStripMenuItem.Text = "Enroll";
            this.enrollToolStripMenuItem.Click += new System.EventHandler(this.enrollToolStripMenuItem_Click);
            // 
            // enrollmentCompleteToolStripMenuItem
            // 
            this.enrollmentCompleteToolStripMenuItem.Name = "enrollmentCompleteToolStripMenuItem";
            this.enrollmentCompleteToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.enrollmentCompleteToolStripMenuItem.Text = "Enrollment Complete";
            this.enrollmentCompleteToolStripMenuItem.Click += new System.EventHandler(this.enrollmentCompleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OrderAndSummaryReportForm
            // 
            this.AcceptButton = this.enrollButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1303, 625);
            this.Controls.Add(this.headerLabel);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderAndSummaryReportForm";
            this.Text = "Order and Summary Report";
            this.coursesGroupBox.ResumeLayout(false);
            this.coursesGroupBox.PerformLayout();
            this.extrasGroupBox.ResumeLayout(false);
            this.extrasGroupBox.PerformLayout();
            this.selectCourseGroupBox.ResumeLayout(false);
            this.selectCourseGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

