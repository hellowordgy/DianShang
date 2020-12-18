using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangMVC.Controllers
{
    public class UserInfoController : Controller
    {
        //用户显示
        public IActionResult Index()
        {
            return View();
        }
        //用户添加
        public IActionResult Add()
        {
            return View();
        }
        //用户配置角色
        public IActionResult PeiZhi(string  id)
        {
            ViewBag.id = id;
            return View();
        }
        //用户详情页
        public IActionResult Xiang()
        {
            return View();
        }
    }
}
