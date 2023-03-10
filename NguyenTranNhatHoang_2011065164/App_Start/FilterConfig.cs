using System.Web;
using System.Web.Mvc;

namespace NguyenTranNhatHoang_2011065164
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
