﻿using System.Web;
using System.Web.Mvc;

namespace aspnet_vs2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
