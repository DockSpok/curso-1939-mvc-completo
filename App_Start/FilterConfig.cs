using System.Web;
using System.Web.Mvc;

namespace curso_1939_mvc_completo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
