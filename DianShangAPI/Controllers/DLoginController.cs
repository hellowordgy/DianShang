using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DianShangAPI.WModel;
using DbAccess;
namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DLoginController : ControllerBase
    {
        [HttpPost]
        [Route("Lg")]
        //登录
        public int Login(UserEnter enter)
        {
            string sql = $"select count(*) from UserEnter where ClienteleRegister='{enter.ClienteleRegister}' and ClientelePassword='{enter.ClientelePassword}'";
            var list = (int)DBHelper.ExecuteScalar(sql);
            return list;
        }
        [HttpPost]
        [Route("reg")]
        //注册
        public int Reg(UserEnter enter)
        {
            string sql = $"insert into Logon values('newid()','{enter.ClienteleRegister}','{enter.ClientelePassword}') ";
            var list = DBHelper.ExecuteNonQuery(sql);
            return list;
        }
    }
}
