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
        //constructor of the class, makes a new deck of cards
        public Pack()
        {
            pack = new List<Card>(52);
            for (int value = 1; value <= 13; value++)//the values are from 1 to 13
            {
                for (int suit = 1; suit <= 4; suit++)//the suites are from 1 to 4
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        public void ShowPack() // method that prints a pack
        {
            foreach (Card card in pack)
            {
                Console.WriteLine(card.Name);
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle, Pack pack)
        {
            if (typeOfShuffle == 1)//the Fisher-Yates Shuffle method
            {
                Card[] arr = pack.pack.ToArray();
                for (int i = arr.Length - 1; i > 0; --i)
                {
                    int j = random.Next(i + 1);
                    Card temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                pack.pack.Clear();
                pack.pack.AddRange(arr);
                return true;
            }
            if (typeOfShuffle == 2)//the Riffle Shuffle method
            {
                int flip = new Random().Next(1, 10);
                for (int n = 0; n < flip; n++)
                {
                    int cut = pack.pack.Count / 2 + (random.Next(0, 2) == 0 ? -1 : 1) * random.Next((int)(pack.pack.Count * 0.1));
                    List<Card> left = new List<Card>(pack.pack.Take(cut));
                    List<Card> right = new List<Card>(pack.pack.Skip(cut));
                    pack.pack.Clear();
                    while (left.Count > 0 && right.Count > 0)
                    {
                        if (random.NextDouble() >= ((double)left.Count / right.Count) / 2)
                        {
                            pack.pack.Add(right.First());
                            right.RemoveAt(0);
                        }
                        else
                        {
                            pack.pack.Add(left.First());
                            left.RemoveAt(0);
                        }
                    }
                    if (left.Count > 0) pack.pack.AddRange(left);
                    if (right.Count > 0) pack.pack.AddRange(right);
                }
                return true;
            }
            if (typeOfShuffle == 3)//there is no shuffle 
            {
                Pack new_pack = new Pack();
                return true;
            }
            else return false;
        }
        public static Card deal(Pack deal)//method to deal a card
        {
            if (deal.pack.Count>0)
            {
                Card card = deal.pack[0];//we show the first card in the pack
                deal.pack.RemoveAt(0);  //delete the first card in the pack
                deal.pack.Add(card); //and adding this card to the end of the pack
                return card;
            }
            else
                return null;
        }
        public static List<Card> dealCard(int amount, Pack deal)//method to deal mutliple cards, the same as one card but with list
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

