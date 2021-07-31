using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public partial class Item
    {
        public string ItemName { get; init; } = "Default Item (THIS IS BROKEN)";
        public int ItemId { get; init; } = -1;
        private int currentState = 0;
        public int CurrentState 
        { 
            get 
            {
                return currentState;
            } 
            set
            {
                if (value > MaxState)
                {
                    currentState = MaxState;
                }
                else if (value < 0)
                {
                    currentState = 0;
                }
                else
                {
                    currentState = value;
                }
            }
        }
        public int MaxState { get; init; } = 1;
        //TODO: Meer?

        public string ImageUrl => $"{ItemId}-{currentState}.jpg";

    }
}
