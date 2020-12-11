using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DianShangMVC.Models
{
    public class MLogonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginIndex()
        {
            return View();
        }
        public IActionResult RegIndex()
        {
            return View();
        }
    }
}
