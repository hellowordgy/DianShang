using System;
using System.Collections.Generic;
using Model;
using DAL.OTC;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Ubiety.Dns.Core;
using System.Text;
using System.Configuration;

namespace DAL
{
    public class DayDal
    {
        
        
        public List<Day10> show()
        {
            string sql = $"select * from biao";
            return DbAccess.DBHelper.GetToList<Day10>(sql);
        }
        //注册
        public object IdOs(ClienteleIdO idO)
        {
            List<string> vs = new List<string>();
            string sql = $"insert into UserEnter (ClienteleRegister,ClientelePassword) values('{idO.ClienteleRegister}','{idO.ClientelePassword}')";
            string str = $"select * from UserEnter";
            string sqt = $"insert into ClienteleId(ClienteleName,ClienteleNickName,ClientelePhone,ClientelePicture,UserEnterId) values('{idO.ClienteleName}','{idO.ClienteleNickName}','{idO.ClientelePhone}','{idO.ClientelePicture}','{idO.UserEnterId}')";
            vs.Add(sql);
            vs.Add(str);
            vs.Add(sqt);
            bool lrt = DbAccess.DBHelper.ExecuteSqlTran(vs);
            return lrt;
        }

        
    }
}
