using System;

namespace StrategyPattern2.Classes.Strategies.CommunicationStrategy
{
    public class ShopkeeperCommuncationStrategy : ICommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Boawh, Wha' can I do fer ye?");
        }
    }
}