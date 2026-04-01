
namespace Daarmoon.Services
{
    using Daarmoon.Models;
    public class GameService
    {
        public void Attack(Card attacker, Card defender)
        {
            if (!attacker.IsAlive || !defender.IsAlive)
                return;

            // Dodge шанс
            var random = new Random();
            int roll = random.Next(0, 6);

            if (roll < defender.Dodge)
            {
                return; // ухилився
            }

            defender.Defence -= attacker.Attack;
        }
    }
}