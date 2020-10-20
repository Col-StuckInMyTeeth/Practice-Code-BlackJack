using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp1BlackJack1
{
    class Hand
    {
        List<Card> LeHand = new List<Card>();

        public void AddCard( Card c)
        {
            LeHand.Add(c);
        }

        public int Scorehand()
        {
            int score = 0;

            for (int i = 0; i < LeHand.Count; i++)
            {
                int acecounter = 0;
                if(LeHand[i].Getface() == 1)
                {
                    acecounter += 1;
                }
                
                if(LeHand[i].Getface() > 10)
                {
                    score = (score + 10);
                    continue;
                }
                else if(LeHand[i].Getface() > 1 && LeHand[i].Getface() < 11)
                {
                    score = (score + LeHand[i].Getface());
                    continue;
                }
                else if(score > 10 && LeHand[i].Getface() == 1)
                {
                    score = (score + 1);
                }
                else if (score <= 10 && LeHand[i].Getface() == 1)
                {
                    score = (score + 11);
                    continue;
                }
            }
            return score;
        }

        public void reset()
        {
            LeHand.Clear();
        }

        public void print()
        {
            for (int i = 0; i < LeHand.Count; i++)
            {
                LeHand[i].Printcard();
            }
        }


    }
}
