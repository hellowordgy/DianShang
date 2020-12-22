using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class URInfo
    {
        public Guid URid { get; set; }
        public Guid Uid { get; set; }
        public Guid Rid { get; set; }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserAccon { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }

        public Guid RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
