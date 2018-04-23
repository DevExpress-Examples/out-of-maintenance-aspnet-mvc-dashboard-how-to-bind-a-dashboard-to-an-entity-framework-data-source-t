using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.EntityFramework;
using System.Web.Routing;
using WebDashboard_EFDataSource.Models;

namespace WebDashboard_EFDataSource {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl");
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);
            
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            // Registers an Entity Framework data source.
            DashboardEFDataSource efDataSource = new DashboardEFDataSource("EF Data Source");
            efDataSource.ConnectionParameters = new EFConnectionParameters(typeof(NorthwindDataModel));
            dataSourceStorage.RegisterDataSource("efDataSource", efDataSource.SaveToXml());

            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
        }
    }
}