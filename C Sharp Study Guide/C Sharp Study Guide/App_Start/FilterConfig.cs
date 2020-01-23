using System.Web;
using System.Web.Mvc;

namespace C_Sharp_Study_Guide
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
