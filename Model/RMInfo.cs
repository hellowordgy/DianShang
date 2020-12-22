using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class RMInfo
    {
        public Guid RMid { get; set; }
        public Guid Rid { get; set; }
        public Guid Mid { get; set; }

        public Guid RoleID { get; set; }
        public string RoleName { get; set; }

        public Guid MenuID { get; set; }
        public string MenuName { get; set; }
        public string MenuLink { get; set; }
    }
}
