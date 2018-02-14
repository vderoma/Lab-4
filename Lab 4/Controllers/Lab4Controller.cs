using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}