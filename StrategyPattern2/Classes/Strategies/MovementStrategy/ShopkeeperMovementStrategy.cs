using System;

namespace StrategyPattern2.Classes.Strategies.MovementStrategy
{
    public class ShopkeeperMovementStrategy : IMovementStrategy
    {
        public void Move()
        {
            Console.WriteLine("The shopkeeper doesn't move much behind the counter of his pop-up-hut");
        }
    }
}