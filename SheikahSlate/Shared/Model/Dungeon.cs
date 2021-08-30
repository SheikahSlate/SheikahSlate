using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public class Dungeon
    {
        public string Name { get; init; } = "Default Name";
        public string Shorthand { get; init; } = "Dflt";
        public int Id { get; init; } = -1;
        public bool HasReward { get; init; }
        public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
    }
}
