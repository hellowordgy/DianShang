using System;
using System.Collections.Generic;
using Model;

namespace DAL
{
    public class DayDal
    {
        public List<Day10> show()
        {
            string sql = $"select * from biao";
            return DbAccess.DBHelper.GetToList<Day10>(sql);
        }
    }
}
