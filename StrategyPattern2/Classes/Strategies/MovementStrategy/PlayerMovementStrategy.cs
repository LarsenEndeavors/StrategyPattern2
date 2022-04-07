using System;

namespace StrategyPattern2.Classes.Strategies.MovementStrategy
{
    public class PlayerMovementStrategy : IMovementStrategy
    {
        public void Move()
        {
            Console.WriteLine("1: Move Forward, 2: Move Backward, 3: Move Left, 4: Move Right");
            var movement = Console.ReadLine();
            switch (movement)
            {
                case "1":
                    Console.WriteLine("You move forward");
                    return;
                case "2":
                    Console.WriteLine("You move backward");
                    return;
                case "3":
                    Console.WriteLine("You move left");
                    return;
                case "4":
                    Console.WriteLine("You move right");
                    return;
                default:
                    Console.WriteLine("Command unrecognized, player did not move.");
                    return;
            }
        }
    }
}