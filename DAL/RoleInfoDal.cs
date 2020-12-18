using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RoleInfoDal
    {
        //角色显示
        public List<RoleInfo> RoleInfoShow()
        {
            string sql = $"select * from RoleInfo";
            return DbAccess.DBHelper.GetToList<RoleInfo>(sql);
        }
        //角色添加
        public int AddRoleInfo(RoleInfo r)
        {
            string sql = $"insert into RoleInfo(RoleName) values('{r.RoleName}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //角色删除
        public int DelRoleInfo(string id)
        {
            string sql = $"delete from RoleInfo where RoleId in ('{id}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //角色反填
        public RoleInfo GetRoleInfo(int id)
        {
            string sql = $"select * from RoleInfo where RoleId ={id}";
            var dt = DbAccess.DBHelper.GetToList<RoleInfo>(sql);
            string json = JsonConvert.SerializeObject(dt);
            RoleInfo r = JsonConvert.DeserializeObject<List<RoleInfo>>(json).FirstOrDefault();
            return r;
        }
        //角色修改
        public int UpdRoleInfo(RoleInfo r)
        {
            string sql = $"update RoleInfo set RoleID ='{r.RoleID}',RoleName ='{r.RoleName}'";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //角色选择菜单
        public List<MenuInfo> RoleInfoXuan(string mid)
        {
            string sql = $"select * from MenuInfo";
            return DbAccess.DBHelper.GetToList<MenuInfo>(sql);
        }
        //角色配置菜单
        public bool RoleInfoPeiZhi(RBAC rb)
        {
            List<string> list = new List<string>();
            var str = rb.Rid.Trim(',').Split(',');
            string sql1 = $"delete RMInfo where RoleID='{rb.Rid}'";
            list.Add(sql1);
            for (int i = 0; i < str.Length; i++)
            {
                string sql = $"insert into RMInfo(Rid,Mid) values('{rb.Rid}',{str[i]})";
                list.Add(sql);
            }
            return DbAccess.DBHelper.ExecuteSqlTran(list);
        }
        //角色详情
        public List<RoleInfo> RoleidXiang()
        {
            string sql = $"select r.RoleId,m.MenuName,r.RoleName from RoleInfo r left join RMInfo rm on r.RoleID=rm.Rid left join MenuInfo m on rm.Mid=m.MenuID";
            return DbAccess.DBHelper.GetToList<RoleInfo>(sql);
        }
    }
}
