<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtCpassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.rdDoctor = New System.Windows.Forms.RadioButton()
        Me.rdRep = New System.Windows.Forms.RadioButton()
        Me.rdNurse = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSpeciality = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inner City Hospital"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Create Account"
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(288, 335)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(92, 37)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(401, 335)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 37)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "First Name: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Confirm Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(437, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Last Name: "
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(180, 126)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(191, 30)
        Me.txtFname.TabIndex = 1
        '
        'txtCpassword
        '
        Me.txtCpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpassword.Location = New System.Drawing.Point(564, 172)
        Me.txtCpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCpassword.Name = "txtCpassword"
        Me.txtCpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCpassword.Size = New System.Drawing.Size(191, 30)
        Me.txtCpassword.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(180, 170)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(191, 30)
        Me.txtPassword.TabIndex = 3
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(564, 126)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(191, 30)
        Me.txtLname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Date Of Birth: "
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.ItemHeight = 25
        Me.cmbMonth.Location = New System.Drawing.Point(180, 233)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(63, 33)
        Me.cmbMonth.TabIndex = 5
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.ItemHeight = 25
        Me.cmbDay.Location = New System.Drawing.Point(249, 233)
        Me.cmbDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(61, 33)
        Me.cmbDay.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.ItemHeight = 25
        Me.cmbYear.Location = New System.Drawing.Point(316, 233)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(72, 33)
        Me.cmbYear.TabIndex = 7
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Location = New System.Drawing.Point(180, 206)
        Me.chkPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(129, 21)
        Me.chkPassword.TabIndex = 30
        Me.chkPassword.Text = "Show Password"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'rdDoctor
        '
        Me.rdDoctor.AutoSize = True
        Me.rdDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDoctor.Location = New System.Drawing.Point(17, 25)
        Me.rdDoctor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdDoctor.Name = "rdDoctor"
        Me.rdDoctor.Size = New System.Drawing.Size(81, 24)
        Me.rdDoctor.TabIndex = 8
        Me.rdDoctor.TabStop = True
        Me.rdDoctor.Text = "Doctor"
        Me.rdDoctor.UseVisualStyleBackColor = True
        '
        'rdRep
        '
        Me.rdRep.AutoSize = True
        Me.rdRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRep.Location = New System.Drawing.Point(17, 55)
        Me.rdRep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdRep.Name = "rdRep"
        Me.rdRep.Size = New System.Drawing.Size(123, 24)
        Me.rdRep.TabIndex = 9
        Me.rdRep.TabStop = True
        Me.rdRep.Text = "Receptionist"
        Me.rdRep.UseVisualStyleBackColor = True
        '
        'rdNurse
        '
        Me.rdNurse.AutoSize = True
        Me.rdNurse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNurse.Location = New System.Drawing.Point(17, 85)
        Me.rdNurse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdNurse.Name = "rdNurse"
        Me.rdNurse.Size = New System.Drawing.Size(75, 24)
        Me.rdNurse.TabIndex = 10
        Me.rdNurse.TabStop = True
        Me.rdNurse.Text = "Nurse"
        Me.rdNurse.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Doctor speciality:"
        '
        'txtSpeciality
        '
        Me.txtSpeciality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeciality.Location = New System.Drawing.Point(180, 277)
        Me.txtSpeciality.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.Size = New System.Drawing.Size(191, 30)
        Me.txtSpeciality.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdDoctor)
        Me.GroupBox1.Controls.Add(Me.rdRep)
        Me.GroupBox1.Controls.Add(Me.rdNurse)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(459, 208)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Title"
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSpeciality)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkPassword)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtCpassword)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CreateAccount"
        Me.Text = "Create Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtCpassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents rdDoctor As RadioButton
    Friend WithEvents rdRep As RadioButton
    Friend WithEvents rdNurse As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSpeciality As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
