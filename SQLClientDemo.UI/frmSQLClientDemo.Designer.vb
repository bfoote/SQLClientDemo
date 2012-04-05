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
        Me.btnGetCustomers = New System.Windows.Forms.Button()
        Me.btnGetByCity2 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.ucCustomer = New SQLClientDemo.UI.CustomerData()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGetByCity
        '
        Me.btnGetByCity.Location = New System.Drawing.Point(345, 175)
        Me.btnGetByCity.Name = "btnGetByCity"
        Me.btnGetByCity.Size = New System.Drawing.Size(75, 35)
        Me.btnGetByCity.TabIndex = 1
        Me.btnGetByCity.Text = "Get By City"
        Me.btnGetByCity.UseVisualStyleBackColor = True
        '
        'btnStoredProcAll
        '
        Me.btnStoredProcAll.Location = New System.Drawing.Point(426, 175)
        Me.btnStoredProcAll.Name = "btnStoredProcAll"
        Me.btnStoredProcAll.Size = New System.Drawing.Size(75, 35)
        Me.btnStoredProcAll.TabIndex = 2
        Me.btnStoredProcAll.Text = "Stored Proc All"
        Me.btnStoredProcAll.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(507, 175)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(75, 35)
        Me.btnTable.TabIndex = 3
        Me.btnTable.Text = "Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1144, 22)
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
        'btnGetCustomers
        '
        Me.btnGetCustomers.Location = New System.Drawing.Point(507, 216)
        Me.btnGetCustomers.Name = "btnGetCustomers"
        Me.btnGetCustomers.Size = New System.Drawing.Size(75, 35)
        Me.btnGetCustomers.TabIndex = 32
        Me.btnGetCustomers.Text = "Get Customers"
        Me.btnGetCustomers.UseVisualStyleBackColor = True
        '
        'btnGetByCity2
        '
        Me.btnGetByCity2.Location = New System.Drawing.Point(345, 219)
        Me.btnGetByCity2.Name = "btnGetByCity2"
        Me.btnGetByCity2.Size = New System.Drawing.Size(75, 35)
        Me.btnGetByCity2.TabIndex = 33
        Me.btnGetByCity2.Text = "Get By City"
        Me.btnGetByCity2.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(264, 219)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(183, 219)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 35)
        Me.btnInsert.TabIndex = 35
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'ucCustomer
        '
        Me.ucCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ucCustomer.Location = New System.Drawing.Point(799, 22)
        Me.ucCustomer.Name = "ucCustomer"
        Me.ucCustomer.Size = New System.Drawing.Size(316, 301)
        Me.ucCustomer.TabIndex = 36
        Me.ucCustomer.Visible = False
        '
        'frmSQLClientDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 386)
        Me.Controls.Add(Me.ucCustomer)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnGetByCity2)
        Me.Controls.Add(Me.btnGetCustomers)
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
    Friend WithEvents btnGetCustomers As System.Windows.Forms.Button
    Friend WithEvents btnGetByCity2 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents ucCustomer As SQLClientDemo.UI.CustomerData

End Class
