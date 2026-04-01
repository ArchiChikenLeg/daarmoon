namespace Daarmoon.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Attack { get; set; }
        public int Dodge { get; set; }
        public int Defence { get; set; }

        public bool IsAlive => Defence > 0;
    }
}
