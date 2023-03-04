using System.Web;
using System.Web.Mvc;

namespace PhamHoaiNam_2011068871
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
