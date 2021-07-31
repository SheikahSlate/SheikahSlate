using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public class Item
    {
        public string ItemName { get; init; } = "Default Item (THIS IS BROKEN)";
        public int ItemId { get; init; } = -1;
        public int CurrentState { get; set; } = 0;
        public int MaxState { get; init; } = 1;
        //TODO: Meer?

    }
}
