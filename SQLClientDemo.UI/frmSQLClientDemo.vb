Imports System.Data.SqlClient
Imports SQLClientDemo.BusinessLayer

Public Class frmSQLClientDemo
    Private msConnStr As String = "Data Source=10.4.169.18;Initial Catalog=NWFoote;User ID=CMLogin;Password=CMLogin"
    Private moCustomers As CCustomers

    Private Sub btnTable_Click(sender As System.Object, e As System.EventArgs) Handles btnTable.Click


        ' Create a new oConn
        Dim oConn As New SqlConnection(msConnStr)

        Try

            ' Open the connection
            oConn.Open()

            Dim oCmd As New SqlCommand("SELECT * FROM CUSTOMERS", oConn)

            Dim oDA As New SqlDataAdapter(oCmd)

            Dim dsCustomers As New DataSet
            oDA.Fill(dsCustomers)

            DataGridView1.DataSource = dsCustomers.Tables(0)

        Catch ex As Exception

            lblStatus.Text = ex.Message

        Finally

            oConn.Close()
            oConn.Dispose()
            oConn = Nothing

        End Try


    End Sub

    Private Sub btnStoredProcAll_Click(sender As System.Object, e As System.EventArgs) Handles btnStoredProcAll.Click
        ' Create a new oConn
        Dim oConn As New SqlConnection(msConnStr)

        Try

            ' Open the connection
            oConn.Open()

            ' Create a command object that calls a stored procedure

            Dim oCmd As New SqlCommand("sp_GetCustomers", oConn)
            oCmd.CommandType = CommandType.StoredProcedure

            Dim oDA As New SqlDataAdapter(oCmd)

            Dim dsCustomers As New DataSet
            oDA.Fill(dsCustomers)

            DataGridView1.DataSource = dsCustomers.Tables(0)

        Catch ex As Exception

            lblStatus.Text = ex.Message

        Finally

            oConn.Close()
            oConn.Dispose()
            oConn = Nothing

        End Try
    End Sub

    Private Sub btnGetByCity_Click(sender As System.Object, e As System.EventArgs) Handles btnGetByCity.Click
        ' Create a new oConn
        Dim oConn As New SqlConnection(msConnStr)

        Try

            ' Open the connection
            oConn.Open()

            ' Create a command object that calls a stored procedure

            Dim oCmd As New SqlCommand("sp_GetCustomersByCity", oConn)
            oCmd.CommandType = CommandType.StoredProcedure
            Dim oParm As SqlParameter = oCmd.Parameters.Add("@City", SqlDbType.VarChar, 25)
            oParm.Value = txtSearchCity.Text

            Dim oDA As New SqlDataAdapter(oCmd)

            Dim dsCustomers As New DataSet
            oDA.Fill(dsCustomers)

            DataGridView1.DataSource = dsCustomers.Tables(0)

        Catch ex As Exception

            lblStatus.Text = ex.Message

        Finally

            oConn.Close()
            oConn.Dispose()
            oConn = Nothing

        End Try
    End Sub

    Private Sub btnGetCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCustomers.Click

        moCustomers = New CCustomers
        moCustomers.GetCustomers()
        DataGridView1.DataSource = moCustomers


    End Sub

    Private Sub btnGetByCity2_Click(sender As System.Object, e As System.EventArgs) Handles btnGetByCity2.Click

        moCustomers = New CCustomers
        moCustomers.GetCustomersByCity(txtSearchCity.Text)
        DataGridView1.DataSource = moCustomers

    End Sub

    Private Sub frmSQLClientDemo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PopulateScreen(ByRef oCustomer As CCustomer)

        With oCustomer
            txtAddress.Text = .Address
            txtCustomerId.Text = .CustomerId
            txtCity.Text = .City
            txtCompanyName.Text = .CompanyName
            txtContactName.Text = .ContactName
            txtCountry.Text = .Country
            txtPhone.Text = .Phone
            txFax.Text = .Fax
            txtRegion.Text = .Region
            txtPostalCode.Text = .PostalCode
            txtTitle.Text = .ContactTitle
        End With
    End Sub

    Private Sub PopulateObject(ByRef oCustomer As CCustomer)
        With oCustomer
            .Address = txtAddress.Text
            .CustomerId = txtCustomerId.Text
            .City = txtCity.Text
            .CompanyName = txtCompanyName.Text
            .ContactName = txtContactName.Text
            .Country = txtCountry.Text
            .Phone = txtPhone.Text
            .Fax = txFax.Text
            .Region = txtRegion.Text
            .PostalCode = txtPostalCode.Text
            .ContactTitle = txtTitle.Text
        End With

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Dim oCustomer As CCustomer = moCustomers.Item(DataGridView1.CurrentRow.Index)
        PopulateScreen(oCustomer)
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim oCustomer As CCustomer = moCustomers.Item(DataGridView1.CurrentRow.Index)
        PopulateObject(oCustomer)
        oCustomer.Update()

    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click

        Dim oCustomer As New CCustomer
        PopulateObject(oCustomer)
        oCustomer.Insert()

    End Sub
End Class
