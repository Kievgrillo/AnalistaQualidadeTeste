using System.Web;
using System.Web.Mvc;

namespace AnalistaQualidadeTeste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
