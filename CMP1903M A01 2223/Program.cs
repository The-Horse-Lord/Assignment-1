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
            Pack pack = new Pack();
            //The user can choose the type of shuffle and how many cards to deal
            shuffle: Console.WriteLine("Choose the shuffle method to show the pack: \n1)Fisher-Yates Shuffle \n2)Riffle Shuffle\n3)No Shuffle\n");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 0 && choice < 4) pack = Testing.TestingShuffle(choice);
                else
                {
                    Console.WriteLine("Invalid command.Try again?\n\n");
                    goto shuffle;
                }
            }
            //if the user entered incorrect type of choice, they will be trhown back to the beginning of the code
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again?\n\n"); goto shuffle;
            }
            cards: Console.WriteLine("Deal a specified amount of cards?\n");
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > 0 && amount < 52)
                {
                    Testing.TestingDeal(amount, pack);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid command.Try again?\n\n");
                    goto cards;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again?\n\n"); goto cards;
            }
            }
        }
    }

