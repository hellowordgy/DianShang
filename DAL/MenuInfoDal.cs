using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MenuInfoDal
    {
        //菜单显示
        public List<MenuInfo> MenuInfoShow()
        {
            string sql = $"select * from MenuInfo";
            return DbAccess.DBHelper.GetToList<MenuInfo>(sql);
        }
        //菜单添加
        public int AddMenuInfo(MenuInfo m)
        {
            string sql = $"insert into MenuInfo(MenuName,MenuLink) values({m.MenuName},'{m.MenuLink}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //菜单删除
        public int DelMenuInfo(string id)
        {
            string sql = $"delete from MenuInfo where MenuId in ('{id}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
    }
}
