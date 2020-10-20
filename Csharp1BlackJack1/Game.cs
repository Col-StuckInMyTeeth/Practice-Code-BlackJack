using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp1BlackJack1
{
    class Game
    {
        Deck thedeck = new Deck();
        Hand playerhand = new Hand();
        Hand dealerhand = new Hand();
        bool isplaying = true;

        int first = 0;
        int playercount = 2;
        int dealercount = 2;
        int lost = 0;

        public void playhand()
        {
            while (isplaying)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                if (first == 0)
                {
                    

                    thedeck.shuffle();
                    first++;

                    for (int i = 0; i < playercount; i++)
                    {
                        playerhand.AddCard(thedeck.dealcard());
                    }

                    for (int i = 0; i < dealercount; i++)
                    {
                        dealerhand.AddCard(thedeck.dealcard());
                    }
                    continue;
                }

                Console.WriteLine("Welcome to Fred's Generic Casino!!!\n\n\n");
                Console.WriteLine("\nplayerhand: ");
                playerhand.print();
                Console.WriteLine("\nScore: " + playerhand.Scorehand() + "\n\n");
                Console.WriteLine("\nDealerhand: ");
                dealerhand.print();
                Console.WriteLine("\nScore: " + dealerhand.Scorehand() + "\n\n");


                if (playerhand.Scorehand() > 21)
                {
                    Console.WriteLine("\nyou have busted!!\n");
                    lost++;
                }

                if (dealerhand.Scorehand() > 21)
                {
                    Console.WriteLine("\ndealer has busted!!!\n");
                    lost++;
                }
                if (lost == 0)
                {
                    Console.WriteLine("would you like to hit?  Y/N\n\n");

                    string UInput = Console.ReadLine();

                    if (UInput == "y")
                    {
                        playerhand.AddCard(thedeck.dealcard());
                        continue;
                    }
                    if (UInput == "n")
                    {
                        while (dealerhand.Scorehand() <= playerhand.Scorehand())
                        {
                            dealerhand.AddCard(thedeck.dealcard());
                        }
                        continue;
                    }
                }
                
                if (lost == 0)
                {
                    continue;
                }

                Console.WriteLine("\nwould you like to play again?  Y/N\n");

                string End = Console.ReadLine();


                if (End == "y")
                {
                    reset();
                    lost = 0;
                }

                if(End == "n")
                {
                    reset();
                    
                    break;
                }

            }
        }

        public void reset()
        {
            thedeck.shuffle();
            playerhand.reset();
            dealerhand.reset();
            first = 0;
        }


    }
}
