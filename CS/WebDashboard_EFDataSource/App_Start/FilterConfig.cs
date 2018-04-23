using System.Web;
using System.Web.Mvc;

namespace WebDashboard_EFDataSource {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}