﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="NWFoote")>  _
Partial Public Class NWFooteDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCustomer(instance As Customer)
    End Sub
  Partial Private Sub UpdateCustomer(instance As Customer)
    End Sub
  Partial Private Sub DeleteCustomer(instance As Customer)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.SQLClientDemo.DataLayer.My.MySettings.Default.NWFooteConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
		Get
			Return Me.GetTable(Of Customer)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.sp_DeleteCustomer")>  _
	Public Function sp_DeleteCustomer(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CustomerId", DbType:="Char(5)")> ByVal customerId As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), customerId)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.sp_UpdateCustomer")>  _
	Public Function sp_UpdateCustomer(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CustomerId", DbType:="NChar(5)")> ByVal customerId As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CompanyName", DbType:="NVarChar(40)")> ByVal companyName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ContactName", DbType:="NVarChar(30)")> ByVal contactName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ContactTitle", DbType:="NVarChar(30)")> ByVal contactTitle As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Address", DbType:="NVarChar(60)")> ByVal address As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="City", DbType:="NVarChar(15)")> ByVal city As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Region", DbType:="NVarChar(15)")> ByVal region As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="PostalCode", DbType:="NVarChar(10)")> ByVal postalCode As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Country", DbType:="NVarChar(15)")> ByVal country As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Phone", DbType:="NVarChar(24)")> ByVal phone As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Fax", DbType:="NVarChar(24)")> ByVal fax As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), customerId, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.sp_GetCustomers")>  _
	Public Function sp_GetCustomers() As ISingleResult(Of sp_GetCustomersResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of sp_GetCustomersResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.sp_GetCustomersByCity")>  _
	Public Function sp_GetCustomersByCity(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="City", DbType:="VarChar(25)")> ByVal city As String) As ISingleResult(Of sp_GetCustomersByCityResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), city)
		Return CType(result.ReturnValue,ISingleResult(Of sp_GetCustomersByCityResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.sp_InsertCustomer")>  _
	Public Function sp_InsertCustomer(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CustomerId", DbType:="NChar(5)")> ByVal customerId As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CompanyName", DbType:="NVarChar(40)")> ByVal companyName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ContactName", DbType:="NVarChar(30)")> ByVal contactName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ContactTitle", DbType:="NVarChar(30)")> ByVal contactTitle As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Address", DbType:="NVarChar(60)")> ByVal address As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="City", DbType:="NVarChar(15)")> ByVal city As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Region", DbType:="NVarChar(15)")> ByVal region As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="PostalCode", DbType:="NVarChar(10)")> ByVal postalCode As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Country", DbType:="NVarChar(15)")> ByVal country As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Phone", DbType:="NVarChar(24)")> ByVal phone As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Fax", DbType:="NVarChar(24)")> ByVal fax As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), customerId, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax)
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Customers")>  _
Partial Public Class Customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CustomerID As String
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _ContactTitle As String
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _Phone As String
	
	Private _Fax As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnCompanyNameChanging(value As String)
    End Sub
    Partial Private Sub OnCompanyNameChanged()
    End Sub
    Partial Private Sub OnContactNameChanging(value As String)
    End Sub
    Partial Private Sub OnContactNameChanged()
    End Sub
    Partial Private Sub OnContactTitleChanging(value As String)
    End Sub
    Partial Private Sub OnContactTitleChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnRegionChanging(value As String)
    End Sub
    Partial Private Sub OnRegionChanged()
    End Sub
    Partial Private Sub OnPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostalCodeChanged()
    End Sub
    Partial Private Sub OnCountryChanging(value As String)
    End Sub
    Partial Private Sub OnCountryChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnFaxChanging(value As String)
    End Sub
    Partial Private Sub OnFaxChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If (String.Equals(Me._CustomerID, value) = false) Then
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CompanyName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me.OnCompanyNameChanging(value)
				Me.SendPropertyChanging
				Me._CompanyName = value
				Me.SendPropertyChanged("CompanyName")
				Me.OnCompanyNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactName", DbType:="NVarChar(30)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If (String.Equals(Me._ContactName, value) = false) Then
				Me.OnContactNameChanging(value)
				Me.SendPropertyChanging
				Me._ContactName = value
				Me.SendPropertyChanged("ContactName")
				Me.OnContactNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactTitle", DbType:="NVarChar(30)")>  _
	Public Property ContactTitle() As String
		Get
			Return Me._ContactTitle
		End Get
		Set
			If (String.Equals(Me._ContactTitle, value) = false) Then
				Me.OnContactTitleChanging(value)
				Me.SendPropertyChanging
				Me._ContactTitle = value
				Me.SendPropertyChanged("ContactTitle")
				Me.OnContactTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If (String.Equals(Me._Region, value) = false) Then
				Me.OnRegionChanging(value)
				Me.SendPropertyChanging
				Me._Region = value
				Me.SendPropertyChanged("Region")
				Me.OnRegionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me.OnPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._PostalCode = value
				Me.SendPropertyChanged("PostalCode")
				Me.OnPostalCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me.OnCountryChanging(value)
				Me.SendPropertyChanging
				Me._Country = value
				Me.SendPropertyChanged("Country")
				Me.OnCountryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(24)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fax", DbType:="NVarChar(24)")>  _
	Public Property Fax() As String
		Get
			Return Me._Fax
		End Get
		Set
			If (String.Equals(Me._Fax, value) = false) Then
				Me.OnFaxChanging(value)
				Me.SendPropertyChanging
				Me._Fax = value
				Me.SendPropertyChanged("Fax")
				Me.OnFaxChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class sp_GetCustomersResult
	
	Private _CustomerID As String
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _ContactTitle As String
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _Phone As String
	
	Private _Fax As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5) NOT NULL", CanBeNull:=false)>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If (String.Equals(Me._CustomerID, value) = false) Then
				Me._CustomerID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CompanyName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me._CompanyName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactName", DbType:="NVarChar(30)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If (String.Equals(Me._ContactName, value) = false) Then
				Me._ContactName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactTitle", DbType:="NVarChar(30)")>  _
	Public Property ContactTitle() As String
		Get
			Return Me._ContactTitle
		End Get
		Set
			If (String.Equals(Me._ContactTitle, value) = false) Then
				Me._ContactTitle = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me._Address = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me._City = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If (String.Equals(Me._Region, value) = false) Then
				Me._Region = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me._PostalCode = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me._Country = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(24)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me._Phone = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fax", DbType:="NVarChar(24)")>  _
	Public Property Fax() As String
		Get
			Return Me._Fax
		End Get
		Set
			If (String.Equals(Me._Fax, value) = false) Then
				Me._Fax = value
			End If
		End Set
	End Property
End Class

Partial Public Class sp_GetCustomersByCityResult
	
	Private _CustomerID As String
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _ContactTitle As String
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _Phone As String
	
	Private _Fax As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5) NOT NULL", CanBeNull:=false)>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If (String.Equals(Me._CustomerID, value) = false) Then
				Me._CustomerID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CompanyName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me._CompanyName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactName", DbType:="NVarChar(30)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If (String.Equals(Me._ContactName, value) = false) Then
				Me._ContactName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactTitle", DbType:="NVarChar(30)")>  _
	Public Property ContactTitle() As String
		Get
			Return Me._ContactTitle
		End Get
		Set
			If (String.Equals(Me._ContactTitle, value) = false) Then
				Me._ContactTitle = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me._Address = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me._City = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If (String.Equals(Me._Region, value) = false) Then
				Me._Region = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me._PostalCode = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me._Country = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(24)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me._Phone = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fax", DbType:="NVarChar(24)")>  _
	Public Property Fax() As String
		Get
			Return Me._Fax
		End Get
		Set
			If (String.Equals(Me._Fax, value) = false) Then
				Me._Fax = value
			End If
		End Set
	End Property
End Class
