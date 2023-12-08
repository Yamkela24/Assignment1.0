using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    internal class MilkSong
    {
        public MilkSong() 
        {
            for (int i = 99; i > 1; i--)
            {
                Console.WriteLine($"{i} bottles of milk on the wall, {i} bottles of milk");


                if (i == 2)
                {
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottle on the wall");
                }
                else
                {
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles on the wall");
                }

                // Console.WriteLine($"{i} bottles of milk on the wall");
            }
            Console.WriteLine($"1 bottle of milk on the wall, 1 bottle of milk");
        }
    }
}
