using System;
using System.Drawing;

namespace GachiConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var myDick = new Dick(DigSize.PickupOwner);
            IAnal boi = new GachiBoy();

            string fakeMoan =  boi.Inject(myDick);

            string anotherFakeMoan =  boi.Inject(myDick,9999);
            string trueMoan = boi.Inject(new Dick(DigSize.Big), 5);
            string mediumMoan = boi.Inject(new Dick(DigSize.Medium), 5);

            Console.WriteLine("Moans with Pickup owner \n");
            Console.WriteLine(fakeMoan);

            Console.WriteLine();

            Console.WriteLine("Moans with big Medium \n");
            Console.WriteLine(mediumMoan);

            Console.WriteLine();

            Console.WriteLine("Moans with big Dick \n");
            Console.WriteLine(trueMoan);

            //boi.Inject(new Dick(DigSize.SmartOwner), 5);

            bool isException = false;
            try
            {
                boi.Inject(new Dick(DigSize.SmartOwner), 5);
            }
            catch 
            {
                isException = true;
                Console.WriteLine(); 
                Console.WriteLine("Moans with Smart car \n");
                Console.WriteLine("Gachi boi can't take dick THAT of size");
            }

            if (!isException) //isException==false
                Console.WriteLine("We didn't catch exception on Smart owner"); 

            

 
        }
    }

}

