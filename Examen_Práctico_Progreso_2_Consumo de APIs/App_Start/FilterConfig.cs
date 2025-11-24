using System.Web;
using System.Web.Mvc;

namespace Examen_Práctico_Progreso_2_Consumo_de_APIs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
