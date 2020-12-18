using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuInfoController : ControllerBase
    {
        MenuInfoDal menuInfoDal = new MenuInfoDal();
        [HttpGet]
        [Route("Show")]
        //菜单显示
        public List<MenuInfo> MenuInfoXianshi()
        {
            return menuInfoDal.MenuInfoShow();
        }
        //菜单添加
        [HttpPost]
        [Route("Add")]
        public int AddMenuInfo(MenuInfo m)
        {
            return menuInfoDal.AddMenuInfo(m);
        }
        //菜单删除
        [HttpGet]
        [Route("Del")]
        public int DelMenuInfo(string id)
        {
            return menuInfoDal.DelMenuInfo(id);
        }
    }
}
