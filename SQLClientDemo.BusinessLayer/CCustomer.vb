Imports System.Data.SqlClient  ' Needed for SQLClient/ADO.Net
Imports SQLClientDemo.DataLayer ' Needed for LINQ

Public Class CCustomer
#Region "Field Declarations"
    Private msCustomerId As String
    Private msCompanyName As String
    Private msContactName As String
    Private msContactTitle As String
    Private msAddress As String
    Private msCity As String
    Private msRegion As String
    Private msCountry As String
    Private msPostalCode As String
    Private msPhone As String
    Private msFax As String
#End Region

#Region "Public Properties"
    Public Property CustomerId() As String
        Get
            Return msCustomerId
        End Get
        Set(value As String)
            msCustomerId = value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return msCompanyName
        End Get
        Set(value As String)
            msCompanyName = value
        End Set
    End Property
    Public Property ContactName() As String
        Get
            Return msContactName
        End Get
        Set(value As String)
            msContactName = value
        End Set
    End Property
    Public Property ContactTitle() As String
        Get
            Return msCustomerId
        End Get
        Set(value As String)
            msCustomerId = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return msAddress
        End Get
        Set(value As String)
            msAddress = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return msCity
        End Get
        Set(value As String)
            msCity = value
        End Set
    End Property
    Public Property Region() As String
        Get
            Return msRegion
        End Get
        Set(value As String)
            msCustomerId = value
        End Set
    End Property
    Public Property Country() As String
        Get
            Return msCountry
        End Get
        Set(value As String)
            msCustomerId = value
        End Set
    End Property
    Public Property PostalCode() As String
        Get
            Return msPostalCode
        End Get
        Set(value As String)
            msPostalCode = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return msPhone
        End Get
        Set(value As String)
            msPhone = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return msFax
        End Get
        Set(value As String)
            msFax = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Function Update() As Boolean

        Dim oDC As New NWFooteDataContext

        ' Get the object
        Dim oCustomer = oDC.Customers.Where(Function(p) p.CustomerID = msCustomerId).FirstOrDefault()

        oCustomer.CompanyName = msCompanyName
        oCustomer.Address = msAddress
        oCustomer.City = msCity
        oCustomer.ContactName = msContactName
        oCustomer.ContactTitle = msContactTitle
        oCustomer.Country = msCountry
        oCustomer.CustomerID = msCustomerId
        oCustomer.Fax = msFax
        oCustomer.Phone = msPhone
        oCustomer.PostalCode = msPostalCode
        oCustomer.Region = msRegion

        oDC.SubmitChanges()

        Return True

    End Function
    Public Function Insert() As Boolean
        Dim oDC As New NWFooteDataContext

        ' Get the object
        Dim oCustomer As New Customer

        oCustomer.CompanyName = msCompanyName
        oCustomer.Address = msAddress
        oCustomer.City = msCity
        oCustomer.ContactName = msContactName
        oCustomer.ContactTitle = msContactTitle
        oCustomer.Country = msCountry
        oCustomer.CustomerID = msCustomerId
        oCustomer.Fax = msFax
        oCustomer.Phone = msPhone
        oCustomer.PostalCode = msPostalCode
        oCustomer.Region = msRegion

        oDC.Customers.InsertOnSubmit(oCustomer)
        oDC.SubmitChanges()

        Return True

    End Function

    Public Sub Load(oDr As DataRow)
        Try
            msCustomerId = oDr("CustomerId")
            msCompanyName = oDr("CompanyName")
            msContactName = oDr("ContactName")
            msContactTitle = oDr("ContactTitle")
            msAddress = oDr("Address")
            msCity = oDr("City")

            If oDr("Region").Equals(System.DBNull.Value) Then
                msRegion = String.Empty
            Else
                msRegion = oDr("Region")
            End If

            If oDr("PostalCode").Equals(System.DBNull.Value) Then
                msPostalCode = String.Empty
            Else
                msPostalCode = oDr("PostalCode")
            End If

            If oDr("Country").Equals(System.DBNull.Value) Then
                msCountry = String.Empty
            Else
                msCountry = oDr("Country")
            End If

            If oDr("Phone").Equals(System.DBNull.Value) Then
                msPhone = String.Empty
            Else
                msPhone = oDr("Phone")
            End If

            If oDr("Fax").Equals(System.DBNull.Value) Then
                msFax = String.Empty
            Else
                msFax = oDr("Fax")
            End If

        Catch ex As Exception

            Throw ex

        End Try
    End Sub
    Public Sub Load(oDr As Customer)
        Try
            msCustomerId = oDr.CustomerID
            msCompanyName = oDr.CompanyName
            msContactName = oDr.ContactName
            msContactTitle = oDr.ContactTitle
            msAddress = oDr.Address
            msCity = oDr.City
            msRegion = oDr.Region
            msPostalCode = oDr.PostalCode
            msCountry = oDr.Country
            msPhone = oDr.Phone
            msFax = oDr.Fax

        Catch ex As Exception

            Throw ex

        End Try
    End Sub
    Public Sub Load(oDr As sp_GetCustomersResult)
        Try
            msCustomerId = oDr.CustomerID
            msCompanyName = oDr.CompanyName
            msContactName = oDr.ContactName
            msContactTitle = oDr.ContactTitle
            msAddress = oDr.Address
            msCity = oDr.City
            msRegion = oDr.Region
            msPostalCode = oDr.PostalCode
            msCountry = oDr.Country
            msPhone = oDr.Phone
            msFax = oDr.Fax

        Catch ex As Exception

            Throw ex

        End Try
    End Sub
    Public Sub Load(oDr As sp_GetCustomersByCityResult)
        Try
            msCustomerId = oDr.CustomerID
            msCompanyName = oDr.CompanyName
            msContactName = oDr.ContactName
            msContactTitle = oDr.ContactTitle
            msAddress = oDr.Address
            msCity = oDr.City
            msRegion = oDr.Region
            msPostalCode = oDr.PostalCode
            msCountry = oDr.Country
            msPhone = oDr.Phone
            msFax = oDr.Fax

        Catch ex As Exception

            Throw ex

        End Try
    End Sub

