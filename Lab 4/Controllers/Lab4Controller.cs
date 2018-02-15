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

            DateTime time = new DateTime();
            time = DateTime.Now;
            
            return View(time);

        }

        public IActionResult Page2(int id)
        {
            
            return View(id);

        }

        public IActionResult Page3()
        {
            string[] beverages = new string[] { "Coffee", "Tea", "Water", "Beer", "Wine" };
            ViewData["beverages"] = "Beverages";
            return View(beverages);

        }
    }
}