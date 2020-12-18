using System.Web;
using System.Web.Mvc;

namespace SampleWebAppZ7AzureProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
