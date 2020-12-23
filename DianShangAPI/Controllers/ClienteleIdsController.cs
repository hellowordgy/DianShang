using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using DAL.OTC;
using System.Net;
using System.IO;
using System.Text;
using Model;
namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteleIdsController : ControllerBase
    {
        DayDal day = new DayDal();
        [HttpPost]
        [Route("ResIndex")]
        public int Res(ClienteleIdO idO)
        {
            int list = day.IdOs(idO);
            return list;
        }
        [HttpPost]
        [Route("Login")]
        public List<ClienteleIdO> Logon(ClienteleIdO idO)
        {
            return day.Logi(idO);
        }
        [HttpPost]
        [Route("UserRes")]
        public int UserRes(UserInfo user)
        {
            int i = day.UserRes(user);
            return i;
        }
        [HttpPost]
        [Route("UserLogin")]
        public int UserLogin(UserInfo user)
        {
            return day.UserLogin(user);
        }
    }
}
