﻿using System.Web;
using System.Web.Mvc;

namespace Centric4200Team12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
