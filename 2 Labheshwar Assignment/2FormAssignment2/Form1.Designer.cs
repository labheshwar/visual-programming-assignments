namespace _2FormAssignment2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerLabel = new System.Windows.Forms.Label();
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.dotNetRadioButton = new System.Windows.Forms.RadioButton();
            this.winFormRadioButton = new System.Windows.Forms.RadioButton();
            this.javaDevRadioButton = new System.Windows.Forms.RadioButton();
            this.webDevRadioButton = new System.Windows.Forms.RadioButton();
            this.webDesRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.welcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.promotionsTextBox = new System.Windows.Forms.TextBox();
            this.coursesPictureBox = new System.Windows.Forms.PictureBox();
            this.imageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.coursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Black;
            this.headerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Lime;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1386, 61);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "CodeLab by Labesh";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerLabel_Paint);
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.BackColor = System.Drawing.Color.Lime;
            this.coursesGroupBox.BackgroundImage = global::_2FormAssignment2.Properties.Resources.R;
            this.coursesGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coursesGroupBox.Controls.Add(this.dotNetRadioButton);
            this.coursesGroupBox.Controls.Add(this.winFormRadioButton);
            this.coursesGroupBox.Controls.Add(this.javaDevRadioButton);
            this.coursesGroupBox.Controls.Add(this.webDevRadioButton);
            this.coursesGroupBox.Controls.Add(this.webDesRadioButton);
            this.coursesGroupBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.coursesGroupBox.Location = new System.Drawing.Point(26, 77);
            this.coursesGroupBox.Name = "coursesGroupBox";
            this.coursesGroupBox.Size = new System.Drawing.Size(480, 282);
            this.coursesGroupBox.TabIndex = 1;
            this.coursesGroupBox.TabStop = false;
            this.coursesGroupBox.Text = "COURSES WE OFFER";
            // 
            // dotNetRadioButton
            // 
            this.dotNetRadioButton.AutoSize = true;
            this.dotNetRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.dotNetRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotNetRadioButton.Enabled = false;
            this.dotNetRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotNetRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.dotNetRadioButton.Location = new System.Drawing.Point(53, 181);
            this.dotNetRadioButton.Name = "dotNetRadioButton";
            this.dotNetRadioButton.Size = new System.Drawing.Size(166, 28);
            this.dotNetRadioButton.TabIndex = 4;
            this.dotNetRadioButton.TabStop = true;
            this.dotNetRadioButton.Text = ".NET Developer";
            this.dotNetRadioButton.UseVisualStyleBackColor = false;
            this.dotNetRadioButton.CheckedChanged += new System.EventHandler(this.dotNetRadioButton_CheckedChanged);
            // 
            // winFormRadioButton
            // 
            this.winFormRadioButton.AutoSize = true;
            this.winFormRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.winFormRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winFormRadioButton.Enabled = false;
            this.winFormRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winFormRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.winFormRadioButton.Location = new System.Drawing.Point(53, 136);
            this.winFormRadioButton.Name = "winFormRadioButton";
            this.winFormRadioButton.Size = new System.Drawing.Size(260, 28);
            this.winFormRadioButton.TabIndex = 3;
            this.winFormRadioButton.TabStop = true;
            this.winFormRadioButton.Text = "Windows Forms Developer";
            this.winFormRadioButton.UseVisualStyleBackColor = false;
            this.winFormRadioButton.CheckedChanged += new System.EventHandler(this.winFormRadioButton_CheckedChanged);
            // 
            // javaDevRadioButton
            // 
            this.javaDevRadioButton.AutoSize = true;
            this.javaDevRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.javaDevRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.javaDevRadioButton.Enabled = false;
            this.javaDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.javaDevRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.javaDevRadioButton.Location = new System.Drawing.Point(53, 231);
            this.javaDevRadioButton.Name = "javaDevRadioButton";
            this.javaDevRadioButton.Size = new System.Drawing.Size(233, 28);
            this.javaDevRadioButton.TabIndex = 5;
            this.javaDevRadioButton.TabStop = true;
            this.javaDevRadioButton.Text = "Java (Spring) Developer";
            this.javaDevRadioButton.UseVisualStyleBackColor = false;
            this.javaDevRadioButton.CheckedChanged += new System.EventHandler(this.javaDevRadioButton_CheckedChanged);
            // 
            // webDevRadioButton
            // 
            this.webDevRadioButton.AutoSize = true;
            this.webDevRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.webDevRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webDevRadioButton.Enabled = false;
            this.webDevRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDevRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.webDevRadioButton.Location = new System.Drawing.Point(53, 87);
            this.webDevRadioButton.Name = "webDevRadioButton";
            this.webDevRadioButton.Size = new System.Drawing.Size(311, 28);
            this.webDevRadioButton.TabIndex = 2;
            this.webDevRadioButton.TabStop = true;
            this.webDevRadioButton.Text = "Web Development (MERN Stack)";
            this.webDevRadioButton.UseVisualStyleBackColor = false;
            this.webDevRadioButton.CheckedChanged += new System.EventHandler(this.webDevRadioButton_CheckedChanged);
            // 
            // webDesRadioButton
            // 
            this.webDesRadioButton.AutoSize = true;
            this.webDesRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.webDesRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webDesRadioButton.Enabled = false;
            this.webDesRadioButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDesRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.webDesRadioButton.Location = new System.Drawing.Point(53, 42);
            this.webDesRadioButton.Name = "webDesRadioButton";
            this.webDesRadioButton.Size = new System.Drawing.Size(162, 28);
            this.webDesRadioButton.TabIndex = 1;
            this.webDesRadioButton.TabStop = true;
            this.webDesRadioButton.Text = "Web Designing";
            this.webDesRadioButton.UseVisualStyleBackColor = false;
            this.webDesRadioButton.CheckedChanged += new System.EventHandler(this.webDesRadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(845, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 29);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.BackColor = System.Drawing.Color.Black;
            this.studentIdLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentIdLabel.Location = new System.Drawing.Point(845, 198);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(119, 29);
            this.studentIdLabel.TabIndex = 3;
            this.studentIdLabel.Text = "Student ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Black;
            this.nameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Lime;
            this.nameTextBox.Location = new System.Drawing.Point(984, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 37);
            this.nameTextBox.TabIndex = 6;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BackColor = System.Drawing.Color.Black;
            this.studentIdTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox.ForeColor = System.Drawing.Color.Lime;
            this.studentIdTextBox.Location = new System.Drawing.Point(984, 190);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(221, 37);
            this.studentIdTextBox.TabIndex = 7;
            // 
            // welcomeRichTextBox
            // 
            this.welcomeRichTextBox.BackColor = System.Drawing.Color.Lime;
            this.welcomeRichTextBox.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.welcomeRichTextBox.Location = new System.Drawing.Point(850, 250);
            this.welcomeRichTextBox.Name = "welcomeRichTextBox";
            this.welcomeRichTextBox.Size = new System.Drawing.Size(355, 141);
            this.welcomeRichTextBox.TabIndex = 11;
            this.welcomeRichTextBox.Text = "";
            // 
            // promotionsTextBox
            // 
            this.promotionsTextBox.BackColor = System.Drawing.Color.Black;
            this.promotionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promotionsTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotionsTextBox.ForeColor = System.Drawing.Color.Lime;
            this.promotionsTextBox.Location = new System.Drawing.Point(850, 409);
            this.promotionsTextBox.MaximumSize = new System.Drawing.Size(355, 70);
            this.promotionsTextBox.MinimumSize = new System.Drawing.Size(355, 70);
            this.promotionsTextBox.Multiline = true;
            this.promotionsTextBox.Name = "promotionsTextBox";
            this.promotionsTextBox.Size = new System.Drawing.Size(355, 70);
            this.promotionsTextBox.TabIndex = 12;
            // 
            // coursesPictureBox
            // 
            this.coursesPictureBox.BackgroundImage = global::_2FormAssignment2.Properties.Resources.R;
            this.coursesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coursesPictureBox.Location = new System.Drawing.Point(26, 365);
            this.coursesPictureBox.Name = "coursesPictureBox";
            this.coursesPictureBox.Size = new System.Drawing.Size(480, 221);
            this.coursesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coursesPictureBox.TabIndex = 9;
            this.coursesPictureBox.TabStop = false;
            // 
            // imageVisibleCheckBox
            // 
            this.imageVisibleCheckBox.AutoSize = true;
            this.imageVisibleCheckBox.BackColor = System.Drawing.Color.Lime;
            this.imageVisibleCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageVisibleCheckBox.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageVisibleCheckBox.ForeColor = System.Drawing.Color.Black;
            this.imageVisibleCheckBox.Location = new System.Drawing.Point(26, 594);
            this.imageVisibleCheckBox.Name = "imageVisibleCheckBox";
            this.imageVisibleCheckBox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.imageVisibleCheckBox.Size = new System.Drawing.Size(211, 39);
            this.imageVisibleCheckBox.TabIndex = 0;
            this.imageVisibleCheckBox.Text = "Image Visible";
            this.imageVisibleCheckBox.UseVisualStyleBackColor = false;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Lime;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.Location = new System.Drawing.Point(1046, 488);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(159, 37);
            this.signInButton.TabIndex = 8;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Lime;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(1046, 581);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 37);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Lime;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.Black;
            this.printButton.Location = new System.Drawing.Point(1046, 535);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(159, 37);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.BackgroundImage = global::_2FormAssignment2.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1386, 645);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.imageVisibleCheckBox);
            this.Controls.Add(this.coursesPictureBox);
            this.Controls.Add(this.promotionsTextBox);
            this.Controls.Add(this.welcomeRichTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.coursesGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.coursesGroupBox.ResumeLayout(false);
            this.coursesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.RadioButton dotNetRadioButton;
        private System.Windows.Forms.RadioButton winFormRadioButton;
        private System.Windows.Forms.RadioButton javaDevRadioButton;
        private System.Windows.Forms.RadioButton webDevRadioButton;
        private System.Windows.Forms.RadioButton webDesRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.RichTextBox welcomeRichTextBox;
        private System.Windows.Forms.TextBox promotionsTextBox;
        private System.Windows.Forms.PictureBox coursesPictureBox;
        private System.Windows.Forms.CheckBox imageVisibleCheckBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button printButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}
        #endregion