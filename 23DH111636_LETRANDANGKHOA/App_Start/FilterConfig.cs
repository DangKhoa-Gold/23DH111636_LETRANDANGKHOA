using System.Web;
using System.Web.Mvc;

namespace _23DH111636_LETRANDANGKHOA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
