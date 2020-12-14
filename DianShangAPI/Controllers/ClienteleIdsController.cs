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
            bool list = (bool)day.IdOs(idO);
            return list;
        }
        //调用时只需要把拼成的URL传给该函数即可。判断返回值即可
        [HttpGet]
        [Route("Duan")]
        public string GetHtmlFromUrl()
        {
            string  url = "http://utf8.api.smschinese.cn/?Uid=迪丽热鹤&Key=d41d8cd98f00b204e980&smsMob=18251514466&smsText=学习";
            string strRet = null;
            if (url == null || url.Trim().ToString() == "")
            {
                return strRet;
            }
            string targeturl = url.Trim().ToString();
            try
            {
                HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
                hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                hr.Method = "GET";
                hr.Timeout = 30 * 60 * 1000;
                WebResponse hs = hr.GetResponse();
                Stream sr = hs.GetResponseStream();
                StreamReader ser = new StreamReader(sr, Encoding.Default);
                strRet = ser.ReadToEnd();
            }
            catch (Exception ex)
            {
                strRet = null;
            }
            return strRet;
        }
    }
}
