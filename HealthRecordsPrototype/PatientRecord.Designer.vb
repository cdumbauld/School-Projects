<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVisit = New System.Windows.Forms.TextBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "First Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Inner City Hospital"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 48)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Add Patient Record"
        '
        'txtFname
        '
        Me.txtFname.Enabled = False
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(124, 136)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(233, 30)
        Me.txtFname.TabIndex = 1
        '
        'txtLname
        '
        Me.txtLname.Enabled = False
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(486, 136)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(191, 30)
        Me.txtLname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Last Name: "
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(124, 180)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(233, 30)
        Me.txtHeight.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Height: "
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(486, 180)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(191, 30)
        Me.txtWeight.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Weight: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Allergies: "
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(486, 223)
        Me.txtAllergies.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(191, 147)
        Me.txtAllergies.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Visit:"
        '
        'txtVisit
        '
        Me.txtVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisit.Location = New System.Drawing.Point(124, 220)
        Me.txtVisit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVisit.Multiline = True
        Me.txtVisit.Name = "txtVisit"
        Me.txtVisit.Size = New System.Drawing.Size(233, 147)
        Me.txtVisit.TabIndex = 5
        '
        'txtSummary
        '
        Me.txtSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummary.Location = New System.Drawing.Point(120, 389)
        Me.txtSummary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Size = New System.Drawing.Size(558, 147)
        Me.txtSummary.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Summary:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(223, 550)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 43)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(389, 550)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 43)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PatientRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(690, 604)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVisit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAllergies)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PatientRecord"
        Me.Text = "Add Patient Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVisit As TextBox
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
