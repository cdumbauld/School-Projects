<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
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
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.cmbPharmacy = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Inner City Hospital"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 58)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Add Patient"
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(497, 143)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(191, 30)
        Me.txtLname.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(156, 145)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(191, 30)
        Me.txtFname.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(371, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Last Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "First Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(156, 185)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(191, 30)
        Me.txtAddress.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(412, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(497, 185)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(191, 30)
        Me.txtPhone.TabIndex = 4
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.ItemHeight = 25
        Me.cmbYear.Location = New System.Drawing.Point(288, 228)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(83, 33)
        Me.cmbYear.TabIndex = 7
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.ItemHeight = 25
        Me.cmbDay.Location = New System.Drawing.Point(221, 229)
        Me.cmbDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(61, 33)
        Me.cmbDay.TabIndex = 6
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.ItemHeight = 25
        Me.cmbMonth.Location = New System.Drawing.Point(152, 229)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(63, 33)
        Me.cmbMonth.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Date Of Birth: "
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(560, 276)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 37)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(447, 276)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(92, 37)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(380, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Pharmacy:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 25)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Primary Doctor:"
        '
        'cmbDoctor
        '
        Me.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(163, 278)
        Me.cmbDoctor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(208, 33)
        Me.cmbDoctor.TabIndex = 9
        '
        'cmbPharmacy
        '
        Me.cmbPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPharmacy.FormattingEnabled = True
        Me.cmbPharmacy.Location = New System.Drawing.Point(497, 228)
        Me.cmbPharmacy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPharmacy.Name = "cmbPharmacy"
        Me.cmbPharmacy.Size = New System.Drawing.Size(208, 33)
        Me.cmbPharmacy.TabIndex = 8
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 329)
        Me.Controls.Add(Me.cmbPharmacy)
        Me.Controls.Add(Me.cmbDoctor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddPatient"
        Me.Text = "Add Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents cmbPharmacy As ComboBox
End Class
