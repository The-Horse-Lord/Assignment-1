using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing test = new Testing();
            Console.WriteLine("Fisher-Yates Shuffle: \n\n");
            Testing.TestingShuffle(1);
            Console.WriteLine("Riffle Shuffle: \n\n");
            Testing.TestingShuffle(2);
            Console.WriteLine("No Shuffle: \n\n");
            Testing.TestingShuffle(3);
            Testing.TestingDeal(1);
            Testing.TestingDeal(5);
            Console.ReadLine();
        }
    }
}
