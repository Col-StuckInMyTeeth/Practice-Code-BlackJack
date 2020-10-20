using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp1BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Deck showdeck = new Deck();
            Deck randdeck = new Deck();
            Game playgame = new Game();
            bool cake = true;

            while (cake)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("welcome to Fred's Generic Blackjack Game...\n\n\n\n");
                Console.WriteLine("please select an option: ");
                Console.WriteLine("1. print a new deck\n2. print a shuffled deck\n3. play blackjack\n4. exit\n\n");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    
                    showdeck.print();
                    Console.WriteLine("\n\npress any key to continue");
                    Console.ReadKey();
                    continue;
                }
                if (input == "2")
                {
                    Console.Clear();
                    randdeck.shuffle();
                    randdeck.print();
                    Console.WriteLine("\n\npress any key to continue");
                    Console.ReadKey();
                    continue;
                }
                if (input == "3")
                {
                    playgame.playhand();
                    continue;
                }
                if (input == "4")
                {
                    break;
                }


            }

            Console.WriteLine(" ---\n|A♠ |\n|   |\n|   |\n ---");
            Console.ReadLine();
            


        }
    }
}
