using System.Drawing;

namespace GrandBazaar.Domain.Entities
{
    public class Merchant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rubies { get; set; }
        public int Lira { get; set; }
        public Location Location { get; set; }
        public Color Color { get; set; }
        public int AvailableAssistants { get; set; } = 4;
        public Wheelbarrow Wheelbarrow { get; set; } = new Wheelbarrow();

        public Merchant()
        {
            Rubies = 0;
            Location = new Location { Id = 0, Row = 0, Col = 0 };
        }
    }
}
