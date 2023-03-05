using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack { get; set; }
        static Random random = new Random();

        public Pack()
        {
            pack = new List<Card>(52);
            for (int value = 1; value <= 13; value++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        public void ShowPack()
        {
            foreach (Card card in pack)
            {
                Console.WriteLine(card.Name);
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle, Pack shuffled_pack)
        {
            if (typeOfShuffle == 1)
            {
                Card[] arr = shuffled_pack.pack.ToArray();
                for (int i = arr.Length - 1; i > 0; --i)
                {
                    int j = random.Next(i + 1);
                    Card temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                shuffled_pack.pack.Clear();
                shuffled_pack.pack.AddRange(arr);
                return true;
            }
            if (typeOfShuffle == 2)
            {
                int flip = new Random().Next(1, 10);
                for (int n = 0; n < flip; n++)
                {
                    int cut = shuffled_pack.pack.Count / 2 + (random.Next(0, 2) == 0 ? -1 : 1) * random.Next((int)(shuffled_pack.pack.Count * 0.1));
                    List<Card> left = new List<Card>(shuffled_pack.pack.Take(cut));
                    List<Card> right = new List<Card>(shuffled_pack.pack.Skip(cut));
                    shuffled_pack.pack.Clear();
                    while (left.Count > 0 && right.Count > 0)
                    {
                        if (random.NextDouble() >= ((double)left.Count / right.Count) / 2)
                        {
                            shuffled_pack.pack.Add(right.First());
                            right.RemoveAt(0);
                        }
                        else
                        {
                            shuffled_pack.pack.Add(left.First());
                            left.RemoveAt(0);
                        }
                    }
                    if (left.Count > 0) shuffled_pack.pack.AddRange(left);
                    if (right.Count > 0) shuffled_pack.pack.AddRange(right);
                }
                return true;
            }
            if (typeOfShuffle == 3)
            {
                Pack new_pack = new Pack();
                return true;
            }
            else return false;
        }
        public static Card deal(Pack deal)
        {
            if (deal.pack.Count>0)
            {
                Card card = deal.pack[0];
                deal.pack.RemoveAt(0);  
                deal.pack.Add(card);
                return card;
            }
            else
                return null;
        }
        public static List<Card> dealCard(int amount, Pack deal)
        {
            List<Card> new_pack = new List<Card>(amount);
            for(int i=0; i<amount; i++)
            {
                new_pack.Add(deal.pack[i]);
                deal.pack.RemoveAt(i);
                deal.pack.Add(deal.pack[i]);
            }
            return new_pack;
        }
    }
}
