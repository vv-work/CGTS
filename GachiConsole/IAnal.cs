using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GachiConsole
{
    interface IAnal
    {
        /// <summary>
        /// Way to insert dick into whole
        /// </summary>
        /// <param name="dick">
        /// We actually accept any dick
        /// But prefer big dicks.
        /// </param>
        /// <returns></returns>
        string Inject(Dick dick, int count=1);

        /// <summary>
        /// 300$ Typicaly 
        /// But we have some extra for
        /// 👆💦✊
        /// </summary>
        /// <param name="finger">how many finger we can take</param>
        /// <returns></returns>
        Money Fisting(int finger);
    }


    internal class Money
    {
        public Money(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }
}
