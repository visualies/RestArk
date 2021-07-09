using System;
using System.Collections.Generic;
using System.Text;

namespace RestArk.Core.Entities
{
    public class PermissionGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Permissions { get; set; }
    }
}
