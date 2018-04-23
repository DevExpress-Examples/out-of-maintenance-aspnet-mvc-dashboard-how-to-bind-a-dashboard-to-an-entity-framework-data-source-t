Imports System.Web.Routing
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.EntityFramework
Imports WebDashboard_EFDataSource.Models

Namespace WebDashboard_EFDataSource
    Public NotInheritable Class DashboardConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("dashboardControl")
            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

            Dim dataSourceStorage As New DataSourceInMemoryStorage()

            ' Registers an Entity Framework data source.
            Dim efDataSource As New DashboardEFDataSource("EF Data Source")
            efDataSource.ConnectionParameters = New EFConnectionParameters(GetType(NorthwindDataModel))
            dataSourceStorage.RegisterDataSource("efDataSource", efDataSource.SaveToXml())

            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
        End Sub
    End Class
End Namespace