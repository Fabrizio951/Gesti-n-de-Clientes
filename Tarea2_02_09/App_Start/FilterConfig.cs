﻿using System.Web;
using System.Web.Mvc;

namespace Tarea2_02_09
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
