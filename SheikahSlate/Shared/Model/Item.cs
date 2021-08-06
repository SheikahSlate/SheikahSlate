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

        public int CountableMin { get;init; }

        public int CountableStep { get; init; }

        public int Count
        {
            get
            {
                if (currentState == 0)
                {
                    return 0;
                }
                else
                {
                    //The minus 1 exists so this does the math for the amount @ state 1
                    return CountableMin + (currentState - 1) * CountableStep;
                }
            }
        }

        public string ImageFileName
        {
            get
            {
                if (!Countable)
                {
                    return $"{ItemId}-{CurrentState}.png";
                }
                else
                {
                    if(currentState == 0)
                    {
                        return $"{ItemId}-0.png";
                    }
                    else
                    {
                        return $"{ItemId}-1.png";
                    }
                }
            }
        }
    }
}
