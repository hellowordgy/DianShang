using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DianShangMVC.Controllers
{
    public class ClienrController : Controller
    {
        public IActionResult ReIndex()
        {
            return View();
        }
    }
}
