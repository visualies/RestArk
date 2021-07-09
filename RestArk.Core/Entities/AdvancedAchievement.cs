using System;
using System.Collections.Generic;
using System.Text;

namespace RestArk.Core.Entities
{
    public class AdvancedAchievement
    {
        public string PlayerName { get; set; }
        public string SteamName { get; set; }
        public string TribeName { get; set; }
        public int TribeId { get; set; }
        public int Playtime { get; set; }
        public int PlayerKills { get; set; }
        public int DinoKills { get; set; }
        public int WildDinoKills { get; set; }
        public int DinosTamed { get; set; }
        public int DeathByPlayer { get; set; }
        public int DeathByDino { get; set; }
        public int DeathByWildDino { get; set; }
        public byte[] Achievements { get; set; }
        public byte[] OncePerCharCommand { get; set; }
    }
}

