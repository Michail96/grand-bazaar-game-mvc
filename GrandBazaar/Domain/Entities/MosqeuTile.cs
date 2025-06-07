using GrandBazaar.Models.Enums;

namespace GrandBazaar.Domain.Entities
{
    public class MosqeuTile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberofGoods { get; set; }
        public Good GoodType     { get; set; }
    }
}
