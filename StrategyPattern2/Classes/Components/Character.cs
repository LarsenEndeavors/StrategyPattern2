using StrategyPattern2.Classes.Strategies.CommunicationStrategy;
using StrategyPattern2.Classes.Strategies.DisplayStrategy;
using StrategyPattern2.Classes.Strategies.MovementStrategy;

namespace StrategyPattern2.Classes.Components
{
    public class Character
    {
        public IMovementStrategy MovementStrategy { get; set; }
        public ICommunicationStrategy CommunicationStrategy { get; set; }
        public IDisplayStrategy DisplayStrategy { get; set; }

        public Character(ICommunicationStrategy communicationStrategy, IDisplayStrategy displayStrategy, IMovementStrategy movementStrategy)
        {
            MovementStrategy = movementStrategy;
            CommunicationStrategy = communicationStrategy;
            DisplayStrategy = displayStrategy;
        }

        public void Move()
        {
            MovementStrategy.Move();
        }

        public void Communicate()
        {
            CommunicationStrategy.Communicate();
        }

        public void Display()
        {
            DisplayStrategy.Display();
        }
    }
}