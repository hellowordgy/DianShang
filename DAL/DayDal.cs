using System;
using System.Collections.Generic;
using Model;
using DAL.OTC;
namespace DAL
{
    public class DayDal
    {
        
        
        public List<Day10> show()
        {
            string sql = $"select * from biao";
            return DbAccess.DBHelper.GetToList<Day10>(sql);
        }
        public object idOs(ClienteleIdO idO)
        {
            List<string> vs = new List<string>();
            string sql = $"insert into UserEnter (ClienteleRegisterId,ClienteleRegister,ClientelePassword) values('{idO.ClienteleRegisterId}','{idO.ClienteleRegister}','{idO.ClientelePassword}')";
            string str = $"select * from UserEnter";
            string sqt = $"insert into ClienteleId(ClienteleId ,ClienteleName,ClienteleNickName,ClientelePhone,ClientelePicture,UserEnterId) values('{idO.ClienteleId}','{idO.ClienteleName}','{idO.ClienteleNickName}','{idO.ClientelePhone}','{idO.ClientelePicture}','{idO.UserEnterId}')";
            vs.Add(sql);
            vs.Add(str);
            vs.Add(sqt);
            bool lrt = DbAccess.DBHelper.ExecuteSqlTran(vs);
            return lrt;
        }
    }
}
