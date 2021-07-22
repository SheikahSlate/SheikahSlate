using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Client.Model
{
    public class Dungeon
    {
        public byte Keys { get; set; }
        public bool BossKey { get; set; }
        public bool Map { get; set; }
        public bool Compass { get; set; }
        public DungeonBossDrop BossDrop { get; set; }
        public Version Version { get; set; }
    }
}
