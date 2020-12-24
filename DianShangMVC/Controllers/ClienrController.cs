using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DianShangMVC.Controllers
{
    public class ClienrController : Controller
    {

        public IActionResult ReIndex()
        {
            return View();
        }
        public IActionResult ZhuYe()
        {
            return View();
        }
        //短信验证
        public static string PostUrl = "https://106.ihuyi.com/webservice/sms.php?method=Submit";

        public JsonResult Page_Load(string mobile/*,object sender, EventArgs e*/)
        {
            string account = "C74015618";//查看用户名 登录用户中心->验证码通知短信>产品总览->API接口信息->APIID
            string password = "50c1ddffa551e37553336fca56db7528"; //查看密码 登录用户中心->验证码通知短信>产品总览->API接口信息->APIKEY
                                                                  // string mobile = HttpContext.Request.Query["mobile"];
            Random rad = new Random();
            int mobile_code = rad.Next(1000, 10000);
            string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";

            //Session["mobile"] = mobile;
            //Session["mobile_code"] = mobile_code;

            string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

            UTF8Encoding encoding = new UTF8Encoding();
            byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = postData.Length;

            Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            newStream.Write(postData, 0, postData.Length);
            newStream.Flush();
            newStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            if (myResponse.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                //Response.Write(reader.ReadToEnd());

                string res = reader.ReadToEnd();
                int len1 = res.IndexOf("</code>");
                int len2 = res.IndexOf("<code>");
                string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                //Response.Write(code);
                int len3 = res.IndexOf("</msg>");
                int len4 = res.IndexOf("<msg>");
                string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                return Json(mobile_code);
            }
            else
            {
                //访问失败
                return Json(new { msg = "发送失败" });
            }
        }
        public IActionResult LoIndex()
        {
            return View();
        }
        public IActionResult UserResIndex()
        {
            return View();
        }
        public IActionResult UserLogonIndex()
        {
            return View();
        }
    }
}
