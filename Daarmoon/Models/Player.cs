namespace Daarmoon.Models
{
    public class Player
    {
        public int Id { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();
    }
}
