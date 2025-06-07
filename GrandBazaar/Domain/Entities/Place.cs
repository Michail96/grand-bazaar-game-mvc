using System.Drawing;

namespace GrandBazaar.Domain.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public Location Location { get; set; }
        public List<Color> PlacedAssistants { get; set; } = new List<Color>();
        public int Rubies { get; set; }
    }
}
