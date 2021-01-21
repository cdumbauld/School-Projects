<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 58)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Inner City Hospital"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(172, 148)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 30)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Patient's Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Payment Type: "
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Location = New System.Drawing.Point(548, 145)
        Me.cmbPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(191, 33)
        Me.cmbPayment.TabIndex = 2
        '
        'txtCard
        '
        Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.Location = New System.Drawing.Point(548, 241)
        Me.txtCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(191, 30)
        Me.txtCard.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(398, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 25)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Card Number:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(172, 197)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(191, 30)
        Me.txtAmount.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Amount:"
        '
        'txtCheck
        '
        Me.txtCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheck.Location = New System.Drawing.Point(548, 197)
        Me.txtCheck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(191, 30)
        Me.txtCheck.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 25)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Check Number:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(252, 257)
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
        Me.btnSubmit.Location = New System.Drawing.Point(89, 257)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 43)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 312)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents txtCard As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCheck As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
End Class
