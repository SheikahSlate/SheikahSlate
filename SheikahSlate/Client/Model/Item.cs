using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Client.Model
{
    public class Item
    {
        private string itemName { get; }
        private byte itemID { get; }
        private byte currentState { set; get; }
        private byte maxState { get; }
        //TODO: Meer?

        public Item(string Name, byte ID, byte State1, byte State2)
        {
            itemName = Name;
            itemID = ID;
            currentState = State1;
            maxState = State2;
        }

        public void incrementState() => currentState++;

        public void decrementState() => currentState--;
    }
}
