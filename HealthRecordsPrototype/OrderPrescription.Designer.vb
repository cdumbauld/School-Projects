<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderPrescription
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDrug = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDosage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRefills = New System.Windows.Forms.NumericUpDown()
        Me.cmbPharmacy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.txtRefills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Inner City Hospital"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 58)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Order Prescription"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Patient's Name: "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(159, 147)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 30)
        Me.txtName.TabIndex = 1
        '
        'txtDrug
        '
        Me.txtDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrug.Location = New System.Drawing.Point(524, 147)
        Me.txtDrug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDrug.Name = "txtDrug"
        Me.txtDrug.Size = New System.Drawing.Size(191, 30)
        Me.txtDrug.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(396, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Drug Name: "
        '
        'txtDosage
        '
        Me.txtDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosage.Location = New System.Drawing.Point(524, 190)
        Me.txtDosage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.Size = New System.Drawing.Size(191, 30)
        Me.txtDosage.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Dosage:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(454, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Refills:"
        '
        'txtRefills
        '
        Me.txtRefills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefills.Location = New System.Drawing.Point(524, 233)
        Me.txtRefills.Name = "txtRefills"
        Me.txtRefills.Size = New System.Drawing.Size(191, 30)
        Me.txtRefills.TabIndex = 5
        '
        'cmbPharmacy
        '
        Me.cmbPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPharmacy.FormattingEnabled = True
        Me.cmbPharmacy.Location = New System.Drawing.Point(160, 191)
        Me.cmbPharmacy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPharmacy.Name = "cmbPharmacy"
        Me.cmbPharmacy.Size = New System.Drawing.Size(191, 33)
        Me.cmbPharmacy.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 25)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Pharmacy:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(238, 238)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 43)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(75, 238)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 43)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'OrderPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(800, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbPharmacy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRefills)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDosage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDrug)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "OrderPrescription"
        Me.Text = "Order Prescription"
        CType(Me.txtRefills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDrug As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDosage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRefills As NumericUpDown
    Friend WithEvents cmbPharmacy As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
End Class
