using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Csharp1BlackJack1
{
    class Card
    {

        int suit;
        int face;

        public Card(int msuit, int mface)
        {
            suit = msuit;
            face = mface;

        }

        public void Setface(int f)
        {
            f = face;
        }

        public void Setsuit(int s)
        {
            s = suit;
        }

        public void Set(int f, int s)
        {
            face = f;
            suit = s;
        }

        public int Getface()
        {
            return face;
        }

        public int GetSuit()
        {
            return suit;
        }

        public void Printcard()
        {
            switch(face)
            {
                case 1:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("J");
                    break;
                case 12:
                    Console.Write("Q");
                    break;
                case 13:
                    Console.Write("k");
                    break;
                default:
                    Console.Write(face);
                    break;
            }

            switch (suit)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("♠");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("♣");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("♥");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("♦");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.Write(" ");
                    break;
            }
        }



    }
}
