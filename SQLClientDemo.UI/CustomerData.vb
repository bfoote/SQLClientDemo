Imports SQLClientDemo.BusinessLayer
Public Class CustomerData

    Private Sub CustomerData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Fill(ByRef oCustomer As CCustomer)
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
End Class
