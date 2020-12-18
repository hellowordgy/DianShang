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
    public class UserInfoController : ControllerBase
    {
        UserInfoDal userinfoDal = new UserInfoDal();
        [HttpGet]
        [Route("Show")]
        //用户显示
        public List<UserInfo> UserInfoXianshi()
        {
            return userinfoDal.UserInfoShow();
        }
        //用户添加
        [HttpPost]
        [Route("Add")]
        public int AddUserInfo(UserInfo u)
        {
            return userinfoDal.AddUserInfo(u);
        }
        //用户删除
        [HttpPost]
        [Route("Del")]
        public int DelUserInfo(string  id)
        {
            return userinfoDal.DelUserInfo(id);
        }
        //用户选择角色
        [HttpGet]
        [Route("Xuan")]
        public List<RoleInfo> UserInfoXuan(string uid)
        {
            return userinfoDal.UserInfoXuan(uid);
        }
        //用户配置角色
        [HttpPost]
        [Route("PeiZhi")]
        public bool UserInfoPeiZhi([FromForm]RBAC rb)
        {
            bool l= userinfoDal.UserInfoPeiZhi(rb);
            return l;
        }
        //用户详情
        [HttpGet]
        [Route("Xiang")]
        public List<UserInfo> UserInfoXiang()
        {
            return userinfoDal.UserInfoXiang();
        }
        //用户反填
        [HttpGet]
        [Route("Get")]
        public UserInfo GetUserInfo(int id)
        {
            return userinfoDal.GetUserInfo(id);
        }
        //用户修改
        [HttpPost]
        [Route("Get")]
        public int UpdUserInfo(UserInfo u)
        {
            return userinfoDal.UpdUserInfo(u);
        }
    }
}
