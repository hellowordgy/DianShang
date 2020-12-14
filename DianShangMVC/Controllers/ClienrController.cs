using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
        public IActionResult ZhuYe()
        {
            return View();
        }

    }
}
