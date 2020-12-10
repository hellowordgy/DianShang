using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Model;

namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DayDal d = new DayDal();
        [HttpGet("show")]
        public ActionResult Show()
        {
            List<Day10> list = d.show();
            return Ok(list);
        }
    }
}
