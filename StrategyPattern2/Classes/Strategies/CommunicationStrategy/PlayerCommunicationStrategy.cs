using System;

namespace StrategyPattern2.Classes.Strategies.CommunicationStrategy
{
    public class PlayerCommuncationStrategy : ICommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("What do you say?\n");
            var speech = Console.ReadLine();
            Console.WriteLine("You say: " + speech);
        }
    }
}