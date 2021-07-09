using System;
using System.Collections.Generic;
using System.Text;

namespace RestArk.Core.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public long SteamId { get; set; }
        public string PermissionGroups { get; set; }
    }
}
