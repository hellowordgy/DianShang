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
using MD5Demo;
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
        public int IdOs(ClienteleIdO idO)
        {

            idO.ClientelePassword = MD5Helper.GetMD5(idO.ClientelePassword);
            string sql = $"insert into UserEnter (ClienteleRegister,ClientelePassword) values('{idO.ClienteleRegister}','{idO.ClientelePassword}')";
            string str = $"select * from UserEnter  where ClienteleRegister='{idO.ClienteleRegister}' and ClientelePassword='{idO.ClientelePassword}'";
            var dt1 = DbAccess.DBHelper.ExecuteNonQuery(sql);
            var dt2 = DbAccess.DBHelper.Get<UserEnter>(str);
            string sqt = $"insert into ClienteleId(ClienteleName,ClienteleNickName,ClientelePhone,ClientelePicture,UserEnterId) values('{idO.ClienteleName}','{idO.ClienteleNickName}','{idO.ClientelePhone}','{idO.ClientelePassword}','{dt2.ClienteleRegisterId}')";
            var dt = DbAccess.DBHelper.ExecuteNonQuery(sqt);
            return dt;
        }
        //登录
        public int Logi(ClienteleIdO idO)
        {
            string sql = $"insert into UserEnter (ClienteleRegister,ClientelePassword) values('{idO.ClienteleRegister}','{idO.ClientelePassword}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //用户注册
        public int UserRes(UserInfo info)
        {
            info.UserPassword = MD5Helper.GetMD5(info.UserPassword);
            string sql = $"select * from UserInfo where UserName='{info.UserName}' and UserPassword='{info.UserPassword}'";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //用户登录
        public int UserLogin(UserInfo info)
        {
            string sql = $"insert into UserInfo values(newid(),'{info.UserName}','{info.UserAccon}','{info.UserPassword}','{info.UserPhone}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
    }
}
