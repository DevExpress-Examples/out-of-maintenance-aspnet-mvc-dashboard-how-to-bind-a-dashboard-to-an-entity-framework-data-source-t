Imports System.Data.Entity

Namespace WebDashboard_EFDataSource.Models

    Partial Public Class NorthwindDataModel
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=NWindConnectionString")
        End Sub

        Public Overridable Property SalesPersons() As DbSet(Of SalesPerson)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of SalesPerson)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)

            modelBuilder.Entity(Of SalesPerson)().Property(Function(e) e.Extended_Price).HasPrecision(19, 4)
        End Sub
    End Class
End Namespace
