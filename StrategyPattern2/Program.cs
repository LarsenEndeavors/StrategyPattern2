using System;
using StrategyPattern2.Classes.Components;
using StrategyPattern2.Classes.Strategies.CommunicationStrategy;
using StrategyPattern2.Classes.Strategies.DisplayStrategy;
using StrategyPattern2.Classes.Strategies.MovementStrategy;

namespace StrategyPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Character(new PlayerCommuncationStrategy(), new PlayerDisplayStrategy(), new PlayerMovementStrategy());
            var shopkeeper = new Character(new ShopkeeperCommuncationStrategy(), new ShopkeeperDisplayStrategy(), new ShopkeeperMovementStrategy());
            Console.WriteLine("Welcome to a new attempt at the strategy pattern by Larsen Endeavors, let's begin.  You are a player in a video game, your limited actions are as follows: \n");
            var cursor = "";
            while (cursor != "q")
            {
                Console.WriteLine("1: Move, 2: Communicate, 3: Look at yourself, 4: Observe the merchant's movements, 5: Speak to the merchant, 6: Look at the merchant, q: Quit");
                cursor = Console.ReadLine();
                if (cursor == "1")
                {
                    player.Move();
                }

                if (cursor == "2")
                {
                    player.Communicate();
                }

                if (cursor == "3")
                {
                    player.Display();
                }

                if (cursor == "4")
                {
                    shopkeeper.Move();
                }

                if (cursor == "5")
                {
                    shopkeeper.Communicate();
                }

                if (cursor == "6")
                {
                    shopkeeper.Display();
                }
            }
        }
    }
}