using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MD5Demo
{
    public class MD5Helper
    {
        public static string GetMD5(string Pwdstr)
        {
            MD5 md5 = MD5.Create();
            //要加密的字符串
            string str = Pwdstr;
            //字节数组
            byte[] strbuffer = Encoding.Default.GetBytes(str);
            //加密并返回字节数组
            strbuffer = md5.ComputeHash(strbuffer);
            string strNew = "";
            foreach (byte item in strbuffer)
            {
                //对字节数组中元素格式化后拼接
                strNew += item.ToString("x2");
            }
            return strNew;
        }
    }
}

