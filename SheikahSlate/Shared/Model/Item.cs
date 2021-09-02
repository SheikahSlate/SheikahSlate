using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Shared.Model
{
    public class Item
    {
        public string Name { get; init; } = "Default Item";
        public int Id { get; init; } = -1;
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

        public bool Countable => CountableStep != 0;

        public int CountableMin { get; init; } = 1;

        public int CountableStep { get; init; }

        public int GridX { get; init; } = -1;

        public int GridY { get; init; } = -1;

        public string HelpText { get; init; } = "";

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
                    // -1 because state 0 means no items, state 1 means minimum, etc
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
                    return $"{Id}-{CurrentState}.png";
                }
                else
                {
                    if(currentState == 0)
                    {
                        return $"{Id}-0.png";
                    }
                    else
                    {
                        return $"{Id}-1.png";
                    }
                }
            }
        }
    }
}
