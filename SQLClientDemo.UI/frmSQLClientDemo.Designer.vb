<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLClientDemo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGetByCity = New System.Windows.Forms.Button()
        Me.btnStoredProcAll = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txFax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnGetCustomers = New System.Windows.Forms.Button()
        Me.btnGetByCity2 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGetByCity
        '
        Me.btnGetByCity.Location = New System.Drawing.Point(523, 168)
        Me.btnGetByCity.Name = "btnGetByCity"
        Me.btnGetByCity.Size = New System.Drawing.Size(75, 35)
        Me.btnGetByCity.TabIndex = 1
        Me.btnGetByCity.Text = "Get By City"
        Me.btnGetByCity.UseVisualStyleBackColor = True
        '
        'btnStoredProcAll
        '
        Me.btnStoredProcAll.Location = New System.Drawing.Point(604, 168)
        Me.btnStoredProcAll.Name = "btnStoredProcAll"
        Me.btnStoredProcAll.Size = New System.Drawing.Size(75, 35)
        Me.btnStoredProcAll.TabIndex = 2
        Me.btnStoredProcAll.Text = "Stored Proc All"
        Me.btnStoredProcAll.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(685, 168)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(75, 35)
        Me.btnTable.TabIndex = 3
        Me.btnTable.Text = "Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "City:"
        '
        'txtSearchCity
        '
        Me.txtSearchCity.Location = New System.Drawing.Point(83, 165)
        Me.txtSearchCity.Name = "txtSearchCity"
        Me.txtSearchCity.Size = New System.Drawing.Size(134, 20)
        Me.txtSearchCity.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(839, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer Id"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(959, 12)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(166, 20)
        Me.txtCustomerId.TabIndex = 9
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(959, 38)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(166, 20)
        Me.txtCompanyName.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(839, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Company  Name"
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(959, 64)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(166, 20)
        Me.txtContactName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(839, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contact Name"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(959, 90)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(166, 20)
        Me.txtTitle.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(839, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Title"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(959, 116)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(166, 20)
        Me.txtAddress.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(839, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Address:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(959, 142)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 20)
        Me.txtCity.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(839, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "City:"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(959, 168)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(166, 20)
        Me.txtRegion.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(839, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Region"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(959, 194)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(166, 20)
        Me.txtPostalCode.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(839, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Postal Code"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(959, 220)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(166, 20)
        Me.txtCountry.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(839, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Country"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(959, 246)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(166, 20)
        Me.txtPhone.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(839, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Phone"
        '
        'txFax
        '
        Me.txFax.Location = New System.Drawing.Point(959, 272)
        Me.txFax.Name = "txFax"
        Me.txFax.Size = New System.Drawing.Size(166, 20)
        Me.txFax.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(839, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Fax"
        '
        'btnGetCustomers
        '
        Me.btnGetCustomers.Location = New System.Drawing.Point(685, 209)
        Me.btnGetCustomers.Name = "btnGetCustomers"
        Me.btnGetCustomers.Size = New System.Drawing.Size(75, 35)
        Me.btnGetCustomers.TabIndex = 32
        Me.btnGetCustomers.Text = "Get Customers"
        Me.btnGetCustomers.UseVisualStyleBackColor = True
        '
        'btnGetByCity2
        '
        Me.btnGetByCity2.Location = New System.Drawing.Point(523, 212)
        Me.btnGetByCity2.Name = "btnGetByCity2"
        Me.btnGetByCity2.Size = New System.Drawing.Size(75, 35)
        Me.btnGetByCity2.TabIndex = 33
        Me.btnGetByCity2.Text = "Get By City"
        Me.btnGetByCity2.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(442, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(361, 212)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 35)
        Me.btnInsert.TabIndex = 35
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'frmSQLClientDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 386)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnGetByCity2)
        Me.Controls.Add(Me.btnGetCustomers)
        Me.Controls.Add(Me.txFax)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContactName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustomerId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchCity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnStoredProcAll)
        Me.Controls.Add(Me.btnGetByCity)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSQLClientDemo"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGetByCity As System.Windows.Forms.Button
    Friend WithEvents btnStoredProcAll As System.Windows.Forms.Button
    Friend WithEvents btnTable As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchCity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txFax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnGetCustomers As System.Windows.Forms.Button
    Friend WithEvents btnGetByCity2 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button

End Class
