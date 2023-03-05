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
        public static void TestingShuffle(int shuffle_type)
        {
            Pack test_pack = new Pack();
            Pack.shuffleCardPack(shuffle_type, test_pack);
            test_pack.ShowPack();
            Console.WriteLine("\n\n");
        }

        public static void TestingDeal(int deal)
        {
            Pack test_pack = new Pack(); 
            Pack.shuffleCardPack(1,test_pack);
            if (deal == 1) { 
                Card dealer = Pack.deal(test_pack);
                Console.WriteLine(dealer.Name);
                Console.WriteLine("\n\n");
            }
            else if (deal > 1)
            {
                List<Card> dealer2 = Pack.dealCard(deal, test_pack);
                foreach (Card card in dealer2) Console.WriteLine(card.Name);
            }
            else throw new ArgumentException(deal.ToString());
            }
        }
    }

