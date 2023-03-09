using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing()
        {
            Pack test_pack = new Pack();
        }
        public static Pack TestingShuffle(int shuffle_type)//method to show different types of shuffle
        {
            Pack test_pack = new Pack();
            Pack.shuffleCardPack(shuffle_type,test_pack);
            test_pack.ShowPack();
            Console.WriteLine("\n\n");
            return test_pack;
        }

        public static void TestingDeal(int deal, Pack pack)//method to deal one or multiple cards
        {
            if (deal == 1) { 
                Card dealer = Pack.deal(pack);
                Console.WriteLine(dealer.Name);
                Console.WriteLine("\n\n");
            }
            else if (deal > 1)
            {
                List<Card> dealer2 = Pack.dealCard(deal,pack);
                foreach (Card card in dealer2) Console.WriteLine("\n"+card.Name);
            }
            }
        }
    }
