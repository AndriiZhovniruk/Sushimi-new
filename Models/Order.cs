using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sushimi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public required string CustomerName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}