using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using DAL.OTC;
namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteleIdsController : ControllerBase
    {
        DayDal day = new DayDal();
        [HttpPost]
        [Route("ResIndex")]
        public bool Res(ClienteleIdO idO)
        {
            bool list = (bool)day.idOs(idO);
            return list;
        }
    }
}
