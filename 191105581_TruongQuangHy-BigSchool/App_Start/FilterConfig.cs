using System.Web;
using System.Web.Mvc;

namespace _191105581_TruongQuangHy_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
