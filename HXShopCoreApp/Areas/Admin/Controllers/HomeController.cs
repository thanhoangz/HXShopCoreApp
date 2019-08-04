using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HXShopCoreApp.Data.EF;
using HXShopCoreApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HXShopCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            

            return View();
        }
    }
}