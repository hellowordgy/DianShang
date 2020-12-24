using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangMVC.Controllers
{
    public class GoodsSpuController : Controller
    {
        //商品显示
        public IActionResult Index()
        {
            return View();
        }
        //商品添加
        public IActionResult Add()
        {
            return View();
        }
    }
}
