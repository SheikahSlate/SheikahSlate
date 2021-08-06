using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public partial class Item
    {
        public string ItemName { get; init; } = "Default Item";
        public int ItemId { get; init; } = -1;
        private int currentState;
        public int CurrentState
        {
            get => currentState;
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

        public bool Countable { get; init; }

        public string ImageFileName
        {
            get
            {
                if (!Countable)
                {
                    return $"{ItemId}-{CurrentState}.jpg";
                }
                else
                {
                    if(currentState == 0)
                    {
                        return $"{ItemId}-0.jpg";
                    }
                    else
                    {
                        return $"{ItemId}-1.jpg";
                    }
                }
            }
        }
    }
}
