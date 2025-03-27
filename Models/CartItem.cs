namespace Sushimi.Models
{
    public class CartItem
    {
        public int DishId { get; set; }
        public required string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice => Quantity * Price;
    }
}
