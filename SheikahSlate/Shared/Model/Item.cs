using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public class Item
    {
        private string ItemName { get; }
        private byte ItemID { get; }
        private byte CurrentState { get; set; }
        private byte MaxState { get; }
        //TODO: Meer?

        public Item(string itemName, byte itemId, byte currentState = 0, byte maxState = 1)
        {
            ItemName = itemName;
            ItemID = itemId;
            CurrentState = currentState;
            MaxState = maxState;
        }
    }
}
