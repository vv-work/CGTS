using System;
using System.Collections.Generic;
using System.Text;

namespace GachiConsole
{
    class GachiBoy:IAnal
    {
    
        public string Inject(Dick dick, int count = 1)
        {
            if (dick.DigSize == DigSize.PickupOwner)
                return "Are you inside?";

            switch (dick.DigSize)
            { 
                case DigSize.Big: 
                   return MoatGenerator(count, "Ohhh");
                break;
                case DigSize.Medium: 
                   return MoatGenerator(count, "Oh");
                break;


            }
                throw new ArgumentException("Dick size not processed"); 
                return "";
        }

        private static string MoatGenerator(int count, string mountSound)
        {
            string result;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < count - 1; i++)
            {
                s.Append(mountSound + ", ");
            }

            s.Append(mountSound);
            result = s.ToString();
            return result;
        }

        public Money Fisting(int finger)
        {
            throw new NotImplementedException();
        }
    }
}
