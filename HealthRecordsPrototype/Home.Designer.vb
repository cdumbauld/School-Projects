<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FdaasdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPatientRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prescriptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.payments = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbPharmacy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FdaasdToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 28)
        '
        'FdaasdToolStripMenuItem
        '
        Me.FdaasdToolStripMenuItem.Name = "FdaasdToolStripMenuItem"
        Me.FdaasdToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.FdaasdToolStripMenuItem.Text = "fdaasd"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.prescriptions, Me.payments, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPatientToolStripMenuItem, Me.AddPatientToolStripMenuItem, Me.AddPatientRecordToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'EditPatientToolStripMenuItem
        '
        Me.EditPatientToolStripMenuItem.Name = "EditPatientToolStripMenuItem"
        Me.EditPatientToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.EditPatientToolStripMenuItem.Text = "Edit Patient"
        '
        'AddPatientToolStripMenuItem
        '
        Me.AddPatientToolStripMenuItem.Name = "AddPatientToolStripMenuItem"
        Me.AddPatientToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.AddPatientToolStripMenuItem.Text = "Add Patient"
        '
        'AddPatientRecordToolStripMenuItem
        '
        Me.AddPatientRecordToolStripMenuItem.Name = "AddPatientRecordToolStripMenuItem"
        Me.AddPatientRecordToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.AddPatientRecordToolStripMenuItem.Text = "Add Patient Record"
        '
        'prescriptions
        '
        Me.prescriptions.Name = "prescriptions"
        Me.prescriptions.Size = New System.Drawing.Size(105, 24)
        Me.prescriptions.Text = "Prescriptions"
        '
        'payments
        '
        Me.payments.Name = "payments"
        Me.payments.Size = New System.Drawing.Size(77, 24)
        Me.payments.Text = "Payment"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 67)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Inner City Hospital"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search Patient"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft JhengHei", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(695, 63)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(124, 30)
        Me.txtSearch.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Date Of Birth: "
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(155, 159)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(191, 30)
        Me.txtAddress.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Address:"
        '
        'txtFname
        '
        Me.txtFname.Enabled = False
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(155, 114)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(191, 30)
        Me.txtFname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "First Name: "
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(520, 156)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(191, 30)
        Me.txtPhone.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(436, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Phone:"
        '
        'txtLname
        '
        Me.txtLname.Enabled = False
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(520, 114)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(191, 30)
        Me.txtLname.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(393, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 25)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Last Name: "
        '
        'txtDOB
        '
        Me.txtDOB.Enabled = False
        Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(155, 206)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(191, 30)
        Me.txtDOB.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Lime
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(243, 296)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 43)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(379, 296)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 43)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(520, 296)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 43)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cmbDoctor
        '
        Me.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctor.Enabled = False
        Me.cmbDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(520, 203)
        Me.cmbDoctor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(208, 33)
        Me.cmbDoctor.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(357, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 25)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Primary Doctor:"
        '
        'cmbPharmacy
        '
        Me.cmbPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPharmacy.Enabled = False
        Me.cmbPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPharmacy.FormattingEnabled = True
        Me.cmbPharmacy.Location = New System.Drawing.Point(155, 253)
        Me.cmbPharmacy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPharmacy.Name = "cmbPharmacy"
        Me.cmbPharmacy.Size = New System.Drawing.Size(191, 33)
        Me.cmbPharmacy.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 25)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Pharmacy:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(720, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "User:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(768, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 17)
        Me.lblUser.TabIndex = 62
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 349)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPharmacy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbDoctor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "Inner City Hospital"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FdaasdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPatientRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prescriptions As ToolStripMenuItem
    Friend WithEvents payments As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbPharmacy As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUser As Label
End Class