#End Region

End Class
Public Class CCustomers
    Inherits CollectionBase
    Dim msConn As String = "Data Source=10.4.169.18;Initial Catalog=NWFoote;User ID=CMLogin;Password=CMLogin"

    
    ' Constructor
    Public Sub New()

    End Sub
    Shadows Function Count() As Integer
        Return Me.List.Count
    End Function
    Public Function Item(ByVal vsCustomerId As String) As CCustomer

        Return Me.List.Item(vsCustomerId)

    End Function
    Public Function Item(ByVal viIndex As Integer) As CCustomer

        Return Me.List.Item(viIndex)

    End Function
    Public Sub Add(oCustomer As CCustomer)
        Me.List.Add(oCustomer)

    End Sub
    Public Function Remove(ByVal viIndex As Integer) As Boolean
        Me.List.Remove(viIndex)
        Return True
    End Function

    Public Function GetCustomers() As Boolean
        Dim bUseLINQ As Boolean = True

        If bUseLINQ Then
            ' Use LINQ
            Dim oDataContext As New NWFooteDataContext

            'Dim oCustomers = From c In oDataContext.Customers
            '                          Select c
            ' Stored Procedure
            Dim oCustomers = From c In oDataContext.sp_GetCustomers
                             Select c

            ' Add entities to collection
            For Each cust In oCustomers
                Dim oCustomer As New CCustomer
                oCustomer.Load(cust)
                Add(oCustomer)
            Next



        Else
            ' Use SQL Client/ADO.Net
            ' Open a connection
            Dim oConn As New SqlConnection(msConn)

            ' Create and use a command object
            Dim oCmd As New SqlCommand("sp_GetCustomers", oConn)
            oCmd.CommandType = CommandType.StoredProcedure

            ' Fill a dataset
            Dim oDA As New SqlDataAdapter(oCmd)
            Dim dsCustomers As New DataSet
            oDA.Fill(dsCustomers)

            ' Add entities to the collection
            For Each oDr As DataRow In dsCustomers.Tables(0).Rows
                Dim oCustomer As New CCustomer
                ' Set the properties on the oCustomer object
                oCustomer.Load(oDr)

                ' Add to the collection
                Add(oCustomer)

            Next

        End If
        Return True

    End Function

    Public Function GetCustomersByCity(ByVal vsCity As String) As Boolean

        ' Use LINQ only
        Dim oDC As New NWFooteDataContext

        Dim oCustomers = From c In oDC.sp_GetCustomersByCity(vsCity)
                         Order By c.CompanyName
                         Select c

        For Each tblCustomer As sp_GetCustomersByCityResult In oCustomers
            Dim oCustomer As New CCustomer
            oCustomer.Load(tblCustomer)
            Add(oCustomer)
        Next


    End Function
End Class
