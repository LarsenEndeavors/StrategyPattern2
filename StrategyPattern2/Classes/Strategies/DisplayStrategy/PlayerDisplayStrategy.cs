using System;

namespace StrategyPattern2.Classes.Strategies.DisplayStrategy
{
    public class PlayerDisplayStrategy : IDisplayStrategy
    {
        public void Display()
        {
            Console.WriteLine("You take a long hard look at yourself and like what you see.");
        }
    }
}