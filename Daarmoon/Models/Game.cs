namespace Daarmoon.Models
{
    public class Game
    {
        public Player Player1 { get; set; } = new Player();
        public Player Player2 { get; set; } = new Player();

        public bool IsFinished =>
            Player1.Cards.All(c => !c.IsAlive) ||
            Player2.Cards.All(c => !c.IsAlive);
    }
}
