Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WebDashboard_EFDataSource.Models

    <Table("SalesPerson")> _
    Partial Public Class SalesPerson
        <Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property OrderID() As Integer

        <StringLength(15)> _
        Public Property Country() As String

        <Key, Column(Order := 1), StringLength(10)> _
        Public Property FirstName() As String

        <Key, Column(Order := 2), StringLength(20)> _
        Public Property LastName() As String

        <Key, Column(Order := 3), StringLength(40)> _
        Public Property ProductName() As String

        <Key, Column(Order := 4), StringLength(15)> _
        Public Property CategoryName() As String

        Public Property OrderDate() As Date?

        <Key, Column(Order := 5, TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal

        <Key, Column(Order := 6), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property Quantity() As Short

        <Key, Column(Order := 7)> _
        Public Property Discount() As Single

        <Column("Extended Price", TypeName := "money")> _
        Public Property Extended_Price() As Decimal?

        <Key, Column("Sales Person", Order := 8), StringLength(31)> _
        Public Property Sales_Person() As String
    End Class
End Namespace
