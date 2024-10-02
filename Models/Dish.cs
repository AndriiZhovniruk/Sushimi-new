namespace Sushimi.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public required string Category { get; set; }
        public required string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        
    }
}
