using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangMVC.Controllers
{
    public class MenuInfoController : Controller
    {
        //菜单显示
        public IActionResult Index()
        {
            return View();
        }
        //菜单添加
        public IActionResult Add()
        {
            return View();
        }
    }
}
