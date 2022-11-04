using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GachiConsole
{
    public class GachiBoy:IAnal
    {
        public event Action OnInjection;

        public string Inject(Dick dick, int count = 1)
        {
            OnInjection?.Invoke();
            if (dick.DigSize == DigSize.PickupOwner)
            {
                string s = MoatGenerator(3, "tuc");
                return  s+"\nAre you inside?";
            }


            switch (dick.DigSize)
            { 
                case DigSize.Big:
                   return MoatGenerator(count, "Ohhh");
                break;
                case DigSize.Medium: 
                   return MoatGenerator(count, "Oh!");
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
                var sound = mountSound + ", ";
                Console.Write(sound);
                Thread.Sleep(1000);
                s.Append(sound);
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
