using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public int Value{get;set;}
    public int Suit { get; set; }
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }
        public string Name
        {
            get
            {
                return Value + " " + Suit;
            }
        }
        public void SetSuit(int _suit)
        {
            if (_suit < 1 || _suit > 4) throw new ArgumentException();
            else Suit= _suit;
        }
        public void SetValue(int _value)
        {
            if (_value < 1 || _value > 13) throw new ArgumentException();
            else Value = _value;
        }
    }
}
