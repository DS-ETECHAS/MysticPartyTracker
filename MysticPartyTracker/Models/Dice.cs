namespace MysticPartyTracker.Models
{
    public class Dice
    {
        private static Random random = new Random();
        public int Side { get; set; }

        public Dice(int side)
        {
            Side = side;
        }

        public int Roll()
        {
            return random.Next(Side) + 1;
        }
    }
}