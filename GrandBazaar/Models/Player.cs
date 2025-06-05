namespace GrandBazaar.Models
{
    public class Player
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Rubies { get; set; }
        public int Coins { get; set; }
        public string Location { get; set; } 
        public Wheelbarrow Wheelbarrow { get; set; } = new Wheelbarrow();

        public Player()
        {
            Rubies = 0;
            Coins = 5;
            Location = "Tile0"; // Start location
        }
    }
}
