using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserInfoDal
    {
        //用户显示
        public List<UserInfo> UserInfoShow()
        {
            string sql = $"select * from UserInfo";
            //string sql = $"select * from UserInfo";
            return DbAccess.DBHelper.GetToList<UserInfo>(sql);
        }

        //用户添加
        public int AddUserInfo(UserInfo u)
        {
            string sql = $"insert into UserInfo(UserName,UserAccon,UserPassword,UserPhone) values('{u.UserName}','{u.UserAccon}','{u.UserPassword}','{u.UserPhone}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }

        //用户删除
        public int DelUserInfo(string id)
        {
            string sql = $"delete from UserInfo where UserId in ('{id}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }

        public int DelUserInfo(RBAC rb)
        {
            throw new NotImplementedException();
        }

        //用户反填
        public UserInfo GetUserInfo(int id)
        {
            string sql = $"select * from UserInfo where UserId ={id}";
            var dt = DbAccess.DBHelper.GetToList<UserInfo>(sql);
            string json = JsonConvert.SerializeObject(dt);
            UserInfo u = JsonConvert.DeserializeObject<List<UserInfo>>(json).FirstOrDefault();
            return u;
        }

        //用户修改
        public int UpdUserInfo(UserInfo u)
        {
            string sql = $"update UserInfo set UserName ='{u.UserName}',UserAccon ='{u.UserAccon}',UserPassword ='{u.UserPassword}',UserPhone ='{u.UserPhone}'";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }

        //用户选择角色
        public List<RoleInfo> UserInfoXuan(string uid)
        {
            string sql = $"select * from RoleInfo";
            return DbAccess.DBHelper.GetToList<RoleInfo>(sql);
        }

        //用户配置角色
        public bool UserInfoPeiZhi(RBAC rb)
        {
            List<string> list = new List<string>();
            var str = rb.Rid.Trim(',').Split(',');
            string sql1 = $"delete URInfo where Uid='{rb.Uid}'";
            list.Add(sql1);
            for (int i = 0; i < str.Length; i++)
            {
                string sql = $"insert into URInfo(Uid,Rid) values('{rb.Uid}',{str[i]})";
                list.Add(sql);
            }
            return DbAccess.DBHelper.ExecuteSqlTran(list);;
        }

        //用户详情
        public List<UserInfo> UserInfoXiang()
        {
            string sql = $"select a.UserId,a.UserName,c.RoleName,a.UserAccon,a.UserPassword,a.UserPhone from UserInfo a join URInfo b on a.UserId=b.Uid join RoleInfo c on b.Rid = c.RoleID";
            return DbAccess.DBHelper.GetToList<UserInfo>(sql);
        }

    }
}
