using System;
using System.Collections.Generic;
using System.Text;

namespace GachiConsole
{
    class Dick
    {
        internal readonly DigSize DigSize;

        public Dick(DigSize digSize)
        {
            DigSize = digSize;
        }
    }
    public enum DigSize
    {
        SmartOwner,
        Big,
        Medium,
        PickupOwner
    }
    
}
