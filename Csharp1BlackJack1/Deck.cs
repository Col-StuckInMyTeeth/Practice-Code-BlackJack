using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Csharp1BlackJack1
{
    class Deck
    {

        public Card[] deckie = new Card[52];
        Random rand = new Random();
        int topindex;

        public Deck()
        {
            
            topindex = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    deckie[(j - 1) + (i * 13)] = new Card(i, j);
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < 52; ++i)
            {
                deckie[i].Printcard();
                Console.WriteLine();
            }
        }

        public void shuffle()
        {
            for (int i = 0; i < 200; i++)
            {
                int first = (rand.Next() % 52);
                int second = (rand.Next() % 52);

                Card temp = deckie[first];

                deckie[first] = deckie[second];
                deckie[second] = temp;
            }
            topindex = 0;
        }

        public Card dealcard()
        {
            return deckie[topindex++];
        }

        public void resetdeck()
        {
            for (int i = 0; i < 52; ++i)
            {
                deckie[i] = null;
                
            }
        }

    }
}
