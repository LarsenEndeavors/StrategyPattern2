using System;

namespace StrategyPattern2.Classes.Strategies.DisplayStrategy
{
    public class ShopkeeperDisplayStrategy : IDisplayStrategy
    {
        public void Display()
        {
            Console.WriteLine("The shopkeeper is a dumpy old bearded man with sandy blonde hair and eyes you feel piercing through you.");
        }
    }
}