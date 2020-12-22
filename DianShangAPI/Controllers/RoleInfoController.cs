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
    public class RoleInfoController : ControllerBase
    {
        RoleInfoDal roleInfoDal = new RoleInfoDal();
        [HttpGet]
        [Route("Show")]
        //角色显示
        public List<RoleInfo> RoleInfoXianshi()
        {
            return roleInfoDal.RoleInfoShow();
        }
        //角色添加
        [HttpPost]
        [Route("Add")]
        public int AddRoleInfo(RoleInfo r)
        {
            return roleInfoDal.AddRoleInfo(r);
        }
        //角色删除
        [HttpPost]
        [Route("Del")]
        public int DelRoleInfo(string id)
        {
            return roleInfoDal.DelRoleInfo(id);
        }
        //角色选择菜单
        [HttpGet]
        [Route("Xuan")]
        public List<MenuInfo> RoleInfoXuan(string mid)
        {
            return roleInfoDal.RoleInfoXuan(mid);
        }
        //角色配置菜单
        [HttpPost]
        [Route("PeiZhi")]
        public bool RoleInfoPeiZhi([FromForm] RBAC rb)
        {
            bool l = roleInfoDal.RoleInfoPeiZhi(rb);
            return l;
        }
        //角色详情
        [HttpGet]
        [Route("Xiang")]
        public List<RoleInfo> RoleidXiang()
        {
            return roleInfoDal.RoleidXiang();
        }
        //角色反填
        [HttpGet]
        [Route("Get")]
        public RoleInfo GetRoleInfo(int id)
        {
            return roleInfoDal.GetRoleInfo(id);
        }
        //角色修改
        [HttpPost]
        [Route("Upd")]
        public int UpdRoleInfo(RoleInfo r)
        {
            return roleInfoDal.UpdRoleInfo(r);
        }
    }
}
