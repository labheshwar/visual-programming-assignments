<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.coursesButton = New System.Windows.Forms.Button()
        Me.aboutUsButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.loginRegisterButton = New System.Windows.Forms.Button()
        Me.watermarksLabel = New System.Windows.Forms.Label()
        Me.promotionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.BackColor = System.Drawing.Color.Black
        Me.headerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.ForeColor = System.Drawing.Color.White
        Me.headerLabel.Location = New System.Drawing.Point(223, 27)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(476, 57)
        Me.headerLabel.TabIndex = 0
        Me.headerLabel.Text = "CodeLab by Labesh"
        Me.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'homeButton
        '
        Me.homeButton.BackColor = System.Drawing.Color.Lime
        Me.homeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homeButton.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeButton.ForeColor = System.Drawing.Color.Black
        Me.homeButton.Location = New System.Drawing.Point(43, 126)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(312, 75)
        Me.homeButton.TabIndex = 1
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = False
        '
        'coursesButton
        '
        Me.coursesButton.BackColor = System.Drawing.Color.Lime
        Me.coursesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.coursesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.coursesButton.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursesButton.ForeColor = System.Drawing.Color.Black
        Me.coursesButton.Location = New System.Drawing.Point(43, 207)
        Me.coursesButton.Name = "coursesButton"
        Me.coursesButton.Size = New System.Drawing.Size(312, 75)
        Me.coursesButton.TabIndex = 2
        Me.coursesButton.Text = "Courses"
        Me.coursesButton.UseVisualStyleBackColor = False
        '
        'aboutUsButton
        '
        Me.aboutUsButton.BackColor = System.Drawing.Color.Lime
        Me.aboutUsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aboutUsButton.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutUsButton.ForeColor = System.Drawing.Color.Black
        Me.aboutUsButton.Location = New System.Drawing.Point(43, 288)
        Me.aboutUsButton.Name = "aboutUsButton"
        Me.aboutUsButton.Size = New System.Drawing.Size(312, 75)
        Me.aboutUsButton.TabIndex = 3
        Me.aboutUsButton.Text = "About Us"
        Me.aboutUsButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Lime
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.Black
        Me.exitButton.Location = New System.Drawing.Point(43, 450)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(312, 75)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'loginRegisterButton
        '
        Me.loginRegisterButton.BackColor = System.Drawing.Color.Lime
        Me.loginRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginRegisterButton.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginRegisterButton.ForeColor = System.Drawing.Color.Black
        Me.loginRegisterButton.Location = New System.Drawing.Point(43, 369)
        Me.loginRegisterButton.Name = "loginRegisterButton"
        Me.loginRegisterButton.Size = New System.Drawing.Size(312, 75)
        Me.loginRegisterButton.TabIndex = 5
        Me.loginRegisterButton.Text = "Login/Register"
        Me.loginRegisterButton.UseVisualStyleBackColor = False
        '
        'watermarksLabel
        '
        Me.watermarksLabel.AutoSize = True
        Me.watermarksLabel.BackColor = System.Drawing.Color.Transparent
        Me.watermarksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.watermarksLabel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.watermarksLabel.ForeColor = System.Drawing.Color.White
        Me.watermarksLabel.Location = New System.Drawing.Point(363, 544)
        Me.watermarksLabel.Name = "watermarksLabel"
        Me.watermarksLabel.Size = New System.Drawing.Size(502, 44)
        Me.watermarksLabel.TabIndex = 6
        Me.watermarksLabel.Text = "Programmed By Labheshwar"
        Me.watermarksLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'promotionLabel
        '
        Me.promotionLabel.AutoSize = True
        Me.promotionLabel.BackColor = System.Drawing.Color.Black
        Me.promotionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.promotionLabel.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.promotionLabel.ForeColor = System.Drawing.Color.Lime
        Me.promotionLabel.Location = New System.Drawing.Point(387, 305)
        Me.promotionLabel.Name = "promotionLabel"
        Me.promotionLabel.Size = New System.Drawing.Size(478, 43)
        Me.promotionLabel.TabIndex = 7
        Me.promotionLabel.Text = "50% off for the first 20 people."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.AssignmentNumber1.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(877, 609)
        Me.Controls.Add(Me.promotionLabel)
        Me.Controls.Add(Me.watermarksLabel)
        Me.Controls.Add(Me.loginRegisterButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.aboutUsButton)
        Me.Controls.Add(Me.coursesButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.headerLabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents headerLabel As System.Windows.Forms.Label
    Friend WithEvents homeButton As System.Windows.Forms.Button
    Friend WithEvents coursesButton As System.Windows.Forms.Button
    Friend WithEvents aboutUsButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents loginRegisterButton As System.Windows.Forms.Button
    Friend WithEvents watermarksLabel As System.Windows.Forms.Label
    Friend WithEvents promotionLabel As System.Windows.Forms.Label

End Class
