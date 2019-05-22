using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiDemo.Web.Models;
using ApiDemo.Data;

namespace ApiDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            NewsManager mgr = new NewsManager();
            vm.News = mgr.GetNews();
            return View(vm);
        }
    }
}
